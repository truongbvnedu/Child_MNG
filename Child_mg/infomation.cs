using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using Child_mg.Controllers;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using static Child_mg.Controllers.childController;
using Child_mg.DTO;

namespace Child_mg
{

    public partial class infomation : Form
    {
        string username, password;

        public infomation(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            loaddata();
            addbiding();
        }
        public infomation()
        {
            InitializeComponent();
            loaddata();
            addbiding();
        }
        public void addbiding()
        {

            tbten1.DataBindings.Clear();
            tbdiachinha1.DataBindings.Clear();
            tbgioitinh1.DataBindings.Clear();
            tblophoc1.DataBindings.Clear();
            tbgiaovienchunhiem1.DataBindings.Clear();
            tbstatus.DataBindings.Clear();
            mtdate.DataBindings.Clear();
            tbcomment.DataBindings.Clear();

            tblophoc1.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "ClassName", true, DataSourceUpdateMode.Never));
            tbgiaovienchunhiem1.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "TeacherName", true, DataSourceUpdateMode.Never));
            mtdate.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "ChildDate", true, DataSourceUpdateMode.Never));
            tbten1.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "ChildName", true, DataSourceUpdateMode.Never));
            tbdiachinha1.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "UserAddress", true, DataSourceUpdateMode.Never));
            tbgioitinh1.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "ChildGender", true, DataSourceUpdateMode.Never));
            tbstatus.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "ChildStatus", true, DataSourceUpdateMode.Never));
            tbcomment.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "Comment", true, DataSourceUpdateMode.Never));


        }
        public void loaddata()
        {
            List<ChildClassUserStructure> children = childController.Instance.LoadInformation(username, password);

            cbbidchild.DataSource = children;
            cbbidchild.DisplayMember = "ID";
            cbbidchild.ValueMember = "ChildId";

        }

        private void bttkb1_Click(object sender, EventArgs e)
        {
            scheduleFrom schedule = new scheduleFrom(username,password);
            this.Hide();
            schedule.ShowDialog();
            this.Close();
        }
    }
}
