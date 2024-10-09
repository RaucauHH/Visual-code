using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace B5_Thread
{
    internal class Program
    {
        static int soNgauNhien = 0;
        static bool coSoNgauNhienMoi = false;
        static object khoa = new object(); // Đối tượng khóa để đồng bộ
        static void Main(string[] args)
        {
            // Tạo và khởi chạy hai thread
            Thread t1 = new Thread(SinhSoNgauNhien);
            Thread t2 = new Thread(TinhBinhPhuong);

            t1.Start();
            t2.Start();

            t1.Join(); // Chờ thread 1 kết thúc (nếu cần)
            t2.Join(); // Chờ thread 2 kết thúc (nếu cần)
        }
        static void SinhSoNgauNhien()
        {
            Random random = new Random();
            while (true)
            {
                lock (khoa)
                {
                    soNgauNhien = random.Next(1, 21); // Sinh số ngẫu nhiên từ 1 đến 20
                    coSoNgauNhienMoi = true; // Đánh dấu có số ngẫu nhiên mới
                    Console.WriteLine($"[Thread 1] Số ngẫu nhiên sinh ra: {soNgauNhien}");
                }
                Thread.Sleep(2000); // Dừng 2 giây
            }
        }

        static void TinhBinhPhuong()
        {
            while (true)
            {
                lock (khoa)
                {
                    if (coSoNgauNhienMoi)
                    {
                        int binhPhuong = soNgauNhien * soNgauNhien;
                        Console.WriteLine($"[Thread 2] Bình phương của {soNgauNhien} là: {binhPhuong}");
                        coSoNgauNhienMoi = false; // Đánh dấu đã xử lý số ngẫu nhiên
                    }
                }
                Thread.Sleep(100); // Dừng một chút để tránh tiêu tốn CPU
            }
        }
    }
}
