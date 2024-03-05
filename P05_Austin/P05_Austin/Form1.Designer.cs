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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            displayLbl.Location = new Point(123, 68);
            displayLbl.Name = "displayLbl";
            displayLbl.Size = new Size(278, 35);
            displayLbl.TabIndex = 0;
            displayLbl.Text = "Student Loan Calculator";
            // 
            // borrowedTxtBox
            // 
            borrowedTxtBox.Location = new Point(31, 187);
            borrowedTxtBox.Margin = new Padding(3, 4, 3, 4);
            borrowedTxtBox.Name = "borrowedTxtBox";
            borrowedTxtBox.Size = new Size(114, 27);
            borrowedTxtBox.TabIndex = 1;
            // 
            // monthsRepayTxtBox
            // 
            monthsRepayTxtBox.Location = new Point(261, 291);
            monthsRepayTxtBox.Margin = new Padding(3, 4, 3, 4);
            monthsRepayTxtBox.Name = "monthsRepayTxtBox";
            monthsRepayTxtBox.ReadOnly = true;
            monthsRepayTxtBox.Size = new Size(114, 27);
            monthsRepayTxtBox.TabIndex = 0;
            monthsRepayTxtBox.TabStop = false;
            // 
            // totalPaidTxtBox
            // 
            totalPaidTxtBox.HideSelection = false;
            totalPaidTxtBox.Location = new Point(97, 291);
            totalPaidTxtBox.Margin = new Padding(3, 4, 3, 4);
            totalPaidTxtBox.Name = "totalPaidTxtBox";
            totalPaidTxtBox.ReadOnly = true;
            totalPaidTxtBox.Size = new Size(114, 27);
            totalPaidTxtBox.TabIndex = 0;
            totalPaidTxtBox.TabStop = false;
            // 
            // monthlyPaymentTxtBox
            // 
            monthlyPaymentTxtBox.Location = new Point(336, 187);
            monthlyPaymentTxtBox.Margin = new Padding(3, 4, 3, 4);
            monthlyPaymentTxtBox.Name = "monthlyPaymentTxtBox";
            monthlyPaymentTxtBox.Size = new Size(114, 27);
            monthlyPaymentTxtBox.TabIndex = 3;
            // 
            // interestTxtBox
            // 
            interestTxtBox.Location = new Point(187, 187);
            interestTxtBox.Margin = new Padding(3, 4, 3, 4);
            interestTxtBox.Name = "interestTxtBox";
            interestTxtBox.Size = new Size(114, 27);
            interestTxtBox.TabIndex = 2;
            // 
            // calculateBtn
            // 
            calculateBtn.Cursor = Cursors.Hand;
            calculateBtn.Location = new Point(264, 416);
            calculateBtn.Margin = new Padding(3, 4, 3, 4);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(86, 31);
            calculateBtn.TabIndex = 4;
            calculateBtn.Text = "Calculate";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.Location = new Point(365, 416);
            clearBtn.Margin = new Padding(3, 4, 3, 4);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(86, 31);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // abLbl
            // 
            abLbl.AutoSize = true;
            abLbl.Location = new Point(31, 163);
            abLbl.Name = "abLbl";
            abLbl.Size = new Size(131, 20);
            abLbl.TabIndex = 8;
            abLbl.Text = "Amount Borrowed";
            // 
            // yirLbl
            // 
            yirLbl.AutoSize = true;
            yirLbl.Location = new Point(187, 163);
            yirLbl.Name = "yirLbl";
            yirLbl.Size = new Size(135, 20);
            yirLbl.TabIndex = 9;
            yirLbl.Text = "Yearly Interest Rate";
            // 
            // mpLbl
            // 
            mpLbl.AutoSize = true;
            mpLbl.Location = new Point(334, 163);
            mpLbl.Name = "mpLbl";
            mpLbl.Size = new Size(123, 20);
            mpLbl.TabIndex = 10;
            mpLbl.Text = "Monthly Payment";
            // 
            // tpLbl
            // 
            tpLbl.AutoSize = true;
            tpLbl.Location = new Point(123, 267);
            tpLbl.Name = "tpLbl";
            tpLbl.Size = new Size(74, 20);
            tpLbl.TabIndex = 11;
            tpLbl.Text = "Total Paid";
            // 
            // mtrLbl
            // 
            mtrLbl.AutoSize = true;
            mtrLbl.Location = new Point(264, 267);
            mtrLbl.Name = "mtrLbl";
            mtrLbl.Size = new Size(121, 20);
            mtrLbl.TabIndex = 12;
            mtrLbl.Text = "Months to Repay";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(495, 497);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
