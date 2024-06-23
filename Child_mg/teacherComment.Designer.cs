namespace Child_mg
{
    partial class teacherComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherComment));
            tbidentity = new TextBox();
            pictureBox2 = new PictureBox();
            cbbclass = new ComboBox();
            lbmajor = new Label();
            lbname1 = new Label();
            cbbnamechild = new ComboBox();
            tbcomment = new TextBox();
            label1 = new Label();
            mtdate = new MaskedTextBox();
            tbgioitinh1 = new TextBox();
            lbbirthday1 = new Label();
            lbgender1 = new Label();
            tbconfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tbidentity
            // 
            tbidentity.BackColor = Color.LightSalmon;
            tbidentity.Location = new Point(29, 27);
            tbidentity.Name = "tbidentity";
            tbidentity.ReadOnly = true;
            tbidentity.Size = new Size(176, 27);
            tbidentity.TabIndex = 87;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(29, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 156);
            pictureBox2.TabIndex = 86;
            pictureBox2.TabStop = false;
            // 
            // cbbclass
            // 
            cbbclass.BackColor = Color.LightSalmon;
            cbbclass.Location = new Point(211, 109);
            cbbclass.Name = "cbbclass";
            cbbclass.Size = new Size(151, 28);
            cbbclass.TabIndex = 95;
            cbbclass.SelectedValueChanged += cbbclass_SelectedValueChanged;
            // 
            // lbmajor
            // 
            lbmajor.AutoSize = true;
            lbmajor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbmajor.ForeColor = Color.Peru;
            lbmajor.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbmajor.Location = new Point(211, 61);
            lbmajor.Name = "lbmajor";
            lbmajor.Size = new Size(98, 31);
            lbmajor.TabIndex = 96;
            lbmajor.Text = "Lớp Dạy";
            // 
            // lbname1
            // 
            lbname1.AutoSize = true;
            lbname1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbname1.ForeColor = Color.Peru;
            lbname1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbname1.Location = new Point(211, 151);
            lbname1.Name = "lbname1";
            lbname1.Size = new Size(113, 31);
            lbname1.TabIndex = 97;
            lbname1.Text = "Họ và Tên";
            // 
            // cbbnamechild
            // 
            cbbnamechild.BackColor = Color.LightSalmon;
            cbbnamechild.Location = new Point(211, 197);
            cbbnamechild.Name = "cbbnamechild";
            cbbnamechild.Size = new Size(221, 28);
            cbbnamechild.TabIndex = 98;
            // 
            // tbcomment
            // 
            tbcomment.BackColor = Color.LightSalmon;
            tbcomment.Location = new Point(29, 366);
            tbcomment.Multiline = true;
            tbcomment.Name = "tbcomment";
            tbcomment.Size = new Size(771, 178);
            tbcomment.TabIndex = 99;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Peru;
            label1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label1.Location = new Point(29, 321);
            label1.Name = "label1";
            label1.Size = new Size(216, 31);
            label1.TabIndex = 100;
            label1.Text = "Ý kiến của giáo viên";
            // 
            // mtdate
            // 
            mtdate.BackColor = Color.LightSalmon;
            mtdate.Location = new Point(590, 198);
            mtdate.Mask = "00/00/0000";
            mtdate.Name = "mtdate";
            mtdate.Size = new Size(141, 27);
            mtdate.TabIndex = 104;
            // 
            // tbgioitinh1
            // 
            tbgioitinh1.BackColor = Color.LightSalmon;
            tbgioitinh1.Location = new Point(590, 157);
            tbgioitinh1.Name = "tbgioitinh1";
            tbgioitinh1.ReadOnly = true;
            tbgioitinh1.Size = new Size(112, 27);
            tbgioitinh1.TabIndex = 103;
            // 
            // lbbirthday1
            // 
            lbbirthday1.AutoSize = true;
            lbbirthday1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbbirthday1.ForeColor = Color.Peru;
            lbbirthday1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbbirthday1.Location = new Point(458, 198);
            lbbirthday1.Name = "lbbirthday1";
            lbbirthday1.Size = new Size(116, 31);
            lbbirthday1.TabIndex = 102;
            lbbirthday1.Text = "Ngày sinh";
            // 
            // lbgender1
            // 
            lbgender1.AutoSize = true;
            lbgender1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbgender1.ForeColor = Color.Peru;
            lbgender1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbgender1.Location = new Point(458, 151);
            lbgender1.Name = "lbgender1";
            lbgender1.Size = new Size(102, 31);
            lbgender1.TabIndex = 101;
            lbgender1.Text = "Giới tính";
            // 
            // tbconfirm
            // 
            tbconfirm.BackColor = Color.Moccasin;
            tbconfirm.Location = new Point(633, 319);
            tbconfirm.Name = "tbconfirm";
            tbconfirm.Size = new Size(167, 42);
            tbconfirm.TabIndex = 105;
            tbconfirm.Text = "xát nhận";
            tbconfirm.UseVisualStyleBackColor = false;
            tbconfirm.Click += tbconfirm_Click;
            // 
            // teacherComment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(842, 675);
            Controls.Add(tbconfirm);
            Controls.Add(mtdate);
            Controls.Add(tbgioitinh1);
            Controls.Add(lbbirthday1);
            Controls.Add(lbgender1);
            Controls.Add(label1);
            Controls.Add(tbcomment);
            Controls.Add(cbbnamechild);
            Controls.Add(lbname1);
            Controls.Add(lbmajor);
            Controls.Add(cbbclass);
            Controls.Add(tbidentity);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "teacherComment";
            Text = "Ý kiến của giáo viên";
            Load += teacherComment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbidentity;
        private PictureBox pictureBox2;
        private ComboBox cbbclass;
        private Label lbmajor;
        private Label lbname1;
        private ComboBox cbbnamechild;
        private TextBox tbcomment;
        private Label label1;
        private MaskedTextBox mtdate;
        private TextBox tbgioitinh1;
        private Label lbbirthday1;
        private Label lbgender1;
        private Button tbconfirm;
    }
}