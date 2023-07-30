using SaleManagementLibrraly.BussinessObject;
using SaleManagementLibrraly.Repository;

namespace SaleManagementWinApp
{
    public partial class frmLogin : Form
    {
        public INguoiDungRepository NguoiDungRepository { get; set; }
        INguoiDungRepository nguoiDungRepository = new NguoiDungRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                var nguoiDung = GetNguoiDungObject();
                var user = nguoiDungRepository.GetNguoiDungLogin(nguoiDung.TenDangNhap, nguoiDung.MatKhau);
                if (user != null)
                {
                    this.Visible = false;
                    if (MessageBox.Show("Đăng nhập thành công", "Thông báo") == DialogResult.OK)
                    {
                        frmMain fMain = new frmMain();
                        fMain.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private NguoiDung GetNguoiDungObject()
        {
            NguoiDung nguoiDung = null;
            try
            {
                nguoiDung = new NguoiDung
                {
                    TenDangNhap = txtDangNhap.Text,
                    MatKhau = txtMatKhau.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get car");
            }
            return nguoiDung;
        }
    }
}
