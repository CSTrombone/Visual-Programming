namespace P05_Austin
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
            displayLbl = new Label();
            borrowedTxtBox = new TextBox();
            monthsRepayTxtBox = new TextBox();
            totalPaidTxtBox = new TextBox();
            monthlyPaymentTxtBox = new TextBox();
            interestTxtBox = new TextBox();
            calculateBtn = new Button();
            clearBtn = new Button();
            abLbl = new Label();
            yirLbl = new Label();
            mpLbl = new Label();
            tpLbl = new Label();
            mtrLbl = new Label();
            SuspendLayout();
            // 
            // displayLbl
            // 
            displayLbl.AutoSize = true;
            displayLbl.Font = new Font("Segoe UI", 15F);
            displayLbl.Location = new Point(108, 51);
            displayLbl.Name = "displayLbl";
            displayLbl.Size = new Size(220, 28);
            displayLbl.TabIndex = 0;
            displayLbl.Text = "Student Loan Calculator";
            // 
            // borrowedTxtBox
            // 
            borrowedTxtBox.Location = new Point(27, 140);
            borrowedTxtBox.Name = "borrowedTxtBox";
            borrowedTxtBox.Size = new Size(100, 23);
            borrowedTxtBox.TabIndex = 1;
            // 
            // monthsRepayTxtBox
            // 
            monthsRepayTxtBox.Location = new Point(228, 218);
            monthsRepayTxtBox.Name = "monthsRepayTxtBox";
            monthsRepayTxtBox.ReadOnly = true;
            monthsRepayTxtBox.Size = new Size(100, 23);
            monthsRepayTxtBox.TabIndex = 2;
            // 
            // totalPaidTxtBox
            // 
            totalPaidTxtBox.HideSelection = false;
            totalPaidTxtBox.Location = new Point(85, 218);
            totalPaidTxtBox.Name = "totalPaidTxtBox";
            totalPaidTxtBox.ReadOnly = true;
            totalPaidTxtBox.Size = new Size(100, 23);
            totalPaidTxtBox.TabIndex = 3;
            // 
            // monthlyPaymentTxtBox
            // 
            monthlyPaymentTxtBox.Location = new Point(294, 140);
            monthlyPaymentTxtBox.Name = "monthlyPaymentTxtBox";
            monthlyPaymentTxtBox.Size = new Size(100, 23);
            monthlyPaymentTxtBox.TabIndex = 4;
            // 
            // interestTxtBox
            // 
            interestTxtBox.Location = new Point(164, 140);
            interestTxtBox.Name = "interestTxtBox";
            interestTxtBox.Size = new Size(100, 23);
            interestTxtBox.TabIndex = 5;
            // 
            // calculateBtn
            // 
            calculateBtn.Cursor = Cursors.Hand;
            calculateBtn.Location = new Point(231, 312);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(75, 23);
            calculateBtn.TabIndex = 6;
            calculateBtn.Text = "Calculate";
            calculateBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.Location = new Point(319, 312);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 7;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // abLbl
            // 
            abLbl.AutoSize = true;
            abLbl.Location = new Point(27, 122);
            abLbl.Name = "abLbl";
            abLbl.Size = new Size(105, 15);
            abLbl.TabIndex = 8;
            abLbl.Text = "Amount Borrowed";
            // 
            // yirLbl
            // 
            yirLbl.AutoSize = true;
            yirLbl.Location = new Point(164, 122);
            yirLbl.Name = "yirLbl";
            yirLbl.Size = new Size(106, 15);
            yirLbl.TabIndex = 9;
            yirLbl.Text = "Yearly Interest Rate";
            // 
            // mpLbl
            // 
            mpLbl.AutoSize = true;
            mpLbl.Location = new Point(292, 122);
            mpLbl.Name = "mpLbl";
            mpLbl.Size = new Size(102, 15);
            mpLbl.TabIndex = 10;
            mpLbl.Text = "Monthly Payment";
            // 
            // tpLbl
            // 
            tpLbl.AutoSize = true;
            tpLbl.Location = new Point(108, 200);
            tpLbl.Name = "tpLbl";
            tpLbl.Size = new Size(58, 15);
            tpLbl.TabIndex = 11;
            tpLbl.Text = "Total Paid";
            // 
            // mtrLbl
            // 
            mtrLbl.AutoSize = true;
            mtrLbl.Location = new Point(231, 200);
            mtrLbl.Name = "mtrLbl";
            mtrLbl.Size = new Size(97, 15);
            mtrLbl.TabIndex = 12;
            mtrLbl.Text = "Months to Repay";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(433, 373);
            Controls.Add(mtrLbl);
            Controls.Add(tpLbl);
            Controls.Add(mpLbl);
            Controls.Add(yirLbl);
            Controls.Add(abLbl);
            Controls.Add(clearBtn);
            Controls.Add(calculateBtn);
            Controls.Add(interestTxtBox);
            Controls.Add(monthlyPaymentTxtBox);
            Controls.Add(totalPaidTxtBox);
            Controls.Add(monthsRepayTxtBox);
            Controls.Add(borrowedTxtBox);
            Controls.Add(displayLbl);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estimate Loan Payoff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label displayLbl;
        private TextBox borrowedTxtBox;
        private TextBox monthsRepayTxtBox;
        private TextBox totalPaidTxtBox;
        private TextBox monthlyPaymentTxtBox;
        private TextBox interestTxtBox;
        private Button calculateBtn;
        private Button clearBtn;
        private Label abLbl;
        private Label yirLbl;
        private Label mpLbl;
        private Label tpLbl;
        private Label mtrLbl;
    }
}
