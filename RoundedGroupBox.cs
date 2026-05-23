using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Student_Record_System // <-- CHANGE THIS TO MATCH YOUR EXACT PROJECT NAMESPACE
{
    public class RoundedGroupBox : GroupBox
    {
        // Private styling fields
        private int _cornerRadius = 15;
        private Color _borderColor = Color.FromArgb(74, 0, 0); // Dark Maroon
        private int _borderThickness = 2;
        private Color _headerTextColor = Color.Maroon; // Maroon Text
        private int _headerTextPaddingLeft = 35; // Shifts text right

        [Category("Appearance")]
        [Description("The radius of the rounded corners")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        [Description("The color of the border line")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("The thickness of the border line")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderThickness
        {
            get => _borderThickness;
            set { _borderThickness = Math.Max(1, value); Invalidate(); }
        }

        [Category("Appearance")]
        [Description("The color of the GroupBox header text")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HeaderTextColor
        {
            get => _headerTextColor;
            set { _headerTextColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Distance from the left edge to shift the header text to the right")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int HeaderTextPaddingLeft
        {
            get => _headerTextPaddingLeft;
            set { _headerTextPaddingLeft = Math.Max(0, value); Invalidate(); }
        }

        public RoundedGroupBox()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Measure text size with precise graphics engine accuracy
            SizeF textSize = e.Graphics.MeasureString(this.Text, this.Font);

            float offset = _borderThickness / 2f;
            float topMargin = textSize.Height / 2f;

            RectangleF boxBounds = new RectangleF(
                offset,
                topMargin,
                this.Width - _borderThickness,
                this.Height - topMargin - offset
            );

            // Clip the outer window boundaries so inner layouts follow the curve
            using (GraphicsPath clipPath = GetRoundedPath(new RectangleF(0, 0, this.Width, this.Height)))
            {
                this.Region = new Region(clipPath);
            }

            // Draw the main custom background color
            using (SolidBrush bgBrush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillRectangle(bgBrush, this.ClientRectangle);
            }

            // Save the current state of the graphics layer
            GraphicsState state = e.Graphics.Save();

            if (!string.IsNullOrEmpty(this.Text) && this.Text.Trim().Length > 0)
            {
                // Convert measurements to a safe integer-based Rectangle using Math.Ceiling
                Rectangle textBlock = new Rectangle(
                    _headerTextPaddingLeft - 2,
                    0,
                    (int)Math.Ceiling(textSize.Width) + 4,
                    (int)Math.Ceiling(textSize.Height)
                );

                // FORCE the graphics engine to completely ignore drawing lines inside the text block area
                e.Graphics.ExcludeClip(textBlock);
            }

            // Draw the complete border path (The graphics engine will skip the text zone automatically)
            using (GraphicsPath borderPath = GetRoundedPath(boxBounds))
            using (Pen pen = new Pen(_borderColor, _borderThickness))
            {
                e.Graphics.DrawPath(pen, borderPath);
            }

            // Restore graphics to full coverage so we can draw the text cleanly over the gap
            e.Graphics.Restore(state);

            // Draw the header text inside the custom carved window
            if (!string.IsNullOrEmpty(this.Text) && this.Text.Trim().Length > 0)
            {
                using (SolidBrush textBrush = new SolidBrush(_headerTextColor))
                {
                    e.Graphics.DrawString(this.Text, this.Font, textBrush, new PointF(_headerTextPaddingLeft, 0));
                }
            }
        }

        private GraphicsPath GetRoundedPath(RectangleF bounds)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = _cornerRadius * 2;

            if (_cornerRadius > 0 && diameter < bounds.Width && diameter < bounds.Height)
            {
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            }
            else
            {
                path.AddRectangle(bounds);
            }

            path.CloseAllFigures();
            return path;
        }
    }
}
