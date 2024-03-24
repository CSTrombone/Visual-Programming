namespace P07_Austin
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
            SuspendLayout();
            // 
            // studentNameLbl
            // 
            studentNameLbl.AutoSize = true;
            studentNameLbl.Location = new Point(499, 87);
            studentNameLbl.Name = "studentNameLbl";
            studentNameLbl.Size = new Size(146, 30);
            studentNameLbl.TabIndex = 0;
            studentNameLbl.Text = "Student Name";
            // 
            // tst1Lbl
            // 
            tst1Lbl.AutoSize = true;
            tst1Lbl.Location = new Point(376, 232);
            tst1Lbl.Name = "tst1Lbl";
            tst1Lbl.Size = new Size(66, 30);
            tst1Lbl.TabIndex = 1;
            tst1Lbl.Text = "Test 1";
            // 
            // tst2Lbl
            // 
            tst2Lbl.AutoSize = true;
            tst2Lbl.Location = new Point(621, 232);
            tst2Lbl.Name = "tst2Lbl";
            tst2Lbl.Size = new Size(66, 30);
            tst2Lbl.TabIndex = 2;
            tst2Lbl.Text = "Test 2";
            // 
            // tst3Lbl
            // 
            tst3Lbl.AutoSize = true;
            tst3Lbl.Location = new Point(864, 232);
            tst3Lbl.Name = "tst3Lbl";
            tst3Lbl.Size = new Size(66, 30);
            tst3Lbl.TabIndex = 3;
            tst3Lbl.Text = "Test 3";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(171, 152);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(789, 35);
            nameTxtBox.TabIndex = 4;
            // 
            // earned1TxtBox
            // 
            earned1TxtBox.Location = new Point(312, 302);
            earned1TxtBox.Name = "earned1TxtBox";
            earned1TxtBox.Size = new Size(175, 35);
            earned1TxtBox.TabIndex = 5;
            // 
            // earned2TxtBox
            // 
            earned2TxtBox.Location = new Point(560, 302);
            earned2TxtBox.Name = "earned2TxtBox";
            earned2TxtBox.Size = new Size(175, 35);
            earned2TxtBox.TabIndex = 6;
            // 
            // earned3TxtBox
            // 
            earned3TxtBox.Location = new Point(804, 302);
            earned3TxtBox.Name = "earned3TxtBox";
            earned3TxtBox.Size = new Size(175, 35);
            earned3TxtBox.TabIndex = 7;
            // 
            // possible1TxtBox
            // 
            possible1TxtBox.Location = new Point(312, 391);
            possible1TxtBox.Name = "possible1TxtBox";
            possible1TxtBox.Size = new Size(175, 35);
            possible1TxtBox.TabIndex = 8;
            // 
            // possible2TxtBox
            // 
            possible2TxtBox.Location = new Point(560, 391);
            possible2TxtBox.Name = "possible2TxtBox";
            possible2TxtBox.Size = new Size(175, 35);
            possible2TxtBox.TabIndex = 9;
            // 
            // possible3TxtBox
            // 
            possible3TxtBox.Location = new Point(804, 391);
            possible3TxtBox.Name = "possible3TxtBox";
            possible3TxtBox.Size = new Size(175, 35);
            possible3TxtBox.TabIndex = 10;
            // 
            // earnedLbl
            // 
            earnedLbl.AutoSize = true;
            earnedLbl.Location = new Point(74, 305);
            earnedLbl.Name = "earnedLbl";
            earnedLbl.Size = new Size(139, 30);
            earnedLbl.TabIndex = 11;
            earnedLbl.Text = "Points Earned";
            // 
            // possibleLbl
            // 
            possibleLbl.AutoSize = true;
            possibleLbl.Location = new Point(64, 394);
            possibleLbl.Name = "possibleLbl";
            possibleLbl.Size = new Size(149, 30);
            possibleLbl.TabIndex = 12;
            possibleLbl.Text = "Points Possible";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(162, 517);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(131, 40);
            addBtn.TabIndex = 13;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // findBtn
            // 
            findBtn.Location = new Point(376, 517);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(131, 40);
            findBtn.TabIndex = 14;
            findBtn.Text = "Find";
            findBtn.UseVisualStyleBackColor = true;
            findBtn.Click += findBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(589, 517);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(131, 40);
            updateBtn.TabIndex = 15;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(804, 517);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(131, 40);
            removeBtn.TabIndex = 16;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(481, 603);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(131, 40);
            clearBtn.TabIndex = 17;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Grades
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1200, 714);
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
            Margin = new Padding(4);
            Name = "Grades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grades";
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
    }
}
