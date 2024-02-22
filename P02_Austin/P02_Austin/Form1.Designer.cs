namespace P02_Austin
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
            listpriceTxtBox = new TextBox();
            discountTxtBox = new TextBox();
            priceLabel = new Label();
            discountLabel = new Label();
            totalLPLabel = new Label();
            totalDALabel = new Label();
            totalTLabel = new Label();
            totalNPLabel = new Label();
            tlpOutLabel = new Label();
            tdaOutLabel = new Label();
            ttOutLabel = new Label();
            tnpOutLabel = new Label();
            addButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // listpriceTxtBox
            // 
            listpriceTxtBox.Location = new Point(145, 65);
            listpriceTxtBox.Name = "listpriceTxtBox";
            listpriceTxtBox.Size = new Size(100, 23);
            listpriceTxtBox.TabIndex = 0;
            // 
            // discountTxtBox
            // 
            discountTxtBox.Location = new Point(305, 65);
            discountTxtBox.Name = "discountTxtBox";
            discountTxtBox.Size = new Size(100, 23);
            discountTxtBox.TabIndex = 1;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(145, 47);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(54, 15);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "&List Price";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new Point(305, 47);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(67, 15);
            discountLabel.TabIndex = 3;
            discountLabel.Text = "&Discount %";
            // 
            // totalLPLabel
            // 
            totalLPLabel.AutoSize = true;
            totalLPLabel.Location = new Point(38, 140);
            totalLPLabel.Name = "totalLPLabel";
            totalLPLabel.Size = new Size(82, 15);
            totalLPLabel.TabIndex = 4;
            totalLPLabel.Text = "Total List Price";
            // 
            // totalDALabel
            // 
            totalDALabel.AutoSize = true;
            totalDALabel.Location = new Point(159, 140);
            totalDALabel.Name = "totalDALabel";
            totalDALabel.Size = new Size(129, 15);
            totalDALabel.TabIndex = 5;
            totalDALabel.Text = "Total Discount Amount";
            // 
            // totalTLabel
            // 
            totalTLabel.AutoSize = true;
            totalTLabel.Location = new Point(320, 140);
            totalTLabel.Name = "totalTLabel";
            totalTLabel.Size = new Size(52, 15);
            totalTLabel.TabIndex = 6;
            totalTLabel.Text = "Total Tax";
            // 
            // totalNPLabel
            // 
            totalNPLabel.AutoSize = true;
            totalNPLabel.Location = new Point(422, 140);
            totalNPLabel.Name = "totalNPLabel";
            totalNPLabel.Size = new Size(83, 15);
            totalNPLabel.TabIndex = 7;
            totalNPLabel.Text = "Total Net Price";
            // 
            // tlpOutLabel
            // 
            tlpOutLabel.AutoSize = true;
            tlpOutLabel.Location = new Point(60, 190);
            tlpOutLabel.Name = "tlpOutLabel";
            tlpOutLabel.Size = new Size(28, 15);
            tlpOutLabel.TabIndex = 8;
            tlpOutLabel.Text = "0.00";
            // 
            // tdaOutLabel
            // 
            tdaOutLabel.AutoSize = true;
            tdaOutLabel.Location = new Point(207, 190);
            tdaOutLabel.Name = "tdaOutLabel";
            tdaOutLabel.Size = new Size(28, 15);
            tdaOutLabel.TabIndex = 9;
            tdaOutLabel.Text = "0.00";
            // 
            // ttOutLabel
            // 
            ttOutLabel.AutoSize = true;
            ttOutLabel.Location = new Point(332, 190);
            ttOutLabel.Name = "ttOutLabel";
            ttOutLabel.Size = new Size(28, 15);
            ttOutLabel.TabIndex = 10;
            ttOutLabel.Text = "0.00";
            // 
            // tnpOutLabel
            // 
            tnpOutLabel.AutoSize = true;
            tnpOutLabel.Location = new Point(446, 190);
            tnpOutLabel.Name = "tnpOutLabel";
            tnpOutLabel.Size = new Size(28, 15);
            tnpOutLabel.TabIndex = 11;
            tnpOutLabel.Text = "0.00";
            // 
            // addButton
            // 
            addButton.Location = new Point(115, 268);
            addButton.Name = "addButton";
            addButton.Size = new Size(84, 23);
            addButton.TabIndex = 12;
            addButton.Text = "&Add to Totals";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(233, 268);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(84, 23);
            clearButton.TabIndex = 13;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(350, 268);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(84, 23);
            exitButton.TabIndex = 14;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(564, 341);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(tnpOutLabel);
            Controls.Add(ttOutLabel);
            Controls.Add(tdaOutLabel);
            Controls.Add(tlpOutLabel);
            Controls.Add(totalNPLabel);
            Controls.Add(totalTLabel);
            Controls.Add(totalDALabel);
            Controls.Add(totalLPLabel);
            Controls.Add(discountLabel);
            Controls.Add(priceLabel);
            Controls.Add(discountTxtBox);
            Controls.Add(listpriceTxtBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accumulate Sales - Calculate Discounts - Add Taxes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox listpriceTxtBox;
        private TextBox discountTxtBox;
        private Label priceLabel;
        private Label discountLabel;
        private Label totalLPLabel;
        private Label totalDALabel;
        private Label totalTLabel;
        private Label totalNPLabel;
        private Label tlpOutLabel;
        private Label tdaOutLabel;
        private Label ttOutLabel;
        private Label tnpOutLabel;
        private Button addButton;
        private Button clearButton;
        private Button exitButton;
    }
}
