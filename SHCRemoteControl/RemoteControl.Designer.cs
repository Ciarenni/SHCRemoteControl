namespace RemoteControl
{
    partial class RemoteControl
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
            this.allStopBtn = new System.Windows.Forms.Button();
            this.tokenBtn = new System.Windows.Forms.Button();
            this.azimuthLabel = new System.Windows.Forms.Label();
            this.azimuthTextBox = new System.Windows.Forms.TextBox();
            this.elevationLabel = new System.Windows.Forms.Label();
            this.elevationTextBox = new System.Windows.Forms.TextBox();
            this.aziIncStepBtn = new System.Windows.Forms.Button();
            this.aziIncBigStepBtn = new System.Windows.Forms.Button();
            this.eleIncStepBtn = new System.Windows.Forms.Button();
            this.eleIncBigStepBtn = new System.Windows.Forms.Button();
            this.eleDecBigStepBtn = new System.Windows.Forms.Button();
            this.eleDecStepBtn = new System.Windows.Forms.Button();
            this.aziDecBigStepBtn = new System.Windows.Forms.Button();
            this.aziDecStepBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allStopBtn
            // 
            this.allStopBtn.Enabled = false;
            this.allStopBtn.Location = new System.Drawing.Point(12, 133);
            this.allStopBtn.Name = "allStopBtn";
            this.allStopBtn.Size = new System.Drawing.Size(85, 23);
            this.allStopBtn.TabIndex = 0;
            this.allStopBtn.Text = "All Stop";
            this.allStopBtn.UseVisualStyleBackColor = true;
            // 
            // tokenBtn
            // 
            this.tokenBtn.Location = new System.Drawing.Point(151, 133);
            this.tokenBtn.Name = "tokenBtn";
            this.tokenBtn.Size = new System.Drawing.Size(85, 23);
            this.tokenBtn.TabIndex = 1;
            this.tokenBtn.Text = "Grab token";
            this.tokenBtn.UseVisualStyleBackColor = true;
            this.tokenBtn.Click += new System.EventHandler(this.tokenBtn_Click);
            // 
            // azimuthLabel
            // 
            this.azimuthLabel.AutoSize = true;
            this.azimuthLabel.Location = new System.Drawing.Point(102, 9);
            this.azimuthLabel.Name = "azimuthLabel";
            this.azimuthLabel.Size = new System.Drawing.Size(44, 13);
            this.azimuthLabel.TabIndex = 2;
            this.azimuthLabel.Text = "Azimuth";
            // 
            // azimuthTextBox
            // 
            this.azimuthTextBox.Location = new System.Drawing.Point(74, 25);
            this.azimuthTextBox.Name = "azimuthTextBox";
            this.azimuthTextBox.Size = new System.Drawing.Size(100, 20);
            this.azimuthTextBox.TabIndex = 3;
            this.azimuthTextBox.Text = "0";
            this.azimuthTextBox.TextChanged += new System.EventHandler(this.azimuthTextBox_TextChanged);
            // 
            // elevationLabel
            // 
            this.elevationLabel.AutoSize = true;
            this.elevationLabel.Location = new System.Drawing.Point(99, 69);
            this.elevationLabel.Name = "elevationLabel";
            this.elevationLabel.Size = new System.Drawing.Size(51, 13);
            this.elevationLabel.TabIndex = 2;
            this.elevationLabel.Text = "Elevation";
            // 
            // elevationTextBox
            // 
            this.elevationTextBox.Location = new System.Drawing.Point(74, 85);
            this.elevationTextBox.Name = "elevationTextBox";
            this.elevationTextBox.Size = new System.Drawing.Size(100, 20);
            this.elevationTextBox.TabIndex = 3;
            this.elevationTextBox.Text = "0";
            this.elevationTextBox.TextChanged += new System.EventHandler(this.elevationTextBox_TextChanged);
            // 
            // aziIncStepBtn
            // 
            this.aziIncStepBtn.Location = new System.Drawing.Point(178, 23);
            this.aziIncStepBtn.Name = "aziIncStepBtn";
            this.aziIncStepBtn.Size = new System.Drawing.Size(27, 23);
            this.aziIncStepBtn.TabIndex = 0;
            this.aziIncStepBtn.Text = ">";
            this.aziIncStepBtn.UseVisualStyleBackColor = true;
            this.aziIncStepBtn.Click += new System.EventHandler(this.aziIncStepBtn_Click);
            // 
            // aziIncBigStepBtn
            // 
            this.aziIncBigStepBtn.Location = new System.Drawing.Point(209, 23);
            this.aziIncBigStepBtn.Name = "aziIncBigStepBtn";
            this.aziIncBigStepBtn.Size = new System.Drawing.Size(27, 23);
            this.aziIncBigStepBtn.TabIndex = 0;
            this.aziIncBigStepBtn.Text = ">>";
            this.aziIncBigStepBtn.UseVisualStyleBackColor = true;
            this.aziIncBigStepBtn.Click += new System.EventHandler(this.aziIncBigStepBtn_Click);
            // 
            // eleIncStepBtn
            // 
            this.eleIncStepBtn.Location = new System.Drawing.Point(178, 83);
            this.eleIncStepBtn.Name = "eleIncStepBtn";
            this.eleIncStepBtn.Size = new System.Drawing.Size(27, 23);
            this.eleIncStepBtn.TabIndex = 0;
            this.eleIncStepBtn.Text = ">";
            this.eleIncStepBtn.UseVisualStyleBackColor = true;
            this.eleIncStepBtn.Click += new System.EventHandler(this.eleIncStepBtn_Click);
            // 
            // eleIncBigStepBtn
            // 
            this.eleIncBigStepBtn.Location = new System.Drawing.Point(209, 83);
            this.eleIncBigStepBtn.Name = "eleIncBigStepBtn";
            this.eleIncBigStepBtn.Size = new System.Drawing.Size(27, 23);
            this.eleIncBigStepBtn.TabIndex = 0;
            this.eleIncBigStepBtn.Text = ">>";
            this.eleIncBigStepBtn.UseVisualStyleBackColor = true;
            this.eleIncBigStepBtn.Click += new System.EventHandler(this.eleIncBigStepBtn_Click);
            // 
            // eleDecBigStepBtn
            // 
            this.eleDecBigStepBtn.Location = new System.Drawing.Point(12, 83);
            this.eleDecBigStepBtn.Name = "eleDecBigStepBtn";
            this.eleDecBigStepBtn.Size = new System.Drawing.Size(27, 23);
            this.eleDecBigStepBtn.TabIndex = 0;
            this.eleDecBigStepBtn.Text = "<<";
            this.eleDecBigStepBtn.UseVisualStyleBackColor = true;
            this.eleDecBigStepBtn.Click += new System.EventHandler(this.eleDecBigStepBtn_Click);
            // 
            // eleDecStepBtn
            // 
            this.eleDecStepBtn.Location = new System.Drawing.Point(42, 83);
            this.eleDecStepBtn.Name = "eleDecStepBtn";
            this.eleDecStepBtn.Size = new System.Drawing.Size(27, 23);
            this.eleDecStepBtn.TabIndex = 0;
            this.eleDecStepBtn.Text = "<";
            this.eleDecStepBtn.UseVisualStyleBackColor = true;
            this.eleDecStepBtn.Click += new System.EventHandler(this.eleDecStepBtn_Click);
            // 
            // aziDecBigStepBtn
            // 
            this.aziDecBigStepBtn.Location = new System.Drawing.Point(12, 23);
            this.aziDecBigStepBtn.Name = "aziDecBigStepBtn";
            this.aziDecBigStepBtn.Size = new System.Drawing.Size(27, 23);
            this.aziDecBigStepBtn.TabIndex = 0;
            this.aziDecBigStepBtn.Text = "<<";
            this.aziDecBigStepBtn.UseVisualStyleBackColor = true;
            this.aziDecBigStepBtn.Click += new System.EventHandler(this.aziDecBigStepBtn_Click);
            // 
            // aziDecStepBtn
            // 
            this.aziDecStepBtn.Location = new System.Drawing.Point(42, 23);
            this.aziDecStepBtn.Name = "aziDecStepBtn";
            this.aziDecStepBtn.Size = new System.Drawing.Size(27, 23);
            this.aziDecStepBtn.TabIndex = 0;
            this.aziDecStepBtn.Text = "<";
            this.aziDecStepBtn.UseVisualStyleBackColor = true;
            this.aziDecStepBtn.Click += new System.EventHandler(this.aziDecStepBtn_Click);
            // 
            // RemoteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 168);
            this.Controls.Add(this.elevationTextBox);
            this.Controls.Add(this.azimuthTextBox);
            this.Controls.Add(this.elevationLabel);
            this.Controls.Add(this.azimuthLabel);
            this.Controls.Add(this.tokenBtn);
            this.Controls.Add(this.aziDecStepBtn);
            this.Controls.Add(this.eleDecStepBtn);
            this.Controls.Add(this.eleIncBigStepBtn);
            this.Controls.Add(this.aziIncBigStepBtn);
            this.Controls.Add(this.aziDecBigStepBtn);
            this.Controls.Add(this.eleDecBigStepBtn);
            this.Controls.Add(this.eleIncStepBtn);
            this.Controls.Add(this.aziIncStepBtn);
            this.Controls.Add(this.allStopBtn);
            this.Name = "RemoteControl";
            this.Text = "SHC Remote Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoteControl_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allStopBtn;
        private System.Windows.Forms.Button tokenBtn;
        private System.Windows.Forms.Label azimuthLabel;
        private System.Windows.Forms.TextBox azimuthTextBox;
        private System.Windows.Forms.Label elevationLabel;
        private System.Windows.Forms.TextBox elevationTextBox;
        private System.Windows.Forms.Button aziIncStepBtn;
        private System.Windows.Forms.Button aziIncBigStepBtn;
        private System.Windows.Forms.Button eleIncStepBtn;
        private System.Windows.Forms.Button eleIncBigStepBtn;
        private System.Windows.Forms.Button eleDecBigStepBtn;
        private System.Windows.Forms.Button eleDecStepBtn;
        private System.Windows.Forms.Button aziDecBigStepBtn;
        private System.Windows.Forms.Button aziDecStepBtn;
    }
}

