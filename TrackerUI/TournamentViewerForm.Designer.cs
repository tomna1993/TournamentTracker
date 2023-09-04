namespace TrackerUI
{
    partial class tournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tournamentLabel = new Label();
            tournamentNameLabel = new Label();
            roundLabel = new Label();
            roundDropDownList = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneNameGroupBox = new GroupBox();
            teamOneScoreTextBox = new TextBox();
            teamOneScoreLabel = new Label();
            teamTwoNameGroupBox = new GroupBox();
            teamTwoScoreTextBox = new TextBox();
            teamTwoScoreLabel = new Label();
            scoreButton = new Button();
            teamOneNameGroupBox.SuspendLayout();
            teamTwoNameGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tournamentLabel
            // 
            tournamentLabel.AutoSize = true;
            tournamentLabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            tournamentLabel.ForeColor = Color.RoyalBlue;
            tournamentLabel.Location = new Point(26, 35);
            tournamentLabel.Name = "tournamentLabel";
            tournamentLabel.Size = new Size(234, 50);
            tournamentLabel.TabIndex = 0;
            tournamentLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = Color.RoyalBlue;
            tournamentNameLabel.Location = new Point(252, 35);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(168, 50);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "<name>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            roundLabel.Location = new Point(26, 118);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(99, 38);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDownList
            // 
            roundDropDownList.FormattingEnabled = true;
            roundDropDownList.Location = new Point(145, 111);
            roundDropDownList.Name = "roundDropDownList";
            roundDropDownList.Size = new Size(275, 45);
            roundDropDownList.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.Location = new Point(145, 178);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(222, 42);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 37;
            matchupListBox.Location = new Point(26, 238);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(394, 337);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneNameGroupBox
            // 
            teamOneNameGroupBox.Controls.Add(teamOneScoreTextBox);
            teamOneNameGroupBox.Controls.Add(teamOneScoreLabel);
            teamOneNameGroupBox.Location = new Point(482, 111);
            teamOneNameGroupBox.Name = "teamOneNameGroupBox";
            teamOneNameGroupBox.Size = new Size(292, 124);
            teamOneNameGroupBox.TabIndex = 6;
            teamOneNameGroupBox.TabStop = false;
            teamOneNameGroupBox.Text = "<team one>";
            // 
            // teamOneScoreTextBox
            // 
            teamOneScoreTextBox.Location = new Point(138, 56);
            teamOneScoreTextBox.Name = "teamOneScoreTextBox";
            teamOneScoreTextBox.Size = new Size(125, 43);
            teamOneScoreTextBox.TabIndex = 1;
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Location = new Point(26, 61);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(86, 38);
            teamOneScoreLabel.TabIndex = 0;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamTwoNameGroupBox
            // 
            teamTwoNameGroupBox.Controls.Add(teamTwoScoreTextBox);
            teamTwoNameGroupBox.Controls.Add(teamTwoScoreLabel);
            teamTwoNameGroupBox.Location = new Point(482, 311);
            teamTwoNameGroupBox.Name = "teamTwoNameGroupBox";
            teamTwoNameGroupBox.Size = new Size(292, 124);
            teamTwoNameGroupBox.TabIndex = 6;
            teamTwoNameGroupBox.TabStop = false;
            teamTwoNameGroupBox.Text = "<team two>";
            // 
            // teamTwoScoreTextBox
            // 
            teamTwoScoreTextBox.Location = new Point(138, 56);
            teamTwoScoreTextBox.Name = "teamTwoScoreTextBox";
            teamTwoScoreTextBox.Size = new Size(125, 43);
            teamTwoScoreTextBox.TabIndex = 1;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Location = new Point(26, 61);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(86, 38);
            teamTwoScoreLabel.TabIndex = 0;
            teamTwoScoreLabel.Text = "Score";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.DimGray;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.White;
            scoreButton.FlatAppearance.MouseOverBackColor = Color.White;
            scoreButton.Location = new Point(581, 506);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(94, 50);
            scoreButton.TabIndex = 7;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // tournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(806, 598);
            Controls.Add(scoreButton);
            Controls.Add(teamTwoNameGroupBox);
            Controls.Add(teamOneNameGroupBox);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDownList);
            Controls.Add(roundLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(tournamentLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "tournamentViewerForm";
            Text = "Torunament Viewer";
            teamOneNameGroupBox.ResumeLayout(false);
            teamOneNameGroupBox.PerformLayout();
            teamTwoNameGroupBox.ResumeLayout(false);
            teamTwoNameGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentLabel;
        private Label tournamentNameLabel;
        private Label roundLabel;
        private ComboBox roundDropDownList;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private GroupBox teamOneNameGroupBox;
        private TextBox teamOneScoreTextBox;
        private Label teamOneScoreLabel;
        private GroupBox teamTwoNameGroupBox;
        private TextBox teamTwoScoreTextBox;
        private Label teamTwoScoreLabel;
        private Button scoreButton;
    }
}