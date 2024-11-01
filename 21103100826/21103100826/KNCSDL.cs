using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace _21103100826
{
    public class KNCSDL
    {
        public SqlConnection conn;

        public void openConnect()
        {
            string sql = @"Data Source=DESKTOP-OR86VKF;Initial Catalog=QLBH_BT;Integrated Security=True";
            conn = new SqlConnection(sql); 
            conn.Open();
        }

        public void closeConnect()
        {
            conn.Close();
        }

        public SqlConnection getConnection()
        {
            return conn;
        }

        public DataTable danhSachKhachhang()
        {
            DataTable bang = new DataTable(); openConnect();
            string sql = "SELECT * FROM tblKhachHang";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader); 
            closeConnect(); 
            return bang;
        }

        public void themKhachhang(string maKH, string hoTen, string gioiTinh, string diaChi, string dienThoai)
        {
            openConnect();
            string sqlInsert = "INSERT INTO tblKhachHang VALUES(@MaKH, @HoTen, @GioiTinh, @DiaChi, @DienThoai)";
            SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn);
            cmdInsert.Parameters.AddWithValue("MaKH", maKH); 
            cmdInsert.Parameters.AddWithValue("HoTen", hoTen);
            cmdInsert.Parameters.AddWithValue("GioiTinh", gioiTinh);
            cmdInsert.Parameters.AddWithValue("DiaChi", diaChi);
            cmdInsert.Parameters.AddWithValue("DienThoai", dienThoai);
            cmdInsert.ExecuteNonQuery(); 
            closeConnect();
        }

        public void suaKhachhang(string hoTen, string gioiTinh, string diaChi, string dienThoai, string maKH)
        {
            openConnect();
            string sqlUpdate = "UPDATE tblKhachHang SET HoTen = @ht, GioiTinh = @gt, DiaChi = @dc, DienThoai = @dt WHERE MaKH = @makh";
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn); 
            cmd.Parameters.AddWithValue("ht", hoTen); 
            cmd.Parameters.AddWithValue("gt", gioiTinh); 
            cmd.Parameters.AddWithValue("dc", diaChi); 
            cmd.Parameters.AddWithValue("dt", dienThoai); 
            cmd.Parameters.AddWithValue("makh", maKH); 
            cmd.ExecuteNonQuery();
            closeConnect();
        }

        public void xoaKhachhang(string makh)
        {
            openConnect();
            string sql = "DELETE tblKhachHang WHERE MaKH = @ma"; 
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("ma", makh); cmd.ExecuteNonQuery();
            closeConnect();
        }

        public DataTable timKiemKhachhang(string makh)
        {
            openConnect();
            DataTable bang = new DataTable();
            string sqlTimkiem = "SELECT * FROM tblKhachHang WHERE MaKH = @ma";
            SqlCommand cmd = new SqlCommand(sqlTimkiem, conn); 
            cmd.Parameters.AddWithValue("ma", makh); 
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) 
            { 
                bang.Load(reader); 
            } 
            else bang = null;
            closeConnect(); return bang;
        }

        public Boolean kiemTraMaKhachhang(string maKH)
        {
            Boolean kiemTra = false; openConnect();
            string sql = "SELECT * FROM tblKhachHang WHERE MaKH = @maKh";
            SqlCommand cmd = new SqlCommand(sql, conn); 
            cmd.Parameters.AddWithValue("maKh", maKH); 
            SqlDataReader reader = cmd.ExecuteReader(); 
            if (reader.HasRows)
            {
                kiemTra = true;
            }
            closeConnect(); 
            return kiemTra;
        }
        //
        public DataTable danhSachMathang()
        {
            DataTable bang = new DataTable(); openConnect();
            string sql = "SELECT * FROM tblMatHang";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect(); return bang;
        }

        public void themMathang(string maMH, string tenMH, string dvt)
        {
            openConnect();
            string sqlInsert = "INSERT INTO tblMatHang VALUES(@MaMH, @TenMH, @DVT)";
            SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn); 
            cmdInsert.Parameters.AddWithValue("MaMH", maMH); 
            cmdInsert.Parameters.AddWithValue("TenMH", tenMH); 
            cmdInsert.Parameters.AddWithValue("DVT", dvt); 
            cmdInsert.ExecuteNonQuery();
            closeConnect();
        }

        public void suaMathang(string tenMh, string dvt, string maMh)
        {
            openConnect();
            string sqlUpdate = "UPDATE tblMatHang SET TenMH = @tenMh, DVT = @dvt WHERE MaMH = @maMh";
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn); 
            cmd.Parameters.AddWithValue("tenMh", tenMh); 
            cmd.Parameters.AddWithValue("dvt", dvt); 
            cmd.Parameters.AddWithValue("maMh", maMh); 
            cmd.ExecuteNonQuery();
            closeConnect();
        }

        public DataTable timKiemMathang(string maMh)
        {
            openConnect();
            DataTable bang = new DataTable();
            string sqlTimkiem = "SELECT * FROM tblMatHang WHERE MaMH = @ma";
            SqlCommand cmd = new SqlCommand(sqlTimkiem, conn); 
            cmd.Parameters.AddWithValue("ma", maMh); 
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) 
            { 
                bang.Load(reader); 
            } 
            else bang = null;
            closeConnect(); 
            return bang;
        }
        public void xoaMathang(string maMh)
        {
            openConnect();
            string sql = "DELETE tblMatHang WHERE MaMH = @ma";
            SqlCommand cmd = new SqlCommand(sql, conn); 
            cmd.Parameters.AddWithValue("ma", maMh); 
            cmd.ExecuteNonQuery();
            closeConnect();
        }

        public Boolean kiemTraMaMathang(string maMH)
        {
            Boolean kiemTra = false; openConnect();
            string sql = "SELECT * FROM tblMatHang WHERE MaMH = @maMh";
            SqlCommand cmd = new SqlCommand(sql, conn); 
            cmd.Parameters.AddWithValue("maMh", maMH); 
            SqlDataReader reader = cmd.ExecuteReader(); 
            if (reader.HasRows)
            {
                kiemTra = true;
            }
            closeConnect(); return kiemTra;
        }
        //
        public DataTable danhSachChitietMathang(string soHoadon)
        {
            DataTable bang = new DataTable(); openConnect();
            string sql = "SELECT * FROM tblChiTietBanHang WHERE SoHieuHD = @shd";
            SqlCommand cmd = new SqlCommand(sql, conn); 
            cmd.Parameters.AddWithValue("shd", soHoadon);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader); 
            closeConnect(); 
            return bang;
        }

        public Boolean kiemTraSoHoadon(string soHieuHoadon)
        {
            Boolean kiemTra = false; openConnect();
            string sql = "SELECT * FROM tblBanHang WHERE SoHieuHD = @sh";
            SqlCommand cmd = new SqlCommand(sql, conn); 
            cmd.Parameters.AddWithValue("sh", soHieuHoadon); 
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                kiemTra = true;
            }
            closeConnect(); 
            return kiemTra;
        }

        public void themBanhang(string soHieuHoadon, string maKH, DateTime ngayMua)
        {
            openConnect();
            string sql = "INSERT INTO tblBanHang VALUES(@SoHieuHD,@MaKH,@NgayMuaBan)";
            SqlCommand cmdBanhang = new SqlCommand(sql, conn); 
            cmdBanhang.Parameters.AddWithValue("SoHieuHD", soHieuHoadon); 
            cmdBanhang.Parameters.AddWithValue("MaKH", maKH); 
            cmdBanhang.Parameters.AddWithValue("NgayMuaBan", ngayMua);
            cmdBanhang.ExecuteNonQuery();
            closeConnect();
        }

        public void themChitietBanhang(string soHieuHoadon, string mamh, int soLuong, float donGia)
        {
            openConnect();
            string sql = "INSERT INTO tblChiTietBanHang VALUES(@SoHieuHD,@MaMH,@SoLuong,@DonGia)";
            SqlCommand cmdBanhang = new SqlCommand(sql, conn); 
            cmdBanhang.Parameters.AddWithValue("SoHieuHD", soHieuHoadon); 
            cmdBanhang.Parameters.AddWithValue("MaMH", mamh); 
            cmdBanhang.Parameters.AddWithValue("SoLuong", soLuong); 
            cmdBanhang.Parameters.AddWithValue("DonGia", donGia); 
            cmdBanhang.ExecuteNonQuery();
            closeConnect();
        }

        public void suaChitietBanhang(int soluong, float dongia, string mamh)
        {
            openConnect();
            string sql = "UPDATE tblChiTietBanHang SET SoLuong = @sl, DonGia = @dg where MaMH = @ma";
            SqlCommand cmd = new SqlCommand(sql, conn); 
            cmd.Parameters.AddWithValue("sl", soluong); 
            cmd.Parameters.AddWithValue("dg", dongia);
            cmd.Parameters.AddWithValue("ma", mamh); 
            cmd.ExecuteNonQuery();
            closeConnect();
        }

        public void xoaChitietBanHang(int sh, string mamh)
        {
            openConnect();
            string sql = "DELETE tblChiTietBanHang WHERE MaMH = @ma and SoHieuHD = @sh";
            SqlCommand cmd = new SqlCommand(sql, conn); 
            cmd.Parameters.AddWithValue("ma", mamh); 
            cmd.Parameters.AddWithValue("sh", sh); 
            cmd.ExecuteNonQuery();
            closeConnect();
        }



    }
}
