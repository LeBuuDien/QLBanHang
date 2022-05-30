using QLSHOPQUANAO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSHOPQUANAO.BLL
{
    internal class DAO_SanPham
    {
        ShopQuanAoDataContext SQA = new ShopQuanAoDataContext();

        public List<SANPHAM> LoadSanPham() => SQA.SANPHAMs.Select(s => s).ToList();

        public bool addSanPham(string maSP,string MaLoai, string maCC,string tenSP,double giaBan,int size, string chatLieu,string mauSac,int soLuongTon,string moTa)
        {
            try
            {
                SANPHAM sp = new SANPHAM();
                sp.MASP = maSP;
                sp.MACC = maCC;
                sp.MALOAI = MaLoai;
                sp.TENSP = tenSP;
                sp.GIABAN = giaBan;
                sp.SIZE = size;
                sp.CHATLIEU = chatLieu;
                sp.MAUSAC = mauSac;
                sp.SOLUONGTON = soLuongTon;
                sp.MOTASP = moTa;

                SQA.SANPHAMs.InsertOnSubmit(sp);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool updateSP(string maSP, string MaLoai, string maCC, string tenSP, double giaBan, int size, string chatLieu, string mauSac, int soLuongTon, string moTa)
        {
            try
            {
                SANPHAM sp = SQA.SANPHAMs.Where(s => s.MASP == maSP).FirstOrDefault();
                sp.MACC = maCC;
                sp.MALOAI = MaLoai;
                sp.TENSP = tenSP;
                sp.GIABAN = giaBan;
                sp.SIZE = size;
                sp.CHATLIEU = chatLieu;
                sp.MAUSAC = mauSac;
                sp.SOLUONGTON = soLuongTon;
                sp.MOTASP = moTa;

                SQA.SANPHAMs.InsertOnSubmit(sp);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool deleteSP(string maSP)
        {
            try
            {
                SANPHAM sp = SQA.SANPHAMs.Where(s => s.MASP == maSP).FirstOrDefault();
                SQA.SANPHAMs.DeleteOnSubmit(sp);
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
