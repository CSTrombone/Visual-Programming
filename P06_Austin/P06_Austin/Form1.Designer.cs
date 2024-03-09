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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1023, 28);
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
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(128, 26);
            exitToolStripMenuItem.Text = "Exit";
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
            priceTxtBox.Location = new Point(416, 158);
            priceTxtBox.Name = "priceTxtBox";
            priceTxtBox.ReadOnly = true;
            priceTxtBox.Size = new Size(125, 27);
            priceTxtBox.TabIndex = 3;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(48, 58);
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
            phoneLbl.Location = new Point(649, 58);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(117, 20);
            phoneLbl.TabIndex = 6;
            phoneLbl.Text = "Customer Phone";
            // 
            // boxesLbl
            // 
            boxesLbl.AutoSize = true;
            boxesLbl.Location = new Point(640, 115);
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
            addBtn.Location = new Point(649, 190);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 10;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(785, 190);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(94, 29);
            removeBtn.TabIndex = 11;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1023, 474);
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
    }
}
