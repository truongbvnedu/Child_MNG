using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace Child_mg
{
    partial class nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhanvien));
            button1 = new Button();
            btlogout = new Button();
            lbchucvu1 = new Label();
            ldadress1 = new Label();
            lbgender1 = new Label();
            btfixinfo1 = new Button();
            btxeptkb = new Button();
            btlaptk = new Button();
            panel1 = new Panel();
            lbname1 = new Label();
            pictureBox1 = new PictureBox();
            tbchucvu1 = new TextBox();
            tbdiachinha1 = new TextBox();
            tbgioitih1 = new TextBox();
            tbten1 = new TextBox();
            tbidentyti = new TextBox();
            tbemail = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(26, 614);
            button1.Name = "button1";
            button1.Size = new Size(91, 71);
            button1.TabIndex = 49;
            button1.UseVisualStyleBackColor = true;
            // 
            // btlogout
            // 
            btlogout.BackColor = Color.PapayaWhip;
            btlogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btlogout.Location = new Point(671, 623);
            btlogout.Name = "btlogout";
            btlogout.Size = new Size(137, 48);
            btlogout.TabIndex = 37;
            btlogout.Text = "đăng xuất";
            btlogout.UseVisualStyleBackColor = false;
            // 
            // lbchucvu1
            // 
            lbchucvu1.AutoSize = true;
            lbchucvu1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbchucvu1.ForeColor = Color.Peru;
            lbchucvu1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbchucvu1.Location = new Point(308, 229);
            lbchucvu1.Name = "lbchucvu1";
            lbchucvu1.Size = new Size(93, 31);
            lbchucvu1.TabIndex = 45;
            lbchucvu1.Text = "chức vụ";
            // 
            // ldadress1
            // 
            ldadress1.AutoSize = true;
            ldadress1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ldadress1.ForeColor = Color.Peru;
            ldadress1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            ldadress1.Location = new Point(308, 174);
            ldadress1.Name = "ldadress1";
            ldadress1.Size = new Size(128, 31);
            ldadress1.TabIndex = 43;
            ldadress1.Text = "Địa chỉ nhà";
            // 
            // lbgender1
            // 
            lbgender1.AutoSize = true;
            lbgender1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbgender1.ForeColor = Color.Peru;
            lbgender1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbgender1.Location = new Point(308, 116);
            lbgender1.Name = "lbgender1";
            lbgender1.Size = new Size(102, 31);
            lbgender1.TabIndex = 39;
            lbgender1.Text = "Giới tính";
            // 
            // btfixinfo1
            // 
            btfixinfo1.BackColor = Color.Moccasin;
            btfixinfo1.Location = new Point(16, 105);
            btfixinfo1.Name = "btfixinfo1";
            btfixinfo1.Size = new Size(167, 42);
            btfixinfo1.TabIndex = 20;
            btfixinfo1.Text = "chỉnh sửa thông tin";
            btfixinfo1.UseVisualStyleBackColor = false;
            btfixinfo1.Click += btfixinfo1_Click;
            // 
            // btxeptkb
            // 
            btxeptkb.BackColor = Color.Moccasin;
            btxeptkb.Location = new Point(16, 57);
            btxeptkb.Name = "btxeptkb";
            btxeptkb.Size = new Size(167, 42);
            btxeptkb.TabIndex = 19;
            btxeptkb.Text = "xếp lịch học";
            btxeptkb.UseVisualStyleBackColor = false;
            // 
            // btlaptk
            // 
            btlaptk.BackColor = Color.Moccasin;
            btlaptk.Location = new Point(16, 9);
            btlaptk.Name = "btlaptk";
            btlaptk.Size = new Size(167, 42);
            btlaptk.TabIndex = 18;
            btlaptk.Text = "lập tài khoản ";
            btlaptk.UseVisualStyleBackColor = false;
            btlaptk.Click += btlaptk_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            panel1.Controls.Add(btfixinfo1);
            panel1.Controls.Add(btxeptkb);
            panel1.Controls.Add(btlaptk);
            panel1.Location = new Point(26, 242);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 161);
            panel1.TabIndex = 48;
            // 
            // lbname1
            // 
            lbname1.AutoSize = true;
            lbname1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbname1.ForeColor = Color.Peru;
            lbname1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbname1.Location = new Point(308, 31);
            lbname1.Name = "lbname1";
            lbname1.Size = new Size(113, 31);
            lbname1.TabIndex = 34;
            lbname1.Text = "Họ và Tên";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(56, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 156);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // tbchucvu1
            // 
            tbchucvu1.BackColor = Color.LightSalmon;
            tbchucvu1.Location = new Point(469, 239);
            tbchucvu1.Name = "tbchucvu1";
            tbchucvu1.ReadOnly = true;
            tbchucvu1.Size = new Size(112, 27);
            tbchucvu1.TabIndex = 67;
            // 
            // tbdiachinha1
            // 
            tbdiachinha1.BackColor = Color.LightSalmon;
            tbdiachinha1.Location = new Point(469, 186);
            tbdiachinha1.Name = "tbdiachinha1";
            tbdiachinha1.ReadOnly = true;
            tbdiachinha1.Size = new Size(239, 27);
            tbdiachinha1.TabIndex = 66;
            // 
            // tbgioitih1
            // 
            tbgioitih1.BackColor = Color.LightSalmon;
            tbgioitih1.Location = new Point(469, 128);
            tbgioitih1.Name = "tbgioitih1";
            tbgioitih1.ReadOnly = true;
            tbgioitih1.Size = new Size(112, 27);
            tbgioitih1.TabIndex = 64;
            // 
            // tbten1
            // 
            tbten1.BackColor = Color.LightSalmon;
            tbten1.Location = new Point(308, 72);
            tbten1.Name = "tbten1";
            tbten1.ReadOnly = true;
            tbten1.Size = new Size(239, 27);
            tbten1.TabIndex = 68;
            // 
            // tbidentyti
            // 
            tbidentyti.BackColor = Color.LightSalmon;
            tbidentyti.Location = new Point(56, 31);
            tbidentyti.Name = "tbidentyti";
            tbidentyti.ReadOnly = true;
            tbidentyti.Size = new Size(209, 27);
            tbidentyti.TabIndex = 69;
            // 
            // tbemail
            // 
            tbemail.BackColor = Color.LightSalmon;
            tbemail.Location = new Point(469, 290);
            tbemail.Name = "tbemail";
            tbemail.ReadOnly = true;
            tbemail.Size = new Size(239, 27);
            tbemail.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Peru;
            label1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label1.Location = new Point(308, 280);
            label1.Name = "label1";
            label1.Size = new Size(70, 31);
            label1.TabIndex = 70;
            label1.Text = "Email";
            // 
            // nhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(844, 714);
            Controls.Add(tbemail);
            Controls.Add(label1);
            Controls.Add(tbidentyti);
            Controls.Add(tbten1);
            Controls.Add(tbchucvu1);
            Controls.Add(tbdiachinha1);
            Controls.Add(tbgioitih1);
            Controls.Add(button1);
            Controls.Add(btlogout);
            Controls.Add(lbchucvu1);
            Controls.Add(ldadress1);
            Controls.Add(lbgender1);
            Controls.Add(panel1);
            Controls.Add(lbname1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "nhanvien";
            Text = "Nhân Viên";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btlogout;
        private Label lbchucvu1;
        private Label ldadress1;
        private Label lbgender1;
        private Button btfixinfo1;
        private Button btxeptkb;
        private Button btlaptk;
        private Panel panel1;
        private Label lbname1;
        private PictureBox pictureBox1;
        private TextBox tbchucvu1;
        private TextBox tbdiachinha1;
        private TextBox tbgioitih1;
        private TextBox tbten1;
        private TextBox tbidentyti;
        private TextBox tbemail;
        private Label label1;
    }
}