namespace RemoteControl
{
    partial class SerialPortSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioComCombo = new System.Windows.Forms.ComboBox();
            this.antennaComCombo = new System.Windows.Forms.ComboBox();
            this.radioComLabel = new System.Windows.Forms.Label();
            this.antennaComLabel = new System.Windows.Forms.Label();
            this.serialSetupBtn = new System.Windows.Forms.Button();
            this.serialCancelBtn = new System.Windows.Forms.Button();
            this.debugLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioComCombo
            // 
            this.radioComCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.radioComCombo.FormattingEnabled = true;
            this.radioComCombo.Location = new System.Drawing.Point(105, 20);
            this.radioComCombo.Name = "radioComCombo";
            this.radioComCombo.Size = new System.Drawing.Size(121, 21);
            this.radioComCombo.TabIndex = 0;
            // 
            // antennaComCombo
            // 
            this.antennaComCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.antennaComCombo.FormattingEnabled = true;
            this.antennaComCombo.Location = new System.Drawing.Point(105, 56);
            this.antennaComCombo.Name = "antennaComCombo";
            this.antennaComCombo.Size = new System.Drawing.Size(121, 21);
            this.antennaComCombo.TabIndex = 1;
            // 
            // radioComLabel
            // 
            this.radioComLabel.AutoSize = true;
            this.radioComLabel.Location = new System.Drawing.Point(12, 23);
            this.radioComLabel.Name = "radioComLabel";
            this.radioComLabel.Size = new System.Drawing.Size(87, 13);
            this.radioComLabel.TabIndex = 2;
            this.radioComLabel.Text = "Radio COM Port:";
            // 
            // antennaComLabel
            // 
            this.antennaComLabel.AutoSize = true;
            this.antennaComLabel.Location = new System.Drawing.Point(5, 59);
            this.antennaComLabel.Name = "antennaComLabel";
            this.antennaComLabel.Size = new System.Drawing.Size(99, 13);
            this.antennaComLabel.TabIndex = 3;
            this.antennaComLabel.Text = "Antenna COM Port:";
            // 
            // serialSetupBtn
            // 
            this.serialSetupBtn.Location = new System.Drawing.Point(155, 83);
            this.serialSetupBtn.Name = "serialSetupBtn";
            this.serialSetupBtn.Size = new System.Drawing.Size(75, 23);
            this.serialSetupBtn.TabIndex = 4;
            this.serialSetupBtn.Text = "Okay";
            this.serialSetupBtn.UseVisualStyleBackColor = true;
            this.serialSetupBtn.Click += new System.EventHandler(this.serialSetupBtn_Click);
            // 
            // serialCancelBtn
            // 
            this.serialCancelBtn.Location = new System.Drawing.Point(12, 83);
            this.serialCancelBtn.Name = "serialCancelBtn";
            this.serialCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.serialCancelBtn.TabIndex = 5;
            this.serialCancelBtn.Text = "Cancel";
            this.serialCancelBtn.UseVisualStyleBackColor = true;
            this.serialCancelBtn.Click += new System.EventHandler(this.serialCancelBtn_Click);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(94, 88);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(55, 13);
            this.debugLabel.TabIndex = 6;
            this.debugLabel.Text = "                ";
            this.debugLabel.DoubleClick += new System.EventHandler(this.debugLabel_DoubleClick);
            // 
            // SerialPortSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 130);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.serialCancelBtn);
            this.Controls.Add(this.serialSetupBtn);
            this.Controls.Add(this.antennaComLabel);
            this.Controls.Add(this.radioComLabel);
            this.Controls.Add(this.antennaComCombo);
            this.Controls.Add(this.radioComCombo);
            this.MinimumSize = new System.Drawing.Size(258, 157);
            this.Name = "SerialPortSetup";
            this.Text = "Serial Port Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerialPortSetup_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox radioComCombo;
        private System.Windows.Forms.ComboBox antennaComCombo;
        private System.Windows.Forms.Label radioComLabel;
        private System.Windows.Forms.Label antennaComLabel;
        private System.Windows.Forms.Button serialSetupBtn;
        private System.Windows.Forms.Button serialCancelBtn;
        private System.Windows.Forms.Label debugLabel;
    }
}