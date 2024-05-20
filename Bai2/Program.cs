using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "Truong";
            string password = "12345";
            string time = "15/5/2024";

            // Sử dụng StringWriter để lưu tài khoản và mật khẩu 
            using (StringWriter sw = new StringWriter()) 
            {
                sw.WriteLine("Username: " + username);
                sw.WriteLine("Password: " +  password);
                sw.WriteLine("Time: " +  time);

                // Lấy chuỗi từ StringWritrer 
                string content = sw.ToString();

                // Sử dụng StringReader để đọc tài khoản và mật khẩu 
                var sr = new StringReader(content);
                string line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }

            
            Console.ReadKey();
        }
    }
}
