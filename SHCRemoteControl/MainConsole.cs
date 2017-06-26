using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace RemoteControl
{
    public partial class MainConsole : Form
    {
        RadioControl radioControl;
        SerialPortSetup portSetup;
        SerialPort radioPort, antennaPort;
        public enum portEnum
        {
            radioPort,antennaPort
        }

        public MainConsole()
        {
            InitializeComponent();
            radioControl = new RadioControl(this);
            radioControl.Hide();

            //goes last so it appears on top
            portSetup = new SerialPortSetup(this);
            portSetup.Show();
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            radioControl.Show();
        }

        private void portsButton_Click(object sender, EventArgs e)
        {
            //set up ports stuff
            portSetup.Location = new Point(this.FindForm().Location.X + this.Width + 10, this.FindForm().Location.Y);
            portSetup.Show();
            portSetup.Activate();
        }

        public void setupPorts(string radioName, string antennaName)//, bool debug)
        {
            radioPort = new SerialPort(radioName, 9600, Parity.None, 8, StopBits.One);
            antennaPort = new SerialPort(antennaName, 9600, Parity.None, 8, StopBits.One);
            radioButton.Enabled = true;
            antennaButton.Enabled = true;
        }

        public void sendString(portEnum port, string str)
        {
            switch (port)
            {
                case portEnum.radioPort:
                    try
                    {
                        radioPort.Open();
                        radioPort.Write(str);
                        radioPort.Close();
                    }
                    catch (Exception)
                    {
                    }
                    break;
                case portEnum.antennaPort:
                    try
                    {
                        antennaPort.Open();
                        antennaPort.Write(str);
                        antennaPort.Close();
                    }
                    catch (Exception)
                    {
                    }
                    break;
            }
        }

        public void sendBytes(portEnum port, byte[] array)
        {
            switch (port)
            {
                case portEnum.radioPort:
                    try
                    {
                        radioPort.Open();
                        radioPort.Write(array, 0, array.Length);
                        radioPort.Close();
                    }
                    catch (Exception)
                    {
                    }
                    break;
                case portEnum.antennaPort:
                    try
                    {
                        antennaPort.Open();
                        antennaPort.Write(array, 0, array.Length);
                        antennaPort.Close();
                    }
                    catch (Exception)
                    {
                    }
                    break;
            }
        }

        private void MainConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (radioPort != null)
                radioPort.Close();

            if (antennaPort != null)
                antennaPort.Close();

            if (radioControl != null)
                radioControl.Close();

            if (portSetup != null)
                portSetup.Close();
        }
    }
}
