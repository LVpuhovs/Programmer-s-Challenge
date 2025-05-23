namespace Game_for_programming
{
    partial class TaskList
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
            this.TaskListLbl = new System.Windows.Forms.Label();
            this.TaskPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.Backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskListLbl
            // 
            this.TaskListLbl.AutoSize = true;
            this.TaskListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskListLbl.Location = new System.Drawing.Point(617, 29);
            this.TaskListLbl.Name = "TaskListLbl";
            this.TaskListLbl.Size = new System.Drawing.Size(133, 31);
            this.TaskListLbl.TabIndex = 0;
            this.TaskListLbl.Text = "Task List";
            // 
            // TaskPannel
            // 
            this.TaskPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskPannel.Location = new System.Drawing.Point(0, 85);
            this.TaskPannel.Name = "TaskPannel";
            this.TaskPannel.Size = new System.Drawing.Size(1403, 633);
            this.TaskPannel.TabIndex = 1;
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(12, 23);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(103, 37);
            this.Backbtn.TabIndex = 2;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1399, 718);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.TaskPannel);
            this.Controls.Add(this.TaskListLbl);
            this.Name = "TaskList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskList";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TaskList_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskListLbl;
        private System.Windows.Forms.FlowLayoutPanel TaskPannel;
        private System.Windows.Forms.Button Backbtn;
    }
}