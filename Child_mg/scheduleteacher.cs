using Child_mg.Controllers;
using Child_mg.DTO;
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
    public partial class scheduleteacher : Form
    {
        string username, password;
        public scheduleteacher(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            loaddata();
        }
        public scheduleteacher()
        {
            InitializeComponent();
            loaddata();
        }
        public void addbiding()
        {
            cbbclass.DataBindings.Clear();
            mtdate.DataBindings.Clear();
            dgvloadschedule.DataBindings.Clear();

            cbbclass.DataBindings.Add(new Binding("Text", dgvloadschedule.DataSource, "ClassName", true, DataSourceUpdateMode.Never));
            mtdate.DataBindings.Add(new Binding("Text", dgvloadschedule.DataSource, "Date", true, DataSourceUpdateMode.Never));
        }
        public void loaddata()
        {
            List<ChildClassUserStructure> classteach = childController.Instance.loadclassteacherteach(username, password);

            cbbclass.DataSource = classteach;
            cbbclass.DisplayMember = "ClassName";
            cbbclass.ValueMember = "ClassId";

            string date = mtdate.Text;
            int idclass = Convert.ToInt32(cbbclass.SelectedValue);
            dgvloadschedule.DataSource = childController.Instance.loadscheduleforteacher(idclass, date);
            dgvloadschedule.Columns["ClassName"].HeaderText = "Lớp Học";
            dgvloadschedule.Columns["Lesson"].HeaderText = "Tiết";
            dgvloadschedule.Columns["SubjectName"].HeaderText = "Môn Học";
            dgvloadschedule.Columns["Date"].HeaderText = "Ngày";

            dgvloadschedule.Columns["TeacherName"].Visible = false;
            dgvloadschedule.Columns["ChildName"].Visible = false;
            dgvloadschedule.Columns["ChildId"].Visible = false;
            dgvloadschedule.Columns["status"].Visible = false;

        }

        private void btloadschedule_Click(object sender, EventArgs e)
        {
            string date = mtdate.Text;
            int idclass = Convert.ToInt32(cbbclass.SelectedValue);
            dgvloadschedule.DataSource = childController.Instance.loadscheduleforteacher(idclass, date);


            dgvloadschedule.Columns["ClassName"].HeaderText = "Lớp Học";
            dgvloadschedule.Columns["Lesson"].HeaderText = "Tiết";
            dgvloadschedule.Columns["SubjectName"].HeaderText = "Môn Học";
            dgvloadschedule.Columns["Date"].HeaderText = "Ngày";

            dgvloadschedule.Columns["TeacherName"].Visible = false;
            dgvloadschedule.Columns["ChildName"].Visible = false;
            dgvloadschedule.Columns["ChildId"].Visible = false;
            dgvloadschedule.Columns["status"].Visible = false;

        }
    }
}
