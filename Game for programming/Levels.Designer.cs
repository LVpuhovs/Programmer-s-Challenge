namespace Game_for_programming
{
    partial class Levels
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
            this.levelsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Location = new System.Drawing.Point(19, 21);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(97, 33);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // levelsPanel
            // 
            this.levelsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.levelsPanel.Location = new System.Drawing.Point(0, 97);
            this.levelsPanel.Name = "levelsPanel";
            this.levelsPanel.Size = new System.Drawing.Size(800, 353);
            this.levelsPanel.TabIndex = 2;
            // 
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.levelsPanel);
            this.Controls.Add(this.BackButton);
            this.Name = "Levels";
            this.Text = "Levels";
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.levelsLoad);
        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel levelsPanel;
    }
}