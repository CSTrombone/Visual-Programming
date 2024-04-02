namespace P08_Austin
{
    partial class Grades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grades));
            studentNameLbl = new Label();
            tst1Lbl = new Label();
            tst2Lbl = new Label();
            tst3Lbl = new Label();
            nameTxtBox = new TextBox();
            earned1TxtBox = new TextBox();
            earned2TxtBox = new TextBox();
            earned3TxtBox = new TextBox();
            possible1TxtBox = new TextBox();
            possible2TxtBox = new TextBox();
            possible3TxtBox = new TextBox();
            earnedLbl = new Label();
            possibleLbl = new Label();
            addBtn = new Button();
            findBtn = new Button();
            updateBtn = new Button();
            removeBtn = new Button();
            clearBtn = new Button();
            checkmarkPicBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)checkmarkPicBox).BeginInit();
            SuspendLayout();
            // 
            // studentNameLbl
            // 
            studentNameLbl.AutoSize = true;
            studentNameLbl.Location = new Point(291, 44);
            studentNameLbl.Margin = new Padding(2, 0, 2, 0);
            studentNameLbl.Name = "studentNameLbl";
            studentNameLbl.Size = new Size(83, 15);
            studentNameLbl.TabIndex = 0;
            studentNameLbl.Text = "Student Name";
            // 
            // tst1Lbl
            // 
            tst1Lbl.AutoSize = true;
            tst1Lbl.Location = new Point(220, 116);
            tst1Lbl.Margin = new Padding(2, 0, 2, 0);
            tst1Lbl.Name = "tst1Lbl";
            tst1Lbl.Size = new Size(36, 15);
            tst1Lbl.TabIndex = 1;
            tst1Lbl.Text = "Test 1";
            // 
            // tst2Lbl
            // 
            tst2Lbl.AutoSize = true;
            tst2Lbl.Location = new Point(362, 116);
            tst2Lbl.Margin = new Padding(2, 0, 2, 0);
            tst2Lbl.Name = "tst2Lbl";
            tst2Lbl.Size = new Size(36, 15);
            tst2Lbl.TabIndex = 2;
            tst2Lbl.Text = "Test 2";
            // 
            // tst3Lbl
            // 
            tst3Lbl.AutoSize = true;
            tst3Lbl.Location = new Point(504, 116);
            tst3Lbl.Margin = new Padding(2, 0, 2, 0);
            tst3Lbl.Name = "tst3Lbl";
            tst3Lbl.Size = new Size(36, 15);
            tst3Lbl.TabIndex = 3;
            tst3Lbl.Text = "Test 3";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(100, 76);
            nameTxtBox.Margin = new Padding(2);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(462, 23);
            nameTxtBox.TabIndex = 4;
            nameTxtBox.TextChanged += textUpdate;
            // 
            // earned1TxtBox
            // 
            earned1TxtBox.Location = new Point(182, 151);
            earned1TxtBox.Margin = new Padding(2);
            earned1TxtBox.Name = "earned1TxtBox";
            earned1TxtBox.Size = new Size(104, 23);
            earned1TxtBox.TabIndex = 5;
            // 
            // earned2TxtBox
            // 
            earned2TxtBox.Location = new Point(326, 151);
            earned2TxtBox.Margin = new Padding(2);
            earned2TxtBox.Name = "earned2TxtBox";
            earned2TxtBox.Size = new Size(104, 23);
            earned2TxtBox.TabIndex = 6;
            // 
            // earned3TxtBox
            // 
            earned3TxtBox.Location = new Point(469, 151);
            earned3TxtBox.Margin = new Padding(2);
            earned3TxtBox.Name = "earned3TxtBox";
            earned3TxtBox.Size = new Size(104, 23);
            earned3TxtBox.TabIndex = 7;
            // 
            // possible1TxtBox
            // 
            possible1TxtBox.Location = new Point(182, 196);
            possible1TxtBox.Margin = new Padding(2);
            possible1TxtBox.Name = "possible1TxtBox";
            possible1TxtBox.Size = new Size(104, 23);
            possible1TxtBox.TabIndex = 8;
            // 
            // possible2TxtBox
            // 
            possible2TxtBox.Location = new Point(326, 196);
            possible2TxtBox.Margin = new Padding(2);
            possible2TxtBox.Name = "possible2TxtBox";
            possible2TxtBox.Size = new Size(104, 23);
            possible2TxtBox.TabIndex = 9;
            // 
            // possible3TxtBox
            // 
            possible3TxtBox.Location = new Point(469, 196);
            possible3TxtBox.Margin = new Padding(2);
            possible3TxtBox.Name = "possible3TxtBox";
            possible3TxtBox.Size = new Size(104, 23);
            possible3TxtBox.TabIndex = 10;
            // 
            // earnedLbl
            // 
            earnedLbl.AutoSize = true;
            earnedLbl.Location = new Point(43, 152);
            earnedLbl.Margin = new Padding(2, 0, 2, 0);
            earnedLbl.Name = "earnedLbl";
            earnedLbl.Size = new Size(79, 15);
            earnedLbl.TabIndex = 11;
            earnedLbl.Text = "Points Earned";
            // 
            // possibleLbl
            // 
            possibleLbl.AutoSize = true;
            possibleLbl.Location = new Point(38, 197);
            possibleLbl.Margin = new Padding(2, 0, 2, 0);
            possibleLbl.Name = "possibleLbl";
            possibleLbl.Size = new Size(86, 15);
            possibleLbl.TabIndex = 12;
            possibleLbl.Text = "Points Possible";
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 8.25F);
            addBtn.Location = new Point(94, 259);
            addBtn.Margin = new Padding(1);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(76, 20);
            addBtn.TabIndex = 13;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // findBtn
            // 
            findBtn.Font = new Font("Segoe UI", 8.25F);
            findBtn.Location = new Point(220, 259);
            findBtn.Margin = new Padding(1);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(76, 20);
            findBtn.TabIndex = 14;
            findBtn.Text = "Find";
            findBtn.UseVisualStyleBackColor = true;
            findBtn.Click += findBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 8.25F);
            updateBtn.Location = new Point(344, 259);
            updateBtn.Margin = new Padding(1);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(76, 20);
            updateBtn.TabIndex = 15;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Font = new Font("Segoe UI", 8.25F);
            removeBtn.Location = new Point(469, 259);
            removeBtn.Margin = new Padding(1);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(76, 20);
            removeBtn.TabIndex = 16;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 8.25F);
            clearBtn.Location = new Point(281, 302);
            clearBtn.Margin = new Padding(1);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(76, 20);
            clearBtn.TabIndex = 17;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // checkmarkPicBox
            // 
            checkmarkPicBox.Image = (Image)resources.GetObject("checkmarkPicBox.Image");
            checkmarkPicBox.Location = new Point(565, 79);
            checkmarkPicBox.Margin = new Padding(3, 2, 3, 2);
            checkmarkPicBox.Name = "checkmarkPicBox";
            checkmarkPicBox.Size = new Size(20, 20);
            checkmarkPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            checkmarkPicBox.TabIndex = 18;
            checkmarkPicBox.TabStop = false;
            checkmarkPicBox.Visible = false;
            // 
            // Grades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(700, 357);
            Controls.Add(checkmarkPicBox);
            Controls.Add(clearBtn);
            Controls.Add(removeBtn);
            Controls.Add(updateBtn);
            Controls.Add(findBtn);
            Controls.Add(addBtn);
            Controls.Add(possibleLbl);
            Controls.Add(earnedLbl);
            Controls.Add(possible3TxtBox);
            Controls.Add(possible2TxtBox);
            Controls.Add(possible1TxtBox);
            Controls.Add(earned3TxtBox);
            Controls.Add(earned2TxtBox);
            Controls.Add(earned1TxtBox);
            Controls.Add(nameTxtBox);
            Controls.Add(tst3Lbl);
            Controls.Add(tst2Lbl);
            Controls.Add(tst1Lbl);
            Controls.Add(studentNameLbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Grades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grades";
            ((System.ComponentModel.ISupportInitialize)checkmarkPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentNameLbl;
        private Label tst1Lbl;
        private Label tst2Lbl;
        private Label tst3Lbl;
        private TextBox nameTxtBox;
        private TextBox earned1TxtBox;
        private TextBox earned2TxtBox;
        private TextBox earned3TxtBox;
        private TextBox possible1TxtBox;
        private TextBox possible2TxtBox;
        private TextBox possible3TxtBox;
        private Label earnedLbl;
        private Label possibleLbl;
        private Button addBtn;
        private Button findBtn;
        private Button updateBtn;
        private Button removeBtn;
        private Button clearBtn;
        private PictureBox checkmarkPicBox;
    }
}
