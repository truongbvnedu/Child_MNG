namespace Child_mg
{
    partial class scheduleFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scheduleFrom));
            dgvloadschedule = new DataGridView();
            mtdate = new MaskedTextBox();
            lbclass1 = new Label();
            cbbname = new ComboBox();
            lbname1 = new Label();
            tbback = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvloadschedule).BeginInit();
            SuspendLayout();
            // 
            // dgvloadschedule
            // 
            dgvloadschedule.BackgroundColor = Color.LightSalmon;
            dgvloadschedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvloadschedule.GridColor = Color.LightSalmon;
            dgvloadschedule.Location = new Point(28, 185);
            dgvloadschedule.Name = "dgvloadschedule";
            dgvloadschedule.RowHeadersWidth = 51;
            dgvloadschedule.Size = new Size(886, 306);
            dgvloadschedule.TabIndex = 99;
            // 
            // mtdate
            // 
            mtdate.BackColor = Color.LightSalmon;
            mtdate.Location = new Point(28, 134);
            mtdate.Mask = "00/00/0000";
            mtdate.Name = "mtdate";
            mtdate.Size = new Size(141, 27);
            mtdate.TabIndex = 100;
            // 
            // lbclass1
            // 
            lbclass1.AutoSize = true;
            lbclass1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbclass1.ForeColor = Color.Peru;
            lbclass1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbclass1.Location = new Point(28, 89);
            lbclass1.Name = "lbclass1";
            lbclass1.Size = new Size(74, 31);
            lbclass1.TabIndex = 101;
            lbclass1.Text = "Ngày ";
            // 
            // cbbname
            // 
            cbbname.BackColor = Color.LightSalmon;
            cbbname.FormattingEnabled = true;
            cbbname.Location = new Point(28, 45);
            cbbname.Name = "cbbname";
            cbbname.Size = new Size(151, 28);
            cbbname.TabIndex = 102;
            // 
            // lbname1
            // 
            lbname1.AutoSize = true;
            lbname1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbname1.ForeColor = Color.Peru;
            lbname1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbname1.Location = new Point(28, 11);
            lbname1.Name = "lbname1";
            lbname1.Size = new Size(113, 31);
            lbname1.TabIndex = 103;
            lbname1.Text = "Họ và Tên";
            // 
            // tbback
            // 
            tbback.BackColor = Color.PapayaWhip;
            tbback.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbback.Location = new Point(264, 113);
            tbback.Name = "tbback";
            tbback.Size = new Size(137, 48);
            tbback.TabIndex = 104;
            tbback.Text = "Trở về";
            tbback.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PapayaWhip;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button1.Location = new Point(264, 59);
            button1.Name = "button1";
            button1.Size = new Size(137, 48);
            button1.TabIndex = 105;
            button1.Text = "xem lịch học";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(931, 532);
            Controls.Add(button1);
            Controls.Add(tbback);
            Controls.Add(lbname1);
            Controls.Add(cbbname);
            Controls.Add(lbclass1);
            Controls.Add(mtdate);
            Controls.Add(dgvloadschedule);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "schedule";
            Text = "Lịch Học";
            ((System.ComponentModel.ISupportInitialize)dgvloadschedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvloadschedule;
        private MaskedTextBox mtdate;
        private Label lbclass1;
        private ComboBox cbbname;
        private Label lbname1;
        private Button tbback;
        private Button button1;
    }
}