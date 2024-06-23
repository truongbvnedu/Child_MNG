namespace Child_mg
{
    partial class editsubject
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editsubject));
            dgvdata = new DataGridView();
            tbid = new TextBox();
            btadd = new Button();
            btview = new Button();
            btedit = new Button();
            tbstatus = new TextBox();
            tbname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // dgvdata
            // 
            dgvdata.BackgroundColor = Color.LightSalmon;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Location = new Point(12, 12);
            dgvdata.Name = "dgvdata";
            dgvdata.RowHeadersWidth = 51;
            dgvdata.Size = new Size(453, 373);
            dgvdata.TabIndex = 0;
            // 
            // tbid
            // 
            tbid.BackColor = Color.LightSalmon;
            tbid.Location = new Point(483, 12);
            tbid.Name = "tbid";
            tbid.ReadOnly = true;
            tbid.Size = new Size(165, 27);
            tbid.TabIndex = 1;
            // 
            // btadd
            // 
            btadd.BackColor = Color.LemonChiffon;
            btadd.Location = new Point(667, 98);
            btadd.Name = "btadd";
            btadd.Size = new Size(116, 51);
            btadd.TabIndex = 2;
            btadd.Text = "Thêm";
            btadd.UseVisualStyleBackColor = false;
            btadd.Click += btadd_Click;
            // 
            // btview
            // 
            btview.BackColor = Color.LemonChiffon;
            btview.Location = new Point(667, 27);
            btview.Name = "btview";
            btview.Size = new Size(116, 51);
            btview.TabIndex = 5;
            btview.Text = "Xem tất cả các môn";
            btview.UseVisualStyleBackColor = false;
            btview.Click += btview_Click;
            // 
            // btedit
            // 
            btedit.BackColor = Color.LemonChiffon;
            btedit.Location = new Point(786, 27);
            btedit.Name = "btedit";
            btedit.Size = new Size(116, 51);
            btedit.TabIndex = 4;
            btedit.Text = "Sửa";
            btedit.UseVisualStyleBackColor = false;
            btedit.Click += btedit_Click;
            // 
            // tbstatus
            // 
            tbstatus.BackColor = Color.LightSalmon;
            tbstatus.Location = new Point(483, 110);
            tbstatus.Name = "tbstatus";
            tbstatus.Size = new Size(165, 27);
            tbstatus.TabIndex = 6;
            // 
            // tbname
            // 
            tbname.BackColor = Color.LightSalmon;
            tbname.Location = new Point(483, 63);
            tbname.Name = "tbname";
            tbname.Size = new Size(165, 27);
            tbname.TabIndex = 7;
            // 
            // editsubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(971, 449);
            Controls.Add(tbname);
            Controls.Add(tbstatus);
            Controls.Add(btview);
            Controls.Add(btedit);
            Controls.Add(btadd);
            Controls.Add(tbid);
            Controls.Add(dgvdata);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "editsubject";
            Text = "Chỉnh Sửa thông tin môn học";
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvdata;
        private TextBox tbid;
        private Button btadd;
        private Button btview;
        private Button btedit;
        private TextBox tbstatus;
        private TextBox tbname;
    }
}
