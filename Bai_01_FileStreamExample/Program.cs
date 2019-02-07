using System;
using System.IO;


namespace Bai_01_FileStreamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSteamEx01();
        }

        public static void FileSteamEx01()
        {
            // Open file or create file if not exist
            FileStream fileStream = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // ghi dữ liệu vào file, chạy vòng lập từ 1 đến 20 ghi vào
            for (int i = 1; i <= 20; i++)
            {
                // sử dụng WriteByte, truyền tham số đầu vào là kiểu byte để ghi
                fileStream.WriteByte((byte)i);  // i có kiểu int, dùng (byte) để ép kiểu
            }

            // Thông báo ghi thành công
            Console.WriteLine("Write success. File will writed in Debug folder that was builded");
            Console.WriteLine("Vi tri hien tai cua fileStream: {0}", fileStream.Position);

            // đọc dữ liệu từ file này. Chú ý, lúc này fileStream đang ở vị trí thứ 20, vì thế cần set nó lại vị trí 0 trước khi đọc
            fileStream.Position = 0;
            string data = "";
            for (int i = 0; i <= 20; i++)
            {
                //data = data + fileStream.ReadByte() + "\t"; // \\t là tab, có thể thay dấu \\t bằng khoảng trắng
                data = data + fileStream.ReadByte() + " ";
            }
            Console.Write(data);

            Console.ReadKey();
        }
    }
}
