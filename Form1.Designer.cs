namespace QLTV_DUNG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbox_tentaikhoan = new System.Windows.Forms.TextBox();
            this.txtbox_matkhau = new System.Windows.Forms.TextBox();
            this.linklbl_quenmatkhau = new System.Windows.Forms.LinkLabel();
            this.linklbl_dangky = new System.Windows.Forms.LinkLabel();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_tentaikhoan
            // 
            this.txtbox_tentaikhoan.Location = new System.Drawing.Point(296, 246);
            this.txtbox_tentaikhoan.Name = "txtbox_tentaikhoan";
            this.txtbox_tentaikhoan.Size = new System.Drawing.Size(238, 22);
            this.txtbox_tentaikhoan.TabIndex = 3;
            // 
            // txtbox_matkhau
            // 
            this.txtbox_matkhau.Location = new System.Drawing.Point(296, 320);
            this.txtbox_matkhau.Name = "txtbox_matkhau";
            this.txtbox_matkhau.PasswordChar = '*';
            this.txtbox_matkhau.Size = new System.Drawing.Size(238, 22);
            this.txtbox_matkhau.TabIndex = 4;
            // 
            // linklbl_quenmatkhau
            // 
            this.linklbl_quenmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_quenmatkhau.Location = new System.Drawing.Point(212, 368);
            this.linklbl_quenmatkhau.Name = "linklbl_quenmatkhau";
            this.linklbl_quenmatkhau.Size = new System.Drawing.Size(141, 38);
            this.linklbl_quenmatkhau.TabIndex = 5;
            this.linklbl_quenmatkhau.TabStop = true;
            this.linklbl_quenmatkhau.Text = "Quên mật khẩu";
            this.linklbl_quenmatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_quenmatkhau_LinkClicked);
            // 
            // linklbl_dangky
            // 
            this.linklbl_dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_dangky.Location = new System.Drawing.Point(455, 368);
            this.linklbl_dangky.Name = "linklbl_dangky";
            this.linklbl_dangky.Size = new System.Drawing.Size(118, 38);
            this.linklbl_dangky.TabIndex = 6;
            this.linklbl_dangky.TabStop = true;
            this.linklbl_dangky.Text = "Đăng ký";
            this.linklbl_dangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_dangky_LinkClicked);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.Blue;
            this.btn_dangnhap.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_dangnhap.Location = new System.Drawing.Point(313, 397);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(149, 41);
            this.btn_dangnhap.TabIndex = 7;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLTV_DUNG.Properties.Resources.lovepik_lock_icon_png_image_401422837_wh860;
            this.pictureBox3.Location = new System.Drawing.Point(215, 303);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLTV_DUNG.Properties.Resources.istockphoto_1200064755_612x612;
            this.pictureBox2.Location = new System.Drawing.Point(215, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLTV_DUNG.Properties.Resources.customer_login_avatar_client_gray_head_portrait_269373_wh860;
            this.pictureBox1.Location = new System.Drawing.Point(216, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox_matkhau);
            this.Controls.Add(this.txtbox_tentaikhoan);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.linklbl_dangky);
            this.Controls.Add(this.linklbl_quenmatkhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtbox_tentaikhoan;
        private System.Windows.Forms.TextBox txtbox_matkhau;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linklbl_quenmatkhau;
        private System.Windows.Forms.LinkLabel linklbl_dangky;
        private System.Windows.Forms.Button btn_dangnhap;
    }
}

