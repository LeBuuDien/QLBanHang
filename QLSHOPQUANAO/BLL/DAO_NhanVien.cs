using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSHOPQUANAO.DTO;

namespace QLSHOPQUANAO.BLL
{
    internal class DAO_NhanVien
    {
        ShopQuanAoDataContext SQA = new ShopQuanAoDataContext();

        public List<NHANVIEN> LoadStaff() => SQA.NHANVIENs.Select(nv => nv).ToList();

        public bool addStaff( string maNV,string tenNV, string ChucVu,string ngaySinh, string GioiTinh, string diaChi, string sdt,string username,string password)
        {
            try
            {
                NHANVIEN staff = new NHANVIEN();
                staff.MANV = maNV;
                staff.TENNV=tenNV;
                staff.CHUCVU = ChucVu;
                staff.NGAYSINH = DateTime.Parse(ngaySinh);
                staff.GTINH = GioiTinh;
                staff.DCHI = diaChi;
                staff.SDT = sdt;
                staff.USERNAME = username;
                staff.PASSW = password;

                SQA.NHANVIENs.InsertOnSubmit(staff);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool updateStaff(string maNV, string tenNV, string ChucVu, string ngaySinh, string GioiTinh, string diaChi, string sdt, string username, string password)
        {
            try
            {
                NHANVIEN staff = SQA.NHANVIENs.Where(nv => nv.MANV == maNV).FirstOrDefault();
                staff.TENNV = tenNV;
                staff.CHUCVU = ChucVu;
                staff.NGAYSINH = DateTime.Parse(ngaySinh);
                staff.GTINH = GioiTinh;
                staff.DCHI = diaChi;
                staff.SDT = sdt;
                staff.USERNAME = username;
                staff.PASSW = password;

                SQA.NHANVIENs.InsertOnSubmit(staff);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool deleteStaff(string maNV)
        {
            try
            {
                NHANVIEN staff = SQA.NHANVIENs.Where(nv => nv.MANV == maNV).FirstOrDefault();
                SQA.NHANVIENs.DeleteOnSubmit(staff);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
