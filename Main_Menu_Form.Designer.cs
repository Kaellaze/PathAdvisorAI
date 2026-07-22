namespace PathAdvisorAI
{
    partial class Main_Menu_Form
    {
        private const ContentAlignment middleCenter = ContentAlignment.MiddleCenter;

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
            pnlMainMenuContent = new Panel();
            btnStartTest = new Button();
            txtUserName = new TextBox();
            lblNameLabel = new Label();
            comboBoxLanguage = new ComboBox();
            lblChooseLanguage = new Label();
            lblTagline = new Label();
            lblAppTitleT = new Label();
            lblAppTitleH = new Label();
            lblAppTitleP = new Label();
            lblAppTitleA = new Label();
            pnlBackground = new Panel();
            pnlMainMenuContent.SuspendLayout();
            pnlBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainMenuContent
            // 
            pnlMainMenuContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pnlMainMenuContent.BackColor = Color.Transparent;
            pnlMainMenuContent.Controls.Add(btnStartTest);
            pnlMainMenuContent.Controls.Add(txtUserName);
            pnlMainMenuContent.Controls.Add(lblNameLabel);
            pnlMainMenuContent.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMainMenuContent.Location = new Point(234, 185);
            pnlMainMenuContent.Margin = new Padding(1, 4, 1, 4);
            pnlMainMenuContent.Name = "pnlMainMenuContent";
            pnlMainMenuContent.Size = new Size(815, 475);
            pnlMainMenuContent.TabIndex = 2;
            // 
            // btnStartTest
            // 
            btnStartTest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStartTest.BackColor = Color.FromArgb(0, 137, 123);
            btnStartTest.BackgroundImageLayout = ImageLayout.None;
            btnStartTest.FlatAppearance.BorderSize = 0;
            btnStartTest.FlatStyle = FlatStyle.Popup;
            btnStartTest.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartTest.ForeColor = Color.White;
            btnStartTest.Location = new Point(249, 330);
            btnStartTest.Name = "btnStartTest";
            btnStartTest.Size = new Size(326, 78);
            btnStartTest.TabIndex = 4;
            btnStartTest.Text = "START TEST";
            btnStartTest.UseVisualStyleBackColor = false;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.BackColor = Color.White;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(227, 112);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(380, 47);
            txtUserName.TabIndex = 1;
            // 
            // lblNameLabel
            // 
            lblNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNameLabel.AutoSize = true;
            lblNameLabel.Font = new Font("Trebuchet MS", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameLabel.ForeColor = Color.FromArgb(51, 51, 51);
            lblNameLabel.Location = new Point(243, 39);
            lblNameLabel.Margin = new Padding(1, 0, 1, 0);
            lblNameLabel.Name = "lblNameLabel";
            lblNameLabel.Size = new Size(332, 49);
            lblNameLabel.TabIndex = 0;
            lblNameLabel.Text = "Enter your name:";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxLanguage.BackColor = SystemColors.Window;
            comboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLanguage.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxLanguage.ForeColor = Color.FromArgb(51, 51, 51);
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(98, 705);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(230, 32);
            comboBoxLanguage.TabIndex = 3;
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
            // 
            // lblChooseLanguage
            // 
            lblChooseLanguage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblChooseLanguage.AutoSize = true;
            lblChooseLanguage.BackColor = Color.Transparent;
            lblChooseLanguage.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChooseLanguage.ForeColor = Color.FromArgb(51, 51, 51);
            lblChooseLanguage.Location = new Point(3, 706);
            lblChooseLanguage.Margin = new Padding(1, 0, 1, 0);
            lblChooseLanguage.Name = "lblChooseLanguage";
            lblChooseLanguage.Size = new Size(91, 27);
            lblChooseLanguage.TabIndex = 2;
            lblChooseLanguage.Text = "Theme:";
            // 
            // lblTagline
            // 
            lblTagline.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTagline.AutoSize = true;
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.FromArgb(0, 10, 44, 42);
            lblTagline.Location = new Point(514, 119);
            lblTagline.Margin = new Padding(4, 0, 4, 0);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(248, 31);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Career Path Advisor AI";
            // 
            // lblAppTitleT
            // 
            lblAppTitleT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblAppTitleT.AutoSize = true;
            lblAppTitleT.BackColor = Color.Transparent;
            lblAppTitleT.Font = new Font("Sitka Banner", 65F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAppTitleT.ForeColor = Color.FromArgb(0, 188, 212);
            lblAppTitleT.Location = new Point(635, -7);
            lblAppTitleT.Margin = new Padding(4, 0, 4, 0);
            lblAppTitleT.Name = "lblAppTitleT";
            lblAppTitleT.Size = new Size(118, 126);
            lblAppTitleT.TabIndex = 4;
            lblAppTitleT.Text = "T.";
            // 
            // lblAppTitleH
            // 
            lblAppTitleH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblAppTitleH.AutoSize = true;
            lblAppTitleH.BackColor = Color.Transparent;
            lblAppTitleH.Font = new Font("Sitka Banner", 65F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAppTitleH.ForeColor = Color.FromArgb(94, 53, 177);
            lblAppTitleH.Location = new Point(715, -7);
            lblAppTitleH.Margin = new Padding(4, 0, 4, 0);
            lblAppTitleH.Name = "lblAppTitleH";
            lblAppTitleH.Size = new Size(136, 126);
            lblAppTitleH.TabIndex = 1;
            lblAppTitleH.Text = "H.";
            // 
            // lblAppTitleP
            // 
            lblAppTitleP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblAppTitleP.AutoSize = true;
            lblAppTitleP.BackColor = Color.Transparent;
            lblAppTitleP.Font = new Font("Sitka Banner", 65F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAppTitleP.ForeColor = Color.FromArgb(0, 137, 123);
            lblAppTitleP.Location = new Point(471, -7);
            lblAppTitleP.Margin = new Padding(4, 0, 4, 0);
            lblAppTitleP.Name = "lblAppTitleP";
            lblAppTitleP.Size = new Size(113, 126);
            lblAppTitleP.TabIndex = 0;
            lblAppTitleP.Text = "P.";
            // 
            // lblAppTitleA
            // 
            lblAppTitleA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblAppTitleA.AutoSize = true;
            lblAppTitleA.BackColor = Color.Transparent;
            lblAppTitleA.Font = new Font("Sitka Banner", 65F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAppTitleA.ForeColor = Color.FromArgb(13, 71, 161);
            lblAppTitleA.Location = new Point(547, -7);
            lblAppTitleA.Margin = new Padding(4, 0, 4, 0);
            lblAppTitleA.Name = "lblAppTitleA";
            lblAppTitleA.Size = new Size(126, 126);
            lblAppTitleA.TabIndex = 3;
            lblAppTitleA.Text = "A.";
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.FromArgb(250, 249, 246);
            pnlBackground.BackgroundImageLayout = ImageLayout.None;
            pnlBackground.Controls.Add(lblTagline);
            pnlBackground.Controls.Add(lblAppTitleH);
            pnlBackground.Controls.Add(lblAppTitleT);
            pnlBackground.Controls.Add(comboBoxLanguage);
            pnlBackground.Controls.Add(lblChooseLanguage);
            pnlBackground.Controls.Add(pnlMainMenuContent);
            pnlBackground.Controls.Add(lblAppTitleA);
            pnlBackground.Controls.Add(lblAppTitleP);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(1264, 749);
            pnlBackground.TabIndex = 6;
            // 
            // Main_Menu_Form
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 251);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 749);
            Controls.Add(pnlBackground);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Main_Menu_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PATHAdvisorAI";
            pnlMainMenuContent.ResumeLayout(false);
            pnlMainMenuContent.PerformLayout();
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMainMenuContent;
        private Label lblNameLabel;
        private Label lblTagline;
        private Label lblAppTitleT;
        private Label lblAppTitleH;
        private Label lblAppTitleP;
        private Label lblAppTitleA;
        private Panel pnlBackground;
        private Label lblChooseLanguage;
        private TextBox txtUserName;
        private ComboBox comboBoxLanguage;
        private Button btnStartTest;
    }
}
