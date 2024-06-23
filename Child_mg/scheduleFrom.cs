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

namespace Child_mg
{
    public partial class scheduleFrom : Form
    {
        string username, password;
        public scheduleFrom(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            loaddata();
        }

        public scheduleFrom()
        {
            InitializeComponent();
            loaddata();
        }
        public void addbiding()
        {
            cbbname.DataBindings.Clear();
            mtdate.DataBindings.Clear();
            dgvloadschedule.DataBindings.Clear();


        }
        public void loaddata()
        {
            List<ChildClassUserStructure> children = childController.Instance.LoadInformation(username, password);

            cbbname.DataSource = children;
            cbbname.DisplayMember = "ChildName";
            cbbname.ValueMember = "ChildId";

            string date =mtdate.Text;
            int idchild = Convert.ToInt32(cbbname.SelectedValue);
            dgvloadschedule.DataSource = childController.Instance.LoadSchedules(idchild,date);
            addbiding();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string date = mtdate.Text;
            int idchild = Convert.ToInt32(cbbname.SelectedValue);
            dgvloadschedule.DataSource = childController.Instance.LoadSchedules(idchild, date);

           
            dgvloadschedule.Columns["ClassName"].HeaderText = "Lớp Học";
            dgvloadschedule.Columns["TeacherName"].HeaderText = "Tên Giáo Viên";
            dgvloadschedule.Columns["Lesson"].HeaderText = "Tiết";
            dgvloadschedule.Columns["SubjectName"].HeaderText = "Môn Học";
            dgvloadschedule.Columns["Date"].HeaderText = "Ngày";


            dgvloadschedule.Columns["ChildName"].Visible = false;
            dgvloadschedule.Columns["ChildId"].Visible = false;
            dgvloadschedule.Columns["status"].Visible = false;
        }
    }
}
