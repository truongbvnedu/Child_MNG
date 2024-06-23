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
using Child_mg.Models;
using Child_mg.Controllers;

namespace Child_mg
{
    public partial class giaovien : Form
    {
        string username, password;
        public giaovien(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            loaddata();
        }
        public giaovien()
        {
            InitializeComponent();
            loaddata();
        }
        public void loaddata()
        {
            User user = userController.Instance.loaddata(username, password);
            tbdiachinha1.Text = user.Address;
            tbemail.Text = user.Email;
            tbgioitih1.Text = user.Gender;
            tbidentity.Text = user.IdentityId;
            tbten1.Text = user.Name;
            tbchucvu1.Text = "Giáo Viên";
        }

        private void btnhanxet_Click(object sender, EventArgs e)
        {
            teacherComment tch = new teacherComment(username, password);
            this.Hide();
            tch.ShowDialog();
            this.Show();
        }

        private void bttkb1_Click(object sender, EventArgs e)
        {
            scheduleteacher scheduleteacher = new scheduleteacher(username, password);
            this.Hide();
            scheduleteacher.ShowDialog();
            this.Show();
        }
    }
}
