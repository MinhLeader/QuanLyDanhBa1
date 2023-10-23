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
    public partial class FrmLogIn : Form
    {
       // public int loggedInUserID;
        public FrmLogIn()
        {
            InitializeComponent();

        }
        
       

        private bool ValidateLogin(string username, string password)
        {
            // Kiểm tra tài khoản và mật khẩu cố định
            //if (username == "Minh6689" && password == "0000")
            //{
            //    return true;
            //}

            //return false;
            using (Model1 context = new Model1())
            {
                // Kiểm tra xem tên đăng nhập và mật khẩu có tồn tại trong cơ sở dữ liệu hay không
                Account user = context.Accounts.FirstOrDefault(a => a.Username == username && a.PasswordHash == password);

                return user != null;
            }
        }

       

        private void btnLog_Click_1(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPass.Text;

            // Kiểm tra thông tin đăng nhập tại đây (sử dụng Entity Framework)
            if (ValidateLogin(username, password))
            {
        //        loggedInUserID = 1;
                // Đăng nhập thành công, chuyển đến Form Danh Bạ
                frmDanhBaDark danhBaForm = new frmDanhBaDark();
                this.Hide();
                danhBaForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại.");
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            FrmSignUp signUpForm = new FrmSignUp();
            signUpForm.ShowDialog();
            

        }

        private void btnFaceBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang được phát triển", "Thông báo", MessageBoxButtons.OK);

        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang được phát triển", "Thông báo", MessageBoxButtons.OK);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
