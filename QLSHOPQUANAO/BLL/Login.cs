using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSHOPQUANAO.DTO;

namespace QLSHOPQUANAO.BLL
{
    internal class Login
    {
        ShopQuanAoDataContext shopQuanAoDataContext = new ShopQuanAoDataContext();

        public bool funtionLogin(string username, string password)
        {
            var q = (from p in shopQuanAoDataContext.NHANVIENs where p.USERNAME == username && p.PASSW == password select p);
            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkQuyen(string maNV)
        {
            string r = (from x in shopQuanAoDataContext.PHANQUYENs where x.MANV == maNV select x.LOAIQUYEN).First().ToString();
            if (r.Contains("Admin"))
            {
                return true;
            }
            return false;
        }
        public String getMANV(string un)
        {
            string r = (from x in shopQuanAoDataContext.NHANVIENs where x.USERNAME == un select x.MANV).First().ToString();
            return r;
        }
    }
}
