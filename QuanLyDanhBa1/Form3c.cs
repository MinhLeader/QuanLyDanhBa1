using QuanLyDanhBa1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDanhBa1
{
    public partial class frmDanhBaDark: Form
    {
        private List<NguoiDung> danhBaList;
        private bool isDarkMode = false;



        public frmDanhBaDark()
        {
            InitializeComponent();
            ApplyLightMode();
            //for (int i = 0; i < 100; i++)
            //{
            //    grid.Rows.Add(new object[] { });

            //}

        }


        private void frmDanhBaDark_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách danh bạ khi Form được tạo
            danhBaList = LoadDanhSachDanhBa();
            RefreshDataGridView();
            dataDanhBadark.Columns["UserID"].Visible = false;
            dataDanhBadark.Columns["Avatar"].Visible = false;
            dataDanhBadark.Columns["IsFavorite"].HeaderText = "Yêu Thích";
            dataDanhBadark.Columns["HoTen"].HeaderText = "Họ Tên";
            dataDanhBadark.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            
            dataDanhBadark.Columns["Note"].HeaderText = "Ghi Chú";



        }
        private List<NguoiDung> LoadDanhSachDanhBa()
        {

            using (Model1 context = new Model1())
            {

                // Sắp xếp bình thường
                //   var sortedDanhBa = context.NguoiDungs.OrderBy(contact => contact.HoTen).ToList(); 
                var danhBa = context.NguoiDungs.ToList();

                // Sắp xếp danh bạ: Yêu thích lên đầu, sau đó theo tên
                var sortedDanhBa = danhBa
                    .OrderByDescending(contact => contact.IsFavorite)
                    .ThenBy(contact => contact.HoTen)
                    .ToList();

                //// Cập nhật lại UserID dựa trên thứ tự sau khi sắp xếp
                //for (int i = 0; i < sortedDanhBa.Count; i++)
                //{
                //    sortedDanhBa[i].UserID = i + 1;
                //}


                return sortedDanhBa;
            }
        }
        private void RefreshDataGridView()
        {
                dataDanhBadark.DataSource = danhBaList;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmIn4 in4Form = new frmIn4();
            in4Form.isAddingNew = true;
            in4Form.ShowDialog();

            // Sau khi thêm liên hệ, cập nhật danh sách
            danhBaList = LoadDanhSachDanhBa();
            RefreshDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataDanhBadark.SelectedRows.Count > 0)
            {
                // Hộp thoại mesbox
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int userId = (int)dataDanhBadark.SelectedRows[0].Cells["UserID"].Value;

                    // Xóa liên hệ từ cơ sở dữ liệu sử dụng Entity Framework
                    using (Model1 context = new Model1())
                    {
                        var user = context.NguoiDungs.Find(userId);
                        if (user != null)
                        {
                            context.NguoiDungs.Remove(user);
                            context.SaveChanges();

                            // Sau khi xóa liên hệ, cập nhật danh sách
                            danhBaList = LoadDanhSachDanhBa();
                            RefreshDataGridView();
                        }
                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            using (Model1 context = new Model1())
            {
                // Tìm kiếm dựa trên tên hoặc số điện thoại
                danhBaList = context.NguoiDungs
                    .Where(user => user.HoTen.Contains(keyword) || user.SoDienThoai.Contains(keyword))
                    .ToList();
            }

            RefreshDataGridView();
        }

      
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Frm6c frm6C = new Frm6c();
            //frm6C.ShowDialog();
            //this.Close();
            ToggleDarkLightMode();
        }



        private void dataDanhBadark_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dataDanhBadark.Columns["IsFavorite"].Index && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataDanhBadark.Columns["IsFavorite"].Index && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                    if (e.Value != null && (bool)e.Value)
                    {
                        Image heartImage = Properties.Resources.heart; // Đảm bảo tên tài nguyên 'heart' đã được đặt chính xác.

                        // Lấy kích cỡ của ô cột
                        int cellWidth = e.CellBounds.Width;
                        int cellHeight = e.CellBounds.Height;

                        // Tính toán kích cỡ của biểu tượng trái tim (1/2 kích cỡ cột)
                        int iconWidth = cellWidth / 2;
                        int iconHeight = cellHeight / 2;

                        // Tính toán vị trí để căn giữa biểu tượng
                        int x = e.CellBounds.Left + (cellWidth - iconWidth) / 2;
                        int y = e.CellBounds.Top + (cellHeight - iconHeight) / 2;

                        // Vẽ biểu tượng trái tim với kích cỡ mong muốn và căn giữa
                        e.Graphics.DrawImage(heartImage, new Rectangle(x, y, iconWidth, iconHeight));
                    }

                    e.Handled = true;
                }
            }
        }
        private void ToggleDarkLightMode()
        {
            isDarkMode = !isDarkMode;
            if (isDarkMode)
            {
                ApplyDarkMode();
            }
            else
            {
                ApplyLightMode();
            }
        }

        private void ApplyDarkMode()
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            dataDanhBadark.BackgroundColor = Color.Black;
            dataDanhBadark.DefaultCellStyle.BackColor = Color.Black;
            dataDanhBadark.BackgroundColor = Color.Black;
            label1.ForeColor = Color.White;
            txtTimKiem.ForeColor = Color.White;
            panel2.BackColor = Color.White;
            // Thay đổi màu sắc của các yếu tố khác theo Dark Mode
        }

        private void ApplyLightMode()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            dataDanhBadark.BackgroundColor = Color.White;
            dataDanhBadark.DefaultCellStyle.BackColor = Color.White;
            dataDanhBadark.BackgroundColor = Color.White;
            label1.ForeColor = Color.Black;
            txtTimKiem.ForeColor = Color.Black;
            panel2.BackColor = Color.Black;

            // Thay đổi màu sắc của các yếu tố khác theo Light Mode
        }

        private void dataDanhBadark_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                int userId = (int)dataDanhBadark.Rows[e.RowIndex].Cells["UserID"].Value;
                frmIn4 in4Form = new frmIn4(userId);
                in4Form.isAddingNew = false;
                in4Form.ShowDialog();

                // Sau khi sửa liên hệ, cập nhật danh sách
                danhBaList = LoadDanhSachDanhBa();
                RefreshDataGridView();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát ứng dụng hay đăng xuất?        " +
                "Yes = Thoát , No = Đăng Xuất", "Xác nhận", MessageBoxButtons.YesNoCancel , MessageBoxIcon.Question);

            if (result == DialogResult.Yes) // Thoát ứng dụng
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)  // Đăng xuất
            {
                // Tạo và hiển thị màn hình đăng nhập (FrmLogIn)
                FrmLogIn loginForm = new FrmLogIn();
                loginForm.ShowDialog();

                // Đóng form hiện tại (frmDanhBaDark)
                this.Close();
            }
            else
            {

            }
            
        }
    }
}
    

