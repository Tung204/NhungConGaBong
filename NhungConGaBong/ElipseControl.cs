using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhungConGaBong
{
    class ElipseControl : Component
    {
        private Control _cntrl;
        private int _CornerRadius = 30;

        public Control TargetControl
        {
            get { return _cntrl; }
            set
            {
                _cntrl = value;
                _cntrl.SizeChanged += (sender, eventArgs) => ApplyRoundedCorners();
                ApplyRoundedCorners();
            }
        }

        public int CornerRadius
        {
            get { return _CornerRadius; }
            set
            {
                _CornerRadius = value;
                if (_cntrl != null)
                    ApplyRoundedCorners();
            }
        }

        private void ApplyRoundedCorners()
        {
            if (_cntrl != null)
            {
                GraphicsPath path = new GraphicsPath();
                Rectangle bounds = new Rectangle(0, 0, _cntrl.Width, _cntrl.Height);
                int radius = _CornerRadius * 2; // Multiply by 2 because we want the diameter, not the radius

                path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90); // Top-left corner
                path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90); // Top-right corner
                path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90); // Bottom-right corner
                path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90); // Bottom-left corner
                path.CloseAllFigures();

                _cntrl.Region = new Region(path);
            }
        }

    }
}