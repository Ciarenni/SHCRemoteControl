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
    public partial class SerialPortSetup : Form
    {
        MainConsole parent;
        bool debugEnabled = false;
        public SerialPortSetup(MainConsole main)
        {
            InitializeComponent();
            parent = main;

            radioComCombo.Items.AddRange(SerialPort.GetPortNames());
            antennaComCombo.Items.AddRange(SerialPort.GetPortNames());
            if (SerialPort.GetPortNames().Length > 0)
            {
                radioComCombo.SelectedIndex = 0;
                antennaComCombo.SelectedIndex = 0;
            }
        }

        private void serialCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void serialSetupBtn_Click(object sender, EventArgs e)
        {
            if (radioComCombo.SelectedIndex.ToString() == antennaComCombo.SelectedIndex.ToString())
                MessageBox.Show("You must specify different ports for the radio and the rotater.", "Need different ports");
            else
            {
                parent.setupPorts(radioComCombo.SelectedItem.ToString(), antennaComCombo.SelectedItem.ToString());//, debugEnabled);
                this.Hide();
            }
        }

        private void debugLabel_DoubleClick(object sender, EventArgs e)
        {
            debugEnabled = !debugEnabled;
            MessageBox.Show("DebugEnabled is now set to " + debugEnabled.ToString() + ".", "Debug enabled/disabled");
        }

        private void SerialPortSetup_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
