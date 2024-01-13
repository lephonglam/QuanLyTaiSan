using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiSan
{
    public class SQLHelper
    {
        private static string taiKhoan;
        private static string matKhau;
        private static string phanQuyen;
        private static string hoTen;
        private static string maTS;
        private static string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["QuanLyTaiSan.Properties.Settings.QuanLyTaiSanConnectionString"].ToString();
        //public static string TaiKhoan { get { return taiKhoan; } set { taiKhoan = value; } }
        public static string TaiKhoan { get; set; }
        public static string MatKhau { get; set; }
        public static string PhanQuyen { get; set; }
        public static string Hoten { get; set; }
        public static string MaTS { get; set; }
        public static string ConnectString { get { return connectString; } }
    }
}
