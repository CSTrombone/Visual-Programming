namespace P04_Austin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            playersLbl = new Label();
            playersList = new ComboBox();
            restartBtn = new Button();
            team1LstBox = new ListBox();
            team2LstBox = new ListBox();
            firstLbl = new Label();
            secondLbl = new Label();
            team1AddBtn = new Button();
            team1RemoveBtn = new Button();
            team2RemoveBtn = new Button();
            team2AddBtn = new Button();
            appendLstBox = new ListBox();
            SuspendLayout();
            // 
            // playersLbl
            // 
            playersLbl.AutoSize = true;
            playersLbl.Location = new Point(192, 41);
            playersLbl.Margin = new Padding(2, 0, 2, 0);
            playersLbl.Name = "playersLbl";
            playersLbl.Size = new Size(44, 15);
            playersLbl.TabIndex = 0;
            playersLbl.Text = "Players";
            // 
            // playersList
            // 
            playersList.DropDownStyle = ComboBoxStyle.Simple;
            playersList.FormattingEnabled = true;
            playersList.Location = new Point(119, 63);
            playersList.Margin = new Padding(2);
            playersList.Name = "playersList";
            playersList.Size = new Size(203, 156);
            playersList.Sorted = true;
            playersList.TabIndex = 1;
            playersList.KeyPress += comboBox1_KeyPress;
            // 
            // restartBtn
            // 
            restartBtn.Location = new Point(181, 229);
            restartBtn.Margin = new Padding(2);
            restartBtn.Name = "restartBtn";
            restartBtn.Size = new Size(76, 20);
            restartBtn.TabIndex = 2;
            restartBtn.Text = "Restart";
            restartBtn.UseVisualStyleBackColor = true;
            restartBtn.Click += restartBtn_Click;
            // 
            // team1LstBox
            // 
            team1LstBox.FormattingEnabled = true;
            team1LstBox.ItemHeight = 15;
            team1LstBox.Location = new Point(69, 281);
            team1LstBox.Name = "team1LstBox";
            team1LstBox.Size = new Size(120, 109);
            team1LstBox.Sorted = true;
            team1LstBox.TabIndex = 3;
            // 
            // team2LstBox
            // 
            team2LstBox.FormattingEnabled = true;
            team2LstBox.ItemHeight = 15;
            team2LstBox.Location = new Point(249, 281);
            team2LstBox.Name = "team2LstBox";
            team2LstBox.Size = new Size(120, 109);
            team2LstBox.Sorted = true;
            team2LstBox.TabIndex = 4;
            // 
            // firstLbl
            // 
            firstLbl.AutoSize = true;
            firstLbl.Location = new Point(101, 263);
            firstLbl.Name = "firstLbl";
            firstLbl.Size = new Size(60, 15);
            firstLbl.TabIndex = 5;
            firstLbl.Text = "First Team";
            // 
            // secondLbl
            // 
            secondLbl.AutoSize = true;
            secondLbl.Location = new Point(268, 263);
            secondLbl.Name = "secondLbl";
            secondLbl.Size = new Size(77, 15);
            secondLbl.TabIndex = 6;
            secondLbl.Text = "Second Team";
            // 
            // team1AddBtn
            // 
            team1AddBtn.Location = new Point(86, 396);
            team1AddBtn.Name = "team1AddBtn";
            team1AddBtn.Size = new Size(75, 23);
            team1AddBtn.TabIndex = 7;
            team1AddBtn.Text = "Add";
            team1AddBtn.UseVisualStyleBackColor = true;
            team1AddBtn.Click += team1AddBtn_Click;
            // 
            // team1RemoveBtn
            // 
            team1RemoveBtn.Location = new Point(86, 425);
            team1RemoveBtn.Name = "team1RemoveBtn";
            team1RemoveBtn.Size = new Size(75, 23);
            team1RemoveBtn.TabIndex = 8;
            team1RemoveBtn.Text = "Remove";
            team1RemoveBtn.UseVisualStyleBackColor = true;
            team1RemoveBtn.Click += team1RemoveBtn_Click;
            // 
            // team2RemoveBtn
            // 
            team2RemoveBtn.Location = new Point(270, 425);
            team2RemoveBtn.Name = "team2RemoveBtn";
            team2RemoveBtn.Size = new Size(75, 23);
            team2RemoveBtn.TabIndex = 10;
            team2RemoveBtn.Text = "Remove";
            team2RemoveBtn.UseVisualStyleBackColor = true;
            team2RemoveBtn.Click += team2RemoveBtn_Click;
            // 
            // team2AddBtn
            // 
            team2AddBtn.Location = new Point(270, 396);
            team2AddBtn.Name = "team2AddBtn";
            team2AddBtn.Size = new Size(75, 23);
            team2AddBtn.TabIndex = 11;
            team2AddBtn.Text = "Add";
            team2AddBtn.UseVisualStyleBackColor = true;
            team2AddBtn.Click += team2AddBtn_Click;
            // 
            // appendLstBox
            // 
            appendLstBox.FormattingEnabled = true;
            appendLstBox.ItemHeight = 15;
            appendLstBox.Location = new Point(327, 63);
            appendLstBox.Name = "appendLstBox";
            appendLstBox.Size = new Size(107, 94);
            appendLstBox.TabIndex = 12;
            appendLstBox.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(446, 472);
            Controls.Add(appendLstBox);
            Controls.Add(team2AddBtn);
            Controls.Add(team2RemoveBtn);
            Controls.Add(team1RemoveBtn);
            Controls.Add(team1AddBtn);
            Controls.Add(secondLbl);
            Controls.Add(firstLbl);
            Controls.Add(team2LstBox);
            Controls.Add(team1LstBox);
            Controls.Add(restartBtn);
            Controls.Add(playersList);
            Controls.Add(playersLbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select Players";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label playersLbl;
        private ComboBox playersList;
        private Button restartBtn;
        private ListBox team1LstBox;
        private ListBox team2LstBox;
        private Label firstLbl;
        private Label secondLbl;
        private Button team1AddBtn;
        private Button team1RemoveBtn;
        private Button team2RemoveBtn;
        private Button team2AddBtn;
        private ListBox appendLstBox;
    }
}
