using System;
using System.IO;

namespace Bai_01_BinaryReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            // BinaryReadWrite : đọc ghi dạng nhị phân
            // thường đc sử dụng để ghi dữ liệu đc định kiểu

            string strA = "ABCD";
            byte byteA = 12;
            double doubleA = 11.23;

            // khởi tạo file, chú ý khi xong phải close nó mới save đc. Ngoài ra mới đọc và xóa file này đc.
            BinaryWriter bw = new BinaryWriter(new FileStream("data.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite));

            try
            {
                bw.Write(strA);
                bw.Write(byteA);
                bw.Write(doubleA);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            bw.Close();

            Console.WriteLine("Saved ok. Do you read file? y/n:");
            string choice = Console.ReadLine();

            if ("y".Equals(choice))
            {
                using(BinaryReader br = new BinaryReader(new FileStream("data.dat", FileMode.Open, FileAccess.Read)))
                {
                    // ở dạng đọc file nhị phân, ta có nhiều method để đọc theo kiểu của dạng truyền vào, ví dụ:
                    Console.WriteLine(br.ReadString());
                    Console.WriteLine(br.ReadByte());
                    Console.WriteLine(br.ReadDouble());
                }
            }
        }
    }
}
