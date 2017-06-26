namespace RemoteControl
{
    partial class MainConsole
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
            this.antennaButton = new System.Windows.Forms.Button();
            this.radioButton = new System.Windows.Forms.Button();
            this.portsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // antennaButton
            // 
            this.antennaButton.Enabled = false;
            this.antennaButton.Location = new System.Drawing.Point(12, 12);
            this.antennaButton.Name = "antennaButton";
            this.antennaButton.Size = new System.Drawing.Size(202, 45);
            this.antennaButton.TabIndex = 0;
            this.antennaButton.Text = "Antenna Control";
            this.antennaButton.UseVisualStyleBackColor = true;
            // 
            // radioButton
            // 
            this.radioButton.Enabled = false;
            this.radioButton.Location = new System.Drawing.Point(12, 63);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(202, 45);
            this.radioButton.TabIndex = 0;
            this.radioButton.Text = "Radio Control";
            this.radioButton.UseVisualStyleBackColor = true;
            this.radioButton.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // portsButton
            // 
            this.portsButton.Location = new System.Drawing.Point(12, 114);
            this.portsButton.Name = "portsButton";
            this.portsButton.Size = new System.Drawing.Size(202, 45);
            this.portsButton.TabIndex = 0;
            this.portsButton.Text = "Setup ports";
            this.portsButton.UseVisualStyleBackColor = true;
            this.portsButton.Click += new System.EventHandler(this.portsButton_Click);
            // 
            // MainConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 164);
            this.Controls.Add(this.portsButton);
            this.Controls.Add(this.radioButton);
            this.Controls.Add(this.antennaButton);
            this.Name = "MainConsole";
            this.Text = "MainConsole";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainConsole_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button antennaButton;
        private System.Windows.Forms.Button radioButton;
        private System.Windows.Forms.Button portsButton;
    }
}