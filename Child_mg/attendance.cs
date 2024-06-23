using Child_mg.Controllers;
using Child_mg.DTO;
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

namespace Child_mg
{
    public partial class attendance : Form
    {
        public attendance()
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
            mtdate.DataBindings.Clear();
            cbbstatus.DataBindings.Clear();
            tbid.DataBindings.Clear();
            cbbclasses.DataBindings.Clear();

            cbbclasses.DataBindings.Add(new Binding("Text", dgvlistchild.DataSource, "ClassName", true, DataSourceUpdateMode.Never));
            tbid.DataBindings.Add(new Binding("Text", dgvlistchild.DataSource, "ChildId", true, DataSourceUpdateMode.Never));
            mtdate.DataBindings.Add(new Binding("Text", dgvlistchild.DataSource, "ChildDate", true, DataSourceUpdateMode.Never));
            tbdiachinha1.DataBindings.Add(new Binding("Text", dgvlistchild.DataSource, "UserAddress", true, DataSourceUpdateMode.Never));
            tbgioitinh1.DataBindings.Add(new Binding("Text", dgvlistchild.DataSource, "ChildGender", true, DataSourceUpdateMode.Never));
            tbten1.DataBindings.Add(new Binding("Text", dgvlistchild.DataSource, "ChildName", true, DataSourceUpdateMode.Never));



        }
        public void loaddata()
        {
            cbbclasses.DataSource = classController.Instance.loadclass();
            cbbclasses.DisplayMember = "Name";
            cbbclasses.ValueMember = "Name";
            string nameclass = cbbclasses.SelectedValue.ToString();
            List<ChildClassUserStructure> children = childController.Instance.childlist(nameclass);
            dgvlistchild.DataSource = children;
            dgvlistchild.Columns["ClassId"].HeaderText = "Mã Lớp";
            dgvlistchild.Columns["ChildId"].HeaderText = "Mã Trẻ";
            dgvlistchild.Columns["ChildName"].HeaderText = "Tên Trẻ";
            dgvlistchild.Columns["ChildDate"].HeaderText = "Ngày Sinh";
            dgvlistchild.Columns["ChildGender"].HeaderText = "Giới Tính";
            dgvlistchild.Columns["ClassName"].HeaderText = "Tên Lớp";
            dgvlistchild.Columns["UserAddress"].HeaderText = "Địa Chỉ";

            dgvlistchild.Columns["phoneuser"].Visible = false;
            dgvlistchild.Columns["Parentsuser"].Visible = false;
            dgvlistchild.Columns["Parentspass"].Visible = false;
            addbiding();
        }


        private void tbsave_Click(object sender, EventArgs e)
        {
            int childid = Convert.ToInt32(tbid.Text);
            int status = cbbstatus.SelectedIndex;
            childController.Instance.checkatten(childid, status);
            loaddata();
        }

        private void tbback_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void cbbclasses_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbclasses.SelectedValue != null)
            {
                string nameclass = cbbclasses.SelectedValue.ToString();
                List<ChildClassUserStructure> children = childController.Instance.childlist(nameclass);
                dgvlistchild.DataSource = children;
            }
        }

    }
}
