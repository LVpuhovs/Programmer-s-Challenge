namespace Game_for_programming
{
    partial class Pause
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
            this.PauseLbl = new System.Windows.Forms.Label();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.QuitGamebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PauseLbl
            // 
            this.PauseLbl.AutoSize = true;
            this.PauseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseLbl.Location = new System.Drawing.Point(137, 40);
            this.PauseLbl.Name = "PauseLbl";
            this.PauseLbl.Size = new System.Drawing.Size(96, 31);
            this.PauseLbl.TabIndex = 0;
            this.PauseLbl.Text = "Pause";
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Location = new System.Drawing.Point(104, 137);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(161, 58);
            this.SettingsBtn.TabIndex = 1;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Location = new System.Drawing.Point(104, 221);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(161, 58);
            this.MainMenuBtn.TabIndex = 2;
            this.MainMenuBtn.Text = "Quit to Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // QuitGamebtn
            // 
            this.QuitGamebtn.Location = new System.Drawing.Point(104, 305);
            this.QuitGamebtn.Name = "QuitGamebtn";
            this.QuitGamebtn.Size = new System.Drawing.Size(161, 58);
            this.QuitGamebtn.TabIndex = 3;
            this.QuitGamebtn.Text = "Quit Game";
            this.QuitGamebtn.UseVisualStyleBackColor = true;
            this.QuitGamebtn.Click += new System.EventHandler(this.QuitGamebtn_Click);
            // 
            // Pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 449);
            this.Controls.Add(this.QuitGamebtn);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.PauseLbl);
            this.Name = "Pause";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pause";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PauseLbl;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Button QuitGamebtn;
    }
}