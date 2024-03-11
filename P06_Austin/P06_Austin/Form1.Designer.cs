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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1023, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(128, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(128, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // menuListBox
            // 
            menuListBox.FormattingEnabled = true;
            menuListBox.Location = new Point(48, 115);
            menuListBox.Name = "menuListBox";
            menuListBox.Size = new Size(316, 104);
            menuListBox.TabIndex = 1;
            menuListBox.SelectedIndexChanged += menuListBox_SelectChanged;
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.Location = new Point(416, 135);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(41, 20);
            priceLbl.TabIndex = 2;
            priceLbl.Text = "Price";
            // 
            // priceTxtBox
            // 
            priceTxtBox.Location = new Point(416, 157);
            priceTxtBox.Name = "priceTxtBox";
            priceTxtBox.ReadOnly = true;
            priceTxtBox.Size = new Size(125, 27);
            priceTxtBox.TabIndex = 3;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(48, 59);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(116, 20);
            nameLbl.TabIndex = 4;
            nameLbl.Text = "Customer Name";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(184, 55);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(287, 27);
            nameTxtBox.TabIndex = 5;
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Location = new Point(649, 59);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(117, 20);
            phoneLbl.TabIndex = 6;
            phoneLbl.Text = "Customer Phone";
            // 
            // boxesLbl
            // 
            boxesLbl.AutoSize = true;
            boxesLbl.Location = new Point(649, 116);
            boxesLbl.Name = "boxesLbl";
            boxesLbl.Size = new Size(126, 20);
            boxesLbl.TabIndex = 7;
            boxesLbl.Text = "Number Of Boxes";
            // 
            // phoneTxtBox
            // 
            phoneTxtBox.Location = new Point(785, 55);
            phoneTxtBox.Name = "phoneTxtBox";
            phoneTxtBox.Size = new Size(149, 27);
            phoneTxtBox.TabIndex = 8;
            // 
            // boxesTxtBox
            // 
            boxesTxtBox.Location = new Point(785, 112);
            boxesTxtBox.Name = "boxesTxtBox";
            boxesTxtBox.Size = new Size(149, 27);
            boxesTxtBox.TabIndex = 9;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(649, 189);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 10;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(785, 189);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(94, 29);
            removeBtn.TabIndex = 11;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // orderListBox
            // 
            orderListBox.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderListBox.Location = new Point(33, 295);
            orderListBox.Name = "orderListBox";
            orderListBox.Size = new Size(958, 204);
            orderListBox.TabIndex = 12;
            // 
            // orderNameLbl
            // 
            orderNameLbl.AutoSize = true;
            orderNameLbl.Location = new Point(115, 256);
            orderNameLbl.Name = "orderNameLbl";
            orderNameLbl.Size = new Size(49, 20);
            orderNameLbl.TabIndex = 13;
            orderNameLbl.Text = "Name";
            // 
            // phoneOrderLbl
            // 
            phoneOrderLbl.AutoSize = true;
            phoneOrderLbl.Location = new Point(301, 256);
            phoneOrderLbl.Name = "phoneOrderLbl";
            phoneOrderLbl.Size = new Size(50, 20);
            phoneOrderLbl.TabIndex = 14;
            phoneOrderLbl.Text = "Phone";
            // 
            // qtyOrderLbl
            // 
            qtyOrderLbl.AutoSize = true;
            qtyOrderLbl.Location = new Point(428, 256);
            qtyOrderLbl.Name = "qtyOrderLbl";
            qtyOrderLbl.Size = new Size(32, 20);
            qtyOrderLbl.TabIndex = 15;
            qtyOrderLbl.Text = "Qty";
            // 
            // totalOrderLbl
            // 
            totalOrderLbl.AutoSize = true;
            totalOrderLbl.Location = new Point(595, 256);
            totalOrderLbl.Name = "totalOrderLbl";
            totalOrderLbl.Size = new Size(13, 20);
            totalOrderLbl.TabIndex = 16;
            totalOrderLbl.Text = " ";
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Location = new Point(531, 256);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(42, 20);
            totalLbl.TabIndex = 17;
            totalLbl.Text = "Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1023, 548);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
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
