using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Child_mg.Controllers;


namespace Child_mg
{
    public partial class login : Form
    {


        public login()
        {
            InitializeComponent();
        }

        private void lb_login_Click(object sender, EventArgs e)
        {

        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text;
            string password = tbpassword.Text;
            if (decentralization_login(username, password) == 0)
            {
               
                infomation infomation = new infomation(username, password);
                this.Hide();
                infomation.ShowDialog();
                this.Show();
            }
            else if (decentralization_login(username, password) == 1)
            {
                nhanvien nhanvien = new nhanvien(username, password);
                this.Hide();
                nhanvien.ShowDialog();
                this.Show();
            }
            else if(decentralization_login(username,password) == 2)
            {
                giaovien giaovien = new giaovien(username, password);
                this.Hide();
                giaovien.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặt mật khẩu vui lòng kiểm tra lại !");
            }

        }



        private void btnquenmk_Click(object sender, EventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            this.Hide();
            quenMK.ShowDialog();
            this.Show();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng suất khỏi chương trình ? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
        }
        public int decentralization_login(string username, string password)
        {
            return userController.Instance.decentralization_login(username, password);
        }
    }

}

