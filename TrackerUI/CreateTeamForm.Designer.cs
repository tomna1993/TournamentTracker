namespace TrackerUI
{
    partial class CreateTeamForm
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
            createTeamLabel = new Label();
            teamMembersListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addMemberButton = new Button();
            selectTeamMemberDropDownList = new ComboBox();
            selectTeamMemberLabel = new Label();
            teamNameTextBox = new TextBox();
            teamNameLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            cellphoneTextBox = new TextBox();
            CellphoneLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamLabel.ForeColor = Color.RoyalBlue;
            createTeamLabel.Location = new Point(15, 9);
            createTeamLabel.Margin = new Padding(6, 0, 6, 0);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(229, 50);
            createTeamLabel.TabIndex = 2;
            createTeamLabel.Text = "Create Team";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 37;
            teamMembersListBox.Location = new Point(470, 126);
            teamMembersListBox.Margin = new Padding(6);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(378, 633);
            teamMembersListBox.TabIndex = 21;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.FlatAppearance.BorderColor = Color.DimGray;
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.White;
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            deleteSelectedMemberButton.Location = new Point(860, 375);
            deleteSelectedMemberButton.Margin = new Padding(6);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(133, 135);
            deleteSelectedMemberButton.TabIndex = 20;
            deleteSelectedMemberButton.Text = "Delete Selected Member";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.DimGray;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.White;
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.White;
            createTeamButton.Location = new Point(324, 796);
            createTeamButton.Margin = new Padding(6);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(336, 59);
            createTeamButton.TabIndex = 19;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.DimGray;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.White;
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            addMemberButton.Location = new Point(108, 321);
            addMemberButton.Margin = new Padding(6);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(235, 52);
            addMemberButton.TabIndex = 18;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDownList
            // 
            selectTeamMemberDropDownList.FormattingEnabled = true;
            selectTeamMemberDropDownList.Location = new Point(15, 246);
            selectTeamMemberDropDownList.Margin = new Padding(6);
            selectTeamMemberDropDownList.Name = "selectTeamMemberDropDownList";
            selectTeamMemberDropDownList.Size = new Size(420, 45);
            selectTeamMemberDropDownList.TabIndex = 17;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.Location = new Point(15, 202);
            selectTeamMemberLabel.Margin = new Padding(6, 0, 6, 0);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(277, 38);
            selectTeamMemberLabel.TabIndex = 16;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // teamNameTextBox
            // 
            teamNameTextBox.Location = new Point(15, 126);
            teamNameTextBox.Margin = new Padding(6);
            teamNameTextBox.Name = "teamNameTextBox";
            teamNameTextBox.Size = new Size(420, 43);
            teamNameTextBox.TabIndex = 15;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Location = new Point(15, 82);
            teamNameLabel.Margin = new Padding(6, 0, 6, 0);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(164, 38);
            teamNameLabel.TabIndex = 14;
            teamNameLabel.Text = "Team Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(163, 58);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(243, 43);
            firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(6, 61);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(151, 38);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellphoneTextBox);
            addNewMemberGroupBox.Controls.Add(CellphoneLabel);
            addNewMemberGroupBox.Controls.Add(emailTextBox);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameTextBox);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameTextBox);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Location = new Point(15, 413);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(420, 358);
            addNewMemberGroupBox.TabIndex = 22;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.DimGray;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.White;
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.White;
            createMemberButton.Location = new Point(90, 294);
            createMemberButton.Margin = new Padding(6);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(235, 52);
            createMemberButton.TabIndex = 23;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // cellphoneTextBox
            // 
            cellphoneTextBox.Location = new Point(163, 236);
            cellphoneTextBox.Name = "cellphoneTextBox";
            cellphoneTextBox.Size = new Size(243, 43);
            cellphoneTextBox.TabIndex = 7;
            // 
            // CellphoneLabel
            // 
            CellphoneLabel.AutoSize = true;
            CellphoneLabel.Location = new Point(6, 239);
            CellphoneLabel.Name = "CellphoneLabel";
            CellphoneLabel.Size = new Size(142, 38);
            CellphoneLabel.TabIndex = 6;
            CellphoneLabel.Text = "Cellphone";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(163, 179);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(243, 43);
            emailTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(6, 182);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(83, 38);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(163, 119);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(243, 43);
            lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(6, 122);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(147, 38);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1005, 870);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(teamMembersListBox);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(createTeamButton);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDownList);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameTextBox);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTeamLabel;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropDownList;
        private Label selectTeamMemberLabel;
        private TextBox teamNameTextBox;
        private Label teamNameLabel;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private GroupBox addNewMemberGroupBox;
        private Button createMemberButton;
        private TextBox cellphoneTextBox;
        private Label CellphoneLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
    }
}