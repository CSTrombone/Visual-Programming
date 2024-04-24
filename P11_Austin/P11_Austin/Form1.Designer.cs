namespace P11_Austin
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
            amountLbl1 = new Label();
            amountLbl2 = new Label();
            resultLbl = new Label();
            amountTxtBox1 = new TextBox();
            amountTxtBox2 = new TextBox();
            addBtn = new Button();
            multpilyBtn = new Button();
            SuspendLayout();
            // 
            // amountLbl1
            // 
            amountLbl1.AutoSize = true;
            amountLbl1.Location = new Point(83, 67);
            amountLbl1.Name = "amountLbl1";
            amountLbl1.Size = new Size(74, 20);
            amountLbl1.TabIndex = 0;
            amountLbl1.Text = "Amount 1";
            // 
            // amountLbl2
            // 
            amountLbl2.AutoSize = true;
            amountLbl2.Location = new Point(83, 123);
            amountLbl2.Name = "amountLbl2";
            amountLbl2.Size = new Size(74, 20);
            amountLbl2.TabIndex = 1;
            amountLbl2.Text = "Amount 2";
            // 
            // resultLbl
            // 
            resultLbl.AutoSize = true;
            resultLbl.Location = new Point(169, 260);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(0, 20);
            resultLbl.TabIndex = 2;
            // 
            // amountTxtBox1
            // 
            amountTxtBox1.Location = new Point(184, 64);
            amountTxtBox1.Name = "amountTxtBox1";
            amountTxtBox1.Size = new Size(125, 27);
            amountTxtBox1.TabIndex = 3;
            // 
            // amountTxtBox2
            // 
            amountTxtBox2.Location = new Point(184, 120);
            amountTxtBox2.Name = "amountTxtBox2";
            amountTxtBox2.Size = new Size(125, 27);
            amountTxtBox2.TabIndex = 4;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(83, 209);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // multpilyBtn
            // 
            multpilyBtn.Location = new Point(203, 209);
            multpilyBtn.Name = "multpilyBtn";
            multpilyBtn.Size = new Size(94, 29);
            multpilyBtn.TabIndex = 6;
            multpilyBtn.Text = "Multiply";
            multpilyBtn.UseVisualStyleBackColor = true;
            multpilyBtn.Click += multpilyBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(396, 332);
            Controls.Add(multpilyBtn);
            Controls.Add(addBtn);
            Controls.Add(amountTxtBox2);
            Controls.Add(amountTxtBox1);
            Controls.Add(resultLbl);
            Controls.Add(amountLbl2);
            Controls.Add(amountLbl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Program 11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label amountLbl1;
        private Label amountLbl2;
        private Label resultLbl;
        private TextBox amountTxtBox1;
        private TextBox amountTxtBox2;
        private Button addBtn;
        private Button multpilyBtn;
    }
}
