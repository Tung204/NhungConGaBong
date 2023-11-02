using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhungConGaBong
{
    public class SacDataGridView
    {
        public static void SetRowNumber(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Set Số thứ tự Dòng Stt index = 0
            var dgView = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left - 3, e.RowBounds.Top, dgView.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, dgView.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}
