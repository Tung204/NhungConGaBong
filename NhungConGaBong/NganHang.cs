using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhungConGaBong
{
    public class NganHang
    {
        public int ID {  get; set; }
        public string TenNH { get; set; } = null!;
        public string MaNH { get; set; } = null!;
   
        public NganHang(string csvLine)
        {
            string[] values = csvLine.Split(',');
            this.ID = Convert.ToInt32(values[0]);
            this.MaNH = values[1];
            this.TenNH = values[2];
        }

        public static List<NganHang> ReadFromFile(string fileName)
        {
            List<NganHang> list = new List<NganHang>();
            string line = "";
            using (StreamReader reader = new StreamReader(fileName))
            {               
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    NganHang d = new NganHang(line);
                    list.Add(d);
                }
            }
            return list;
        }
    }
}
