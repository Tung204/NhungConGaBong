using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhungConGaBong
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string HoDemKH { get; set; }
        public string TenKH { get; set; }
        public string MaSoThue {  get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string STK {  get; set; }
        public int NganHangID { get; set; }
        public DateTime NgayLap { get; set; }
        public  KhachHang() 
        {
            NganHangID = 0;
            MaKH = HoDemKH = TenKH = MaSoThue = DienThoai = Email = STK = "";
        }

        public KhachHang(string ckhLine)
        {
            string[] values = ckhLine.Split(',');
            this.MaKH = values[0];
            this.HoDemKH = values[1];
            this.TenKH = values[2];
            this.MaSoThue = values[3];
            this.DienThoai = values[4];
            this.Email = values[5];
            this.STK = values[6];
            this.NganHangID = Convert.ToInt32(values[7]);
            var cultureInfoVietName = new CultureInfo("vi-VN");
            string dateString = values[8];
            this.NgayLap = DateTime.Parse(dateString);
        }

        public static void SaveToFile(List<KhachHang> khList, string fileName)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                string data = lines[0]+"\n";
                foreach (var kh in khList)
                {
                    data += kh.ToString() + "\n";
                } 
                File.WriteAllText(fileName,data);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: "+e.Message);
            }
        }

        public static List<KhachHang> ReadFromFile(string fileName)
        {
            List<KhachHang> result = new List<KhachHang>();
            string[] lines = File.ReadAllLines(fileName).ToArray();
            foreach (string line in lines.Skip(1))
            {
                result.Add(new KhachHang(line));
            }
            return result;
        }

        public static DataTable ToDataTable(List<KhachHang> khList)
        {
            DataTable dataTable = new DataTable();
            string[] headers = { "MaKH", "TenKH", "DienThoai", "IDNhanVien" };
            for (int i = 0; i < headers.Length; i++)
            {
                dataTable.Columns.Add(headers[i]);
            }
            foreach (var item in khList)
            {
                DataRow row;
                row = dataTable.NewRow();
                row[0] = item.MaKH;
                row[1] = item.HoDemKH;
                row[2] = item.TenKH;
                row[3] = item.DienThoai;
                row[4] = item.Email;
                row[5] = item.MaSoThue;
                row[6] = item.STK;
                row[7] = item.NganHangID;
                row[9] = item.NgayLap;
                dataTable.Rows.Add(row);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
        public static List<T> Sort<T>(List<T> input, string property, SortOrder sortOrder)
        {
            if (sortOrder == SortOrder.Descending)
            {
                return input.OrderByDescending(p => p.GetType().GetProperty(property).GetValue(p, null)).ToList();
            }
            return input.OrderBy(p => p.GetType().GetProperty(property).GetValue(p, null)).ToList();
        }

        public override string ToString()
        {
            return $"{MaKH},{HoDemKH},{TenKH},{DienThoai},{Email},{MaSoThue},{STK},{NganHangID},{NgayLap.ToString("MM/dd/yyyy")}";
        }

    }
}

