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
            this.level1Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // level1Btn
            // 
            this.level1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1Btn.Location = new System.Drawing.Point(116, 92);
            this.level1Btn.Name = "level1Btn";
            this.level1Btn.Size = new System.Drawing.Size(70, 54);
            this.level1Btn.TabIndex = 0;
            this.level1Btn.Text = "1";
            this.level1Btn.UseVisualStyleBackColor = true;
            this.level1Btn.Click += new System.EventHandler(this.level1Btn_Click);
            // 
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.level1Btn);
            this.Name = "Levels";
            this.Text = "Levels";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button level1Btn;
    }
}