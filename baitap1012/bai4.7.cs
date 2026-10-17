using System;
using System.Linq;
using System.Windows.Forms;

namespace baitap1012
{
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Thiết lập Form chính là MDI Parent
        }

        // Sự kiện khi Form khởi chạy
        private void bai4_7_Load(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lblStatus.Text = "Sẵn sàng";
        }

        // Timer cập nhật đồng hồ mỗi 1 giây
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        #region THUẬT TOÁN QUẢN LÝ MỞ FORM CON (Yêu cầu Bài 4.7)
        /// <summary>
        /// Mở một Form con mới nếu chưa mở, hoặc Activate nếu đã mở (Không bị lặp Form)
        /// </summary>
        public void OpenOrActivateChildForm<T>() where T : Form, new()
        {
            Form childForm = this.MdiChildren.FirstOrDefault(f => f is T);

            if (childForm == null)
            {
                // Chưa mở -> Khởi tạo mới và gán MdiParent
                childForm = new T();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                // Đã mở -> Đưa cửa sổ đó lên trên cùng
                childForm.Activate();
            }
        }
        #endregion

        #region PHƯƠNG THỨC NHẬN THÔNG ĐIỆP TỪ FORM CON
        /// <summary>
        /// Cho phép Form con gọi tới để cập nhật StatusStrip của Form cha
        /// </summary>
        public void UpdateStatus(string message)
        {
            lblStatus.Text = message;
        }
        #endregion

        #region SỰ KIỆN MENU STRIP
        // Menu Hệ thống -> Đăng xuất
        private void mniLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form child in this.MdiChildren)
                {
                    child.Close(); // Đóng tất cả Form con đang mở
                }
                lblStatus.Text = "Đã đăng xuất.";
            }
        }

        // Menu Hệ thống -> Thoát
        private void mniExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Menu Danh mục -> Quản lý Sinh viên
        private void mniStudent_Click(object sender, EventArgs e)
        {
            OpenOrActivateChildForm<FormStudent>();
        }

        // Menu Danh mục -> Quản lý Sản phẩm
        private void mniProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Quản lý Sản phẩm đang được phát triển!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Menu Cửa sổ -> Sắp xếp
        private void mniCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mniTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mniTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        #endregion

        #region SỰ KIỆN TOOLSTRIP (NÚT BẤM NHANH)
        private void btnStudent_Click(object sender, EventArgs e)
        {
            mniStudent_Click(sender, e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            mniLogout_Click(sender, e);
        }
        #endregion

        private void bai4_Load(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lblStatus.Text = "Sẵn sàng";
        }
    }
}