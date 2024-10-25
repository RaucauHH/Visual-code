using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lap9
{
    internal class KNCSDL
    {
        SqlConnection conn;
        public void MoKN()
        {
            string sql = @"Data Source=DESKTOP-OR86VKF;Initial Catalog=QLBH_BT;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
        }

        public void DongKN()
        {
            conn.Close();
        }

        public DataTable getAllKH()
        {
            DataTable dt = new DataTable();
            MoKN();
            string sql = "select * from tblKhachHang";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);
            DongKN();
            return dt;
        }

        public bool TonTaiKH(string ma)
        {
            bool kt = false;
            MoKN();
            string sql = "select * from tblKhachHang where MaKH=@maKH";
            SqlCommand cm = new SqlCommand(sql, conn);
            cm.Parameters.AddWithValue("maKH", ma);
            SqlDataReader sdr = cm.ExecuteReader();
            if(sdr.HasRows) kt = true;
            DongKN();
            return kt;
        }

        public void ThemKH(string ma, string ten, string gioiTinh,string diaChi, string sdt)
        {
            MoKN();  // Mở kết nối

            string sql = "INSERT INTO tblKhachHang (MaKH, HoTen, GioiTinh, DiaChi, DienThoai) " +
                         "VALUES (@maKH, @tenKH, @gioiTinh, @diaChi, @sdt)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thêm các tham số cho câu lệnh SQL
            cmd.Parameters.AddWithValue("@maKH", ma);
            cmd.Parameters.AddWithValue("@tenKH", ten);
            cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("@diaChi", diaChi);
            cmd.Parameters.AddWithValue("@sdt", sdt);

            cmd.ExecuteNonQuery();  // Thực thi câu lệnh thêm

            DongKN();  // Đóng kết nối
        }


        public void XoaKH(string ma)
        {
            MoKN();
            string sql = "delete from tblKhachHang where MaKH = @maKH";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@maKH", ma);
            cmd.ExecuteNonQuery();
            DongKN() ;
        }
    }
}
