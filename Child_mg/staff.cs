using Child_mg.Controllers;
using Child_mg.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Child_mg
{
    public partial class nhanvien : Form
    {
        string username, password;
        public nhanvien(string username,string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            loaddata();
        }
        public nhanvien()
        {
            InitializeComponent();
            loaddata();
        }
       
        public void loaddata()
        {
            User user = userController.Instance.loaddata(username, password);
            tbemail.Text = user.Email;
            tbgioitih1.Text = user.Gender;
            tbidentyti.Text = user.IdentityId;
            tbten1.Text = user.Name;
            tbdiachinha1.Text = user.Address;
            tbchucvu1.Text = "Nhân Viên";
            
         }

        private void btlaptk_Click(object sender, EventArgs e)
        {
            addaccount addaccount = new addaccount();
            this.Hide();
            addaccount.ShowDialog();
            this.Show();
        }

        private void btfixinfo1_Click(object sender, EventArgs e)
        {
            editinfomation eidtinfo = new editinfomation();
            this.Hide();
            eidtinfo.ShowDialog();
            this.Show();
        }
    }
}
