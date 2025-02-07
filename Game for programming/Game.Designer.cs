namespace Game_for_programming
{
    partial class Game
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
            this.userCodeTxtBx = new System.Windows.Forms.RichTextBox();
            this.outputTxtBx = new System.Windows.Forms.RichTextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.OutputLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userCodeTxtBx
            // 
            this.userCodeTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCodeTxtBx.Location = new System.Drawing.Point(33, 150);
            this.userCodeTxtBx.Name = "userCodeTxtBx";
            this.userCodeTxtBx.Size = new System.Drawing.Size(491, 288);
            this.userCodeTxtBx.TabIndex = 0;
            this.userCodeTxtBx.Text = "";
            // 
            // outputTxtBx
            // 
            this.outputTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTxtBx.Location = new System.Drawing.Point(598, 66);
            this.outputTxtBx.Name = "outputTxtBx";
            this.outputTxtBx.Size = new System.Drawing.Size(296, 372);
            this.outputTxtBx.TabIndex = 1;
            this.outputTxtBx.Text = "";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(428, 109);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(96, 35);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(792, 471);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(102, 33);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(660, 471);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(102, 33);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OutputLbl
            // 
            this.OutputLbl.AutoSize = true;
            this.OutputLbl.Location = new System.Drawing.Point(598, 44);
            this.OutputLbl.Name = "OutputLbl";
            this.OutputLbl.Size = new System.Drawing.Size(45, 16);
            this.OutputLbl.TabIndex = 5;
            this.OutputLbl.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputLbl);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.outputTxtBx);
            this.Controls.Add(this.userCodeTxtBx);
            this.Name = "Game";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox userCodeTxtBx;
        private System.Windows.Forms.RichTextBox outputTxtBx;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label OutputLbl;
        private System.Windows.Forms.Label label1;
    }
}