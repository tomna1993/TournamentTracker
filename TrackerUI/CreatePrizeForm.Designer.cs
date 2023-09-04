namespace TrackerUI
{
    partial class CreatePrizeForm
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
            createPrizeButton = new Button();
            prizePercentageTextBox = new TextBox();
            prizePercentageLabel = new Label();
            prizeAmountTextBox = new TextBox();
            prizeAmountLabel = new Label();
            placeNameTextBox = new TextBox();
            placeNameLabel = new Label();
            placeNumberTextBox = new TextBox();
            placeNumberLabel = new Label();
            createPrizeLabel = new Label();
            orLabel = new Label();
            SuspendLayout();
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.DimGray;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.White;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.White;
            createPrizeButton.Location = new Point(148, 421);
            createPrizeButton.Margin = new Padding(6);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(235, 52);
            createPrizeButton.TabIndex = 32;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizePercentageTextBox
            // 
            prizePercentageTextBox.Location = new Point(270, 338);
            prizePercentageTextBox.Name = "prizePercentageTextBox";
            prizePercentageTextBox.Size = new Size(243, 43);
            prizePercentageTextBox.TabIndex = 31;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Location = new Point(15, 341);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(224, 38);
            prizePercentageLabel.TabIndex = 30;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // prizeAmountTextBox
            // 
            prizeAmountTextBox.Location = new Point(270, 211);
            prizeAmountTextBox.Name = "prizeAmountTextBox";
            prizeAmountTextBox.Size = new Size(243, 43);
            prizeAmountTextBox.TabIndex = 29;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Location = new Point(15, 214);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(185, 38);
            prizeAmountLabel.TabIndex = 28;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameTextBox
            // 
            placeNameTextBox.Location = new Point(270, 151);
            placeNameTextBox.Name = "placeNameTextBox";
            placeNameTextBox.Size = new Size(243, 43);
            placeNameTextBox.TabIndex = 27;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Location = new Point(15, 154);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(164, 38);
            placeNameLabel.TabIndex = 26;
            placeNameLabel.Text = "Place Name";
            // 
            // placeNumberTextBox
            // 
            placeNumberTextBox.Location = new Point(270, 90);
            placeNumberTextBox.Name = "placeNumberTextBox";
            placeNumberTextBox.Size = new Size(243, 43);
            placeNumberTextBox.TabIndex = 25;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Location = new Point(15, 93);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(192, 38);
            placeNumberLabel.TabIndex = 24;
            placeNumberLabel.Text = "Place Number";
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeLabel.ForeColor = Color.RoyalBlue;
            createPrizeLabel.Location = new Point(15, 9);
            createPrizeLabel.Margin = new Padding(6, 0, 6, 0);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(224, 50);
            createPrizeLabel.TabIndex = 33;
            createPrizeLabel.Text = "Create Prize";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Location = new Point(246, 278);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(81, 38);
            orLabel.TabIndex = 34;
            orLabel.Text = "- or -";
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(537, 504);
            Controls.Add(orLabel);
            Controls.Add(createPrizeLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(prizePercentageTextBox);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountTextBox);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameTextBox);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberTextBox);
            Controls.Add(placeNumberLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createPrizeButton;
        private TextBox prizePercentageTextBox;
        private Label prizePercentageLabel;
        private TextBox prizeAmountTextBox;
        private Label prizeAmountLabel;
        private TextBox placeNameTextBox;
        private Label placeNameLabel;
        private TextBox placeNumberTextBox;
        private Label placeNumberLabel;
        private Label createPrizeLabel;
        private Label orLabel;
    }
}