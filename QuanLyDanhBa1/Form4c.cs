using QuanLyDanhBa1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace QuanLyDanhBa1
{
    public partial class frmIn4: Form
    {
        private NguoiDung currentContact;
        public bool isAddingNew = true;
        private string avatarPath = ""; // Đường dẫn của hình ảnh
       
       

        public frmIn4(int userId = -1)
        {
            InitializeComponent();
            // Lưu trạng thái ban đầu của màu sắc
                    
           

            if (userId != -1)
            {
                // Load thông tin liên hệ từ cơ sở dữ liệu nếu có
                using (Model1 context = new Model1())
                {

                    currentContact = context.NguoiDungs.Find(userId);

                }
            }

        }

        private void Frm5c_Load(object sender, EventArgs e)
        {
            if (currentContact != null)
            {
                // Hiển thị thông tin liên hệ nếu tồn tại
                txtName.Text = currentContact.HoTen;
                txtNumber.Text = currentContact.SoDienThoai;
                txtEmail.Text = currentContact.Email;
                txtNote.Text = currentContact.Note;
                avatarPath = currentContact.Avatar; // Gán đường dẫn hình ảnh từ cơ sở dữ liệu
                if (!string.IsNullOrEmpty(avatarPath))
                {
                    pictureBox1.Image = Image.FromFile(avatarPath); // Hiển thị hình ảnh từ đường dẫn đã lưu
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (Model1 context = new Model1())
            {
                if (isAddingNew)
                {
                    // Thêm liên hệ mới vào cơ sở dữ liệu
                    NguoiDung existingContact = context.NguoiDungs.FirstOrDefault(c => c.HoTen == txtName.Text || c.SoDienThoai == txtNumber.Text);

                    if (existingContact != null)
                    {
                        MessageBox.Show("Tên hoặc số điện thoại đã tồn tại trong danh bạ.");
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtNumber.Text))
                        {
                            MessageBox.Show("Tên và số điện thoại không được bỏ trống.");
                        }
                        else
                        {
                            NguoiDung newContact = new NguoiDung
                            {
                                IsFavorite = chkFavorite.Checked,
                                HoTen = txtName.Text,
                                SoDienThoai = txtNumber.Text,
                                Email = txtEmail.Text,
                                Note = txtNote.Text,
                                Avatar = avatarPath
                            };

                            context.NguoiDungs.Add(newContact);
                            context.SaveChanges();

                            MessageBox.Show("Thêm liên hệ mới thành công!");
                        }
                    }
                }
                else
                {
                    // Chỉnh sửa liên hệ hiện có trong cơ sở dữ liệu
                    if (currentContact != null)
                    {
                        NguoiDung existingContact = context.NguoiDungs.FirstOrDefault(c => (c.HoTen == txtName.Text || c.SoDienThoai == txtNumber.Text) && c.UserID != currentContact.UserID);

                        if (existingContact != null)
                        {
                            MessageBox.Show("Tên hoặc số điện thoại đã tồn tại trong danh bạ.");
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtNumber.Text))
                            {
                                MessageBox.Show("Tên và số điện thoại không được bỏ trống.");
                            }
                            else
                            {
                                currentContact.IsFavorite = chkFavorite.Checked;
                                currentContact.HoTen = txtName.Text;
                                currentContact.SoDienThoai = txtNumber.Text;
                                currentContact.Email = txtEmail.Text;
                                currentContact.Note = txtNote.Text;
                                currentContact.Avatar = avatarPath;
                                context.Entry(currentContact).State = EntityState.Modified;
                                context.SaveChanges();

                                MessageBox.Show("Cập nhật thông tin thành công!");
                            }
                        }
                    }
                }
            }

            this.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    // Kiểm tra xem tệp đã chọn có phải là hình ảnh hay không.
                    if (IsImageFile(selectedImagePath))
                    {
                        avatarPath = selectedImagePath; // Gán đường dẫn hình ảnh
                        // Tải hình ảnh và hiển thị lên PictureBox
                        pictureBox1.Image = Image.FromFile(selectedImagePath);

                        // Lưu đường dẫn của hình ảnh vào biến hoặc cơ sở dữ liệu tùy thuộc vào nhu cầu của bạn.
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một tệp hình ảnh.");
                    }
                }
            }
        }
        private bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif" || extension == ".bmp";
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void btnDark_Click(object sender, EventArgs e)
        {
          
        }
    }
}
