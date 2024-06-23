namespace Child_mg
{
    partial class edirSchedule
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
            cbbclasses = new ComboBox();
            lbclass1 = new Label();
            dgvloadschedule = new DataGridView();
            label1 = new Label();
            mtdate = new MaskedTextBox();
            cbblesson = new ComboBox();
            label2 = new Label();
            cbbsubject = new ComboBox();
            label3 = new Label();
            cbbstatus = new ComboBox();
            label4 = new Label();
            btedit = new Button();
            tbback = new Button();
            btadd = new Button();
            btdelete = new Button();
            label5 = new Label();
            mtbdateforfind = new MaskedTextBox();
            btfindschedule = new Button();
            cbbclassedit = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvloadschedule).BeginInit();
            SuspendLayout();
            // 
            // cbbclasses
            // 
            cbbclasses.BackColor = Color.LightSalmon;
            cbbclasses.FormattingEnabled = true;
            cbbclasses.Location = new Point(156, 47);
            cbbclasses.Name = "cbbclasses";
            cbbclasses.Size = new Size(151, 28);
            cbbclasses.TabIndex = 97;
            cbbclasses.SelectedIndexChanged += cbbclasses_SelectedIndexChanged;
            // 
            // lbclass1
            // 
            lbclass1.AutoSize = true;
            lbclass1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbclass1.ForeColor = Color.Peru;
            lbclass1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbclass1.Location = new Point(34, 44);
            lbclass1.Name = "lbclass1";
            lbclass1.Size = new Size(96, 31);
            lbclass1.TabIndex = 96;
            lbclass1.Text = "Lớp học";
            // 
            // dgvloadschedule
            // 
            dgvloadschedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvloadschedule.BackgroundColor = Color.LightSalmon;
            dgvloadschedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvloadschedule.GridColor = Color.LightSalmon;
            dgvloadschedule.Location = new Point(34, 96);
            dgvloadschedule.Name = "dgvloadschedule";
            dgvloadschedule.RowHeadersWidth = 51;
            dgvloadschedule.Size = new Size(1043, 185);
            dgvloadschedule.TabIndex = 98;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Peru;
            label1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label1.Location = new Point(34, 334);
            label1.Name = "label1";
            label1.Size = new Size(74, 31);
            label1.TabIndex = 103;
            label1.Text = "Ngày ";
            // 
            // mtdate
            // 
            mtdate.BackColor = Color.LightSalmon;
            mtdate.Location = new Point(34, 379);
            mtdate.Mask = "00/00/0000";
            mtdate.Name = "mtdate";
            mtdate.Size = new Size(141, 27);
            mtdate.TabIndex = 102;
            mtdate.MaskInputRejected += mtdate_MaskInputRejected;
            // 
            // cbblesson
            // 
            cbblesson.BackColor = Color.LightSalmon;
            cbblesson.FormattingEnabled = true;
            cbblesson.Location = new Point(211, 379);
            cbblesson.Name = "cbblesson";
            cbblesson.Size = new Size(151, 28);
            cbblesson.TabIndex = 105;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Peru;
            label2.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label2.Location = new Point(211, 334);
            label2.Name = "label2";
            label2.Size = new Size(52, 31);
            label2.TabIndex = 104;
            label2.Text = "Tiết";
            // 
            // cbbsubject
            // 
            cbbsubject.BackColor = Color.LightSalmon;
            cbbsubject.FormattingEnabled = true;
            cbbsubject.Location = new Point(34, 481);
            cbbsubject.Name = "cbbsubject";
            cbbsubject.Size = new Size(151, 28);
            cbbsubject.TabIndex = 107;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.Peru;
            label3.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label3.Location = new Point(34, 436);
            label3.Name = "label3";
            label3.Size = new Size(104, 31);
            label3.TabIndex = 106;
            label3.Text = "Môn học";
            // 
            // cbbstatus
            // 
            cbbstatus.BackColor = Color.LightSalmon;
            cbbstatus.FormattingEnabled = true;
            cbbstatus.Location = new Point(211, 481);
            cbbstatus.Name = "cbbstatus";
            cbbstatus.Size = new Size(151, 28);
            cbbstatus.TabIndex = 109;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.Peru;
            label4.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label4.Location = new Point(211, 436);
            label4.Name = "label4";
            label4.Size = new Size(121, 31);
            label4.TabIndex = 108;
            label4.Text = "Tình Trạng";
            // 
            // btedit
            // 
            btedit.BackColor = Color.PapayaWhip;
            btedit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btedit.Location = new Point(693, 433);
            btedit.Name = "btedit";
            btedit.Size = new Size(137, 48);
            btedit.TabIndex = 111;
            btedit.Text = "Sửa";
            btedit.UseVisualStyleBackColor = false;
            btedit.Click += btedit_Click;
            // 
            // tbback
            // 
            tbback.BackColor = Color.PapayaWhip;
            tbback.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbback.Location = new Point(847, 434);
            tbback.Name = "tbback";
            tbback.Size = new Size(137, 48);
            tbback.TabIndex = 110;
            tbback.Text = "Trở về";
            tbback.UseVisualStyleBackColor = false;
            // 
            // btadd
            // 
            btadd.BackColor = Color.PapayaWhip;
            btadd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btadd.Location = new Point(693, 379);
            btadd.Name = "btadd";
            btadd.Size = new Size(137, 48);
            btadd.TabIndex = 112;
            btadd.Text = "Thêm ";
            btadd.UseVisualStyleBackColor = false;
            btadd.Click += btadd_Click;
            // 
            // btdelete
            // 
            btdelete.BackColor = Color.PapayaWhip;
            btdelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btdelete.Location = new Point(847, 380);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(137, 48);
            btdelete.TabIndex = 113;
            btdelete.Text = "Xóa";
            btdelete.UseVisualStyleBackColor = false;
            btdelete.Click += btdelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.Peru;
            label5.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label5.Location = new Point(357, 44);
            label5.Name = "label5";
            label5.Size = new Size(74, 31);
            label5.TabIndex = 115;
            label5.Text = "Ngày ";
            // 
            // mtbdateforfind
            // 
            mtbdateforfind.BackColor = Color.LightSalmon;
            mtbdateforfind.Location = new Point(453, 50);
            mtbdateforfind.Mask = "00/00/0000";
            mtbdateforfind.Name = "mtbdateforfind";
            mtbdateforfind.Size = new Size(141, 27);
            mtbdateforfind.TabIndex = 114;
            // 
            // btfindschedule
            // 
            btfindschedule.BackColor = Color.PapayaWhip;
            btfindschedule.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btfindschedule.Location = new Point(643, 37);
            btfindschedule.Name = "btfindschedule";
            btfindschedule.Size = new Size(137, 48);
            btfindschedule.TabIndex = 116;
            btfindschedule.Text = "Xem";
            btfindschedule.UseVisualStyleBackColor = false;
            btfindschedule.Click += btfindschedule_Click;
            // 
            // cbbclassedit
            // 
            cbbclassedit.BackColor = Color.LightSalmon;
            cbbclassedit.FormattingEnabled = true;
            cbbclassedit.Location = new Point(406, 481);
            cbbclassedit.Name = "cbbclassedit";
            cbbclassedit.Size = new Size(151, 28);
            cbbclassedit.TabIndex = 120;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label7.ForeColor = Color.Peru;
            label7.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            label7.Location = new Point(404, 439);
            label7.Name = "label7";
            label7.Size = new Size(96, 31);
            label7.TabIndex = 119;
            label7.Text = "Lớp học";
            // 
            // edirSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1092, 603);
            Controls.Add(cbbclassedit);
            Controls.Add(label7);
            Controls.Add(btfindschedule);
            Controls.Add(label5);
            Controls.Add(mtbdateforfind);
            Controls.Add(btdelete);
            Controls.Add(btadd);
            Controls.Add(btedit);
            Controls.Add(tbback);
            Controls.Add(cbbstatus);
            Controls.Add(label4);
            Controls.Add(cbbsubject);
            Controls.Add(label3);
            Controls.Add(cbblesson);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mtdate);
            Controls.Add(dgvloadschedule);
            Controls.Add(cbbclasses);
            Controls.Add(lbclass1);
            Name = "edirSchedule";
            Text = "edirSchedule";
            Load += edirSchedule_Load;
            ((System.ComponentModel.ISupportInitialize)dgvloadschedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbclasses;
        private Label lbclass1;
        private DataGridView dgvloadschedule;
        private Label label1;
        private MaskedTextBox mtdate;
        private ComboBox cbblesson;
        private Label label2;
        private ComboBox cbbsubject;
        private Label label3;
        private ComboBox cbbstatus;
        private Label label4;
        private Button btedit;
        private Button tbback;
        private Button btadd;
        private Button btdelete;
        private Label label5;
        private MaskedTextBox mtbdateforfind;
        private Button btfindschedule;
        private ComboBox cbbclassedit;
        private Label label7;
    }
}