namespace P09_Austin
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
            nameLbl = new Label();
            midLbl = new Label();
            finLbl = new Label();
            paperLbl = new Label();
            percentLbl = new Label();
            underBtn = new Button();
            gradBtn = new Button();
            showBtn = new Button();
            infoLstBox = new ListBox();
            SuspendLayout();
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(54, 133);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(49, 20);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "Name";
            // 
            // midLbl
            // 
            midLbl.AutoSize = true;
            midLbl.Location = new Point(186, 133);
            midLbl.Name = "midLbl";
            midLbl.Size = new Size(66, 20);
            midLbl.TabIndex = 1;
            midLbl.Text = "Midterm";
            // 
            // finLbl
            // 
            finLbl.AutoSize = true;
            finLbl.Location = new Point(283, 133);
            finLbl.Name = "finLbl";
            finLbl.Size = new Size(40, 20);
            finLbl.TabIndex = 2;
            finLbl.Text = "Final";
            // 
            // paperLbl
            // 
            paperLbl.AutoSize = true;
            paperLbl.Location = new Point(359, 133);
            paperLbl.Name = "paperLbl";
            paperLbl.Size = new Size(46, 20);
            paperLbl.TabIndex = 3;
            paperLbl.Text = "Paper";
            // 
            // percentLbl
            // 
            percentLbl.AutoSize = true;
            percentLbl.Location = new Point(443, 133);
            percentLbl.Name = "percentLbl";
            percentLbl.Size = new Size(57, 20);
            percentLbl.TabIndex = 4;
            percentLbl.Text = "Percent";
            // 
            // underBtn
            // 
            underBtn.Location = new Point(84, 52);
            underBtn.Name = "underBtn";
            underBtn.Size = new Size(94, 29);
            underBtn.TabIndex = 5;
            underBtn.Text = "Under";
            underBtn.UseVisualStyleBackColor = true;
            underBtn.Click += underBtn_Click;
            // 
            // gradBtn
            // 
            gradBtn.Location = new Point(223, 52);
            gradBtn.Name = "gradBtn";
            gradBtn.Size = new Size(94, 29);
            gradBtn.TabIndex = 6;
            gradBtn.Text = "Grad";
            gradBtn.UseVisualStyleBackColor = true;
            gradBtn.Click += gradBtn_Click;
            // 
            // showBtn
            // 
            showBtn.Location = new Point(367, 52);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(94, 29);
            showBtn.TabIndex = 7;
            showBtn.Text = "Show";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // infoLstBox
            // 
            infoLstBox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infoLstBox.FormattingEnabled = true;
            infoLstBox.ItemHeight = 17;
            infoLstBox.Location = new Point(32, 156);
            infoLstBox.Name = "infoLstBox";
            infoLstBox.Size = new Size(488, 157);
            infoLstBox.TabIndex = 8;
            infoLstBox.TabStop = false;
            // 
            // Grades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(556, 370);
            Controls.Add(infoLstBox);
            Controls.Add(showBtn);
            Controls.Add(gradBtn);
            Controls.Add(underBtn);
            Controls.Add(percentLbl);
            Controls.Add(paperLbl);
            Controls.Add(finLbl);
            Controls.Add(midLbl);
            Controls.Add(nameLbl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Grades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLbl;
        private Label midLbl;
        private Label finLbl;
        private Label paperLbl;
        private Label percentLbl;
        private Button underBtn;
        private Button gradBtn;
        private Button showBtn;
        private ListBox infoLstBox;
    }
}
