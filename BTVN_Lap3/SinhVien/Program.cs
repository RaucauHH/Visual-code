using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    class Student
    {
        public string MaSoSinhVien { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string LopHoc { get; set; }

        public Student(string maSoSinhVien, string hoTen, int namSinh, string diaChi, string lopHoc)
        {
            MaSoSinhVien = maSoSinhVien;
            HoTen = hoTen;
            NamSinh = namSinh;
            DiaChi = diaChi;
            LopHoc = lopHoc;
        }

        public override string ToString()
        {
            return $"MSSV: {MaSoSinhVien}, Họ tên: {HoTen}, Năm sinh: {NamSinh}, Địa chỉ: {DiaChi}, Lớp: {LopHoc}";
        }
    }
    internal class Program
    {
        static ArrayList danhSachSinhVien = new ArrayList();
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n----- QUẢN LÝ SINH VIÊN -----");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Sửa sinh viên");
                Console.WriteLine("3. Xóa sinh viên");
                Console.WriteLine("4. Xuất số lượng sinh viên");
                Console.WriteLine("5. Xuất danh sách sinh viên theo lớp");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ThemSinhVien();
                        break;
                    case 2:
                        SuaSinhVien();
                        break;
                    case 3:
                        XoaSinhVien();
                        break;
                    case 4:
                        XuatSoLuongSinhVien();
                        break;
                    case 5:
                        XuatDanhSachSinhVienTheoLop();
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ!");
                        break;
                }
            } while (choice != 0);
        }
        static void ThemSinhVien()
        {
            Console.Write("Nhập mã số sinh viên: ");
            string maSo = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            int namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập địa chỉ: ");
            string diaChi = Console.ReadLine();
            Console.Write("Nhập lớp học: ");
            string lopHoc = Console.ReadLine();

            Student sv = new Student(maSo, hoTen, namSinh, diaChi, lopHoc);
            danhSachSinhVien.Add(sv);
            Console.WriteLine("Thêm sinh viên thành công!");
        }
        static void SuaSinhVien()
        {
            Console.Write("Nhập mã số sinh viên cần sửa: ");
            string maSo = Console.ReadLine();
            Student svSua = null;

            foreach (Student sv in danhSachSinhVien)
            {
                if (sv.MaSoSinhVien == maSo)
                {
                    svSua = sv;
                    break;
                }
            }

            if (svSua != null)
            {
                Console.Write("Nhập họ tên mới: ");
                svSua.HoTen = Console.ReadLine();
                Console.Write("Nhập năm sinh mới: ");
                svSua.NamSinh = int.Parse(Console.ReadLine());
                Console.Write("Nhập địa chỉ mới: ");
                svSua.DiaChi = Console.ReadLine();
                Console.Write("Nhập lớp học mới: ");
                svSua.LopHoc = Console.ReadLine();

                Console.WriteLine("Sửa thông tin sinh viên thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên với mã số sinh viên đã nhập!");
            }
        }
        static void XoaSinhVien()
        {
            Console.Write("Nhập mã số sinh viên cần xóa: ");
            string maSo = Console.ReadLine();
            Student svXoa = null;

            foreach (Student sv in danhSachSinhVien)
            {
                if (sv.MaSoSinhVien == maSo)
                {
                    svXoa = sv;
                    break;
                }
            }

            if (svXoa != null)
            {
                danhSachSinhVien.Remove(svXoa);
                Console.WriteLine("Xóa sinh viên thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên với mã số sinh viên đã nhập!");
            }
        }
        static void XuatSoLuongSinhVien()
        {
            Console.WriteLine($"Số lượng sinh viên hiện tại: {danhSachSinhVien.Count}");
        }
        static void XuatDanhSachSinhVienTheoLop()
        {
            Console.Write("Nhập tên lớp học: ");
            string lopHoc = Console.ReadLine();

            Console.WriteLine($"\nDanh sách sinh viên thuộc lớp {lopHoc}:");
            bool coSinhVien = false;
            foreach (Student sv in danhSachSinhVien)
            {
                if (sv.LopHoc == lopHoc)
                {
                    Console.WriteLine(sv);
                    coSinhVien = true;
                }
            }

            if (!coSinhVien)
            {
                Console.WriteLine("Không có sinh viên nào trong lớp này.");
            }
        }
    }
}
