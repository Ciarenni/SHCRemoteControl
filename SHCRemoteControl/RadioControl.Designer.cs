namespace RemoteControl
{
    partial class RadioControl
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
            this.frequnecyTextbox = new System.Windows.Forms.TextBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.frequnecyButton = new System.Windows.Forms.Button();
            this.engageDuplexButton = new System.Windows.Forms.Button();
            this.duplexOffsetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frequnecyTextbox
            // 
            this.frequnecyTextbox.Location = new System.Drawing.Point(110, 9);
            this.frequnecyTextbox.MaxLength = 11;
            this.frequnecyTextbox.Name = "frequnecyTextbox";
            this.frequnecyTextbox.Size = new System.Drawing.Size(100, 20);
            this.frequnecyTextbox.TabIndex = 0;
            this.frequnecyTextbox.Text = "146123450";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(13, 12);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(91, 13);
            this.frequencyLabel.TabIndex = 1;
            this.frequencyLabel.Text = "Radio frequency: ";
            // 
            // frequnecyButton
            // 
            this.frequnecyButton.Location = new System.Drawing.Point(216, 7);
            this.frequnecyButton.Name = "frequnecyButton";
            this.frequnecyButton.Size = new System.Drawing.Size(103, 23);
            this.frequnecyButton.TabIndex = 2;
            this.frequnecyButton.Text = "Set frequency";
            this.frequnecyButton.UseVisualStyleBackColor = true;
            this.frequnecyButton.Click += new System.EventHandler(this.frequnecyButton_Click);
            // 
            // engageDuplexButton
            // 
            this.engageDuplexButton.Location = new System.Drawing.Point(12, 46);
            this.engageDuplexButton.Name = "engageDuplexButton";
            this.engageDuplexButton.Size = new System.Drawing.Size(114, 23);
            this.engageDuplexButton.TabIndex = 3;
            this.engageDuplexButton.Text = "Engage radio duplex";
            this.engageDuplexButton.UseVisualStyleBackColor = true;
            this.engageDuplexButton.Click += new System.EventHandler(this.engageDuplexButton_Click);
            // 
            // duplexOffsetButton
            // 
            this.duplexOffsetButton.Location = new System.Drawing.Point(216, 46);
            this.duplexOffsetButton.Name = "duplexOffsetButton";
            this.duplexOffsetButton.Size = new System.Drawing.Size(103, 23);
            this.duplexOffsetButton.TabIndex = 3;
            this.duplexOffsetButton.Text = "Set duplex offset";
            this.duplexOffsetButton.UseVisualStyleBackColor = true;
            this.duplexOffsetButton.Click += new System.EventHandler(this.duplexOffsetButton_Click);
            // 
            // RadioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 88);
            this.Controls.Add(this.duplexOffsetButton);
            this.Controls.Add(this.engageDuplexButton);
            this.Controls.Add(this.frequnecyButton);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.frequnecyTextbox);
            this.Name = "RadioControl";
            this.Text = "RadioControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RadioControl_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox frequnecyTextbox;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Button frequnecyButton;
        private System.Windows.Forms.Button engageDuplexButton;
        private System.Windows.Forms.Button duplexOffsetButton;
    }
}