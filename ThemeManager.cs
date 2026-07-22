using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PathAdvisorAI
{
    public static class ThemeManager
    {
        public static bool IsDarkMode = false;

        private static readonly string ThemeSavePath = Application.StartupPath + "\\theme.config";

        // Save original colors
        private static readonly Dictionary<Control, Color> OriginalBackColors = new();
        private static readonly Dictionary<Control, Color> OriginalForeColors = new();

        // Labels that turn white in Dark Mode
        private static readonly HashSet<string> LabelsToWhite = new()
        {
            "lblTagline", "lblNameLabel", "lblChooseLanguage",
            "lblQ1Text","lblQ2Text","lblQ3Text","lblQ4Text","lblQ5Text",
            "lblQ6Text","lblQ7Text","lblQ8Text","lblQ9Text","lblQ10Text",
            "lblQ11Text","lblQ12Text","lblQ13Text","lblQ14Text","lblQ15Text",
            "lblQ16Text","lblQ17Text","lblQ18Text","lblQ19Text","lblQ20Text",
            "lblQ21Text","lblQ22Text","lblQ23Text","lblQ24Text", 
        };

        public static void LoadTheme()
        {
            if (File.Exists(ThemeSavePath))
                IsDarkMode = File.ReadAllText(ThemeSavePath) == "dark";
        }

        public static void SaveTheme()
        {
            File.WriteAllText(ThemeSavePath, IsDarkMode ? "dark" : "light");
        }

        public static void SaveOriginalColors(Form form)
        {
            SaveControlColors(form.Controls);
        }

        private static void SaveControlColors(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (!OriginalBackColors.ContainsKey(ctrl))
                    OriginalBackColors[ctrl] = ctrl.BackColor;
                if (!OriginalForeColors.ContainsKey(ctrl))
                    OriginalForeColors[ctrl] = ctrl.ForeColor;

                if (ctrl.Controls.Count > 0)
                    SaveControlColors(ctrl.Controls);
            }
        }

        public static void ApplyTheme(Form form)
        {
            if (IsDarkMode)
            {
                form.BackColor = Color.FromArgb(25, 25, 25);
                ApplyDarkMode(form.Controls);
            }
            else
            {
                form.BackColor = OriginalBackColors.ContainsKey(form) ? OriginalBackColors[form] : form.BackColor;
                ApplyLightMode(form.Controls);
            }
        }

        private static void ApplyDarkMode(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                // labels that are in whitelist turn white
                if (ctrl is Label && LabelsToWhite.Contains(ctrl.Name))
                {
                    ctrl.ForeColor = Color.White;
                }
                else if (ctrl is Label)
                {
                    // keep original color for other labels
                    continue;
                }
                else if (ctrl is Panel || ctrl is GroupBox)
                    ctrl.BackColor = Color.FromArgb(40, 40, 40);
                else if (ctrl is Button)
                {
                    ctrl.BackColor = Color.FromArgb(50, 50, 50);
                    ctrl.ForeColor = Color.White;
                }
                else if (ctrl is TextBox)
                {
                    ctrl.BackColor = Color.FromArgb(45, 45, 45);
                    ctrl.ForeColor = Color.White;
                }
                else
                    ctrl.BackColor = Color.FromArgb(30, 30, 30);

                if (ctrl.Controls.Count > 0)
                    ApplyDarkMode(ctrl.Controls);
            }
        }

        private static void ApplyLightMode(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (OriginalBackColors.ContainsKey(ctrl))
                    ctrl.BackColor = OriginalBackColors[ctrl];
                if (OriginalForeColors.ContainsKey(ctrl))
                    ctrl.ForeColor = OriginalForeColors[ctrl];

                if (ctrl.Controls.Count > 0)
                    ApplyLightMode(ctrl.Controls);
            }
        }
    }
}
