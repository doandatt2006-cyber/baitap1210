namespace baitap1012
{
    partial class bai4
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bai4));
            menuStrip1 = new MenuStrip();
            mniSystem = new ToolStripMenuItem();
            mniLogout = new ToolStripMenuItem();
            mniExit = new ToolStripMenuItem();
            mniCategory = new ToolStripMenuItem();
            mniStudent = new ToolStripMenuItem();
            mniProduct = new ToolStripMenuItem();
            mniWindow = new ToolStripMenuItem();
            mniCascade = new ToolStripMenuItem();
            mniTileHorizontal = new ToolStripMenuItem();
            mniTileVertical = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblUser = new ToolStripStatusLabel();
            lblStatus = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnStudent = new ToolStripButton();
            btnLogout = new ToolStripButton();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mniSystem, mniCategory, mniWindow });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mniSystem
            // 
            mniSystem.DropDownItems.AddRange(new ToolStripItem[] { mniLogout, mniExit });
            mniSystem.Name = "mniSystem";
            mniSystem.Size = new Size(85, 24);
            mniSystem.Text = "Hệ thống";
            // 
            // mniLogout
            // 
            mniLogout.Name = "mniLogout";
            mniLogout.Size = new Size(160, 26);
            mniLogout.Text = "Đăng xuất";
            mniLogout.Click += mniLogout_Click;
            // 
            // mniExit
            // 
            mniExit.Name = "mniExit";
            mniExit.Size = new Size(160, 26);
            mniExit.Text = "Thoát";
            mniExit.Click += mniExit_Click;
            // 
            // mniCategory
            // 
            mniCategory.DropDownItems.AddRange(new ToolStripItem[] { mniStudent, mniProduct });
            mniCategory.Name = "mniCategory";
            mniCategory.Size = new Size(90, 24);
            mniCategory.Text = "Danh mục";
            // 
            // mniStudent
            // 
            mniStudent.Name = "mniStudent";
            mniStudent.Size = new Size(224, 26);
            mniStudent.Text = "Quản lý sinh viên";
            mniStudent.Click += mniStudent_Click;
            // 
            // mniProduct
            // 
            mniProduct.Name = "mniProduct";
            mniProduct.Size = new Size(224, 26);
            mniProduct.Text = "Quản lý sản phẩm";
            mniProduct.Click += mniProduct_Click;
            // 
            // mniWindow
            // 
            mniWindow.DropDownItems.AddRange(new ToolStripItem[] { mniCascade, mniTileHorizontal, mniTileVertical });
            mniWindow.Name = "mniWindow";
            mniWindow.Size = new Size(68, 24);
            mniWindow.Text = "Cửa sổ";
            // 
            // mniCascade
            // 
            mniCascade.Name = "mniCascade";
            mniCascade.Size = new Size(164, 26);
            mniCascade.Text = "Xếp tầng";
            mniCascade.Click += mniCascade_Click;
            // 
            // mniTileHorizontal
            // 
            mniTileHorizontal.Name = "mniTileHorizontal";
            mniTileHorizontal.Size = new Size(164, 26);
            mniTileHorizontal.Text = "Xếp ngang";
            mniTileHorizontal.Click += mniTileHorizontal_Click;
            // 
            // mniTileVertical
            // 
            mniTileVertical.Name = "mniTileVertical";
            mniTileVertical.Size = new Size(164, 26);
            mniTileVertical.Text = "Xếp dọc";
            mniTileVertical.Click += mniTileVertical_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUser, lblStatus, lblClock });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(140, 20);
            lblUser.Text = "Người dùng: Admin";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(68, 20);
            lblStatus.Text = "Sẵn sàng";
            // 
            // lblClock
            // 
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(577, 20);
            lblClock.Spring = true;
            lblClock.Text = "00:00:00";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnStudent, btnLogout });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnStudent
            // 
            btnStudent.Image = (Image)resources.GetObject("btnStudent.Image");
            btnStudent.ImageTransparentColor = Color.Magenta;
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(92, 24);
            btnStudent.Text = "Sinh viên";
            // 
            // btnLogout
            // 
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageTransparentColor = Color.Magenta;
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 24);
            btnLogout.Text = "Đăng xuất";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "bai4";
            Load += bai4_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mniSystem;
        private ToolStripMenuItem mniLogout;
        private ToolStripMenuItem mniExit;
        private ToolStripMenuItem mniCategory;
        private ToolStripMenuItem mniStudent;
        private ToolStripMenuItem mniProduct;
        private ToolStripMenuItem mniWindow;
        private ToolStripMenuItem mniCascade;
        private ToolStripMenuItem mniTileHorizontal;
        private ToolStripMenuItem mniTileVertical;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUser;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblClock;
        private ToolStrip toolStrip1;
        private ToolStripButton btnStudent;
        private ToolStripButton btnLogout;
        private System.Windows.Forms.Timer timer1;
    }
}