using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiSan
{
    public class Functions
    {
        public static bool KiemTraSDT(string sdt)
        {
            int dt;
            if(int.TryParse(sdt, out dt) && sdt.Length == 10)
            {
                return true;
            }

            return false;
        }

        public static bool KTDinhDangSo(string number)
        {
            int num;
            if(int.TryParse(number, out num) && num > 0) {  return true; }
            return false;
        }

        //public static DateTime DinhDangNgay(string date)
        //{
        //    DateTime dateTime = DateTime.Parse(date);
        //    DateTime ngayDingDang = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
        //    return ngayDingDang;
        //}
    }
}
