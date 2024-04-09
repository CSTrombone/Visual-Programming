namespace P09_Austin
{
    partial class StudentInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saveBtn = new Button();
            cancelBtn = new Button();
            nameTxtBox = new TextBox();
            eMTxtBox = new TextBox();
            pFTxtBox = new TextBox();
            eFTxtBox = new TextBox();
            pMTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(202, 147);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(332, 147);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(34, 78);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(155, 27);
            nameTxtBox.TabIndex = 1;
            // 
            // eMTxtBox
            // 
            eMTxtBox.Location = new Point(268, 78);
            eMTxtBox.Name = "eMTxtBox";
            eMTxtBox.Size = new Size(65, 27);
            eMTxtBox.TabIndex = 2;
            // 
            // pFTxtBox
            // 
            pFTxtBox.Location = new Point(525, 78);
            pFTxtBox.Name = "pFTxtBox";
            pFTxtBox.Size = new Size(65, 27);
            pFTxtBox.TabIndex = 5;
            // 
            // eFTxtBox
            // 
            eFTxtBox.Location = new Point(454, 78);
            eFTxtBox.Name = "eFTxtBox";
            eFTxtBox.Size = new Size(65, 27);
            eFTxtBox.TabIndex = 4;
            // 
            // pMTxtBox
            // 
            pMTxtBox.Location = new Point(339, 78);
            pMTxtBox.Name = "pMTxtBox";
            pMTxtBox.Size = new Size(65, 27);
            pMTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 52);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 55);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 8;
            label2.Text = "Earned";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 55);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Possible";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(302, 26);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 10;
            label4.Text = "Midterm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 52);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 11;
            label5.Text = "Earned";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(525, 52);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 12;
            label6.Text = "Possible";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(497, 26);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 13;
            label7.Text = "Final";
            // 
            // StudentInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(657, 188);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pMTxtBox);
            Controls.Add(eFTxtBox);
            Controls.Add(pFTxtBox);
            Controls.Add(eMTxtBox);
            Controls.Add(nameTxtBox);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentInfo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Student Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private Button cancelBtn;
        private TextBox nameTxtBox;
        private TextBox eMTxtBox;
        private TextBox pFTxtBox;
        private TextBox eFTxtBox;
        private TextBox pMTxtBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}