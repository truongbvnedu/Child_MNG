using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Child_mg.Controllers;


namespace Child_mg
{
    public partial class QuenMK : Form
    {
        public static string to;
        public QuenMK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            userController.Instance.sendcode("test");


        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(tbcode.Text);
            string pass = tbpassword.Text;
            string confrorim = tbconfirmpass.Text;
            string username = tbusername.Text;
            userController.Instance.changepassword(username, pass, confrorim, code);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
