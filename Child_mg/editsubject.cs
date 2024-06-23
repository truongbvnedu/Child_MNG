using Child_mg.Models;
using Child_mg.Controllers;
namespace Child_mg
{
    public partial class editsubject : Form
    {
       
        public editsubject()
        {
            InitializeComponent();
        }
        #region method
        public void AddBiding()
        {
            tbid.DataBindings.Clear();
            tbname.DataBindings.Clear();
            tbstatus.DataBindings.Clear();
            tbid.DataBindings.Add(new Binding("Text", dgvdata.DataSource, "ID", true, DataSourceUpdateMode.Never));
            tbname.DataBindings.Add(new Binding("Text", dgvdata.DataSource, "name", true, DataSourceUpdateMode.Never));
            tbstatus.DataBindings.Add(new Binding("Text",dgvdata.DataSource,"status",true, DataSourceUpdateMode.Never));
        }
       
        #endregion
        #region events
        public void loaddata()
        {
            dgvdata.DataSource = subjectControlller.Instance.loaddata();

        }
        private void btadd_Click(object sender, EventArgs e)
        {
            Subject sb = new Subject() { Name = tbname.Text, Status = Convert.ToInt32(tbstatus.Text) };

            subjectControlller.Instance.addsubject(sb);
            loaddata();            
            AddBiding();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvdata.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            int status = Convert.ToInt32(tbstatus.Text);
            string name = tbname.Text;
            subjectControlller.Instance.editsubject(id,name,status);
            loaddata();
            AddBiding();
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvdata.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());

            subjectControlller.Instance.deletesubject(id);
            loaddata();
            AddBiding();
        }

        private void btview_Click(object sender, EventArgs e)
        {
            loaddata();
            AddBiding();
        }
        #endregion
    }
}
