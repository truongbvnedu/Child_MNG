using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Child_mg
{
    partial class editinfomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editinfomation));
            dgvdata = new DataGridView();
            tbten1 = new TextBox();
            tbdiachinha1 = new TextBox();
            tbgioitinh1 = new TextBox();
            lbgv1 = new Label();
            ldadress1 = new Label();
            lbbirthday1 = new Label();
            lbgender1 = new Label();
            lbname1 = new Label();
            label1 = new Label();
            tbback = new Button();
            button1 = new Button();
            cbbidchild = new ComboBox();
            tbphone = new TextBox();
            label2 = new Label();
            tbcheckinfo = new Button();
            cbbteacher = new ComboBox();
            tbedit = new Button();
            mtdate = new MaskedTextBox();
            lbclass1 = new Label();
            cbbclasses = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // dgvdata
            // 
            dgvdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdata.BackgroundColor = Color.LightSalmon;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.GridColor = Color.LightSalmon;
            dgvdata.Location = new Point(12, 23);
            dgvdata.Name = "dgvdata";
            dgvdata.RowHeadersWidth = 51;
            dgvdata.Size = new Size(1312, 163);
            dgvdata.TabIndex = 0;
            // 
            // tbten1
            // 
            tbten1.BackColor = Color.LightSalmon;
            tbten1.Location = new Point(41, 400);
            tbten1.Name = "tbten1";
            tbten1.Size = new Size(239, 27);
            tbten1.TabIndex = 80;
            // 
            // tbdiachinha1
            // 
            tbdiachinha1.BackColor = Color.LightSalmon;
            tbdiachinha1.Location = new Point(173, 547);
            tbdiachinha1.Name = "tbdiachinha1";
            tbdiachinha1.Size = new Size(239, 27);
            tbdiachinha1.TabIndex = 77;
            // 
            // tbgioitinh1
            // 
            tbgioitinh1.BackColor = Color.LightSalmon;
            tbgioitinh1.Location = new Point(173, 453);
            tbgioitinh1.Name = "tbgioitinh1";
            tbgioitinh1.Size = new Size(112, 27);
            tbgioitinh1.TabIndex = 75;
            // 
            // lbgv1
            // 
            lbgv1.AutoSize = true;
            lbgv1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbgv1.ForeColor = Color.Peru;
            lbgv1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbgv1.Location = new Point(415, 422);
            lbgv1.Name = "lbgv1";
            lbgv1.Size = new Size(222, 31);
            lbgv1.TabIndex = 72;
            lbgv1.Text = "Giáo viên chủ nhiệm";
            // 
            // ldadress1
            // 
            ldadress1.AutoSize = true;
            ldadress1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ldadress1.ForeColor = Color.Peru;
            ldadress1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            ldadress1.Location = new Point(41, 541);
            ldadress1.Name = "ldadress1";
            ldadress1.Size = new Size(128, 31);
            ldadress1.TabIndex = 70;
            ldadress1.Text = "Địa chỉ nhà";
            // 
            // lbbirthday1
            // 
            lbbirthday1.AutoSize = true;
            lbbirthday1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbbirthday1.ForeColor = Color.Peru;
            lbbirthday1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbbirthday1.Location = new Point(41, 494);
            lbbirthday1.Name = "lbbirthday1";
            lbbirthday1.Size = new Size(116, 31);
            lbbirthday1.TabIndex = 69;
            lbbirthday1.Text = "Ngày sinh";
            // 
            // lbgender1
            // 
            lbgender1.AutoSize = true;
            lbgender1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbgender1.ForeColor = Color.Peru;
            lbgender1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbgender1.Location = new Point(41, 447);
            lbgender1.Name = "lbgender1";
            lbgender1.Size = new Size(102, 31);
            lbgender1.TabIndex = 68;
            lbgender1.Text = "Giới tính";
            // 
            // lbname1
            // 
            lbname1.AutoSize = true;
            lbname1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbname1.ForeColor = Color.Peru;
            lbname1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbname1.Location = new Point(41, 362);
            lbname1.Name = "lbname1";
            lbname1.Size = new Size(113, 31);
            lbname1.TabIndex = 66;
            lbname1.Text = "Họ và Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Peru;
            label1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label1.Location = new Point(41, 300);
            label1.Name = "label1";
            label1.Size = new Size(36, 31);
            label1.TabIndex = 83;
            label1.Text = "ID";
            // 
            // tbback
            // 
            tbback.BackColor = Color.PapayaWhip;
            tbback.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbback.Location = new Point(725, 531);
            tbback.Name = "tbback";
            tbback.Size = new Size(137, 48);
            tbback.TabIndex = 86;
            tbback.Text = "Trở về";
            tbback.UseVisualStyleBackColor = false;
            tbback.Click += tbback_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PapayaWhip;
            button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button1.Location = new Point(725, 472);
            button1.Name = "button1";
            button1.Size = new Size(137, 48);
            button1.TabIndex = 87;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbbidchild
            // 
            cbbidchild.BackColor = Color.LightSalmon;
            cbbidchild.FormattingEnabled = true;
            cbbidchild.Location = new Point(95, 303);
            cbbidchild.Name = "cbbidchild";
            cbbidchild.Size = new Size(151, 28);
            cbbidchild.TabIndex = 88;
            // 
            // tbphone
            // 
            tbphone.BackColor = Color.LightSalmon;
            tbphone.Location = new Point(372, 248);
            tbphone.Name = "tbphone";
            tbphone.Size = new Size(239, 27);
            tbphone.TabIndex = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Peru;
            label2.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label2.Location = new Point(41, 244);
            label2.Name = "label2";
            label2.Size = new Size(305, 31);
            label2.TabIndex = 89;
            label2.Text = "Số điện thoại của phụ huynh";
            // 
            // tbcheckinfo
            // 
            tbcheckinfo.BackColor = Color.PapayaWhip;
            tbcheckinfo.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbcheckinfo.Location = new Point(657, 227);
            tbcheckinfo.Name = "tbcheckinfo";
            tbcheckinfo.Size = new Size(137, 48);
            tbcheckinfo.TabIndex = 91;
            tbcheckinfo.Text = "Kiểm tra ";
            tbcheckinfo.UseVisualStyleBackColor = false;
            tbcheckinfo.Click += tbcheckinfo_Click;
            // 
            // cbbteacher
            // 
            cbbteacher.BackColor = Color.LightSalmon;
            cbbteacher.FormattingEnabled = true;
            cbbteacher.Location = new Point(415, 472);
            cbbteacher.Name = "cbbteacher";
            cbbteacher.Size = new Size(244, 28);
            cbbteacher.TabIndex = 92;
            // 
            // tbedit
            // 
            tbedit.BackColor = Color.PapayaWhip;
            tbedit.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbedit.Location = new Point(725, 400);
            tbedit.Name = "tbedit";
            tbedit.Size = new Size(137, 48);
            tbedit.TabIndex = 93;
            tbedit.Text = "Sửa";
            tbedit.UseVisualStyleBackColor = false;
            tbedit.Click += tbedit_Click;
            // 
            // mtdate
            // 
            mtdate.BackColor = Color.LightSalmon;
            mtdate.Location = new Point(173, 500);
            mtdate.Mask = "00/00/0000";
            mtdate.Name = "mtdate";
            mtdate.Size = new Size(141, 27);
            mtdate.TabIndex = 94;
            // 
            // lbclass1
            // 
            lbclass1.AutoSize = true;
            lbclass1.Font = new System.Drawing.Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbclass1.ForeColor = Color.Peru;
            lbclass1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbclass1.Location = new Point(415, 362);
            lbclass1.Name = "lbclass1";
            lbclass1.Size = new Size(96, 31);
            lbclass1.TabIndex = 71;
            lbclass1.Text = "Lớp học";
            // 
            // cbbclasses
            // 
            cbbclasses.BackColor = Color.LightSalmon;
            cbbclasses.FormattingEnabled = true;
            cbbclasses.Location = new Point(537, 365);
            cbbclasses.Name = "cbbclasses";
            cbbclasses.Size = new Size(151, 28);
            cbbclasses.TabIndex = 95;
            // 
            // editinfomation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1335, 676);
            Controls.Add(cbbclasses);
            Controls.Add(mtdate);
            Controls.Add(tbedit);
            Controls.Add(cbbteacher);
            Controls.Add(tbcheckinfo);
            Controls.Add(tbphone);
            Controls.Add(label2);
            Controls.Add(cbbidchild);
            Controls.Add(button1);
            Controls.Add(tbback);
            Controls.Add(label1);
            Controls.Add(tbten1);
            Controls.Add(tbdiachinha1);
            Controls.Add(tbgioitinh1);
            Controls.Add(lbgv1);
            Controls.Add(lbclass1);
            Controls.Add(ldadress1);
            Controls.Add(lbbirthday1);
            Controls.Add(lbgender1);
            Controls.Add(lbname1);
            Controls.Add(dgvdata);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "editinfomation";
            Text = "Chỉnh Sửa Thông Tin";
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvdata;
        private TextBox tbten1;
        private TextBox tbdiachinha1;
        private TextBox tbgioitinh1;
        private Label lbgv1;
        private Label ldadress1;
        private Label lbbirthday1;
        private Label lbgender1;
        private Label lbname1;
        private Label label1;
        private Button tbback;
        private Button button1;
        private ComboBox cbbidchild;
        private TextBox tbphone;
        private Label label2;
        private Button tbcheckinfo;
        private ComboBox cbbteacher;
        private Button tbedit;
        private MaskedTextBox mtdate;
        private Label lbclass1;
        private ComboBox cbbclasses;
    }
}