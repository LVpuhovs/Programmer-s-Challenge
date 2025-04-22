namespace Game_for_programming
{
    partial class Signup
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
            this.NameTxtBx = new System.Windows.Forms.TextBox();
            this.UsernameTxtBx = new System.Windows.Forms.TextBox();
            this.PasswordTxtBx = new System.Windows.Forms.TextBox();
            this.EmailTxtBx = new System.Windows.Forms.TextBox();
            this.RoleSelection = new System.Windows.Forms.CheckedListBox();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SignInLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTxtBx
            // 
            this.NameTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTxtBx.Location = new System.Drawing.Point(92, 67);
            this.NameTxtBx.Name = "NameTxtBx";
            this.NameTxtBx.Size = new System.Drawing.Size(181, 22);
            this.NameTxtBx.TabIndex = 0;
            // 
            // UsernameTxtBx
            // 
            this.UsernameTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTxtBx.Location = new System.Drawing.Point(92, 140);
            this.UsernameTxtBx.Name = "UsernameTxtBx";
            this.UsernameTxtBx.Size = new System.Drawing.Size(181, 22);
            this.UsernameTxtBx.TabIndex = 1;
            // 
            // PasswordTxtBx
            // 
            this.PasswordTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTxtBx.Location = new System.Drawing.Point(92, 207);
            this.PasswordTxtBx.Name = "PasswordTxtBx";
            this.PasswordTxtBx.Size = new System.Drawing.Size(181, 22);
            this.PasswordTxtBx.TabIndex = 2;
            // 
            // EmailTxtBx
            // 
            this.EmailTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTxtBx.Location = new System.Drawing.Point(92, 270);
            this.EmailTxtBx.Name = "EmailTxtBx";
            this.EmailTxtBx.Size = new System.Drawing.Size(181, 22);
            this.EmailTxtBx.TabIndex = 3;
            // 
            // RoleSelection
            // 
            this.RoleSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoleSelection.FormattingEnabled = true;
            this.RoleSelection.Items.AddRange(new object[] {
            "Students",
            "Lecturer / Professor"});
            this.RoleSelection.Location = new System.Drawing.Point(92, 338);
            this.RoleSelection.Name = "RoleSelection";
            this.RoleSelection.Size = new System.Drawing.Size(186, 55);
            this.RoleSelection.TabIndex = 4;
            this.RoleSelection.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.RoleSelection_ItemCheck);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.Location = new System.Drawing.Point(92, 428);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(181, 60);
            this.SignUpBtn.TabIndex = 5;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Role";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Already Have Account?";
            // 
            // SignInLbl
            // 
            this.SignInLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInLbl.AutoSize = true;
            this.SignInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.SignInLbl.Location = new System.Drawing.Point(243, 409);
            this.SignInLbl.Name = "SignInLbl";
            this.SignInLbl.Size = new System.Drawing.Size(54, 16);
            this.SignInLbl.TabIndex = 12;
            this.SignInLbl.Text = "Sign in";
            this.SignInLbl.Click += new System.EventHandler(this.SignInLbl_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 537);
            this.Controls.Add(this.SignInLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.RoleSelection);
            this.Controls.Add(this.EmailTxtBx);
            this.Controls.Add(this.PasswordTxtBx);
            this.Controls.Add(this.UsernameTxtBx);
            this.Controls.Add(this.NameTxtBx);
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxtBx;
        private System.Windows.Forms.TextBox UsernameTxtBx;
        private System.Windows.Forms.TextBox PasswordTxtBx;
        private System.Windows.Forms.TextBox EmailTxtBx;
        private System.Windows.Forms.CheckedListBox RoleSelection;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SignInLbl;
    }
}