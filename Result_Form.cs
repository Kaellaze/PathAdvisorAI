using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PathAdvisorAI
{
    public partial class Result_Form : Form
    {

        private UserResponseProfile userProfile;
        private const string IMAGE_FOLDER = "Resources";
        private FormWindowState previousState;

        public Result_Form()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        public Result_Form(FormWindowState previousState, UserResponseProfile profile)
        {
            InitializeComponent();

            this.previousState = previousState;
            this.userProfile = profile;

            // Apply Theme AFTER Initialize
            ThemeManager.ApplyTheme(this);

            this.WindowState = previousState;

            if (previousState == FormWindowState.Normal)
                this.StartPosition = FormStartPosition.CenterScreen;

            this.Load += Result_Form_Load;

            btnGenerateAnother.Click += (s, e) => UpdateResultDisplay();
            btnRetakeTest.Click += (s, e) => RetakeTest_Click();
            this.FormClosing += (s, e) => Application.Exit();
        }


        private void Result_Form_Load(object sender, EventArgs e)
        {
            UpdateResultDisplay();

            txtExplanation.SelectionStart = 0;
            txtExplanation.SelectionLength = 0;
            this.ActiveControl = lblMBTIType; // Shift focus away from textbox
        }

        private void RetakeTest_Click()
        {
            try
            {
                frmQuestionnaire newForm = new frmQuestionnaire(this.WindowState);

                // Apply SAME theme to the new form
                ThemeManager.ApplyTheme(newForm);

                newForm.FormClosed += (s, e) =>
                {
                    Application.ExitThread();
                    Environment.Exit(0);
                };

                this.Hide();
                newForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Questionnaire Form:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void UpdateResultDisplay()
        {
            string mbtiType = userProfile.FinalMBTIType;
            MbtiTypeDetails details = MbtiDataStore.GetDetails(mbtiType);

            // A. Display MBTI Type and Explanation
            lblMBTIType.Text = $"{mbtiType} - {details.Nickname}";

            // B. Display Reasoning Log
            lbReasoningLog.Items.Clear();
            List<string> logMessages = MbtiLogic.GenerateReasoningLog(userProfile);
            foreach (string message in logMessages)
            {
                lbReasoningLog.Items.Add(message);
            }

            // C. Display Random Career Suggestion
            var careerData = MbtiLogic.GetRandomCareer(mbtiType);
            lblCareerSuggestion.Text = careerData.Title;
            txtExplanation.Text = careerData.Explanation;

            // D. Load Career Image
            try
            {
                string fullPath = Path.Combine(IMAGE_FOLDER, careerData.ImagePath);

                if (pbCareerImage.Image != null)
                    pbCareerImage.Image.Dispose();

                pbCareerImage.Image = Image.FromFile(fullPath);
                pbCareerImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (FileNotFoundException)
            {
                pbCareerImage.Image = null;
                MessageBox.Show(
                    $"Image file not found for '{careerData.ImagePath}'.\n" +
                    $"Make sure it's inside '{IMAGE_FOLDER}' and set to 'Copy if newer'.",
                    "Image Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnGenerateAnother_Click(object sender, EventArgs e)
        {

        }

        private void lbReasoningLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
