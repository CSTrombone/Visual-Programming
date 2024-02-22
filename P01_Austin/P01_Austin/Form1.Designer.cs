namespace P01_Austin
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            btnTalk = new Button();
            btnExit = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnTalk
            // 
            btnTalk.Cursor = Cursors.Hand;
            btnTalk.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnTalk.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTalk.Location = new Point(55, 100);
            btnTalk.MaximumSize = new Size(75, 25);
            btnTalk.MinimumSize = new Size(30, 10);
            btnTalk.Name = "btnTalk";
            btnTalk.Padding = new Padding(5, 1, 5, 1);
            btnTalk.Size = new Size(75, 25);
            btnTalk.TabIndex = 1;
            btnTalk.TabStop = false;
            btnTalk.Text = "Talk";
            btnTalk.UseVisualStyleBackColor = true;
            btnTalk.Click += btnTalk_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnExit.Location = new Point(173, 100);
            btnExit.MaximumSize = new Size(75, 25);
            btnExit.MinimumSize = new Size(30, 10);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(5, 1, 5, 1);
            btnExit.Size = new Size(75, 25);
            btnExit.TabIndex = 2;
            btnExit.TabStop = false;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblMessage
            // 
            lblMessage.Dock = DockStyle.Top;
            lblMessage.Font = new Font("Segoe UI", 10F);
            lblMessage.Location = new Point(0, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Padding = new Padding(10);
            lblMessage.Size = new Size(309, 60);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Hello!";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Window
            // 
            AccessibleName = "Window";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            ClientSize = new Size(309, 141);
            Controls.Add(lblMessage);
            Controls.Add(btnExit);
            Controls.Add(btnTalk);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(25, 25);
            Name = "Window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Program 1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTalk;
        private Button btnExit;
        private Label lblMessage;
    }
}
