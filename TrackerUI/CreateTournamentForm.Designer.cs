namespace TrackerUI
{
    partial class createTournamentForm
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
            createTournamentLabel = new Label();
            tournamentNameTextBox = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeTextBox = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDownList = new ComboBox();
            selectTeamLabel = new Label();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            createTournamentButton = new Button();
            deleteSelectedTeamPlayerButton = new Button();
            tournamentPlayersListBox = new ListBox();
            teamPlayerLabel = new Label();
            createNewTeamLinkLabel = new LinkLabel();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            deleteSelectedPrizesbutton = new Button();
            SuspendLayout();
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentLabel.ForeColor = Color.RoyalBlue;
            createTournamentLabel.Location = new Point(22, 23);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(344, 50);
            createTournamentLabel.TabIndex = 1;
            createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameTextBox
            // 
            tournamentNameTextBox.Location = new Point(35, 175);
            tournamentNameTextBox.Name = "tournamentNameTextBox";
            tournamentNameTextBox.Size = new Size(386, 43);
            tournamentNameTextBox.TabIndex = 3;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Location = new Point(35, 134);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(247, 38);
            tournamentNameLabel.TabIndex = 2;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeTextBox
            // 
            entryFeeTextBox.Location = new Point(221, 254);
            entryFeeTextBox.Name = "entryFeeTextBox";
            entryFeeTextBox.Size = new Size(200, 43);
            entryFeeTextBox.TabIndex = 5;
            entryFeeTextBox.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Location = new Point(35, 259);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(132, 38);
            entryFeeLabel.TabIndex = 4;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDownList
            // 
            selectTeamDropDownList.FormattingEnabled = true;
            selectTeamDropDownList.Location = new Point(35, 427);
            selectTeamDropDownList.Name = "selectTeamDropDownList";
            selectTeamDropDownList.Size = new Size(386, 45);
            selectTeamDropDownList.TabIndex = 7;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.Location = new Point(35, 386);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(164, 38);
            selectTeamLabel.TabIndex = 6;
            selectTeamLabel.Text = "Select Team";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.DimGray;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.White;
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            addTeamButton.Location = new Point(132, 524);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(192, 50);
            addTeamButton.TabIndex = 8;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.DimGray;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.White;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            createPrizeButton.Location = new Point(899, 427);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(139, 89);
            createPrizeButton.TabIndex = 9;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.DimGray;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.White;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            createTournamentButton.Location = new Point(377, 682);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(308, 50);
            createTournamentButton.TabIndex = 10;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedTeamPlayerButton
            // 
            deleteSelectedTeamPlayerButton.FlatAppearance.BorderColor = Color.DimGray;
            deleteSelectedTeamPlayerButton.FlatAppearance.MouseDownBackColor = Color.White;
            deleteSelectedTeamPlayerButton.FlatAppearance.MouseOverBackColor = Color.White;
            deleteSelectedTeamPlayerButton.Location = new Point(899, 128);
            deleteSelectedTeamPlayerButton.Name = "deleteSelectedTeamPlayerButton";
            deleteSelectedTeamPlayerButton.Size = new Size(139, 89);
            deleteSelectedTeamPlayerButton.TabIndex = 11;
            deleteSelectedTeamPlayerButton.Text = "Delete Selected";
            deleteSelectedTeamPlayerButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 37;
            tournamentPlayersListBox.Location = new Point(489, 128);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(394, 226);
            tournamentPlayersListBox.TabIndex = 13;
            // 
            // teamPlayerLabel
            // 
            teamPlayerLabel.AutoSize = true;
            teamPlayerLabel.Location = new Point(489, 87);
            teamPlayerLabel.Name = "teamPlayerLabel";
            teamPlayerLabel.Size = new Size(185, 38);
            teamPlayerLabel.TabIndex = 14;
            teamPlayerLabel.Text = "Team / Player";
            // 
            // createNewTeamLinkLabel
            // 
            createNewTeamLinkLabel.AutoSize = true;
            createNewTeamLinkLabel.Location = new Point(260, 386);
            createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            createNewTeamLinkLabel.Size = new Size(161, 38);
            createNewTeamLinkLabel.TabIndex = 15;
            createNewTeamLinkLabel.TabStop = true;
            createNewTeamLinkLabel.Text = "Create New";
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Location = new Point(489, 386);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(90, 38);
            prizesLabel.TabIndex = 18;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 37;
            prizesListBox.Location = new Point(489, 427);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(394, 226);
            prizesListBox.TabIndex = 17;
            // 
            // deleteSelectedPrizesbutton
            // 
            deleteSelectedPrizesbutton.FlatAppearance.BorderColor = Color.DimGray;
            deleteSelectedPrizesbutton.FlatAppearance.MouseDownBackColor = Color.White;
            deleteSelectedPrizesbutton.FlatAppearance.MouseOverBackColor = Color.White;
            deleteSelectedPrizesbutton.Location = new Point(899, 564);
            deleteSelectedPrizesbutton.Name = "deleteSelectedPrizesbutton";
            deleteSelectedPrizesbutton.Size = new Size(139, 89);
            deleteSelectedPrizesbutton.TabIndex = 16;
            deleteSelectedPrizesbutton.Text = "Delete Selected";
            deleteSelectedPrizesbutton.UseVisualStyleBackColor = true;
            // 
            // createTournamentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1065, 753);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(deleteSelectedPrizesbutton);
            Controls.Add(createNewTeamLinkLabel);
            Controls.Add(teamPlayerLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(deleteSelectedTeamPlayerButton);
            Controls.Add(createTournamentButton);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(selectTeamDropDownList);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeTextBox);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameTextBox);
            Controls.Add(tournamentNameLabel);
            Controls.Add(createTournamentLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 6, 6, 6);
            Name = "createTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentLabel;
        private TextBox tournamentNameTextBox;
        private Label tournamentNameLabel;
        private TextBox entryFeeTextBox;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDownList;
        private Label selectTeamLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Button createTournamentButton;
        private Button deleteSelectedTeamPlayerButton;
        private ListBox tournamentPlayersListBox;
        private Label teamPlayerLabel;
        private LinkLabel createNewTeamLinkLabel;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button deleteSelectedPrizesbutton;
    }
}