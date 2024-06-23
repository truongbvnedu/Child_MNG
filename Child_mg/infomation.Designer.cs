using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace Child_mg
{
    partial class infomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infomation));
            button1 = new Button();
            btlogout = new Button();
            bttkb1 = new Button();
            panel1 = new Panel();
            lbgv1 = new Label();
            lbclass1 = new Label();
            lbbirthday1 = new Label();
            lbgender1 = new Label();
            lbname1 = new Label();
            pictureBox1 = new PictureBox();
            tbgioitinh1 = new TextBox();
            tblophoc1 = new TextBox();
            tbgiaovienchunhiem1 = new TextBox();
            tbten1 = new TextBox();
            cbbidchild = new ComboBox();
            ldadress1 = new Label();
            tbdiachinha1 = new TextBox();
            tbstatus = new TextBox();
            label1 = new Label();
            mtdate = new MaskedTextBox();
            label2 = new Label();
            tbcomment = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(26, 622);
            button1.Name = "button1";
            button1.Size = new Size(91, 71);
            button1.TabIndex = 55;
            button1.UseVisualStyleBackColor = true;
            // 
            // btlogout
            // 
            btlogout.BackColor = Color.PapayaWhip;
            btlogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btlogout.Location = new Point(460, 631);
            btlogout.Name = "btlogout";
            btlogout.Size = new Size(137, 48);
            btlogout.TabIndex = 53;
            btlogout.Text = "đăng xuất";
            btlogout.UseVisualStyleBackColor = false;
            // 
            // bttkb1
            // 
            bttkb1.BackColor = Color.Moccasin;
            bttkb1.Location = new Point(7, 52);
            bttkb1.Name = "bttkb1";
            bttkb1.Size = new Size(167, 42);
            bttkb1.TabIndex = 19;
            bttkb1.Text = "lịch học";
            bttkb1.UseVisualStyleBackColor = false;
            bttkb1.Click += bttkb1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            panel1.Controls.Add(bttkb1);
            panel1.Location = new Point(3, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 147);
            panel1.TabIndex = 52;
            // 
            // lbgv1
            // 
            lbgv1.AutoSize = true;
            lbgv1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbgv1.ForeColor = Color.Peru;
            lbgv1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbgv1.Location = new Point(226, 323);
            lbgv1.Name = "lbgv1";
            lbgv1.Size = new Size(222, 31);
            lbgv1.TabIndex = 50;
            lbgv1.Text = "Giáo viên chủ nhiệm";
            // 
            // lbclass1
            // 
            lbclass1.AutoSize = true;
            lbclass1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbclass1.ForeColor = Color.Peru;
            lbclass1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbclass1.Location = new Point(226, 275);
            lbclass1.Name = "lbclass1";
            lbclass1.Size = new Size(96, 31);
            lbclass1.TabIndex = 48;
            lbclass1.Text = "Lớp học";
            // 
            // lbbirthday1
            // 
            lbbirthday1.AutoSize = true;
            lbbirthday1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbbirthday1.ForeColor = Color.Peru;
            lbbirthday1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbbirthday1.Location = new Point(226, 188);
            lbbirthday1.Name = "lbbirthday1";
            lbbirthday1.Size = new Size(116, 31);
            lbbirthday1.TabIndex = 44;
            lbbirthday1.Text = "Ngày sinh";
            // 
            // lbgender1
            // 
            lbgender1.AutoSize = true;
            lbgender1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbgender1.ForeColor = Color.Peru;
            lbgender1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbgender1.Location = new Point(226, 141);
            lbgender1.Name = "lbgender1";
            lbgender1.Size = new Size(102, 31);
            lbgender1.TabIndex = 42;
            lbgender1.Text = "Giới tính";
            // 
            // lbname1
            // 
            lbname1.AutoSize = true;
            lbname1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbname1.ForeColor = Color.Peru;
            lbname1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbname1.Location = new Point(226, 61);
            lbname1.Name = "lbname1";
            lbname1.Size = new Size(113, 31);
            lbname1.TabIndex = 38;
            lbname1.Text = "Họ và Tên";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(26, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 167);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // tbgioitinh1
            // 
            tbgioitinh1.BackColor = Color.LightSalmon;
            tbgioitinh1.Location = new Point(358, 147);
            tbgioitinh1.Name = "tbgioitinh1";
            tbgioitinh1.ReadOnly = true;
            tbgioitinh1.Size = new Size(112, 27);
            tbgioitinh1.TabIndex = 59;
            // 
            // tblophoc1
            // 
            tblophoc1.BackColor = Color.LightSalmon;
            tblophoc1.Location = new Point(358, 279);
            tblophoc1.Name = "tblophoc1";
            tblophoc1.ReadOnly = true;
            tblophoc1.Size = new Size(112, 27);
            tblophoc1.TabIndex = 62;
            // 
            // tbgiaovienchunhiem1
            // 
            tbgiaovienchunhiem1.BackColor = Color.LightSalmon;
            tbgiaovienchunhiem1.Location = new Point(472, 325);
            tbgiaovienchunhiem1.Name = "tbgiaovienchunhiem1";
            tbgiaovienchunhiem1.ReadOnly = true;
            tbgiaovienchunhiem1.Size = new Size(172, 27);
            tbgiaovienchunhiem1.TabIndex = 63;
            // 
            // tbten1
            // 
            tbten1.BackColor = Color.LightSalmon;
            tbten1.Location = new Point(226, 99);
            tbten1.Name = "tbten1";
            tbten1.ReadOnly = true;
            tbten1.Size = new Size(239, 27);
            tbten1.TabIndex = 65;
            // 
            // cbbidchild
            // 
            cbbidchild.BackColor = Color.LightSalmon;
            cbbidchild.FormattingEnabled = true;
            cbbidchild.Location = new Point(26, 27);
            cbbidchild.Name = "cbbidchild";
            cbbidchild.Size = new Size(151, 28);
            cbbidchild.TabIndex = 66;
            // 
            // ldadress1
            // 
            ldadress1.AutoSize = true;
            ldadress1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ldadress1.ForeColor = Color.Peru;
            ldadress1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            ldadress1.Location = new Point(226, 234);
            ldadress1.Name = "ldadress1";
            ldadress1.Size = new Size(128, 31);
            ldadress1.TabIndex = 46;
            ldadress1.Text = "Địa chỉ nhà";
            // 
            // tbdiachinha1
            // 
            tbdiachinha1.BackColor = Color.LightSalmon;
            tbdiachinha1.Location = new Point(358, 240);
            tbdiachinha1.Name = "tbdiachinha1";
            tbdiachinha1.ReadOnly = true;
            tbdiachinha1.Size = new Size(239, 27);
            tbdiachinha1.TabIndex = 61;
            // 
            // tbstatus
            // 
            tbstatus.BackColor = Color.LightSalmon;
            tbstatus.Location = new Point(472, 375);
            tbstatus.Name = "tbstatus";
            tbstatus.ReadOnly = true;
            tbstatus.Size = new Size(172, 27);
            tbstatus.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Peru;
            label1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label1.Location = new Point(226, 373);
            label1.Name = "label1";
            label1.Size = new Size(206, 31);
            label1.TabIndex = 68;
            label1.Text = "Tình trạng trên lớp";
            // 
            // mtdate
            // 
            mtdate.BackColor = Color.LightSalmon;
            mtdate.Location = new Point(358, 188);
            mtdate.Mask = "00/00/0000";
            mtdate.Name = "mtdate";
            mtdate.ReadOnly = true;
            mtdate.Size = new Size(141, 27);
            mtdate.TabIndex = 95;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Peru;
            label2.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label2.Location = new Point(26, 403);
            label2.Name = "label2";
            label2.Size = new Size(216, 31);
            label2.TabIndex = 102;
            label2.Text = "Ý kiến của giáo viên";
            // 
            // tbcomment
            // 
            tbcomment.BackColor = Color.LightSalmon;
            tbcomment.Location = new Point(26, 448);
            tbcomment.Multiline = true;
            tbcomment.Name = "tbcomment";
            tbcomment.ReadOnly = true;
            tbcomment.ScrollBars = ScrollBars.Vertical;
            tbcomment.Size = new Size(618, 78);
            tbcomment.TabIndex = 101;
            // 
            // infomation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(656, 736);
            Controls.Add(label2);
            Controls.Add(tbcomment);
            Controls.Add(mtdate);
            Controls.Add(tbstatus);
            Controls.Add(label1);
            Controls.Add(cbbidchild);
            Controls.Add(tbten1);
            Controls.Add(tbgiaovienchunhiem1);
            Controls.Add(tblophoc1);
            Controls.Add(tbdiachinha1);
            Controls.Add(tbgioitinh1);
            Controls.Add(button1);
            Controls.Add(btlogout);
            Controls.Add(panel1);
            Controls.Add(lbgv1);
            Controls.Add(lbclass1);
            Controls.Add(ldadress1);
            Controls.Add(lbbirthday1);
            Controls.Add(lbgender1);
            Controls.Add(lbname1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "infomation";
            Text = "Thông Tin";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btlogout;
        private Button bttkb1;
        private Panel panel1;
        private Label lbgv1;
        private Label lbclass1;
        private Label lbbirthday1;
        private Label lbgender1;
        private Label lbname1;
        private PictureBox pictureBox1;
        private TextBox tbgioitinh1;
        private TextBox tblophoc1;
        private TextBox tbgiaovienchunhiem1;
        private TextBox tbten1;
        private ComboBox cbbidchild;
        private Label ldadress1;
        private TextBox tbdiachinha1;
        private TextBox tbstatus;
        private Label label1;
        private MaskedTextBox mtdate;
        private Label label2;
        private TextBox tbcomment;
    }
}