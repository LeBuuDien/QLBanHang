using QLSHOPQUANAO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSHOPQUANAO.BLL
{
    internal class DAO_NhapHang
    {
        ShopQuanAoDataContext SQA = new ShopQuanAoDataContext();

        public List<NHAPHANG> LoadNCC() => SQA.NHAPHANGs.Select(nc => nc).ToList();

        public bool addPNH(string MaNH, string MaNCC, string ngayNhap)
        {
            try
            {
                NHAPHANG nh = new NHAPHANG();

                nh.MANH = MaNH;
                nh.MACC = MaNCC;
                nh.NGAYNHAP = DateTime.Parse(ngayNhap);

                SQA.NHAPHANGs.InsertOnSubmit(nh);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deletePNH(string maNH)
        {
            try
            {
                NHAPHANG nh = SQA.NHAPHANGs.Where(n => n.MANH == maNH).FirstOrDefault();
                SQA.NHAPHANGs.DeleteOnSubmit(nh);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        //=========================================================
        ///chi tiet nhap hang
        ///
        public List<CHITIETNHAPHANG> LoadCTNH() => SQA.CHITIETNHAPHANGs.Select(nc => nc).ToList();

        public bool addCTNH(string MaNH, string MaSP, int SoLuong,int giaNhap)
        {
            try
            {
                CHITIETNHAPHANG ct = new CHITIETNHAPHANG();
                ct.MANH = MaNH;
                ct.MASP = MaSP;
                ct.SOLUONG = SoLuong;
                ct.GIANHAP = giaNhap;
                ct.TONGTIEN = giaNhap * SoLuong;


                SQA.CHITIETNHAPHANGs.InsertOnSubmit(ct);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deleteCTNH(string maNH,string maSP)
        {
            try
            {
               CHITIETNHAPHANG ct  = SQA.CHITIETNHAPHANGs.Where(n => n.MANH == maNH && n.MASP == maSP) .FirstOrDefault();
                SQA.CHITIETNHAPHANGs.DeleteOnSubmit(ct);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool updateCTNH(string MaNH, string MaSP, int SoLuong, int giaNhap)
        {
            try
            {
                CHITIETNHAPHANG ct = SQA.CHITIETNHAPHANGs.Where(n => n.MANH == MaNH && n.MASP == MaSP).FirstOrDefault();
                ct.SOLUONG = SoLuong;
                ct.GIANHAP = giaNhap;
                ct.TONGTIEN = giaNhap * SoLuong;

                SQA.CHITIETNHAPHANGs.InsertOnSubmit(ct);
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
