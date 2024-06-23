using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace Child_mg
{
    partial class giaovien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giaovien));
            button1 = new Button();
            btlogout = new Button();
            panel1 = new Panel();
            btnhanxet = new Button();
            bttkb1 = new Button();
            pictureBox2 = new PictureBox();
            tbten1 = new TextBox();
            tbchucvu1 = new TextBox();
            tbdiachinha1 = new TextBox();
            tbgioitih1 = new TextBox();
            lbchucvu1 = new Label();
            ldadress1 = new Label();
            lbgender1 = new Label();
            lbname1 = new Label();
            tbemail = new TextBox();
            label1 = new Label();
            tbidentity = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(13, 638);
            button1.Name = "button1";
            button1.Size = new Size(99, 73);
            button1.TabIndex = 69;
            button1.UseVisualStyleBackColor = true;
            // 
            // btlogout
            // 
            btlogout.BackColor = Color.PapayaWhip;
            btlogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btlogout.Location = new Point(661, 663);
            btlogout.Name = "btlogout";
            btlogout.Size = new Size(137, 48);
            btlogout.TabIndex = 68;
            btlogout.Text = "đăng xuất";
            btlogout.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            panel1.Controls.Add(btnhanxet);
            panel1.Controls.Add(bttkb1);
            panel1.Location = new Point(13, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 117);
            panel1.TabIndex = 65;
            // 
            // btnhanxet
            // 
            btnhanxet.BackColor = Color.Moccasin;
            btnhanxet.Location = new Point(16, 57);
            btnhanxet.Name = "btnhanxet";
            btnhanxet.Size = new Size(167, 42);
            btnhanxet.TabIndex = 19;
            btnhanxet.Text = "nhận xét";
            btnhanxet.UseVisualStyleBackColor = false;
            btnhanxet.Click += btnhanxet_Click;
            // 
            // bttkb1
            // 
            bttkb1.BackColor = Color.Moccasin;
            bttkb1.Location = new Point(16, 9);
            bttkb1.Name = "bttkb1";
            bttkb1.Size = new Size(167, 42);
            bttkb1.TabIndex = 18;
            bttkb1.Text = "xem lịch giảng dạy";
            bttkb1.UseVisualStyleBackColor = false;
            bttkb1.Click += bttkb1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(43, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 156);
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // tbten1
            // 
            tbten1.BackColor = Color.LightSalmon;
            tbten1.Location = new Point(238, 62);
            tbten1.Name = "tbten1";
            tbten1.ReadOnly = true;
            tbten1.Size = new Size(239, 27);
            tbten1.TabIndex = 81;
            // 
            // tbchucvu1
            // 
            tbchucvu1.BackColor = Color.LightSalmon;
            tbchucvu1.Location = new Point(472, 204);
            tbchucvu1.Name = "tbchucvu1";
            tbchucvu1.ReadOnly = true;
            tbchucvu1.Size = new Size(142, 27);
            tbchucvu1.TabIndex = 80;
            // 
            // tbdiachinha1
            // 
            tbdiachinha1.BackColor = Color.LightSalmon;
            tbdiachinha1.Location = new Point(472, 157);
            tbdiachinha1.Name = "tbdiachinha1";
            tbdiachinha1.ReadOnly = true;
            tbdiachinha1.Size = new Size(269, 27);
            tbdiachinha1.TabIndex = 79;
            // 
            // tbgioitih1
            // 
            tbgioitih1.BackColor = Color.LightSalmon;
            tbgioitih1.Location = new Point(472, 108);
            tbgioitih1.Name = "tbgioitih1";
            tbgioitih1.ReadOnly = true;
            tbgioitih1.Size = new Size(142, 27);
            tbgioitih1.TabIndex = 77;
            // 
            // lbchucvu1
            // 
            lbchucvu1.AutoSize = true;
            lbchucvu1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbchucvu1.ForeColor = Color.Peru;
            lbchucvu1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbchucvu1.Location = new Point(238, 206);
            lbchucvu1.Name = "lbchucvu1";
            lbchucvu1.Size = new Size(93, 31);
            lbchucvu1.TabIndex = 75;
            lbchucvu1.Text = "chức vụ";
            // 
            // ldadress1
            // 
            ldadress1.AutoSize = true;
            ldadress1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ldadress1.ForeColor = Color.Peru;
            ldadress1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            ldadress1.Location = new Point(238, 151);
            ldadress1.Name = "ldadress1";
            ldadress1.Size = new Size(128, 31);
            ldadress1.TabIndex = 74;
            ldadress1.Text = "Địa chỉ nhà";
            // 
            // lbgender1
            // 
            lbgender1.AutoSize = true;
            lbgender1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbgender1.ForeColor = Color.Peru;
            lbgender1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbgender1.Location = new Point(238, 102);
            lbgender1.Name = "lbgender1";
            lbgender1.Size = new Size(102, 31);
            lbgender1.TabIndex = 72;
            lbgender1.Text = "Giới tính";
            // 
            // lbname1
            // 
            lbname1.AutoSize = true;
            lbname1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbname1.ForeColor = Color.Peru;
            lbname1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbname1.Location = new Point(238, 21);
            lbname1.Name = "lbname1";
            lbname1.Size = new Size(113, 31);
            lbname1.TabIndex = 70;
            lbname1.Text = "Họ và Tên";
            // 
            // tbemail
            // 
            tbemail.BackColor = Color.LightSalmon;
            tbemail.Location = new Point(472, 269);
            tbemail.Name = "tbemail";
            tbemail.ReadOnly = true;
            tbemail.Size = new Size(142, 27);
            tbemail.TabIndex = 84;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Peru;
            label1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label1.Location = new Point(238, 263);
            label1.Name = "label1";
            label1.Size = new Size(70, 31);
            label1.TabIndex = 83;
            label1.Text = "Email";
            // 
            // tbidentity
            // 
            tbidentity.BackColor = Color.LightSalmon;
            tbidentity.Location = new Point(43, 21);
            tbidentity.Name = "tbidentity";
            tbidentity.ReadOnly = true;
            tbidentity.Size = new Size(176, 27);
            tbidentity.TabIndex = 85;
            // 
            // giaovien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(810, 723);
            Controls.Add(tbidentity);
            Controls.Add(tbemail);
            Controls.Add(label1);
            Controls.Add(tbten1);
            Controls.Add(tbchucvu1);
            Controls.Add(tbdiachinha1);
            Controls.Add(tbgioitih1);
            Controls.Add(lbchucvu1);
            Controls.Add(ldadress1);
            Controls.Add(lbgender1);
            Controls.Add(lbname1);
            Controls.Add(button1);
            Controls.Add(btlogout);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "giaovien";
            Text = "Giáo Viên";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btlogout;
        private Panel panel1;
        private Button btnhanxet;
        private Button bttkb1;
        private PictureBox pictureBox2;
        private TextBox tbten1;
        private TextBox tbchucvu1;
        private TextBox tbdiachinha1;
        private TextBox tbgioitih1;
        private Label lbchucvu1;
        private Label ldadress1;
        private Label lbgender1;
        private Label lbname1;
        private TextBox tbemail;
        private Label label1;
        private TextBox tbidentity;
    }
}