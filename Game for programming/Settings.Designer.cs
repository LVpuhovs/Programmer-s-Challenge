namespace Game_for_programming
{
    partial class Settings
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.Mute = new System.Windows.Forms.CheckBox();
            this.SettingsLbl = new System.Windows.Forms.Label();
            this.volumeChange = new System.Windows.Forms.HScrollBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ZeroLbl = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.ChangeVolumeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBtn.Location = new System.Drawing.Point(133, 214);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(97, 37);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Mute
            // 
            this.Mute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mute.AutoSize = true;
            this.Mute.Location = new System.Drawing.Point(137, 58);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(96, 20);
            this.Mute.TabIndex = 1;
            this.Mute.Text = "Mute Audio";
            this.Mute.UseVisualStyleBackColor = true;
            this.Mute.CheckedChanged += new System.EventHandler(this.Mute_CheckedChanged);
            // 
            // SettingsLbl
            // 
            this.SettingsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsLbl.AutoSize = true;
            this.SettingsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLbl.Location = new System.Drawing.Point(127, 9);
            this.SettingsLbl.Name = "SettingsLbl";
            this.SettingsLbl.Size = new System.Drawing.Size(121, 31);
            this.SettingsLbl.TabIndex = 2;
            this.SettingsLbl.Text = "Settings";
            // 
            // volumeChange
            // 
            this.volumeChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeChange.Location = new System.Drawing.Point(29, 126);
            this.volumeChange.Name = "volumeChange";
            this.volumeChange.Size = new System.Drawing.Size(317, 23);
            this.volumeChange.TabIndex = 3;
            this.volumeChange.Value = 40;
            this.volumeChange.ValueChanged += new System.EventHandler(this.volumeChange_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(65, 126);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(8, 8);
            this.progressBar1.TabIndex = 4;
            // 
            // ZeroLbl
            // 
            this.ZeroLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroLbl.AutoSize = true;
            this.ZeroLbl.Location = new System.Drawing.Point(12, 126);
            this.ZeroLbl.Name = "ZeroLbl";
            this.ZeroLbl.Size = new System.Drawing.Size(14, 16);
            this.ZeroLbl.TabIndex = 5;
            this.ZeroLbl.Text = "0";
            // 
            // label100
            // 
            this.label100.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(349, 126);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(28, 16);
            this.label100.TabIndex = 6;
            this.label100.Text = "100";
            // 
            // ChangeVolumeLbl
            // 
            this.ChangeVolumeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeVolumeLbl.AutoSize = true;
            this.ChangeVolumeLbl.Location = new System.Drawing.Point(130, 95);
            this.ChangeVolumeLbl.Name = "ChangeVolumeLbl";
            this.ChangeVolumeLbl.Size = new System.Drawing.Size(103, 16);
            this.ChangeVolumeLbl.TabIndex = 7;
            this.ChangeVolumeLbl.Text = "Change Volume";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 263);
            this.Controls.Add(this.ChangeVolumeLbl);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.ZeroLbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.volumeChange);
            this.Controls.Add(this.SettingsLbl);
            this.Controls.Add(this.Mute);
            this.Controls.Add(this.BackBtn);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.CheckBox Mute;
        private System.Windows.Forms.Label SettingsLbl;
        private System.Windows.Forms.HScrollBar volumeChange;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ZeroLbl;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label ChangeVolumeLbl;
    }
}