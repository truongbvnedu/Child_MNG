using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace Child_mg
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            tbusername = new TextBox();
            tbpassword = new TextBox();
            btn_login = new Button();
            lb_login = new Label();
            lb2_login = new Label();
            lb3_login = new Label();
            btnquenmk = new Button();
            SuspendLayout();
            // 
            // tbusername
            // 
            tbusername.BackColor = SystemColors.Window;
            tbusername.Location = new Point(306, 214);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(305, 27);
            tbusername.TabIndex = 0;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(306, 308);
            tbpassword.Name = "tbpassword";
            tbpassword.PasswordChar = '#';
            tbpassword.Size = new Size(305, 27);
            tbpassword.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackgroundImageLayout = ImageLayout.Stretch;
            btn_login.ForeColor = SystemColors.ActiveBorder;
            btn_login.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            btn_login.Location = new Point(259, 376);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(167, 57);
            btn_login.TabIndex = 2;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // lb_login
            // 
            lb_login.AutoSize = true;
            lb_login.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb_login.ForeColor = Color.Peru;
            lb_login.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lb_login.Location = new Point(306, 180);
            lb_login.Name = "lb_login";
            lb_login.Size = new Size(172, 31);
            lb_login.TabIndex = 4;
            lb_login.Text = "Tên đăng nhập ";
            lb_login.Click += lb_login_Click;
            // 
            // lb2_login
            // 
            lb2_login.AutoSize = true;
            lb2_login.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb2_login.ForeColor = Color.Peru;
            lb2_login.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lb2_login.Location = new Point(306, 274);
            lb2_login.Name = "lb2_login";
            lb2_login.Size = new Size(110, 31);
            lb2_login.TabIndex = 5;
            lb2_login.Text = "Mật khẩu";
            // 
            // lb3_login
            // 
            lb3_login.AutoSize = true;
            lb3_login.Font = new System.Drawing.Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb3_login.ForeColor = Color.Orchid;
            lb3_login.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lb3_login.Location = new Point(259, 58);
            lb3_login.Name = "lb3_login";
            lb3_login.Size = new Size(405, 62);
            lb3_login.TabIndex = 6;
            lb3_login.Text = "Preschool Nursery";
            // 
            // btnquenmk
            // 
            btnquenmk.BackgroundImageLayout = ImageLayout.Stretch;
            btnquenmk.ForeColor = SystemColors.ActiveBorder;
            btnquenmk.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            btnquenmk.Location = new Point(497, 376);
            btnquenmk.Name = "btnquenmk";
            btnquenmk.Size = new Size(167, 57);
            btnquenmk.TabIndex = 7;
            btnquenmk.Text = "Quên mật khẩu";
            btnquenmk.UseVisualStyleBackColor = true;
            btnquenmk.Click += btnquenmk_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z5341720380969_1687c3ed07506d8a6ce1371da3a52a53;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(950, 514);
            Controls.Add(btnquenmk);
            Controls.Add(lb3_login);
            Controls.Add(lb2_login);
            Controls.Add(lb_login);
            Controls.Add(btn_login);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "login";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Đăng nhập ";
            FormClosing += login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_login;
        private Label lb_login;
        private Label lb2_login;
        private Label lb3_login;
        private Button btnquenmk;
        private TextBox tbusername;
        private TextBox tbpassword;
    }
}