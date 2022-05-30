using QLSHOPQUANAO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSHOPQUANAO.BLL
{
    internal class DAO_NhaCungCap
    {
        ShopQuanAoDataContext SQA = new ShopQuanAoDataContext();

        public List<NHACUNGCAP> LoadNCC() => SQA.NHACUNGCAPs.Select(nc => nc).ToList();

        public bool addNCC(string MaNCC,string tenNCC,string diaChi,string sdt)
        {
            try
            {
                NHACUNGCAP ncc = new NHACUNGCAP();

                ncc.MACC=MaNCC; ;
                ncc.TENNCC=tenNCC; 
                ncc.DCHI=diaChi;
                ncc.SDT=sdt;

                SQA.NHACUNGCAPs.InsertOnSubmit(ncc);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool updateNCC(string MaNCC, string tenNCC, string diaChi, string sdt)
        {
            try
            {
                NHACUNGCAP ncc = SQA.NHACUNGCAPs.Where(n => n.MACC == MaNCC).FirstOrDefault();
                ncc.TENNCC = tenNCC;
                ncc.DCHI = diaChi;
                ncc.SDT = sdt;

                SQA.NHACUNGCAPs.InsertOnSubmit(ncc);
                SQA.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool deleteNCC(string maNCC)
        {
            try
            {
                NHACUNGCAP ncc = SQA.NHACUNGCAPs.Where(n => n.MACC == maNCC).FirstOrDefault();
                SQA.NHACUNGCAPs.DeleteOnSubmit(ncc);
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
