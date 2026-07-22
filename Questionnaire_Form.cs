using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PathAdvisorAI;

namespace PathAdvisorAI
{





    public partial class frmQuestionnaire : Form
    {
        public frmQuestionnaire()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this); // Apply dark/light theme
        }





        // --- COLOR DEFINITIONS ---
        private readonly Color COLOR_AGREE_OUTLINE = Color.FromArgb(0, 137, 123);
        private readonly Color COLOR_AGREE_STATIC_FILL = Color.FromArgb(38, 166, 154);
        private readonly Color COLOR_AGREE_HOVER_FILL = Color.FromArgb(102, 204, 179);

        private readonly Color COLOR_DISAGREE_OUTLINE = Color.FromArgb(13, 71, 161);
        private readonly Color COLOR_DISAGREE_STATIC_FILL = Color.FromArgb(13, 71, 161); // darkest stays
        private readonly Color COLOR_DISAGREE_HOVER_FILL = Color.FromArgb(141, 172, 204);

        private readonly Color COLOR_NEUTRAL_OUTLINE = Color.FromArgb(170, 170, 170);
        private readonly Color COLOR_NEUTRAL_FILL = Color.FromArgb(200, 200, 200);

        private const int TOTAL_QUESTIONS = 24;

        private Dictionary<string, bool> QuestionAnsweredStatus = new Dictionary<string, bool>();

    

        public frmQuestionnaire(FormWindowState previousState)
        {
            InitializeComponent();
            this.WindowState = previousState;

            pnl24Questions.AutoScroll = true; // Keep scrollable
            InitializeQuestionPanels();

            this.Load += frmQuestionnaire_Load;
            this.Resize += frmQuestionnaire_Resize;
            this.ResizeEnd += frmQuestionnaire_ResizeEnd;

            if (this.progressBar1 != null)
                progressBar1.Maximum = TOTAL_QUESTIONS;

            if (this.btnViewResult != null)
            {
                btnViewResult.Visible = false;
                btnViewResult.Click += btnViewResult_Click;
            }
        }

        // --- FORM LOAD / CENTERING ---
        private void frmQuestionnaire_Load(object? sender, EventArgs e)
        {
            for (int i = 1; i <= TOTAL_QUESTIONS; i++)
            {
                string panelName = "pnlQuestion" + i;
                Control[] found = pnl24Questions.Controls.Find(panelName, false);
                if (found.Length > 0)
                    SetupRadioButtons(found[0]);
            }

            SetupRadioButtonsForPanel(pnlViewResult);

            UpdateProgressStatus();
            CenterPanelsHorizontally();
        }

        private void frmQuestionnaire_Resize(object? sender, EventArgs e)
        {
            CenterPanelsHorizontally();
        }

        private void frmQuestionnaire_ResizeEnd(object? sender, EventArgs e)
        {
            CenterPanelsHorizontally();
        }

        private void CenterPanelsHorizontally()
        {
            // Center question panels horizontally inside scrollable panel
            foreach (Control c in pnl24Questions.Controls)
            {
                if (c is Panel pnl)
                {
                    pnl.Left = (pnl24Questions.ClientSize.Width - pnl.Width) / 2;
                }
            }

            // Center pnlViewResult if needed
            if (pnlViewResult != null)
                pnlViewResult.Left = (this.ClientSize.Width - pnlViewResult.Width) / 2;
        }

        // --- INITIALIZE QUESTIONS ---
        private void InitializeQuestionPanels()
        {
            QuestionAnsweredStatus.Clear();

            foreach (Control c in pnl24Questions.Controls)
            {
                if (c is Panel pnl)
                    QuestionAnsweredStatus[pnl.Name] = false;
            }
        }

        // --- RADIO BUTTON SETUP ---
        private void SetupRadioButtons(Control parent)
        {
            if (parent == null) return;

            foreach (Control c in parent.Controls)
            {
                if (c is RadioButton rb)
                {
                    rb.Appearance = Appearance.Button;
                    rb.FlatStyle = FlatStyle.Flat;
                    rb.FlatAppearance.BorderSize = 2;
                    rb.TextAlign = ContentAlignment.MiddleCenter;
                    rb.BackColor = Color.White;

                    rb.Click -= RadioButton_Click;
                    rb.MouseEnter -= RadioButton_MouseEnter;
                    rb.MouseLeave -= RadioButton_MouseLeave;

                    rb.Click += RadioButton_Click;
                    rb.MouseEnter += RadioButton_MouseEnter;
                    rb.MouseLeave += RadioButton_MouseLeave;

                    SetButtonState(rb);
                }

                if (c.HasChildren)
                    SetupRadioButtons(c);
            }
        }

        private void SetupRadioButtonsForPanel(Control panel)
        {
            if (panel == null) return;
            SetupRadioButtons(panel);
        }

        // --- RADIO BUTTON EVENTS ---
        private void RadioButton_Click(object? sender, EventArgs e)
        {
            if (sender is not RadioButton selectedButton) return;
            Panel? parentPanel = FindParentPanel(selectedButton);
            if (parentPanel == null) return;

            foreach (Control c in parentPanel.Controls)
            {
                if (c is RadioButton rb)
                {
                    rb.Checked = false;
                    SetButtonState(rb);
                }
            }

            selectedButton.Checked = true;
            SetButtonState(selectedButton);

            if (QuestionAnsweredStatus.ContainsKey(parentPanel.Name))
            {
                QuestionAnsweredStatus[parentPanel.Name] = true;
                UpdateProgressStatus();
            }
        }

        private void RadioButton_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is not RadioButton rb || rb.Checked) return;

            if (rb.Tag != null && int.TryParse(rb.Tag.ToString(), out int value))
            {
                rb.BackColor = GetHoverColorByTag(value);
                rb.FlatAppearance.BorderColor = GetOutlineColorByTag(value);
            }
        }

        private void RadioButton_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is not RadioButton rb) return;
            SetButtonState(rb);
        }

        private void SetButtonState(RadioButton rb)
        {
            if (rb.Tag == null || !int.TryParse(rb.Tag.ToString(), out int value)) return;

            Color outline = GetOutlineColorByTag(value);
            Color fill = rb.Checked ? GetStaticFillColorByTag(value) : Color.White;

            rb.FlatAppearance.BorderColor = outline;
            rb.BackColor = fill;
        }

        private Panel? FindParentPanel(Control c)
        {
            Control? current = c.Parent;
            while (current != null && current is not Panel)
                current = current.Parent;
            return current as Panel;
        }

        // --- COLOR HELPERS ---
        private Color GetOutlineColorByTag(int value)
        {
            if (value > 0) return COLOR_AGREE_OUTLINE;
            if (value < 0) return COLOR_DISAGREE_OUTLINE;
            return COLOR_NEUTRAL_OUTLINE;
        }

        private Color GetStaticFillColorByTag(int value)
        {
            if (value > 0) return COLOR_AGREE_STATIC_FILL;
            if (value < 0) return COLOR_DISAGREE_STATIC_FILL; // darkest stays
            return COLOR_NEUTRAL_FILL;
        }

        private Color GetHoverColorByTag(int value)
        {
            if (value > 0) return COLOR_AGREE_HOVER_FILL;
            if (value < 0) return COLOR_DISAGREE_HOVER_FILL;
            return COLOR_NEUTRAL_FILL;
        }

        // --- PROGRESS BAR / VIEW RESULT ---
        private void UpdateProgressStatus()
        {
            if (progressBar1 == null || btnViewResult == null) return;

            int answered = QuestionAnsweredStatus.Count(kvp => kvp.Value);
            progressBar1.Maximum = TOTAL_QUESTIONS;
            progressBar1.Value = Math.Min(answered, TOTAL_QUESTIONS);
            btnViewResult.Visible = answered == TOTAL_QUESTIONS;
        }

        private void btnViewResult_Click(object? sender, EventArgs e)
        {
            FormWindowState currentState = this.WindowState;

            // TAWAGIN ANG AI LOGIC para i-process ang sagot at ibalik ang ACCURATE na resulta
            // Tiyakin na ang 'this.pnl24Questions' ang pangalan ng container panel na naglalaman ng lahat ng tanong mo.
            UserResponseProfile userProfile = MbtiLogic.AnalyzeResponses(this.pnl24Questions);

            // I-INSTANTIATE ANG RESULT FORM AT IPASA ANG USER PROFILE
            Result_Form resultForm = new Result_Form(currentState, userProfile);

            this.Hide();
            resultForm.Show();
        }

        private void btnQ2_Neg3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
