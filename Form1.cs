using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_DUNG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linklbl_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Quenmatkhau quenmatkhau = new Quenmatkhau();
            quenmatkhau.ShowDialog();
        }

        private void linklbl_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangky dangky = new Dangky(); 
            dangky.ShowDialog();
        }
        Modify modify = new Modify();
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string tenTK = txtbox_tentaikhoan.Text;
            string matK = txtbox_matkhau.Text;
            if(tenTK.Trim() == "")
            {
                MessageBox.Show("Vui long nhap ten tai khoan");
                return;
            }
            else if(matK.Trim()== "")
            {
                MessageBox.Show("Vui long nhap mat khau");
                return;
            }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tenTK + "' and MatKhau = '" + matK + "';";
                if (modify.TaiKhoans(query).Count > 0)
                {
                    MessageBox.Show("Dang nhap thanh cong!","Thong bao!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ten tai khoan hoac mat khau khong chinh xac!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


        }
    }
}
