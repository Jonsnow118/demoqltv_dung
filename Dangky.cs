using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLTV_DUNG
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();   
        public bool checkAccount(string ac)//check ten mat khau
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string em) // kiểm tra định dạng email hợp lệ
        {
            return Regex.IsMatch(em, @"^[\w\.-]+@[a-zA-Z0-9-]+\.[a-zA-Z]{2,4}$");
        }
        private void btndangky_Click(object sender, EventArgs e)
        {
            string tentk = txttendangnhap.Text;
            string matkhat = txtmatkhau.Text;
            string xnmatkhau = txtnhaplaimatkhau.Text;
            string email = txtemail.Text;

            if (!checkAccount(tentk))
            {
                MessageBox.Show("Vui lòng nhập tài khoản dài 6-24 ký tự, với đủ chữ in hoa và in thường");
                return;
            }
            if (!checkAccount(matkhat)) // dùng đúng phương thức để kiểm tra mật khẩu
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, với đủ chữ in hoa và in thường");
                return;
            }
            if (xnmatkhau != matkhat)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác");
                return;
            }
            if (!checkEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email");
                return;
            }
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký email khác");
                return;
            }
            try
            {
                string query = "Insert into TaiKhoan values('" + tentk + "','" + matkhat + "','" + email + "')";
                modify.Command(query);
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng ký tài khoản khác!");
            }
        }

    }
}
