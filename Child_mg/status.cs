using Child_mg.Controllers;

namespace Child_mg
{
    public partial class statust : Form
    {
        private DialogResult result;

        public statust()
        {
            InitializeComponent();

        }





        private void statust_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng suất khỏi chương trình ? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Show();
            
        }
      
    }
}
