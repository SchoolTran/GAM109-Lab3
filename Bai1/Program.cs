using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // .../ ra thư mục cha
            // C:\\...\\...\\ đường dẫn tương đối 
            // example.txt đường dẫn tuyệt đối 

            string path = "example.txt";

            // Tạo một đối tượng FileStream để ghi đối tượng 
            using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                // Tạo một đối tượng StreamWriter để ghi dữ liệu vào FileStream 
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine("Username: myUserName");
                    sw.WriteLine("Password: myPassWord");
                }
            }

            // Tạo một đối tượng FileStream để đọc đối tượng 
            using (FileStream fs = new FileStream(path,FileMode.Open, FileAccess.Read))
            {
                // Tạo một đối tượng StreamWriter để đọc dữ liệu từ FileStream 
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            Console.ReadKey();
        }
    }
     
}

