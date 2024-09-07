namespace WordGuessApplication
{
    partial class Guess_The_Word
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guess_The_Word));
            label1 = new Label();
            GuessButton = new Button();
            GuessList = new ListBox();
            GuessWordTextBox = new TextBox();
            WrongGuessLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("SimSun-ExtB", 48F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 54);
            label1.Name = "label1";
            label1.Size = new Size(555, 64);
            label1.TabIndex = 0;
            label1.Text = "Guess That WORD!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // GuessButton
            // 
            GuessButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GuessButton.BackgroundImage = (Image)resources.GetObject("GuessButton.BackgroundImage");
            GuessButton.Font = new Font("Sitka Small", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            GuessButton.Location = new Point(184, 177);
            GuessButton.Name = "GuessButton";
            GuessButton.Size = new Size(327, 60);
            GuessButton.TabIndex = 1;
            GuessButton.Text = "GUESS";
            GuessButton.UseVisualStyleBackColor = true;
            GuessButton.Click += button1_Click;
            // 
            // GuessList
            // 
            GuessList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GuessList.BackColor = Color.MediumTurquoise;
            GuessList.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuessList.ForeColor = SystemColors.ActiveCaptionText;
            GuessList.FormattingEnabled = true;
            GuessList.ItemHeight = 25;
            GuessList.Location = new Point(82, 281);
            GuessList.Name = "GuessList";
            GuessList.Size = new Size(537, 154);
            GuessList.TabIndex = 2;
            GuessList.SelectedIndexChanged += GuessList_SelectedIndexChanged;
            // 
            // GuessWordTextBox
            // 
            GuessWordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GuessWordTextBox.BackColor = SystemColors.InactiveCaption;
            GuessWordTextBox.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuessWordTextBox.Location = new Point(96, 121);
            GuessWordTextBox.Name = "GuessWordTextBox";
            GuessWordTextBox.Size = new Size(503, 48);
            GuessWordTextBox.TabIndex = 4;
            GuessWordTextBox.TextAlign = HorizontalAlignment.Center;
            GuessWordTextBox.TextChanged += GuessWordTextBox_TextChanged;
            // 
            // WrongGuessLabel
            // 
            WrongGuessLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WrongGuessLabel.BackColor = Color.FromArgb(192, 255, 255);
            WrongGuessLabel.Font = new Font("SimSun", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            WrongGuessLabel.Location = new Point(184, 245);
            WrongGuessLabel.Name = "WrongGuessLabel";
            WrongGuessLabel.Size = new Size(317, 29);
            WrongGuessLabel.TabIndex = 5;
            WrongGuessLabel.Text = "Wrong Guessed Words";
            WrongGuessLabel.TextAlign = ContentAlignment.MiddleCenter;
            WrongGuessLabel.Click += WrongGuessLabel_Click;
            // 
            // Guess_The_Word
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(702, 493);
            Controls.Add(WrongGuessLabel);
            Controls.Add(GuessWordTextBox);
            Controls.Add(GuessList);
            Controls.Add(GuessButton);
            Controls.Add(label1);
            Name = "Guess_The_Word";
            Text = "Guess The Word";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button GuessButton;
        private ListBox GuessList;
        private TextBox GuessWordTextBox;
        private Label WrongGuessLabel;
    }
}
