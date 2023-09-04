namespace TrackerUI
{
    partial class tournamentDashboardForm
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
            loadTournamentButton = new Button();
            loadExistingTournamentDropDownList = new ComboBox();
            loadExistingTournamentLabel = new Label();
            tournamentDashboardLabel = new Label();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.DimGray;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.White;
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            loadTournamentButton.Location = new Point(69, 195);
            loadTournamentButton.Margin = new Padding(6);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(313, 52);
            loadTournamentButton.TabIndex = 22;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // loadExistingTournamentDropDownList
            // 
            loadExistingTournamentDropDownList.FormattingEnabled = true;
            loadExistingTournamentDropDownList.Location = new Point(15, 138);
            loadExistingTournamentDropDownList.Margin = new Padding(6);
            loadExistingTournamentDropDownList.Name = "loadExistingTournamentDropDownList";
            loadExistingTournamentDropDownList.Size = new Size(420, 45);
            loadExistingTournamentDropDownList.TabIndex = 21;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            loadExistingTournamentLabel.Location = new Point(52, 94);
            loadExistingTournamentLabel.Margin = new Padding(6, 0, 6, 0);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(346, 38);
            loadExistingTournamentLabel.TabIndex = 20;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            tournamentDashboardLabel.ForeColor = Color.RoyalBlue;
            tournamentDashboardLabel.Location = new Point(20, 9);
            tournamentDashboardLabel.Margin = new Padding(6, 0, 6, 0);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(418, 50);
            tournamentDashboardLabel.TabIndex = 19;
            tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.DimGray;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.White;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            createTournamentButton.Location = new Point(15, 289);
            createTournamentButton.Margin = new Padding(6);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(420, 98);
            createTournamentButton.TabIndex = 23;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // tournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(449, 410);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropDownList);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(tournamentDashboardLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 6, 6, 6);
            Name = "tournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadTournamentButton;
        private ComboBox loadExistingTournamentDropDownList;
        private Label loadExistingTournamentLabel;
        private Label tournamentDashboardLabel;
        private Button createTournamentButton;
    }
}