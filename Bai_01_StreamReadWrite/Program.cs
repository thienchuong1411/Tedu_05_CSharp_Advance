using System;
using System.IO;
namespace Bai_01_StreamReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string input = Console.ReadLine();
            string filePath = "data.txt";

            // cách sử dụng cú pháp using, khởi tạo obj, khi ra ngoài khỏi using sẽ tự động hủy đối tượng này
            // nên dùng khối using cho đóng mở file hay kết nối db
            // go to definiition of StreamWriter để xem các constructor của nó như: có append hay ko? có unicode ko?
            using(StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(input);
            }

            Console.WriteLine("Your name was saved. Do you to read it? y/n:");
            string choice = Console.ReadLine();
            
            if("Y".Equals(choice) || "y".Equals(choice))
            {
                string data = string.Empty; // nên dùng cách này thay vì dùng string data = "" , vì nó sẽ ko khởi tạo vùng bộ nhớ
                using(StreamReader sr = new StreamReader(filePath))
                {
                    // khi đọc, nó sẽ đọc từng dòng 1
                    while((data = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(data);
                    }
                }
            }
        }
    }
}
