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
    public partial class edirSchedule : Form
    {
        public edirSchedule()
        {
            InitializeComponent();
            loadlesson();
            loadstatus();
            loadsubject();
            loadclass();
            loadclassedit();


        }
        public void loadlesson()
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add("Tiết " + i.ToString());
            }
            cbblesson.DataSource = list;
        }
        public void loadstatus()
        {
            List<StatusDisValue> list = new List<StatusDisValue>();
            list.Add(new StatusDisValue { Display = "Đang Hoạt Động", Value = 0 });
            list.Add(new StatusDisValue { Display = "Bị hủy", Value = 1 });

            cbbstatus.DataSource = list;
            cbbstatus.DisplayMember = "Display";
            cbbstatus.ValueMember = "Value";
        }

        public void loadsubject()
        {
            cbbsubject.DataSource = subjectControlller.Instance.loadsubject();
            cbbsubject.DisplayMember = "Name";
            cbbsubject.ValueMember = "Id";
        }
        public void loadclass()
        {
            cbbclasses.DataSource = classController.Instance.loadclass();
            cbbclasses.DisplayMember = "Name";
            cbbclasses.ValueMember = "Id";
        }



        public void loadclassedit()
        {
            cbbclassedit.DataSource = classController.Instance.loadclass();
            cbbclassedit.DisplayMember = "Name";
            cbbclassedit.ValueMember = "Id";
        }

        public void addbiding()
        {
            dgvloadschedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvloadschedule.MultiSelect = false;

            cbbclassedit.DataBindings.Clear();
            cbblesson.DataBindings.Clear();
            cbbstatus.DataBindings.Clear();
            mtdate.DataBindings.Clear();
            cbbsubject.DataBindings.Clear();

            cbbstatus.DataBindings.Add(new Binding("Text", dgvloadschedule.DataSource, "status", true, DataSourceUpdateMode.Never));
            cbbsubject.DataBindings.Add(new Binding("Text", dgvloadschedule.DataSource, "SubjectName", true, DataSourceUpdateMode.Never));
            cbblesson.DataBindings.Add(new Binding("Text", dgvloadschedule.DataSource, "Lesson", true, DataSourceUpdateMode.Never));
            mtdate.DataBindings.Add(new Binding("Text", dgvloadschedule.DataSource, "Date", true, DataSourceUpdateMode.Never));
            cbbclassedit.DataBindings.Add(new Binding("Text", dgvloadschedule.DataSource, "ClassName", true, DataSourceUpdateMode.Never));

            dgvloadschedule.Columns["ClassName"].HeaderText = "Lớp Học";
            dgvloadschedule.Columns["Lesson"].HeaderText = "Tiết";
            dgvloadschedule.Columns["SubjectName"].HeaderText = "Môn Học";
            dgvloadschedule.Columns["Date"].HeaderText = "Ngày";
            dgvloadschedule.Columns["TeacherName"].HeaderText = "Tên Giáo Viên";

            dgvloadschedule.Columns["idschedule"].Visible = false;
            dgvloadschedule.Columns["idscheduleinfo"].Visible = false;
            dgvloadschedule.Columns["ChildName"].Visible = false;
            dgvloadschedule.Columns["ChildId"].Visible = false;
            dgvloadschedule.Columns["status"].Visible = false;
        }

        private void edirSchedule_Load(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            string date = mtdate.Text;
            int idclass = Convert.ToInt32(cbbclassedit.SelectedValue);
            int status = Convert.ToInt32(cbbstatus.SelectedValue);
            int subject = Convert.ToInt32(cbbsubject.SelectedValue);
            string lesson = cbblesson.SelectedValue.ToString();
            scheduleController.Instance.addtrueschedule(date, idclass, subject, lesson, status);


        }

        private void cbbclasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtdate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btfindschedule_Click(object sender, EventArgs e)
        {

            int idclass = Convert.ToInt32(cbbclasses.SelectedValue);
            string datefind = mtbdateforfind.Text;
            dgvloadschedule.DataSource = childController.Instance.loadscheduleforteacher(idclass, datefind);
            addbiding();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvloadschedule.SelectedRows[0];
            int idscheduleinfo = Convert.ToInt32(selectedRow.Cells["idscheduleinfo"].Value);
            scheduleController.Instance.deletelesson(idscheduleinfo);
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            dgvloadschedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvloadschedule.MultiSelect = false;
            if (dgvloadschedule.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn đầu tiên
                DataGridViewRow selectedRow = dgvloadschedule.SelectedRows[0];

                // Truy xuất các giá trị từ hàng được chọn
                string date = mtdate.Text;
                int idclass = Convert.ToInt32(cbbclassedit.SelectedValue);
                int status = Convert.ToInt32(cbbstatus.SelectedValue);
                int subject = Convert.ToInt32(cbbsubject.SelectedValue);
                string lesson = cbblesson.SelectedValue.ToString();
                int idschedule = Convert.ToInt32(selectedRow.Cells["idschedule"].Value);
                int idscheduleinfo   = Convert.ToInt32(selectedRow.Cells["idscheduleinfo"].Value);
                scheduleController.Instance.fixschedule(date, idclass, subject, status, idschedule, idscheduleinfo);
            }
            else
            {
                MessageBox.Show("chọn ô muốn sửa");
            }
        }
    }

}

