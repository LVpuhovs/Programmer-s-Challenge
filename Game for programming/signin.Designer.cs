namespace Game_for_programming
{
    partial class signin
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
            this.usernameTxtBx = new System.Windows.Forms.TextBox();
            this.passwordTxtBx = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.signinbtn = new System.Windows.Forms.Button();
            this.NewHereLbl = new System.Windows.Forms.Label();
            this.signupLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTxtBx
            // 
            this.usernameTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTxtBx.Location = new System.Drawing.Point(79, 127);
            this.usernameTxtBx.Name = "usernameTxtBx";
            this.usernameTxtBx.Size = new System.Drawing.Size(187, 22);
            this.usernameTxtBx.TabIndex = 0;
            // 
            // passwordTxtBx
            // 
            this.passwordTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTxtBx.Location = new System.Drawing.Point(79, 197);
            this.passwordTxtBx.Name = "passwordTxtBx";
            this.passwordTxtBx.Size = new System.Drawing.Size(187, 22);
            this.passwordTxtBx.TabIndex = 1;
            // 
            // usernameLbl
            // 
            this.usernameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(79, 105);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(70, 16);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(82, 175);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(67, 16);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Password";
            // 
            // signinbtn
            // 
            this.signinbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signinbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbtn.Location = new System.Drawing.Point(79, 263);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(187, 66);
            this.signinbtn.TabIndex = 4;
            this.signinbtn.Text = "Sign in";
            this.signinbtn.UseVisualStyleBackColor = true;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // NewHereLbl
            // 
            this.NewHereLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewHereLbl.AutoSize = true;
            this.NewHereLbl.Location = new System.Drawing.Point(79, 233);
            this.NewHereLbl.Name = "NewHereLbl";
            this.NewHereLbl.Size = new System.Drawing.Size(74, 16);
            this.NewHereLbl.TabIndex = 5;
            this.NewHereLbl.Text = "New Here?";
            // 
            // signupLbl
            // 
            this.signupLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signupLbl.AutoSize = true;
            this.signupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signupLbl.Location = new System.Drawing.Point(160, 233);
            this.signupLbl.Name = "signupLbl";
            this.signupLbl.Size = new System.Drawing.Size(132, 16);
            this.signupLbl.TabIndex = 6;
            this.signupLbl.Text = "Create an account";
            this.signupLbl.Click += new System.EventHandler(this.signupLbl_Click);
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.signupLbl);
            this.Controls.Add(this.NewHereLbl);
            this.Controls.Add(this.signinbtn);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.passwordTxtBx);
            this.Controls.Add(this.usernameTxtBx);
            this.Name = "signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.signin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTxtBx;
        private System.Windows.Forms.TextBox passwordTxtBx;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Button signinbtn;
        private System.Windows.Forms.Label NewHereLbl;
        private System.Windows.Forms.Label signupLbl;
    }
}