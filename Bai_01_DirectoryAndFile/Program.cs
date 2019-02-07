using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_01_DirectoryAndFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // kiểm tra thư mục, nếu tồn tại thì lấy ra danh sách file

            DirectoryInfo myDir = new DirectoryInfo(@"C:\Windows"); // @ để chỉ rằng chuỗi đó ko có kí tự đặc biệt

            if (myDir.Exists)
            {
                DirectoryInfo[] files = myDir.GetDirectories();
                foreach(DirectoryInfo file in files)
                {
                    Console.WriteLine(file.FullName);
                }

            }
            else
            {
                Console.WriteLine("Directory is not exist.");
            }
        }
    }
}
