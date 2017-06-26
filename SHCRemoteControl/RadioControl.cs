using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpaceHardwareClub;

namespace RemoteControl
{
    public partial class RadioControl : Form
    {
        MainConsole main;
        SpaceHardwareClub.RadioControlLibrary libRC = new RadioControlLibrary();
        
        public RadioControl(MainConsole p)
        {
            InitializeComponent();
            main = p;
        }

        private void RadioControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void frequnecyButton_Click(object sender, EventArgs e)
        {
            int freq;
            try
            {
                freq = Int32.Parse(frequnecyTextbox.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Frequency must be a valid number", "Invalid frequency");
                return;
            }
            main.sendBytes(MainConsole.portEnum.radioPort, libRC.setFrequency(freq));
        }

        private void engageDuplexButton_Click(object sender, EventArgs e)
        {
            main.sendBytes(MainConsole.portEnum.radioPort, libRC.engageDuplex());
        }

        private void duplexOffsetButton_Click(object sender, EventArgs e)
        {
            main.sendBytes(MainConsole.portEnum.radioPort, libRC.setDuplexOffset());
        }
    }
}
