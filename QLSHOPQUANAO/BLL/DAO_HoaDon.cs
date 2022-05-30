using QLSHOPQUANAO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSHOPQUANAO.BLL
{
    internal class DAO_HoaDon
    {
        ShopQuanAoDataContext SQA = new ShopQuanAoDataContext();

        public List<HOADON> LoadSanPham() => SQA.HOADONs.Select(s => s).ToList();

        public bool addBill(string MaHD,string ngayLapHD,string maKH,string maNV)
        {
            try
            {
                HOADON bill = new HOADON();
                bill.MAHD = MaHD;
                bill.NGAYLAPHD = DateTime.Parse(ngayLapHD);
                bill.MAKH = maKH;
                bill.MANV = maNV;

                SQA.HOADONs.InsertOnSubmit(bill);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool updateBill(string MaHD, string ngayLapHD, string maKH, string maNV)
        {
            try
            {
                HOADON bill = SQA.HOADONs.Where(h => h.MAHD == MaHD).FirstOrDefault();
                bill.NGAYLAPHD = DateTime.Parse(ngayLapHD);
                bill.MAKH = maKH;
                bill.MANV = maNV;

                SQA.HOADONs.InsertOnSubmit(bill);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool deleteBill(string maHD)
        {
            try
            {
                HOADON bill = SQA.HOADONs.Where(h => h.MAHD == maHD).FirstOrDefault();
                SQA.HOADONs.DeleteOnSubmit(bill);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        
        ///Chi tiet hoa don
        ///
        ///
        public List<CHITIETHD> LoadCTHD() => SQA.CHITIETHDs.Select(s => s).ToList();

        public bool addBillInformation(string MaHD, string maSP,int soLuong, int giaBan,double tongTien)
        {
            try
            {
                CHITIETHD cthd = new CHITIETHD();
                cthd.MAHD = MaHD;
                cthd.MASP = maSP;
                cthd.SOLUONG = soLuong;
                cthd.GIABAN = giaBan;
                cthd.TONGTIEN = tongTien;

                SQA.CHITIETHDs.InsertOnSubmit(cthd);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool updateBillInformation(string MaHD, string maSP, int soLuong, int giaBan, double tongTien)
        {
            try
            {
                CHITIETHD cthd = SQA.CHITIETHDs.Where(ct => ct.MAHD == MaHD && ct.MASP == maSP).FirstOrDefault();
                cthd.SOLUONG = soLuong;
                cthd.GIABAN = giaBan;
                cthd.TONGTIEN = tongTien;

                SQA.CHITIETHDs.InsertOnSubmit(cthd);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool deleteBillInformation(string maHD,string maSP)
        {
            try
            {
                CHITIETHD cthd = SQA.CHITIETHDs.Where(ct => ct.MAHD == maHD && ct.MASP == maSP).FirstOrDefault();
                SQA.CHITIETHDs.DeleteOnSubmit(cthd);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        //load Gia SP
        public string loadGiaSP(string maSP)
        {
            string r = (from x in SQA.SANPHAMs where x.MASP == maSP select x.GIABAN).First().ToString();
            return r;
        }

    }
}
