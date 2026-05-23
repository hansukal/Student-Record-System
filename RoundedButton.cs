using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Student_Record_System // <-- CHANGE THIS TO MATCH YOUR EXACT PROJECT NAMESPACE
{
    public class RoundedButton : Button
    {
        // Private fields for corner radii
        private int _topLeftRadius = 15;
        private int _topRightRadius = 15;
        private int _bottomLeftRadius = 15;
        private int _bottomRightRadius = 15;

        // Border and color state tracking
        private Color _borderColor = Color.FromArgb(74, 0, 0); // Dark Maroon Border
        private int _borderThickness = 1;
        private bool _isHovering = false;
        private bool _isPressed = false;

        // Hover/Click properties exposed to the designer
        [Category("Appearance"), Description("Background color when mouse hovers over the button")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverColor { get; set; } = Color.FromArgb(160, 0, 0); // Lighter Maroon hover

        [Category("Appearance"), Description("Background color when button is clicked")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color PressedColor { get; set; } = Color.FromArgb(60, 0, 0); // Deep Wine press

        [Category("Appearance"), Description("Top-left corner radius")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int TopLeftRadius
        {
            get => _topLeftRadius;
            set { _topLeftRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance"), Description("Top-right corner radius")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int TopRightRadius
        {
            get => _topRightRadius;
            set { _topRightRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance"), Description("Bottom-left corner radius")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BottomLeftRadius
        {
            get => _bottomLeftRadius;
            set { _bottomLeftRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance"), Description("Bottom-right corner radius")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BottomRightRadius
        {
            get => _bottomRightRadius;
            set { _bottomRightRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance"), Description("Border color")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Appearance"), Description("Border thickness in pixels (0 for no border)")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderThickness
        {
            get => _borderThickness;
            set { _borderThickness = Math.Max(0, value); Invalidate(); }
        }

        public RoundedButton()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(120, 40);
            this.BackColor = Color.Maroon; // Maroon theme style
            this.ForeColor = Color.White;

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        // Capture mouse state changes for active UI feedback
        protected override void OnMouseEnter(EventArgs e) { _isHovering = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _isHovering = false; _isPressed = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs mevent) { _isPressed = true; Invalidate(); base.OnMouseDown(mevent); }
        protected override void OnMouseUp(MouseEventArgs mevent) { _isPressed = false; Invalidate(); base.OnMouseUp(mevent); }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);

            using (GraphicsPath path = GetRoundedPath(bounds))
            {
                // Clip the button region so everything inside (including the image) respects the rounded corners
                this.Region = new Region(path);

                // Determine active background color based on mouse interaction state
                Color activeBgColor = this.BackColor;
                if (_isPressed) activeBgColor = PressedColor;
                else if (_isHovering) activeBgColor = HoverColor;

                using (SolidBrush brush = new SolidBrush(activeBgColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // NEW: Custom Image Rendering Section
                if (this.Image != null)
                {
                    // Calculate image position based on standard ImageAlign property
                    Rectangle imgBounds = CalculateImageBounds(this.Image.Size);

                    // Handle hover/pressed blending effects if you want, or just draw basic
                    e.Graphics.DrawImage(this.Image, imgBounds);
                }

                // Draw button border
                if (_borderThickness > 0)
                {
                    float offset = _borderThickness / 2f;
                    RectangleF borderBounds = new RectangleF(offset, offset, this.Width - _borderThickness, this.Height - _borderThickness);

                    using (GraphicsPath borderPath = GetRoundedPath(borderBounds))
                    using (Pen pen = new Pen(_borderColor, _borderThickness))
                    {
                        pen.Alignment = PenAlignment.Center;
                        e.Graphics.DrawPath(pen, borderPath);
                    }
                }
            }

            // Adjust text bounds if an image is sharing the button space (aligned to left)
            Rectangle textBounds = bounds;
            if (this.Image != null && this.ImageAlign == ContentAlignment.MiddleLeft)
            {
                int shiftRight = this.Image.Width + 10;
                textBounds = new Rectangle(shiftRight, 0, this.Width - shiftRight, this.Height);
            }

            // Center and draw text cleanly using high-fidelity modern typography engine
            TextRenderer.DrawText(
                e.Graphics,
                this.Text,
                this.Font,
                textBounds,
                this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak
            );
        }

        // Helper method to position the image inside the custom button container
        private Rectangle CalculateImageBounds(Size imgSize)
        {
            int x = 10; // Default padding left
            int y = (this.Height - imgSize.Height) / 2; // Center vertically

            // Calculate position dynamically depending on designer choice
            switch (this.ImageAlign)
            {
                case ContentAlignment.MiddleCenter:
                    x = (this.Width - imgSize.Width) / 2;
                    break;
                case ContentAlignment.MiddleRight:
                    x = this.Width - imgSize.Width - 10;
                    break;
                case ContentAlignment.MiddleLeft:
                default:
                    x = 10;
                    break;
            }

            return new Rectangle(x, y, imgSize.Width, imgSize.Height);
        }

        private GraphicsPath GetRoundedPath(Rectangle bounds)
        {
            return GetRoundedPath(new RectangleF(bounds.X, bounds.Y, bounds.Width, bounds.Height));
        }

        private GraphicsPath GetRoundedPath(RectangleF bounds)
        {
            GraphicsPath path = new GraphicsPath();

            // Top Left
            if (_topLeftRadius > 0)
                path.AddArc(bounds.X, bounds.Y, _topLeftRadius * 2, _topLeftRadius * 2, 180, 90);
            else
                path.AddLine(bounds.X, bounds.Y, bounds.X, bounds.Y);

            // Top Right
            if (_topRightRadius > 0)
                path.AddArc(bounds.Right - (_topRightRadius * 2), bounds.Y, _topRightRadius * 2, _topRightRadius * 2, 270, 90);
            else
                path.AddLine(bounds.Right, bounds.Y, bounds.Right, bounds.Y);

            // Bottom Right
            if (_bottomRightRadius > 0)
                path.AddArc(bounds.Right - (_bottomRightRadius * 2), bounds.Bottom - (_bottomRightRadius * 2), _bottomRightRadius * 2, _bottomRightRadius * 2, 0, 90);
            else
                path.AddLine(bounds.Right, bounds.Bottom, bounds.Right, bounds.Bottom);

            // Bottom Left
            if (_bottomLeftRadius > 0)
                path.AddArc(bounds.X, bounds.Bottom - (_bottomLeftRadius * 2), _bottomLeftRadius * 2, _bottomLeftRadius * 2, 90, 90);
            else
                path.AddLine(bounds.X, bounds.Bottom, bounds.X, bounds.Bottom);

            path.CloseAllFigures();
            return path;
        }
    }
}
