using Child_mg.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Child_mg
{
    public partial class addaccount : Form
    {
        public addaccount()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string name = tbten.Text;
            string phone = tbphone.Text;
            string username = tendangnhap.Text;
            string password = tbmatkhau.Text;
            int role = cbbrole.SelectedIndex;
            string address = tbdiachinha.Text;
            string gender = cbbgender.SelectedItem.ToString();
            string email = tbemail.Text;
            string identityid = tbidentity.Text;
            if (userController.Instance.checkphone(phone))
            {
                userController.Instance.addaccount(name, phone, username, password, address, gender, role, email, identityid);
                MessageBox.Show("Lưu tạo mới thành công!");

            }
            else { MessageBox.Show("Số điện thoại lỗi hoặt bị trùng !"); }
        }

        private void tbback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
