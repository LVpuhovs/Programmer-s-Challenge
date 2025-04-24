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
            this.DoneButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.OutputLbl = new System.Windows.Forms.Label();
            this.selectedLanguageLBL = new System.Windows.Forms.Label();
            this.taskPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TaskLbl = new System.Windows.Forms.Label();
            this.taskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userCodeTxtBx
            // 
            this.userCodeTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userCodeTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCodeTxtBx.Location = new System.Drawing.Point(33, 173);
            this.userCodeTxtBx.Name = "userCodeTxtBx";
            this.userCodeTxtBx.Size = new System.Drawing.Size(491, 288);
            this.userCodeTxtBx.TabIndex = 0;
            this.userCodeTxtBx.Text = "";
            // 
            // outputTxtBx
            // 
            this.outputTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTxtBx.Location = new System.Drawing.Point(598, 177);
            this.outputTxtBx.Name = "outputTxtBx";
            this.outputTxtBx.Size = new System.Drawing.Size(296, 288);
            this.outputTxtBx.TabIndex = 1;
            this.outputTxtBx.Text = "";
            // 
            // runButton
            // 
            this.runButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.runButton.Location = new System.Drawing.Point(428, 132);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(96, 35);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.Location = new System.Drawing.Point(792, 471);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(102, 33);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.OutputLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputLbl.AutoSize = true;
            this.OutputLbl.Location = new System.Drawing.Point(595, 151);
            this.OutputLbl.Name = "OutputLbl";
            this.OutputLbl.Size = new System.Drawing.Size(45, 16);
            this.OutputLbl.TabIndex = 5;
            this.OutputLbl.Text = "Output";
            // 
            // selectedLanguageLBL
            // 
            this.selectedLanguageLBL.AutoSize = true;
            this.selectedLanguageLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedLanguageLBL.Location = new System.Drawing.Point(31, 9);
            this.selectedLanguageLBL.Name = "selectedLanguageLBL";
            this.selectedLanguageLBL.Size = new System.Drawing.Size(86, 31);
            this.selectedLanguageLBL.TabIndex = 6;
            this.selectedLanguageLBL.Text = "label1";
            // 
            // taskPanel
            // 
            this.taskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskPanel.Controls.Add(this.TaskLbl);
            this.taskPanel.Location = new System.Drawing.Point(29, 45);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(864, 76);
            this.taskPanel.TabIndex = 8;
            // 
            // TaskLbl
            // 
            this.TaskLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TaskLbl.AutoEllipsis = true;
            this.TaskLbl.AutoSize = true;
            this.TaskLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskLbl.Location = new System.Drawing.Point(3, 0);
            this.TaskLbl.Name = "TaskLbl";
            this.TaskLbl.Size = new System.Drawing.Size(53, 20);
            this.TaskLbl.TabIndex = 7;
            this.TaskLbl.Text = "label2";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 521);
            this.Controls.Add(this.taskPanel);
            this.Controls.Add(this.selectedLanguageLBL);
            this.Controls.Add(this.OutputLbl);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.outputTxtBx);
            this.Controls.Add(this.userCodeTxtBx);
            this.Name = "Game";
            this.Text = "Form2";
            this.taskPanel.ResumeLayout(false);
            this.taskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox userCodeTxtBx;
        private System.Windows.Forms.RichTextBox outputTxtBx;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label OutputLbl;
        private System.Windows.Forms.Label selectedLanguageLBL;
        private System.Windows.Forms.FlowLayoutPanel taskPanel;
        private System.Windows.Forms.Label TaskLbl;
    }
}