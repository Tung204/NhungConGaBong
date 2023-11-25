using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhungConGaBong
{
    public class GetString
    {
        // 5. Xóa khoảng trắng dư thừa trong chuỗi
        public static string Standard(string s)
        {
            s = s.Trim();
            do
            {
                s = s.Replace("  ", " ");
            } while (s.IndexOf("  ") != -1);
            return s;
        }
        // 6. Trả về n kí tự bên trái của chuỗi
        static public string Left(string s, int n)
        {            
            return s.Substring(0, n); ;
        }
        // 7. Trả về n kí tự bên phải của chuỗi
        static public string Right(string s, int n)
        {
            return s.Substring(s.Length - n, n); 
        }
        // 8. Trả về n kí tự bên phải của chuỗi
        static public string Mid(string s, int index, int n)
        {
            return s.Substring(index, n);
        }

        // 9. Proper(s) Chuỗi có kí tự đầu HOA, các kí tự còn lại thường
        public static string Proper(string s)
        {
            s = Standard(s);
            s = s.ToLower();
            char[] arr = s.ToCharArray();
            arr[0] = char.ToUpper(arr[0]);
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] == ' ')
                {
                    arr[i + 1] = char.ToUpper(arr[i + 1]);
                }
            }
            return new string(arr);
        }

        // 9. FirstCapitalLetter(s) Chuỗi có kí tự đầu HOA, các kí tự còn lại thường
        public static string FirstCapitalLetter(string s)
        {
            // Xóa khoảng trắng dư thừa và chuyển chuỗi --> chữ thường
            s = Standard(s);        s = s.ToLower();
            
            //Chuyển chuỗi thành mảng chuỗi dựa vào kí tự khoảng trắng ' '
            string[] Words = s.Split(' ');
            s = "";
            foreach (string st in Words)
            {                
                if (st.Length > 1)
                    s += st.Substring(0, 1).ToUpper() + st.Substring(1) + " ";
                else
                    s += st.ToUpper() + " ";
            }
            // Xóa khoảng trắng đầu và cuối chuỗi
            return s.Trim();
        }


    }
}
