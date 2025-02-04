namespace Game_for_programming
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.QuitBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.English = new System.Windows.Forms.PictureBox();
            this.Latvian = new System.Windows.Forms.PictureBox();
            this.signinbtn = new System.Windows.Forms.Button();
            this.signupbtn = new System.Windows.Forms.Button();
            this.SignOutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.English)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Latvian)).BeginInit();
            this.SuspendLayout();
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(326, 330);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(101, 42);
            this.QuitBtn.TabIndex = 0;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Location = new System.Drawing.Point(326, 269);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(101, 42);
            this.SettingsBtn.TabIndex = 1;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(326, 209);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(101, 42);
            this.PlayBtn.TabIndex = 2;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // English
            // 
            this.English.Image = ((System.Drawing.Image)(resources.GetObject("English.Image")));
            this.English.Location = new System.Drawing.Point(12, 415);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(23, 23);
            this.English.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.English.TabIndex = 3;
            this.English.TabStop = false;
            this.English.Click += new System.EventHandler(this.English_Click);
            // 
            // Latvian
            // 
            this.Latvian.Image = ((System.Drawing.Image)(resources.GetObject("Latvian.Image")));
            this.Latvian.Location = new System.Drawing.Point(41, 415);
            this.Latvian.Name = "Latvian";
            this.Latvian.Size = new System.Drawing.Size(23, 23);
            this.Latvian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Latvian.TabIndex = 4;
            this.Latvian.TabStop = false;
            this.Latvian.Click += new System.EventHandler(this.Latvian_Click);
            // 
            // signinbtn
            // 
            this.signinbtn.Location = new System.Drawing.Point(12, 3);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(74, 31);
            this.signinbtn.TabIndex = 5;
            this.signinbtn.Text = "Sign In";
            this.signinbtn.UseVisualStyleBackColor = true;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // signupbtn
            // 
            this.signupbtn.Location = new System.Drawing.Point(12, 40);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(74, 31);
            this.signupbtn.TabIndex = 6;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.UseVisualStyleBackColor = true;
            // 
            // SignOutBtn
            // 
            this.SignOutBtn.Location = new System.Drawing.Point(716, 9);
            this.SignOutBtn.Name = "SignOutBtn";
            this.SignOutBtn.Size = new System.Drawing.Size(79, 24);
            this.SignOutBtn.TabIndex = 7;
            this.SignOutBtn.Text = "Sign Out";
            this.SignOutBtn.UseVisualStyleBackColor = true;
            this.SignOutBtn.Click += new System.EventHandler(this.SignOutBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignOutBtn);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.signinbtn);
            this.Controls.Add(this.Latvian);
            this.Controls.Add(this.English);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.QuitBtn);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.English)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Latvian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.PictureBox English;
        private System.Windows.Forms.PictureBox Latvian;
        private System.Windows.Forms.Button signinbtn;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Button SignOutBtn;
    }
}

