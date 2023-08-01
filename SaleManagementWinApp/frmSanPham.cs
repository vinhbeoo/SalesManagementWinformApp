using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleManagementLibrraly.BussinessObject;
using SaleManagementLibrraly.Repository;

namespace SaleManagementWinApp
{
    public partial class frmSanPham : Form
    {
        IHangHoaRepository hangHoaRepository = new HangHoaRepository();
        BindingSource source;
        List<GioHang> list_GH;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadHangHoaList();
            list_GH = new List<GioHang>();
        }

        public void LoadHangHoaList()
        {
            var hangHoas = hangHoaRepository.GetHangHoas();
            try
            {
                source = new BindingSource();
                source.DataSource = hangHoas;

                dgvHangHoa.DataSource = null;
                dgvHangHoa.AutoGenerateColumns = false;
                dgvHangHoa.Columns.Clear();  // Xóa tất cả các cột hiện có trên DataGridView
                // Thêm cột ID và Tên vào DataGridView
                var maHangHoa = new DataGridViewTextBoxColumn();
                maHangHoa.DataPropertyName = "MaHangHoa";
                maHangHoa.HeaderText = "Mã Hàng hoá";
                dgvHangHoa.Columns.Add(maHangHoa);

                var tenHangHoa = new DataGridViewTextBoxColumn();
                tenHangHoa.DataPropertyName = "TenHangHoa";
                tenHangHoa.HeaderText = "Tên Hàng hoá";
                dgvHangHoa.Columns.Add(tenHangHoa);

                var soLuong = new DataGridViewTextBoxColumn();
                soLuong.DataPropertyName = "SoLuong";
                soLuong.HeaderText = "Số lượng";
                dgvHangHoa.Columns.Add(soLuong);

                var donGiaNhap = new DataGridViewTextBoxColumn();
                donGiaNhap.DataPropertyName = "DonGiaNhap";
                donGiaNhap.HeaderText = "Đơn giá nhập";
                dgvHangHoa.Columns.Add(donGiaNhap);

                var donGiaBan = new DataGridViewTextBoxColumn();
                donGiaBan.DataPropertyName = "DonGiaBan";
                donGiaBan.HeaderText = "Đơn giá bán";
                dgvHangHoa.Columns.Add(donGiaBan);

                var muaHang = new DataGridViewButtonColumn();
                muaHang.HeaderText = "Mua hàng";
                muaHang.Text = "Mua";
                muaHang.UseColumnTextForButtonValue = true;
                dgvHangHoa.Columns.Add(muaHang);
                // Ẩn cột Ảnh
                //dgvHangHoa.Columns[5].Visible = false;
                dgvHangHoa.DataSource = source;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void LoadGioHangList()
        {
            try
            {
                source = new BindingSource();
                source.DataSource = list_GH;
                dgvCart.DataSource = source;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã nhấn vào cột "Mua hàng" hay chưa
            if (e.ColumnIndex == dgvHangHoa.Columns[5].Index && e.RowIndex >= 0 && e.RowIndex < dgvHangHoa.Rows.Count - 1)
            {
                // Xử lý sự kiện mua hàng ở đây
                // Ví dụ: Lấy thông tin sản phẩm được chọn bằng cách sử dụng dgvHangHoa.Rows[e.RowIndex].DataBoundItem
                // và thực hiện xử lý mua hàng tương ứng
                DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];
                var MaHangHoa = Convert.ToInt32(row.Cells[0].Value);
                int SoLuong = 0;
                if (CheckCart(MaHangHoa))
                {
                    SoLuong = TinhTongSoLuongTheoMa(MaHangHoa) + 1;
                    CapNhatSoLuong(Convert.ToInt32(MaHangHoa), SoLuong);
                    LoadGioHangList();
                    return;
                }
                else
                {
                    SoLuong = 1;
                }
                var DonGia = row.Cells[4].Value;
                list_GH.Add(new GioHang
                {
                    MaHangHoa = Convert.ToInt32(MaHangHoa),
                    SoLuong = Convert.ToInt32(SoLuong),
                    DonGia = Convert.ToDecimal(DonGia)
                }
                );
                LoadGioHangList();
            }
        }

        public void CapNhatSoLuong(int maHangHoa, int soLuongMoi)
        {
            foreach (var gh in list_GH)
            {
                if (gh.MaHangHoa == maHangHoa)
                {
                    gh.SoLuong = soLuongMoi;
                    break;
                }
            }
        }

        public bool CheckCart(int maHangHoa)
        {
            return list_GH.Any(gh => gh.MaHangHoa == maHangHoa);
        }

        public int TinhTongSoLuongTheoMa(int maHangHoa)
        {
            return list_GH.Where(gh => gh.MaHangHoa == maHangHoa).Sum(gh => gh.SoLuong);
        }
    }
}
