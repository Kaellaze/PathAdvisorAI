using System;
using System.Drawing;
using System.Windows.Forms;

namespace PathAdvisorAI
{
    public partial class Main_Menu_Form : Form
    {
        // 1. NEW COLOR DEFINITIONS 
        private readonly Color FocusBorderColor = Color.FromArgb(13, 71, 161);
        private readonly Color NormalBorderColor = Color.FromArgb(204, 204, 204);

        private readonly Color P_Color = Color.FromArgb(0, 137, 123);
        private readonly Color A_Color = Color.FromArgb(13, 71, 161);
        private readonly Color T_Color = Color.FromArgb(0, 188, 212);
        private readonly Color H_Color = Color.FromArgb(94, 53, 177);

        private readonly Color PrimaryActionColor = Color.FromArgb(0, 137, 123);
        private readonly Color DarkText = Color.FromArgb(51, 51, 51);
        private readonly Color LightBackground = Color.FromArgb(235, 240, 245);

        private bool isUserNameFocused = false;

        public Main_Menu_Form()
        {
            InitializeComponent();

            // 1. Add ComboBox items FIRST
            comboBoxLanguage.Items.AddRange(new object[]
            {
                "Light Mode",
                "Dark Mode"
            });

            // 2. Save original colors (needed for Light mode revert)
            ThemeManager.SaveOriginalColors(this);

            // 3. Load saved theme & apply
            ThemeManager.LoadTheme();
            ThemeManager.ApplyTheme(this);

            // 4. Set ComboBox selection based on current theme
            comboBoxLanguage.SelectedItem = ThemeManager.IsDarkMode ? "Dark Mode" : "Light Mode";

            // 5. APPLYING NEW COLORS & STYLES IN CONSTRUCTOR
            this.BackColor = LightBackground;

            lblAppTitleP.ForeColor = P_Color;
            lblAppTitleA.ForeColor = A_Color;
            lblAppTitleT.ForeColor = T_Color;
            lblAppTitleH.ForeColor = H_Color;

            btnStartTest.BackColor = Color.FromArgb(100, PrimaryActionColor);
            btnStartTest.ForeColor = Color.White;
            btnStartTest.FlatStyle = FlatStyle.Flat;
            btnStartTest.FlatAppearance.BorderSize = 0;
            btnStartTest.Enabled = false;

            txtUserName.BorderStyle = BorderStyle.None;

            // 6. HOOKING UP EVENTS
            txtUserName.Paint += txtUserName_Paint;
            txtUserName.Enter += txtUserName_Enter;
            txtUserName.Leave += txtUserName_Leave;

            txtUserName.TextChanged += CheckStartButtonStatus;
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;

            btnStartTest.Click += btnStartTest_Click;

            this.ResizeEnd += Main_Menu_Form_ResizeEnd;

            // Rendering Optimization
            this.SetStyle(ControlStyles.DoubleBuffer |
                          ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint,
                          true);
            this.UpdateStyles();
        }

        // ===== TEXTBOX BORDER LOGIC =====
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            isUserNameFocused = true;
            txtUserName.Invalidate();
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            isUserNameFocused = false;
            txtUserName.Invalidate();
        }

        private void txtUserName_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = isUserNameFocused ? FocusBorderColor : NormalBorderColor;
            int borderWidth = isUserNameFocused ? 2 : 1;

            ControlPaint.DrawBorder(
                e.Graphics,
                txtUserName.ClientRectangle,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid
            );
        }

        // ===== START BUTTON ENABLE LOGIC =====
        private void CheckStartButtonStatus(object sender, EventArgs e)
        {
            bool ok = !string.IsNullOrWhiteSpace(txtUserName.Text)
                      && comboBoxLanguage.SelectedIndex != -1;

            btnStartTest.Enabled = ok;
            btnStartTest.BackColor = ok ? PrimaryActionColor : Color.FromArgb(100, PrimaryActionColor);
        }

        // ===== WINDOW CENTERING =====
        private void Main_Menu_Form_ResizeEnd(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.CenterToScreen();
        }

        // ===== START BUTTON CLICK =====
        private void btnStartTest_Click(object sender, EventArgs e)
        {
            if (!btnStartTest.Enabled) return;

            FormWindowState currentState = this.WindowState;

            frmQuestionnaire f2 = new frmQuestionnaire(currentState);
            ThemeManager.ApplyTheme(f2);

            this.Hide();

            f2.FormClosed += (s, args) =>
            {
                this.WindowState = f2.WindowState;
                this.Show();
            };

            f2.Show();
        }

        // ===== COMBOBOX THEME SWITCH =====
        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLanguage.SelectedItem.ToString() == "Dark Mode")
                ThemeManager.IsDarkMode = true;
            else
                ThemeManager.IsDarkMode = false;

            ThemeManager.SaveTheme();
            ThemeManager.ApplyTheme(this);
        }
    }
}
