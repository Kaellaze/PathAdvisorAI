using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PathAdvisorAI
{
    public class CustomProgressBar : ProgressBar
    {
        // Bagong kulay para sa mas professional na look (#009688)
        private readonly Color PROGRESS_FORE_COLOR = Color.FromArgb(0, 150, 136);

        // Fix sa Error: SystemColors
        private readonly Color PROGRESS_BACK_COLOR = System.Drawing.SystemColors.GradientInactiveCaption;
        private readonly Color PROGRESS_TEXT_COLOR = Color.White;

        public CustomProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int width = (int)((float)this.Value / this.Maximum * this.Width);

            // ... (rest of the drawing logic is the same) ...
            GraphicsPath path = new GraphicsPath();
            int radius = 8;
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(this.Width - radius * 2 - 1, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(this.Width - radius * 2 - 1, this.Height - radius * 2 - 1, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, this.Height - radius * 2 - 1, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);

            using (SolidBrush backBrush = new SolidBrush(PROGRESS_BACK_COLOR))
            {
                e.Graphics.FillRectangle(backBrush, 0, 0, this.Width, this.Height);
            }

            using (SolidBrush foreBrush = new SolidBrush(PROGRESS_FORE_COLOR))
            {
                e.Graphics.FillRectangle(foreBrush, 0, 0, width, this.Height);
            }

            double percentage = (double)this.Value / this.Maximum * 100;
            string text = $"{Math.Round(percentage)}% Done";

            using (Font font = new Font(this.Font.FontFamily, 9, FontStyle.Bold))
            {
                Color textColor = PROGRESS_TEXT_COLOR;

                using (SolidBrush textBrush = new SolidBrush(textColor))
                {
                    SizeF size = e.Graphics.MeasureString(text, font);

                    float x = 5;
                    float y = (this.Height - size.Height) / 2;

                    RectangleF clipRect = new RectangleF(0, 0, width, this.Height);
                    e.Graphics.SetClip(clipRect);

                    e.Graphics.DrawString(text, font, textBrush, x, y);

                    e.Graphics.SetClip(e.ClipRectangle);
                }
            }
        }
    }
}