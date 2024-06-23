using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;


namespace Child_mg
{
    partial class statust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statust));
            lb_main = new Label();
            btlogin = new Button();
            regsiter = new Button();
            SuspendLayout();
            // 
            // lb_main
            // 
            lb_main.AutoSize = true;
            lb_main.Font = new System.Drawing.Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lb_main.ForeColor = Color.Violet;
            lb_main.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            lb_main.Location = new Point(225, 200);
            lb_main.MaximumSize = new Size(500, 0);
            lb_main.MinimumSize = new Size(100, 0);
            lb_main.Name = "lb_main";
            lb_main.Size = new Size(394, 53);
            lb_main.TabIndex = 2;
            lb_main.Text = "Preschool Nursery";
            // 
            // btlogin
            // 
            btlogin.BackColor = Color.White;
            btlogin.BackgroundImageLayout = ImageLayout.Stretch;
            btlogin.Image = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            btlogin.Location = new Point(328, 276);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(157, 58);
            btlogin.TabIndex = 0;
            btlogin.Text = "Đăng nhập";
            btlogin.UseVisualStyleBackColor = false;
            btlogin.Click += btlogin_Click;
            // 
            // regsiter
            // 
            regsiter.BackgroundImage = Properties.Resources.z5305773677949_166d29dc46f037af2471eff4884eae8a;
            regsiter.BackgroundImageLayout = ImageLayout.Stretch;
            regsiter.Location = new Point(328, 362);
            regsiter.Name = "regsiter";
            regsiter.Size = new Size(157, 50);
            regsiter.TabIndex = 1;
            regsiter.Text = "Đăng ký";
            regsiter.UseVisualStyleBackColor = true;
            // 
            // statust
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.z5305766175605_bd53d5881a4683c1074e10226a0bd35f;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_main);
            Controls.Add(regsiter);
            Controls.Add(btlogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "statust";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phạm Hồng Trưởng";
            FormClosing += statust_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btlogin;
        private Button regsiter;
        private Label lb_main;
    }
}
