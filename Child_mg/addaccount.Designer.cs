using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Child_mg
{
    partial class addaccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addaccount));
            lb3_login = new Label();
            lb2_login = new Label();
            lb_login = new Label();
            btn_login = new Button();
            tbmatkhau = new TextBox();
            tendangnhap = new TextBox();
            lbchuvu = new Label();
            tbten = new TextBox();
            tbdiachinha = new TextBox();
            ldadress1 = new Label();
            lbgender1 = new Label();
            lbname1 = new Label();
            cbbrole = new ComboBox();
            tbemail = new TextBox();
            tbphone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbbgender = new ComboBox();
            tbidentity = new TextBox();
            label3 = new Label();
            tbback = new Button();
            SuspendLayout();
            // 
            // lb3_login
            // 
            lb3_login.AutoSize = true;
            lb3_login.Font = new System.Drawing.Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb3_login.ForeColor = Color.Orchid;
            lb3_login.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lb3_login.Location = new Point(320, 29);
            lb3_login.Name = "lb3_login";
            lb3_login.Size = new Size(405, 62);
            lb3_login.TabIndex = 13;
            lb3_login.Text = "Preschool Nursery";
            // 
            // lb2_login
            // 
            lb2_login.AutoSize = true;
            lb2_login.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb2_login.ForeColor = Color.Peru;
            lb2_login.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lb2_login.Location = new Point(88, 249);
            lb2_login.Name = "lb2_login";
            lb2_login.Size = new Size(110, 31);
            lb2_login.TabIndex = 12;
            lb2_login.Text = "Mật khẩu";
            // 
            // lb_login
            // 
            lb_login.AutoSize = true;
            lb_login.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb_login.ForeColor = Color.Peru;
            lb_login.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lb_login.Location = new Point(88, 166);
            lb_login.Name = "lb_login";
            lb_login.Size = new Size(172, 31);
            lb_login.TabIndex = 11;
            lb_login.Text = "Tên đăng nhập ";
            // 
            // btn_login
            // 
            btn_login.BackgroundImageLayout = ImageLayout.Stretch;
            btn_login.ForeColor = SystemColors.ActiveBorder;
            btn_login.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            btn_login.Location = new Point(392, 511);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(167, 57);
            btn_login.TabIndex = 10;
            btn_login.Text = "Tạo mới";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // tbmatkhau
            // 
            tbmatkhau.BackColor = Color.LightSalmon;
            tbmatkhau.Location = new Point(88, 283);
            tbmatkhau.Name = "tbmatkhau";
            tbmatkhau.PasswordChar = '#';
            tbmatkhau.Size = new Size(305, 27);
            tbmatkhau.TabIndex = 9;
            // 
            // tendangnhap
            // 
            tendangnhap.BackColor = Color.LightSalmon;
            tendangnhap.Location = new Point(88, 200);
            tendangnhap.Name = "tendangnhap";
            tendangnhap.Size = new Size(305, 27);
            tendangnhap.TabIndex = 8;
            // 
            // lbchuvu
            // 
            lbchuvu.AutoSize = true;
            lbchuvu.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbchuvu.ForeColor = Color.Peru;
            lbchuvu.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbchuvu.Location = new Point(88, 328);
            lbchuvu.Name = "lbchuvu";
            lbchuvu.Size = new Size(96, 31);
            lbchuvu.TabIndex = 16;
            lbchuvu.Text = "Chức vụ";
            // 
            // tbten
            // 
            tbten.BackColor = Color.LightSalmon;
            tbten.Location = new Point(460, 204);
            tbten.Name = "tbten";
            tbten.Size = new Size(239, 27);
            tbten.TabIndex = 88;
            // 
            // tbdiachinha
            // 
            tbdiachinha.BackColor = Color.LightSalmon;
            tbdiachinha.Location = new Point(649, 253);
            tbdiachinha.Name = "tbdiachinha";
            tbdiachinha.Size = new Size(183, 27);
            tbdiachinha.TabIndex = 87;
            // 
            // ldadress1
            // 
            ldadress1.AutoSize = true;
            ldadress1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ldadress1.ForeColor = Color.Peru;
            ldadress1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            ldadress1.Location = new Point(460, 249);
            ldadress1.Name = "ldadress1";
            ldadress1.Size = new Size(128, 31);
            ldadress1.TabIndex = 84;
            ldadress1.Text = "Địa chỉ nhà";
            // 
            // lbgender1
            // 
            lbgender1.AutoSize = true;
            lbgender1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbgender1.ForeColor = Color.Peru;
            lbgender1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbgender1.Location = new Point(88, 406);
            lbgender1.Name = "lbgender1";
            lbgender1.Size = new Size(102, 31);
            lbgender1.TabIndex = 82;
            lbgender1.Text = "Giới tính";
            // 
            // lbname1
            // 
            lbname1.AutoSize = true;
            lbname1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbname1.ForeColor = Color.Peru;
            lbname1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbname1.Location = new Point(460, 166);
            lbname1.Name = "lbname1";
            lbname1.Size = new Size(113, 31);
            lbname1.TabIndex = 81;
            lbname1.Text = "Họ và Tên";
            // 
            // cbbrole
            // 
            cbbrole.BackColor = Color.LightSalmon;
            cbbrole.Items.AddRange(new object[] { "Phụ Huynh", "Nhân Viên", "Giáo Viên" });
            cbbrole.Location = new Point(88, 362);
            cbbrole.Name = "cbbrole";
            cbbrole.Size = new Size(151, 28);
            cbbrole.TabIndex = 89;
            // 
            // tbemail
            // 
            tbemail.BackColor = Color.LightSalmon;
            tbemail.Location = new Point(649, 354);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(239, 27);
            tbemail.TabIndex = 93;
            // 
            // tbphone
            // 
            tbphone.BackColor = Color.LightSalmon;
            tbphone.Location = new Point(649, 305);
            tbphone.Name = "tbphone";
            tbphone.Size = new Size(222, 27);
            tbphone.TabIndex = 92;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Peru;
            label1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label1.Location = new Point(460, 350);
            label1.Name = "label1";
            label1.Size = new Size(177, 31);
            label1.TabIndex = 91;
            label1.Text = "Hộp thư điện tử";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Peru;
            label2.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label2.Location = new Point(460, 303);
            label2.Name = "label2";
            label2.Size = new Size(146, 31);
            label2.TabIndex = 90;
            label2.Text = "số điện thoại";
            // 
            // cbbgender
            // 
            cbbgender.BackColor = Color.LightSalmon;
            cbbgender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbgender.Location = new Point(222, 410);
            cbbgender.Name = "cbbgender";
            cbbgender.Size = new Size(151, 28);
            cbbgender.TabIndex = 94;
            // 
            // tbidentity
            // 
            tbidentity.BackColor = Color.LightSalmon;
            tbidentity.Location = new Point(649, 406);
            tbidentity.Name = "tbidentity";
            tbidentity.Size = new Size(222, 27);
            tbidentity.TabIndex = 96;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.Peru;
            label3.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label3.Location = new Point(460, 404);
            label3.Name = "label3";
            label3.Size = new Size(70, 31);
            label3.TabIndex = 95;
            label3.Text = "CCCD";
            // 
            // tbback
            // 
            tbback.BackColor = Color.PapayaWhip;
            tbback.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbback.Location = new Point(903, 511);
            tbback.Name = "tbback";
            tbback.Size = new Size(137, 48);
            tbback.TabIndex = 97;
            tbback.Text = "Trở về";
            tbback.UseVisualStyleBackColor = false;
            tbback.Click += tbback_Click;
            // 
            // addaccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z5341720380969_1687c3ed07506d8a6ce1371da3a52a53;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1074, 617);
            Controls.Add(tbback);
            Controls.Add(tbidentity);
            Controls.Add(label3);
            Controls.Add(cbbgender);
            Controls.Add(tbemail);
            Controls.Add(tbphone);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cbbrole);
            Controls.Add(tbten);
            Controls.Add(tbdiachinha);
            Controls.Add(ldadress1);
            Controls.Add(lbgender1);
            Controls.Add(lbname1);
            Controls.Add(lbchuvu);
            Controls.Add(lb3_login);
            Controls.Add(lb2_login);
            Controls.Add(lb_login);
            Controls.Add(btn_login);
            Controls.Add(tbmatkhau);
            Controls.Add(tendangnhap);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "addaccount";
            Text = "Thêm Tài khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb3_login;
        private Label lb2_login;
        private Label lb_login;
        private Button btn_login;
        private TextBox tbmatkhau;
        private TextBox tendangnhap;
        private Label lbchuvu;
        private TextBox tbten;
        private TextBox tbdiachinha;
        private Label ldadress1;
        private Label lbgender1;
        private Label lbname1;
        private ComboBox cbbrole;
        private TextBox tbemail;
        private TextBox tbphone;
        private Label label1;
        private Label label2;
        private ComboBox cbbgender;
        private TextBox tbidentity;
        private Label label3;
        private Button tbback;
    }
}