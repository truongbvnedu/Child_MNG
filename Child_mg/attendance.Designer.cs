namespace Child_mg
{
    partial class attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendance));
            cbbclasses = new ComboBox();
            lbclass1 = new Label();
            dgvlistchild = new DataGridView();
            tbten1 = new TextBox();
            tbdiachinha1 = new TextBox();
            ldadress1 = new Label();
            lbbirthday1 = new Label();
            lbname1 = new Label();
            mtdate = new MaskedTextBox();
            cbbstatus = new ComboBox();
            label1 = new Label();
            tbsave = new Button();
            lbgender1 = new Label();
            tbgioitinh1 = new TextBox();
            tbid = new TextBox();
            label2 = new Label();
            tbback = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvlistchild).BeginInit();
            SuspendLayout();
            // 
            // cbbclasses
            // 
            cbbclasses.BackColor = Color.LightSalmon;
            cbbclasses.FormattingEnabled = true;
            cbbclasses.Location = new Point(134, 339);
            cbbclasses.Name = "cbbclasses";
            cbbclasses.Size = new Size(151, 28);
            cbbclasses.TabIndex = 97;
            cbbclasses.SelectedValueChanged += cbbclasses_SelectedValueChanged;
            // 
            // lbclass1
            // 
            lbclass1.AutoSize = true;
            lbclass1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbclass1.ForeColor = Color.Peru;
            lbclass1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbclass1.Location = new Point(12, 336);
            lbclass1.Name = "lbclass1";
            lbclass1.Size = new Size(96, 31);
            lbclass1.TabIndex = 96;
            lbclass1.Text = "Lớp học";
            // 
            // dgvlistchild
            // 
            dgvlistchild.BackgroundColor = Color.LightSalmon;
            dgvlistchild.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistchild.Location = new Point(12, 12);
            dgvlistchild.Name = "dgvlistchild";
            dgvlistchild.RowHeadersWidth = 51;
            dgvlistchild.Size = new Size(1217, 282);
            dgvlistchild.TabIndex = 98;
            // 
            // tbten1
            // 
            tbten1.BackColor = Color.LightSalmon;
            tbten1.Location = new Point(12, 434);
            tbten1.Name = "tbten1";
            tbten1.ReadOnly = true;
            tbten1.Size = new Size(239, 27);
            tbten1.TabIndex = 105;
            // 
            // tbdiachinha1
            // 
            tbdiachinha1.BackColor = Color.LightSalmon;
            tbdiachinha1.Location = new Point(436, 487);
            tbdiachinha1.Name = "tbdiachinha1";
            tbdiachinha1.ReadOnly = true;
            tbdiachinha1.Size = new Size(239, 27);
            tbdiachinha1.TabIndex = 104;
            // 
            // ldadress1
            // 
            ldadress1.AutoSize = true;
            ldadress1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ldadress1.ForeColor = Color.Peru;
            ldadress1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            ldadress1.Location = new Point(304, 481);
            ldadress1.Name = "ldadress1";
            ldadress1.Size = new Size(128, 31);
            ldadress1.TabIndex = 102;
            ldadress1.Text = "Địa chỉ nhà";
            // 
            // lbbirthday1
            // 
            lbbirthday1.AutoSize = true;
            lbbirthday1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbbirthday1.ForeColor = Color.Peru;
            lbbirthday1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbbirthday1.Location = new Point(304, 434);
            lbbirthday1.Name = "lbbirthday1";
            lbbirthday1.Size = new Size(116, 31);
            lbbirthday1.TabIndex = 101;
            lbbirthday1.Text = "Ngày sinh";
            // 
            // lbname1
            // 
            lbname1.AutoSize = true;
            lbname1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbname1.ForeColor = Color.Peru;
            lbname1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbname1.Location = new Point(12, 396);
            lbname1.Name = "lbname1";
            lbname1.Size = new Size(113, 31);
            lbname1.TabIndex = 99;
            lbname1.Text = "Họ và Tên";
            // 
            // mtdate
            // 
            mtdate.BackColor = Color.LightSalmon;
            mtdate.Location = new Point(436, 434);
            mtdate.Mask = "00/00/0000";
            mtdate.Name = "mtdate";
            mtdate.Size = new Size(141, 27);
            mtdate.TabIndex = 108;
            // 
            // cbbstatus
            // 
            cbbstatus.BackColor = Color.LightSalmon;
            cbbstatus.FormattingEnabled = true;
            cbbstatus.Items.AddRange(new object[] { "Có mặt", "Vắng" });
            cbbstatus.Location = new Point(436, 342);
            cbbstatus.Name = "cbbstatus";
            cbbstatus.Size = new Size(151, 28);
            cbbstatus.TabIndex = 110;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Peru;
            label1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label1.Location = new Point(304, 339);
            label1.Name = "label1";
            label1.Size = new Size(132, 31);
            label1.TabIndex = 109;
            label1.Text = "Điểm danh ";
            // 
            // tbsave
            // 
            tbsave.BackColor = Color.PapayaWhip;
            tbsave.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbsave.Location = new Point(731, 427);
            tbsave.Name = "tbsave";
            tbsave.Size = new Size(137, 48);
            tbsave.TabIndex = 111;
            tbsave.Text = "Lưu ";
            tbsave.UseVisualStyleBackColor = false;
            tbsave.Click += tbsave_Click;
            // 
            // lbgender1
            // 
            lbgender1.AutoSize = true;
            lbgender1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbgender1.ForeColor = Color.Peru;
            lbgender1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbgender1.Location = new Point(12, 476);
            lbgender1.Name = "lbgender1";
            lbgender1.Size = new Size(102, 31);
            lbgender1.TabIndex = 100;
            lbgender1.Text = "Giới tính";
            // 
            // tbgioitinh1
            // 
            tbgioitinh1.BackColor = Color.LightSalmon;
            tbgioitinh1.Location = new Point(144, 482);
            tbgioitinh1.Name = "tbgioitinh1";
            tbgioitinh1.ReadOnly = true;
            tbgioitinh1.Size = new Size(112, 27);
            tbgioitinh1.TabIndex = 103;
            // 
            // tbid
            // 
            tbid.BackColor = Color.LightSalmon;
            tbid.Location = new Point(436, 402);
            tbid.Name = "tbid";
            tbid.ReadOnly = true;
            tbid.Size = new Size(112, 27);
            tbid.TabIndex = 113;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Peru;
            label2.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label2.Location = new Point(304, 396);
            label2.Name = "label2";
            label2.Size = new Size(36, 31);
            label2.TabIndex = 112;
            label2.Text = "ID";
            // 
            // tbback
            // 
            tbback.BackColor = Color.PapayaWhip;
            tbback.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbback.Location = new Point(731, 487);
            tbback.Name = "tbback";
            tbback.Size = new Size(137, 48);
            tbback.TabIndex = 114;
            tbback.Text = "Trở về";
            tbback.UseVisualStyleBackColor = false;
            tbback.Click += tbback_Click;
            // 
            // attendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1241, 607);
            Controls.Add(tbback);
            Controls.Add(tbid);
            Controls.Add(label2);
            Controls.Add(tbsave);
            Controls.Add(cbbstatus);
            Controls.Add(label1);
            Controls.Add(mtdate);
            Controls.Add(tbten1);
            Controls.Add(tbdiachinha1);
            Controls.Add(tbgioitinh1);
            Controls.Add(ldadress1);
            Controls.Add(lbbirthday1);
            Controls.Add(lbgender1);
            Controls.Add(lbname1);
            Controls.Add(dgvlistchild);
            Controls.Add(cbbclasses);
            Controls.Add(lbclass1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "attendance";
            Text = "Điểm danh";
            ((System.ComponentModel.ISupportInitialize)dgvlistchild).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbclasses;
        private Label lbclass1;
        private DataGridView dgvlistchild;
        private TextBox tbten1;
        private TextBox tbdiachinha1;
        private Label ldadress1;
        private Label lbbirthday1;
        private Label lbname1;
        private MaskedTextBox mtdate;
        private ComboBox cbbstatus;
        private Label label1;
        private Button tbsave;
        private Label lbgender1;
        private TextBox tbgioitinh1;
        private TextBox tbid;
        private Label label2;
        private Button tbback;
    }
}