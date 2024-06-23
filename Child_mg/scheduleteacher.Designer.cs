namespace Child_mg
{
    partial class scheduleteacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scheduleteacher));
            btloadschedule = new Button();
            tbback = new Button();
            lbname1 = new Label();
            cbbclass = new ComboBox();
            lbclass1 = new Label();
            mtdate = new MaskedTextBox();
            dgvloadschedule = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvloadschedule).BeginInit();
            SuspendLayout();
            // 
            // btloadschedule
            // 
            btloadschedule.BackColor = Color.PapayaWhip;
            btloadschedule.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btloadschedule.Location = new Point(265, 85);
            btloadschedule.Name = "btloadschedule";
            btloadschedule.Size = new Size(137, 48);
            btloadschedule.TabIndex = 112;
            btloadschedule.Text = "xem lịch";
            btloadschedule.UseVisualStyleBackColor = false;
            btloadschedule.Click += btloadschedule_Click;
            // 
            // tbback
            // 
            tbback.BackColor = Color.PapayaWhip;
            tbback.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbback.Location = new Point(265, 139);
            tbback.Name = "tbback";
            tbback.Size = new Size(137, 48);
            tbback.TabIndex = 111;
            tbback.Text = "Trở về";
            tbback.UseVisualStyleBackColor = false;
            // 
            // lbname1
            // 
            lbname1.AutoSize = true;
            lbname1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbname1.ForeColor = Color.Peru;
            lbname1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbname1.Location = new Point(29, 37);
            lbname1.Name = "lbname1";
            lbname1.Size = new Size(59, 31);
            lbname1.TabIndex = 110;
            lbname1.Text = "Lớp ";
            // 
            // cbbclass
            // 
            cbbclass.BackColor = Color.LightSalmon;
            cbbclass.FormattingEnabled = true;
            cbbclass.Location = new Point(29, 71);
            cbbclass.Name = "cbbclass";
            cbbclass.Size = new Size(151, 28);
            cbbclass.TabIndex = 109;
            // 
            // lbclass1
            // 
            lbclass1.AutoSize = true;
            lbclass1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbclass1.ForeColor = Color.Peru;
            lbclass1.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lbclass1.Location = new Point(29, 115);
            lbclass1.Name = "lbclass1";
            lbclass1.Size = new Size(74, 31);
            lbclass1.TabIndex = 108;
            lbclass1.Text = "Ngày ";
            // 
            // mtdate
            // 
            mtdate.BackColor = Color.LightSalmon;
            mtdate.Location = new Point(29, 160);
            mtdate.Mask = "00/00/0000";
            mtdate.Name = "mtdate";
            mtdate.Size = new Size(141, 27);
            mtdate.TabIndex = 107;
            // 
            // dgvloadschedule
            // 
            dgvloadschedule.BackgroundColor = Color.LightSalmon;
            dgvloadschedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvloadschedule.GridColor = Color.LightSalmon;
            dgvloadschedule.Location = new Point(29, 211);
            dgvloadschedule.Name = "dgvloadschedule";
            dgvloadschedule.RowHeadersWidth = 51;
            dgvloadschedule.Size = new Size(886, 306);
            dgvloadschedule.TabIndex = 106;
            // 
            // scheduleteacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(953, 596);
            Controls.Add(btloadschedule);
            Controls.Add(tbback);
            Controls.Add(lbname1);
            Controls.Add(cbbclass);
            Controls.Add(lbclass1);
            Controls.Add(mtdate);
            Controls.Add(dgvloadschedule);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "scheduleteacher";
            Text = "Lịch dạy";
            ((System.ComponentModel.ISupportInitialize)dgvloadschedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btloadschedule;
        private Button tbback;
        private Label lbname1;
        private ComboBox cbbclass;
        private Label lbclass1;
        private MaskedTextBox mtdate;
        private DataGridView dgvloadschedule;
    }
}