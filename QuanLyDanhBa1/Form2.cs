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
using System.Data.Entity;


namespace QuanLyDanhBa1
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {

        }

      
        private bool IsUsernameExists(string username)
        {
            using (Model1 context = new Model1())
            {
                return context.Accounts.Any(a => a.Username == username);
            }
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            string username = txtTK.Text;
            string password = txtMK.Text;
            string confirmPassword = txtMK2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                return;
            }

            // Kiểm tra xem tên đăng nhập đã tồn tại trong cơ sở dữ liệu hay chưa
            if (IsUsernameExists(username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                return;
            }

            // Lưu thông tin đăng ký vào cơ sở dữ liệu sử dụng Entity Framework
            using (Model1 context = new Model1())
            {
                Account newAccount = new Account
                {
                    Username = username,
                    PasswordHash = password
                };

                context.Accounts.Add(newAccount);
                context.SaveChanges();
            }

            MessageBox.Show("Đăng ký thành công!");
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
