using Child_mg.Controllers;
using Child_mg.DTO;
using Child_mg.Models;
using System.Windows.Forms;

namespace Child_mg
{
    public partial class editinfomation : Form
    {
        public editinfomation()
        {
            InitializeComponent();
        }
        public void addbiding()
        {

            tbten1.DataBindings.Clear();
            tbdiachinha1.DataBindings.Clear();
            tbgioitinh1.DataBindings.Clear();
            cbbclasses.DataBindings.Clear();
            cbbteacher.DataBindings.Clear();
            mtdate.DataBindings.Clear();

            cbbclasses.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "ClassName", true, DataSourceUpdateMode.Never));
            cbbteacher.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "TeacherName", true, DataSourceUpdateMode.Never));
            mtdate.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "ChildDate", true, DataSourceUpdateMode.Never));
            tbten1.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "ChildName", true, DataSourceUpdateMode.Never));
            tbdiachinha1.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "UserAddress", true, DataSourceUpdateMode.Never));
            tbgioitinh1.DataBindings.Add(new Binding("Text", cbbidchild.DataSource, "ChildGender", true, DataSourceUpdateMode.Never));
        }
        public void loaddata()
        {
            string phoneuser = tbphone.Text;
            List<ChildClassUserStructure> children = childController.Instance.findchild(phoneuser);
            dgvdata.DataSource = children;
            List<User> teacherlist = userController.Instance.loadteaherlist();

            var classes = classController.Instance.loadclass();
            cbbclasses.DataSource = classes;
            cbbclasses.DisplayMember = "Name";
            cbbclasses.ValueMember = "Id";

            cbbteacher.DataSource = teacherlist;
            cbbteacher.DisplayMember = "Name";
            cbbteacher.ValueMember = "Name";

            cbbidchild.DataSource = children;
            cbbidchild.DisplayMember = "ID";
            cbbidchild.ValueMember = "ChildId";

            dgvdata.Columns["ClassId"].HeaderText = "Mã Lớp";
            dgvdata.Columns["ChildId"].HeaderText = "Mã Trẻ";
            dgvdata.Columns["ChildName"].HeaderText = "Tên Trẻ";
            dgvdata.Columns["ChildDate"].HeaderText = "Ngày Sinh";
            dgvdata.Columns["ChildStatus"].HeaderText = "Trạng Thái";
            dgvdata.Columns["ChildGender"].HeaderText = "Giới Tính";
            dgvdata.Columns["ClassName"].HeaderText = "Tên Lớp";
            dgvdata.Columns["TeacherName"].HeaderText = "Tên Giáo Viên";
            dgvdata.Columns["Parents"].HeaderText = "Tên Phụ Huynh";
            dgvdata.Columns["UserAddress"].HeaderText = "Địa Chỉ";

            dgvdata.Columns["phoneuser"].Visible = false;
            dgvdata.Columns["Parentsuser"].Visible = false;
            dgvdata.Columns["Parentspass"].Visible = false;
            addbiding();
        }

        private void tbcheckinfo_Click(object sender, EventArgs e)
        {
            if (tbphone.Text == "")
            {
                MessageBox.Show("hãy nhập số điện thoại ");
            }
            else
            {
                loaddata();
            }

        }

        private void tbedit_Click(object sender, EventArgs e)
        {
            string name = tbten1.Text;
            string gender = tbgioitinh1.Text;
            string address = tbdiachinha1.Text;
            string teacher = cbbteacher.SelectedValue.ToString();
            string date = mtdate.Text;
            int id = Convert.ToInt32(cbbidchild.SelectedValue);
            int classchild = Convert.ToInt32(cbbclasses.SelectedValue);
            adinfoController.Instance.editinfo(id, name, classchild, gender, address, date);
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbten1.Text;
            string gender = tbgioitinh1.Text;
            int idclass = Convert.ToInt32(cbbclasses.SelectedValue);
            string phone = tbphone.Text;
            childController.Instance.addchild(phone, name, gender, idclass);
        }

        private void tbback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

