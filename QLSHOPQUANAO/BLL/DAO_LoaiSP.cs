using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSHOPQUANAO.DTO;

namespace QLSHOPQUANAO.BLL
{
    internal class DAO_LoaiSP
    {
        ShopQuanAoDataContext SQA = new ShopQuanAoDataContext();

        public List<LOAI> LoadLoai() => SQA.LOAIs.Select(L => L).ToList();
    }
}
