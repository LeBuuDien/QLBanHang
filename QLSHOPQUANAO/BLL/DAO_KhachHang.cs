using QLSHOPQUANAO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSHOPQUANAO.BLL
{
    internal class DAO_KhachHang
    {
        ShopQuanAoDataContext SQA = new ShopQuanAoDataContext();

        public List<KHACH> LoadCustomer() => SQA.KHACHes.Select(c => c).ToList();

        public bool addCustomer(string maKH, string tenKH, string ngaySinh, string GioiTinh,string email, string diaChi, string sdt)
        {
            try
            {
                KHACH kHACH = new KHACH();
                kHACH.MAKH = maKH;
                kHACH.TENKH = tenKH;
                kHACH.NGAYSINH = DateTime.Parse(ngaySinh);
                kHACH.EMAIL = email;
                kHACH.GTINH = GioiTinh;
                kHACH.DCHI = diaChi;
                kHACH.SDT = sdt;


                SQA.KHACHes.InsertOnSubmit(kHACH);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool updatecustomer(string maKH, string tenKH, string ngaySinh, string GioiTinh, string email, string diaChi, string sdt)
        {
            try
            {
                KHACH kHACH = SQA.KHACHes.Where(k => k.MAKH == maKH).FirstOrDefault();
                kHACH.MAKH = maKH;
                kHACH.TENKH = tenKH;
                kHACH.NGAYSINH = DateTime.Parse(ngaySinh);
                kHACH.EMAIL = email;
                kHACH.GTINH = GioiTinh;
                kHACH.DCHI = diaChi;
                kHACH.SDT = sdt;

                SQA.KHACHes.InsertOnSubmit(kHACH);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool deleteCustomer(string maKH)
        {
            try
            {
                KHACH kHACH = SQA.KHACHes.Where(k => k.MAKH == maKH).FirstOrDefault();
                SQA.KHACHes.DeleteOnSubmit(kHACH);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
