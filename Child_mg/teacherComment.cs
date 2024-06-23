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
    public partial class teacherComment : Form
    {
        string username, password;
        public teacherComment(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            loaddata();
        }
        public teacherComment()
        {
            InitializeComponent();
            loaddata();
            addbiding();
        }

        public void addbiding()
        {
            cbbclass.DataBindings.Clear();
            cbbnamechild.DataBindings.Clear();
            tbidentity.DataBindings.Clear();
            tbgioitinh1.DataBindings.Clear();
            tbcomment.DataBindings.Clear();
            mtdate.DataBindings.Clear();

            tbgioitinh1.DataBindings.Add(new Binding("Text", cbbnamechild.DataSource, "gender", true, DataSourceUpdateMode.Never));
            mtdate.DataBindings.Add(new Binding("Text", cbbnamechild.DataSource, "Date", true, DataSourceUpdateMode.Never));
            tbcomment.DataBindings.Add(new Binding("Text", cbbnamechild.DataSource, "Comment", true, DataSourceUpdateMode.Never));
        }
        public void loaddata()
        {

            User user = userController.Instance.loaddata(username, password);
            tbidentity.Text = user.IdentityId;


            List<Class> list = childController.Instance.loadclassteacher(username, password);
            cbbclass.DataSource = list;
            cbbclass.DisplayMember = "Name";
            cbbclass.ValueMember = "Id";


            int idclass = Convert.ToInt32(cbbclass.SelectedValue);
            List<TeacherComment> members = childController.Instance.commentteacher(idclass);
            cbbnamechild.DataSource = members;
            cbbnamechild.DisplayMember = "ChildName";
            cbbnamechild.ValueMember = "idChild";

            addbiding();


        }

        private void cbbclass_SelectedValueChanged(object sender, EventArgs e)
        {



        }

        private void tbconfirm_Click(object sender, EventArgs e)
        {
            string commnet = tbcomment.Text;
            int idchild = Convert.ToInt32(cbbnamechild.SelectedValue);
            childController.Instance.commentsend(commnet, idchild);
        }

        private void teacherComment_Load(object sender, EventArgs e)
        {

        }
    }
}
