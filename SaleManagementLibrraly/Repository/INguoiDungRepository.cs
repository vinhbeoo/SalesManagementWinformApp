using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManagementLibrraly.BussinessObject;

namespace SaleManagementLibrraly.Repository
{
    public interface INguoiDungRepository
    {
        NguoiDung GetNguoiDungLogin(string TenDangNhap, string MatKhau);
    }
}
