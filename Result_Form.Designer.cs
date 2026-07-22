namespace PathAdvisorAI
{
    partial class Result_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result_Form));
            pnlMainContent = new Panel();
            btnGenerateAnother = new Button();
            btnRetakeTest = new Button();
            lbReasoningLog = new ListBox();
            label1 = new Label();
            txtExplanation = new TextBox();
            lblCareerSuggestion = new Label();
            pbCareerImage = new PictureBox();
            lblMBTIType = new Label();
            pnlHeader = new Panel();
            lblAdvisorAI = new Label();
            progressBar1 = new CustomProgressBar();
            lblAppTitleH = new Label();
            lblAppTitleT = new Label();
            lblAppTitleA = new Label();
            lblAppTitleP = new Label();
            pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCareerImage).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainContent
            // 
            pnlMainContent.Controls.Add(btnGenerateAnother);
            pnlMainContent.Controls.Add(btnRetakeTest);
            pnlMainContent.Controls.Add(lbReasoningLog);
            pnlMainContent.Controls.Add(label1);
            pnlMainContent.Controls.Add(txtExplanation);
            pnlMainContent.Controls.Add(lblCareerSuggestion);
            pnlMainContent.Controls.Add(pbCareerImage);
            pnlMainContent.Controls.Add(lblMBTIType);
            pnlMainContent.Controls.Add(pnlHeader);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(0, 0);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1264, 749);
            pnlMainContent.TabIndex = 0;
            // 
            // btnGenerateAnother
            // 
            btnGenerateAnother.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerateAnother.BackColor = Color.FromArgb(0, 137, 123);
            btnGenerateAnother.BackgroundImageLayout = ImageLayout.None;
            btnGenerateAnother.FlatAppearance.BorderSize = 0;
            btnGenerateAnother.FlatStyle = FlatStyle.Popup;
            btnGenerateAnother.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateAnother.ForeColor = Color.White;
            btnGenerateAnother.Location = new Point(75, 605);
            btnGenerateAnother.Name = "btnGenerateAnother";
            btnGenerateAnother.Size = new Size(340, 54);
            btnGenerateAnother.TabIndex = 10;
            btnGenerateAnother.Text = "Generate Another";
            btnGenerateAnother.UseVisualStyleBackColor = false;
            btnGenerateAnother.Click += btnGenerateAnother_Click;
            // 
            // btnRetakeTest
            // 
            btnRetakeTest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRetakeTest.BackColor = Color.FromArgb(13, 71, 161);
            btnRetakeTest.BackgroundImageLayout = ImageLayout.None;
            btnRetakeTest.FlatAppearance.BorderSize = 0;
            btnRetakeTest.FlatStyle = FlatStyle.Popup;
            btnRetakeTest.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetakeTest.ForeColor = Color.White;
            btnRetakeTest.Location = new Point(1022, 683);
            btnRetakeTest.Name = "btnRetakeTest";
            btnRetakeTest.Size = new Size(230, 54);
            btnRetakeTest.TabIndex = 9;
            btnRetakeTest.Text = "RETAKE TEST";
            btnRetakeTest.UseVisualStyleBackColor = false;
            // 
            // lbReasoningLog
            // 
            lbReasoningLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbReasoningLog.ForeColor = Color.DarkSlateGray;
            lbReasoningLog.FormattingEnabled = true;
            lbReasoningLog.ItemHeight = 15;
            lbReasoningLog.Location = new Point(617, 499);
            lbReasoningLog.Name = "lbReasoningLog";
            lbReasoningLog.Size = new Size(567, 169);
            lbReasoningLog.TabIndex = 8;
            lbReasoningLog.SelectedIndexChanged += lbReasoningLog_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 34F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 71, 161);
            label1.Location = new Point(617, 440);
            label1.Name = "label1";
            label1.Size = new Size(394, 56);
            label1.TabIndex = 7;
            label1.Text = "AI Reasoning 🤖";
            // 
            // txtExplanation
            // 
            txtExplanation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtExplanation.BackColor = Color.FromArgb(249, 249, 251);
            txtExplanation.BorderStyle = BorderStyle.None;
            txtExplanation.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExplanation.ForeColor = Color.FromArgb(0, 137, 123);
            txtExplanation.Location = new Point(575, 152);
            txtExplanation.Multiline = true;
            txtExplanation.Name = "txtExplanation";
            txtExplanation.ReadOnly = true;
            txtExplanation.Size = new Size(621, 279);
            txtExplanation.TabIndex = 6;
            txtExplanation.Text = resources.GetString("txtExplanation.Text");
            // 
            // lblCareerSuggestion
            // 
            lblCareerSuggestion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCareerSuggestion.AutoSize = true;
            lblCareerSuggestion.BackColor = Color.Transparent;
            lblCareerSuggestion.Font = new Font("Rockwell", 34F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCareerSuggestion.ForeColor = Color.FromArgb(0, 137, 123);
            lblCareerSuggestion.Location = new Point(35, 509);
            lblCareerSuggestion.Name = "lblCareerSuggestion";
            lblCareerSuggestion.Size = new Size(442, 56);
            lblCareerSuggestion.TabIndex = 5;
            lblCareerSuggestion.Text = "Software Architect";
            // 
            // pbCareerImage
            // 
            pbCareerImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbCareerImage.Image = (Image)resources.GetObject("pbCareerImage.Image");
            pbCareerImage.Location = new Point(23, 152);
            pbCareerImage.Name = "pbCareerImage";
            pbCareerImage.Size = new Size(472, 344);
            pbCareerImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCareerImage.TabIndex = 4;
            pbCareerImage.TabStop = false;
            // 
            // lblMBTIType
            // 
            lblMBTIType.AutoSize = true;
            lblMBTIType.BackColor = Color.Transparent;
            lblMBTIType.Font = new Font("Rockwell", 34F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMBTIType.ForeColor = Color.FromArgb(0, 137, 123);
            lblMBTIType.Location = new Point(23, 93);
            lblMBTIType.Name = "lblMBTIType";
            lblMBTIType.Size = new Size(483, 56);
            lblMBTIType.TabIndex = 3;
            lblMBTIType.Text = "INTJ - The Strategist";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ActiveCaption;
            pnlHeader.BackgroundImage = (Image)resources.GetObject("pnlHeader.BackgroundImage");
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(lblAdvisorAI);
            pnlHeader.Controls.Add(progressBar1);
            pnlHeader.Controls.Add(lblAppTitleH);
            pnlHeader.Controls.Add(lblAppTitleT);
            pnlHeader.Controls.Add(lblAppTitleA);
            pnlHeader.Controls.Add(lblAppTitleP);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1264, 73);
            pnlHeader.TabIndex = 2;
            // 
            // lblAdvisorAI
            // 
            lblAdvisorAI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblAdvisorAI.AutoSize = true;
            lblAdvisorAI.BackColor = Color.Transparent;
            lblAdvisorAI.Font = new Font("Sitka Banner", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAdvisorAI.ForeColor = Color.FromArgb(249, 249, 251);
            lblAdvisorAI.Location = new Point(229, 2);
            lblAdvisorAI.Name = "lblAdvisorAI";
            lblAdvisorAI.Size = new Size(186, 55);
            lblAdvisorAI.TabIndex = 8;
            lblAdvisorAI.Text = "Advisor AI";
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            progressBar1.Location = new Point(1850, 27);
            progressBar1.Maximum = 24;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(457, 40);
            progressBar1.TabIndex = 7;
            // 
            // lblAppTitleH
            // 
            lblAppTitleH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblAppTitleH.AutoSize = true;
            lblAppTitleH.BackColor = Color.Transparent;
            lblAppTitleH.Font = new Font("Sitka Banner", 40F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAppTitleH.ForeColor = Color.FromArgb(94, 53, 177);
            lblAppTitleH.Location = new Point(159, -13);
            lblAppTitleH.Name = "lblAppTitleH";
            lblAppTitleH.Size = new Size(85, 78);
            lblAppTitleH.TabIndex = 6;
            lblAppTitleH.Text = "H.";
            // 
            // lblAppTitleT
            // 
            lblAppTitleT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblAppTitleT.AutoSize = true;
            lblAppTitleT.BackColor = Color.Transparent;
            lblAppTitleT.Font = new Font("Sitka Banner", 40F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAppTitleT.ForeColor = Color.FromArgb(0, 188, 212);
            lblAppTitleT.Location = new Point(110, -13);
            lblAppTitleT.Name = "lblAppTitleT";
            lblAppTitleT.Size = new Size(74, 78);
            lblAppTitleT.TabIndex = 5;
            lblAppTitleT.Text = "T.";
            // 
            // lblAppTitleA
            // 
            lblAppTitleA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblAppTitleA.AutoSize = true;
            lblAppTitleA.BackColor = Color.Transparent;
            lblAppTitleA.Font = new Font("Sitka Banner", 40F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAppTitleA.ForeColor = Color.FromArgb(13, 71, 161);
            lblAppTitleA.Location = new Point(56, -13);
            lblAppTitleA.Name = "lblAppTitleA";
            lblAppTitleA.Size = new Size(78, 78);
            lblAppTitleA.TabIndex = 4;
            lblAppTitleA.Text = "A.";
            // 
            // lblAppTitleP
            // 
            lblAppTitleP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblAppTitleP.AutoSize = true;
            lblAppTitleP.BackColor = Color.Transparent;
            lblAppTitleP.Font = new Font("Sitka Banner", 40F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAppTitleP.ForeColor = Color.FromArgb(0, 137, 123);
            lblAppTitleP.Location = new Point(9, -13);
            lblAppTitleP.Name = "lblAppTitleP";
            lblAppTitleP.Size = new Size(71, 78);
            lblAppTitleP.TabIndex = 2;
            lblAppTitleP.Text = "P.";
            // 
            // Result_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 251);
            ClientSize = new Size(1264, 749);
            Controls.Add(pnlMainContent);
            Name = "Result_Form";
            Text = "Result_Form";
            pnlMainContent.ResumeLayout(false);
            pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCareerImage).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMainContent;
        private Panel pnlHeader;
        private Label lblAdvisorAI;
        private CustomProgressBar progressBar1;
        private Label lblAppTitleH;
        private Label lblAppTitleT;
        private Label lblAppTitleA;
        private Label lblAppTitleP;
        private Label lblMBTIType;
        private PictureBox pbCareerImage;
        private TextBox txtExplanation;
        private Label lblCareerSuggestion;
        private Label label1;
        private ListBox lbReasoningLog;
        private Button btnGenerateAnother;
        private Button btnRetakeTest;
    }
}