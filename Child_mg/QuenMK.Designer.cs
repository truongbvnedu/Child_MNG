namespace Child_mg
{
    partial class QuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMK));
            lb3_login = new Label();
            lb_login = new Label();
            tbusername = new TextBox();
            tbcode = new TextBox();
            lb2_login = new Label();
            label1 = new Label();
            tbconfirmpass = new TextBox();
            label2 = new Label();
            tbpassword = new TextBox();
            btn_login = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lb3_login
            // 
            lb3_login.AutoSize = true;
            lb3_login.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb3_login.ForeColor = Color.Orchid;
            lb3_login.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lb3_login.Location = new Point(174, 37);
            lb3_login.Name = "lb3_login";
            lb3_login.Size = new Size(405, 62);
            lb3_login.TabIndex = 11;
            lb3_login.Text = "Preschool Nursery";
            // 
            // lb_login
            // 
            lb_login.AutoSize = true;
            lb_login.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb_login.ForeColor = Color.Peru;
            lb_login.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lb_login.Location = new Point(221, 159);
            lb_login.Name = "lb_login";
            lb_login.Size = new Size(168, 31);
            lb_login.TabIndex = 9;
            lb_login.Text = "Tên Đăng nhập";
            // 
            // tbusername
            // 
            tbusername.BackColor = Color.LightSalmon;
            tbusername.Location = new Point(221, 193);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(305, 27);
            tbusername.TabIndex = 7;
            // 
            // tbcode
            // 
            tbcode.BackColor = Color.LightSalmon;
            tbcode.Location = new Point(221, 275);
            tbcode.Name = "tbcode";
            tbcode.PasswordChar = '#';
            tbcode.Size = new Size(305, 27);
            tbcode.TabIndex = 8;
            // 
            // lb2_login
            // 
            lb2_login.AutoSize = true;
            lb2_login.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb2_login.ForeColor = Color.Peru;
            lb2_login.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lb2_login.Location = new Point(221, 241);
            lb2_login.Name = "lb2_login";
            lb2_login.Size = new Size(141, 31);
            lb2_login.TabIndex = 10;
            lb2_login.Text = "Mã xát nhận";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Peru;
            label1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label1.Location = new Point(221, 326);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 13;
            label1.Text = "Mật khẩu mới";
            // 
            // tbconfirmpass
            // 
            tbconfirmpass.BackColor = Color.LightSalmon;
            tbconfirmpass.Location = new Point(221, 438);
            tbconfirmpass.Name = "tbconfirmpass";
            tbconfirmpass.PasswordChar = '#';
            tbconfirmpass.Size = new Size(305, 27);
            tbconfirmpass.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Peru;
            label2.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label2.Location = new Point(221, 404);
            label2.Name = "label2";
            label2.Size = new Size(206, 31);
            label2.TabIndex = 15;
            label2.Text = "Nhập Lại mật khẩu";
            // 
            // tbpassword
            // 
            tbpassword.BackColor = Color.LightSalmon;
            tbpassword.Location = new Point(221, 360);
            tbpassword.Name = "tbpassword";
            tbpassword.PasswordChar = '#';
            tbpassword.Size = new Size(305, 27);
            tbpassword.TabIndex = 14;
            // 
            // btn_login
            // 
            btn_login.BackgroundImageLayout = ImageLayout.Stretch;
            btn_login.ForeColor = SystemColors.ActiveBorder;
            btn_login.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            btn_login.Location = new Point(163, 495);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(167, 57);
            btn_login.TabIndex = 16;
            btn_login.Text = "Đổi mật khẩu";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(424, 226);
            button1.Name = "button1";
            button1.Size = new Size(102, 43);
            button1.TabIndex = 17;
            button1.Text = "Mã Sát nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = SystemColors.ActiveBorder;
            button2.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            button2.Location = new Point(397, 495);
            button2.Name = "button2";
            button2.Size = new Size(167, 57);
            button2.TabIndex = 18;
            button2.Text = "Trở về";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // QuenMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z5341720380969_1687c3ed07506d8a6ce1371da3a52a53;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(777, 587);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(tbpassword);
            Controls.Add(label1);
            Controls.Add(tbconfirmpass);
            Controls.Add(lb3_login);
            Controls.Add(lb2_login);
            Controls.Add(lb_login);
            Controls.Add(tbcode);
            Controls.Add(tbusername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuenMK";
            Text = "Quên Mật Khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb3_login;
        private Label lb_login;
        private TextBox tbusername;
        private TextBox tbcode;
        private Label lb2_login;
        private Label label1;
        private TextBox tbconfirmpass;
        private Label label2;
        private TextBox tbpassword;
        private Button btn_login;
        private Button button1;
        private Button button2;
    }
}