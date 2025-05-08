namespace Game_for_programming
{
    partial class LanguageSelection
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
            this.BackButton = new System.Windows.Forms.Button();
            this.PreferedLanguageLbl = new System.Windows.Forms.Label();
            this.cSharpButton = new System.Windows.Forms.Button();
            this.JavaButton = new System.Windows.Forms.Button();
            this.PythonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Location = new System.Drawing.Point(128, 305);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(141, 32);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PreferedLanguageLbl
            // 
            this.PreferedLanguageLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreferedLanguageLbl.AutoSize = true;
            this.PreferedLanguageLbl.Location = new System.Drawing.Point(115, 120);
            this.PreferedLanguageLbl.Name = "PreferedLanguageLbl";
            this.PreferedLanguageLbl.Size = new System.Drawing.Size(180, 16);
            this.PreferedLanguageLbl.TabIndex = 1;
            this.PreferedLanguageLbl.Text = "Choose Prefferred Language";
            // 
            // cSharpButton
            // 
            this.cSharpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cSharpButton.Location = new System.Drawing.Point(128, 154);
            this.cSharpButton.Name = "cSharpButton";
            this.cSharpButton.Size = new System.Drawing.Size(141, 37);
            this.cSharpButton.TabIndex = 2;
            this.cSharpButton.Text = "C#";
            this.cSharpButton.UseVisualStyleBackColor = true;
            this.cSharpButton.Click += new System.EventHandler(this.cSharpButton_Click);
            // 
            // JavaButton
            // 
            this.JavaButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JavaButton.Location = new System.Drawing.Point(128, 197);
            this.JavaButton.Name = "JavaButton";
            this.JavaButton.Size = new System.Drawing.Size(141, 37);
            this.JavaButton.TabIndex = 3;
            this.JavaButton.Text = "JAVA";
            this.JavaButton.UseVisualStyleBackColor = true;
            this.JavaButton.Click += new System.EventHandler(this.JavaButton_Click);
            // 
            // PythonButton
            // 
            this.PythonButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PythonButton.Location = new System.Drawing.Point(128, 240);
            this.PythonButton.Name = "PythonButton";
            this.PythonButton.Size = new System.Drawing.Size(141, 37);
            this.PythonButton.TabIndex = 4;
            this.PythonButton.Text = "Python";
            this.PythonButton.UseVisualStyleBackColor = true;
            this.PythonButton.Click += new System.EventHandler(this.PythonButton_Click);
            // 
            // LanguageSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 444);
            this.Controls.Add(this.PythonButton);
            this.Controls.Add(this.JavaButton);
            this.Controls.Add(this.cSharpButton);
            this.Controls.Add(this.PreferedLanguageLbl);
            this.Controls.Add(this.BackButton);
            this.Name = "LanguageSelection";
            this.Text = "Language Selection";
            this.Load += new System.EventHandler(this.LanguageSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label PreferedLanguageLbl;
        private System.Windows.Forms.Button cSharpButton;
        private System.Windows.Forms.Button JavaButton;
        private System.Windows.Forms.Button PythonButton;
    }
}