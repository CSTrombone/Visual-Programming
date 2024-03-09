namespace P06_Austin
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuListBox = new ListBox();
            priceLbl = new Label();
            priceTxtBox = new TextBox();
            nameLbl = new Label();
            nameTxtBox = new TextBox();
            phoneLbl = new Label();
            boxesLbl = new Label();
            phoneTxtBox = new TextBox();
            boxesTxtBox = new TextBox();
            addBtn = new Button();
            removeBtn = new Button();
            orderListBox = new ListBox();
            orderNameLbl = new Label();
            phoneOrderLbl = new Label();
            qtyOrderLbl = new Label();
            totalOrderLbl = new Label();
            totalLbl = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(895, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(103, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // menuListBox
            // 
            menuListBox.FormattingEnabled = true;
            menuListBox.ItemHeight = 15;
            menuListBox.Location = new Point(42, 86);
            menuListBox.Margin = new Padding(3, 2, 3, 2);
            menuListBox.Name = "menuListBox";
            menuListBox.Size = new Size(277, 79);
            menuListBox.TabIndex = 1;
            menuListBox.SelectedIndexChanged += menuListBox_SelectChanged;
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.Location = new Point(364, 101);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(33, 15);
            priceLbl.TabIndex = 2;
            priceLbl.Text = "Price";
            // 
            // priceTxtBox
            // 
            priceTxtBox.Location = new Point(364, 118);
            priceTxtBox.Margin = new Padding(3, 2, 3, 2);
            priceTxtBox.Name = "priceTxtBox";
            priceTxtBox.ReadOnly = true;
            priceTxtBox.Size = new Size(110, 23);
            priceTxtBox.TabIndex = 3;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(42, 44);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(94, 15);
            nameLbl.TabIndex = 4;
            nameLbl.Text = "Customer Name";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(161, 41);
            nameTxtBox.Margin = new Padding(3, 2, 3, 2);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(252, 23);
            nameTxtBox.TabIndex = 5;
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Location = new Point(568, 44);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(96, 15);
            phoneLbl.TabIndex = 6;
            phoneLbl.Text = "Customer Phone";
            // 
            // boxesLbl
            // 
            boxesLbl.AutoSize = true;
            boxesLbl.Location = new Point(568, 87);
            boxesLbl.Name = "boxesLbl";
            boxesLbl.Size = new Size(101, 15);
            boxesLbl.TabIndex = 7;
            boxesLbl.Text = "Number Of Boxes";
            // 
            // phoneTxtBox
            // 
            phoneTxtBox.Location = new Point(687, 41);
            phoneTxtBox.Margin = new Padding(3, 2, 3, 2);
            phoneTxtBox.Name = "phoneTxtBox";
            phoneTxtBox.Size = new Size(131, 23);
            phoneTxtBox.TabIndex = 8;
            // 
            // boxesTxtBox
            // 
            boxesTxtBox.Location = new Point(687, 84);
            boxesTxtBox.Margin = new Padding(3, 2, 3, 2);
            boxesTxtBox.Name = "boxesTxtBox";
            boxesTxtBox.Size = new Size(131, 23);
            boxesTxtBox.TabIndex = 9;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(568, 142);
            addBtn.Margin = new Padding(3, 2, 3, 2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(82, 22);
            addBtn.TabIndex = 10;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(687, 142);
            removeBtn.Margin = new Padding(3, 2, 3, 2);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(82, 22);
            removeBtn.TabIndex = 11;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // orderListBox
            // 
            orderListBox.FormattingEnabled = true;
            orderListBox.ItemHeight = 15;
            orderListBox.Location = new Point(42, 221);
            orderListBox.Margin = new Padding(3, 2, 3, 2);
            orderListBox.Name = "orderListBox";
            orderListBox.Size = new Size(827, 169);
            orderListBox.TabIndex = 12;
            // 
            // orderNameLbl
            // 
            orderNameLbl.AutoSize = true;
            orderNameLbl.Location = new Point(142, 192);
            orderNameLbl.Name = "orderNameLbl";
            orderNameLbl.Size = new Size(39, 15);
            orderNameLbl.TabIndex = 13;
            orderNameLbl.Text = "Name";
            // 
            // phoneOrderLbl
            // 
            phoneOrderLbl.AutoSize = true;
            phoneOrderLbl.Location = new Point(340, 192);
            phoneOrderLbl.Name = "phoneOrderLbl";
            phoneOrderLbl.Size = new Size(41, 15);
            phoneOrderLbl.TabIndex = 14;
            phoneOrderLbl.Text = "Phone";
            // 
            // qtyOrderLbl
            // 
            qtyOrderLbl.AutoSize = true;
            qtyOrderLbl.Location = new Point(449, 192);
            qtyOrderLbl.Name = "qtyOrderLbl";
            qtyOrderLbl.Size = new Size(26, 15);
            qtyOrderLbl.TabIndex = 15;
            qtyOrderLbl.Text = "Qty";
            // 
            // totalOrderLbl
            // 
            totalOrderLbl.AutoSize = true;
            totalOrderLbl.Location = new Point(521, 192);
            totalOrderLbl.Name = "totalOrderLbl";
            totalOrderLbl.Size = new Size(10, 15);
            totalOrderLbl.TabIndex = 16;
            totalOrderLbl.Text = " ";
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Location = new Point(537, 192);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(32, 15);
            totalLbl.TabIndex = 17;
            totalLbl.Text = "Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(895, 411);
            Controls.Add(totalLbl);
            Controls.Add(totalOrderLbl);
            Controls.Add(qtyOrderLbl);
            Controls.Add(phoneOrderLbl);
            Controls.Add(orderNameLbl);
            Controls.Add(orderListBox);
            Controls.Add(removeBtn);
            Controls.Add(addBtn);
            Controls.Add(boxesTxtBox);
            Controls.Add(phoneTxtBox);
            Controls.Add(boxesLbl);
            Controls.Add(phoneLbl);
            Controls.Add(nameTxtBox);
            Controls.Add(nameLbl);
            Controls.Add(priceTxtBox);
            Controls.Add(priceLbl);
            Controls.Add(menuListBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Girl Scout Cookies";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ListBox menuListBox;
        private Label priceLbl;
        private TextBox priceTxtBox;
        private Label nameLbl;
        private TextBox nameTxtBox;
        private Label phoneLbl;
        private Label boxesLbl;
        private TextBox phoneTxtBox;
        private TextBox boxesTxtBox;
        private Button addBtn;
        private Button removeBtn;
        private ListBox orderListBox;
        private Label orderNameLbl;
        private Label phoneOrderLbl;
        private Label qtyOrderLbl;
        private Label totalOrderLbl;
        private Label totalLbl;
    }
}
