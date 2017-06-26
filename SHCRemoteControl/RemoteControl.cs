using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using MySql.Data.MySqlClient;
using SpaceHardwareClub;

namespace RemoteControl
{
    public partial class RemoteControl : Form
    {
        const string DBserver = "";//removed the IP address since this is in a public repo
        enum formComponents
        {
            AZIMUTH, ELEVATION
        };
        bool stopUpdate = false, hasToken = false;
        int lastAzimuth = 0, lastElevation = 0;

        Thread updateThread;
        MySqlConnection updateConnection, connection;
        MySqlCommand command;
        MySqlDataReader reader;

        delegate void delegateUpdate(string value, formComponents component);

        public RemoteControl()
        {
            InitializeComponent();
            updateThread = new Thread(updater);
            try
            {
                connection = new MySqlConnection("");//removed connection strings since this is in a public repo
                updateConnection = new MySqlConnection("");//removed connection strings since this is in a public repo
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to the database. Please try again later.", "Cannot connect");
                this.Close();
            }

            //connection.Open();
            
            updateThread.Start();
        }

        private void updateForm(string value, formComponents component)
        {
            switch (component)
            {
                case formComponents.AZIMUTH:
                    if (this.azimuthTextBox.InvokeRequired)
                    {
                        delegateUpdate d = new delegateUpdate(updateForm);
                        this.Invoke(d, new object[] { value, component });
                    }
                    else
                    {
                        this.azimuthTextBox.Text = value;
                    }
                    break;
                case formComponents.ELEVATION:
                    if (this.elevationTextBox.InvokeRequired)
                    {
                        delegateUpdate d = new delegateUpdate(updateForm);
                        this.Invoke(d, new object[] { value, component });
                    }
                    else
                    {
                        this.elevationTextBox.Text = value;
                    }
                    break;
            }
        }

        private bool getConnection()
        {
            if (connection.State == ConnectionState.Open)
                return true;
            else
            {
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }

        public void updater()
        {
            int az = 1, el = 1;
            while (!stopUpdate)
            {
                if (!hasToken)
                {//if the program does not have the token, update the text boxes
                    updateConnection.Open();
                    if (updateConnection.State==ConnectionState.Open)
                    {
                        try
                        {
                            command = new MySqlCommand("select * from remote_control;",updateConnection);
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                az = reader.GetInt32("azimuth");
                                el = reader.GetInt32("elevation");
                            }
                            if (az != lastAzimuth || el != lastElevation)
                            {
                                //write out to COM port using library
                                //update form to reflect database
                                lastAzimuth = az;
                                lastElevation = el;
                                updateForm(lastAzimuth.ToString(), formComponents.AZIMUTH);
                                updateForm(lastElevation.ToString(), formComponents.ELEVATION);
                            }
                            reader.Close();
                        }
                        catch (Exception)
                        {
                        }
                        updateConnection.Close();
                    }
                }
                Thread.Sleep(1000);//check every second
            }
        }

        private void tokenBtn_Click(object sender, EventArgs e)
        {
            if (hasToken)
            {//need to return the token and update the DB
                try
                {
                    if (getConnection())
                    {
                        command = new MySqlCommand("select * from remote_control;",connection);
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            if (!reader.GetBoolean("antenna_token"))
                            {
                                reader.Close();
                                command = new MySqlCommand("update remote_control set azimuth=" + azimuthTextBox.Text + ", elevation=" + elevationTextBox.Text + ", antenna_token=1 where primKey=\"key\";",connection);
                                command.ExecuteNonQuery();
                                hasToken = false;
                                tokenBtn.Text = "Grab token";
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                }
            }
            else
            {//need to grab the token to prevent any changes to the DB values from happening to the application
                try
                {
                    if (getConnection())
                    {
                        command = new MySqlCommand("update remote_control set antenna_token=0 where primKey=\"key\";",connection);
                        command.ExecuteNonQuery();
                        hasToken = true;
                        connection.Close();
                        tokenBtn.Text = "Return token";
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void RemoteControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (updateThread.ThreadState == ThreadState.Running)
                updateThread.Abort();
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        private void aziIncStepBtn_Click(object sender, EventArgs e)
        {
            try
            {
                azimuthChange(1);
                azimuthTextBox.Text = lastAzimuth.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void aziIncBigStepBtn_Click(object sender, EventArgs e)
        {
            try
            {
                azimuthChange(10);
                azimuthTextBox.Text = lastAzimuth.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void aziDecStepBtn_Click(object sender, EventArgs e)
        {
            try
            {
                azimuthChange(-1);
                azimuthTextBox.Text = lastAzimuth.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void aziDecBigStepBtn_Click(object sender, EventArgs e)
        {
            try
            {
                azimuthChange(-10);
                azimuthTextBox.Text = lastAzimuth.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void eleIncStepBtn_Click(object sender, EventArgs e)
        {
            try
            {
                elevationChange(1);
                elevationTextBox.Text = lastElevation.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void eleIncBigStepBtn_Click(object sender, EventArgs e)
        {
            try
            {
                elevationChange(10);
                elevationTextBox.Text = lastElevation.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void eleDecStepBtn_Click(object sender, EventArgs e)
        {
            try
            {
                elevationChange(-1);
                elevationTextBox.Text = lastElevation.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void eleDecBigStepBtn_Click(object sender, EventArgs e)
        {
            try
            {
                elevationChange(-10);
                elevationTextBox.Text = lastElevation.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void azimuthChange(int change)
        {
            lastAzimuth += change;
            if (lastAzimuth < 0)
                lastAzimuth = 0;
            else if (lastAzimuth > 360)
                lastAzimuth = 360;
        }

        private void elevationChange(int change)
        {
            lastElevation += change;
            if (lastElevation < 0)
                lastElevation = 0;
            else if (lastElevation > 180)
                lastElevation = 180;
        }

        private void azimuthTextBox_TextChanged(object sender, EventArgs e)
        {
            int az=lastAzimuth;
            try
            {
                az = Int32.Parse(azimuthTextBox.Text);
            }
            catch (Exception)
            {
            }

            if (az < 0 || az > 360)
            {
                az = lastAzimuth;
                return;
            }
            else
            {
                lastAzimuth = az;
            }
        }

        private void elevationTextBox_TextChanged(object sender, EventArgs e)
        {
            int el=lastElevation;
            try
            {
                el = Int32.Parse(elevationTextBox.Text);
            }
            catch (Exception)
            {
            }

            if (el < 0 || el > 360)
            {
                el = lastElevation;
                return;
            }
            else
            {
                lastElevation = el;
            }
        }
    }
}
