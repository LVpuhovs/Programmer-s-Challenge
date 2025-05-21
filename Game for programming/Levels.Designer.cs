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
            this.LevelsLbl = new System.Windows.Forms.Label();
            this.DifficultyFilter = new System.Windows.Forms.ComboBox();
            this.FilterLbl = new System.Windows.Forms.Label();
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
            this.levelsPanel.Location = new System.Drawing.Point(0, 126);
            this.levelsPanel.Name = "levelsPanel";
            this.levelsPanel.Size = new System.Drawing.Size(800, 324);
            this.levelsPanel.TabIndex = 2;
            // 
            // LevelsLbl
            // 
            this.LevelsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelsLbl.AutoSize = true;
            this.LevelsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelsLbl.Location = new System.Drawing.Point(346, 21);
            this.LevelsLbl.Name = "LevelsLbl";
            this.LevelsLbl.Size = new System.Drawing.Size(99, 31);
            this.LevelsLbl.TabIndex = 3;
            this.LevelsLbl.Text = "Levels";
            // 
            // DifficultyFilter
            // 
            this.DifficultyFilter.AccessibleName = "";
            this.DifficultyFilter.FormattingEnabled = true;
            this.DifficultyFilter.Items.AddRange(new object[] {
            "All",
            "Easy",
            "Medium",
            "Hard"});
            this.DifficultyFilter.Location = new System.Drawing.Point(19, 83);
            this.DifficultyFilter.Name = "DifficultyFilter";
            this.DifficultyFilter.Size = new System.Drawing.Size(121, 24);
            this.DifficultyFilter.TabIndex = 4;
            this.DifficultyFilter.Text = "All";
            this.DifficultyFilter.SelectedIndexChanged += new System.EventHandler(this.DifficultyFilter_SelectedIndexChanged);
            // 
            // FilterLbl
            // 
            this.FilterLbl.AutoSize = true;
            this.FilterLbl.Location = new System.Drawing.Point(146, 86);
            this.FilterLbl.Name = "FilterLbl";
            this.FilterLbl.Size = new System.Drawing.Size(104, 16);
            this.FilterLbl.TabIndex = 5;
            this.FilterLbl.Text = "Filter by difficulty";
            // 
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilterLbl);
            this.Controls.Add(this.DifficultyFilter);
            this.Controls.Add(this.LevelsLbl);
            this.Controls.Add(this.levelsPanel);
            this.Controls.Add(this.BackButton);
            this.Name = "Levels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levels";
            this.Load += new System.EventHandler(this.levelsLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Levels_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel levelsPanel;
        private System.Windows.Forms.Label LevelsLbl;
        private System.Windows.Forms.ComboBox DifficultyFilter;
        private System.Windows.Forms.Label FilterLbl;
    }
}