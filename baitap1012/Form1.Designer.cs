namespace baitap1012
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtStudentId = new TextBox();
            txtFullName = new TextBox();
            txtAge = new TextBox();
            picAvatar = new PictureBox();
            btnSelectAvatar = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnExportCSV = new Button();
            cboGender = new ComboBox();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 78);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 120);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Tuổi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 159);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(128, 41);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(125, 27);
            txtStudentId.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(128, 78);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(128, 117);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 6;
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(300, 36);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(164, 108);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 8;
            picAvatar.TabStop = false;
            // 
            // btnSelectAvatar
            // 
            btnSelectAvatar.Location = new Point(321, 159);
            btnSelectAvatar.Name = "btnSelectAvatar";
            btnSelectAvatar.Size = new Size(125, 29);
            btnSelectAvatar.TabIndex = 9;
            btnSelectAvatar.Text = "Nút chọn ảnh";
            btnSelectAvatar.UseVisualStyleBackColor = true;
            btnSelectAvatar.Click += btnSelectAvatar_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(514, 69);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Nút thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(676, 69);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Nút xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(514, 111);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Nút cập nhập";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExportCSV
            // 
            btnExportCSV.Location = new Point(676, 111);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(109, 29);
            btnExportCSV.TabIndex = 13;
            btnExportCSV.Text = "Nút Xuất CSV";
            btnExportCSV.UseVisualStyleBackColor = true;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(128, 159);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(151, 28);
            cboGender.TabIndex = 14;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(22, 216);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(748, 222);
            dgvStudents.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStudents);
            Controls.Add(cboGender);
            Controls.Add(btnExportCSV);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSelectAvatar);
            Controls.Add(picAvatar);
            Controls.Add(txtAge);
            Controls.Add(txtFullName);
            Controls.Add(txtStudentId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtStudentId;
        private TextBox txtFullName;
        private TextBox txtAge;
        private PictureBox picAvatar;
        private Button btnSelectAvatar;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExportCSV;
        private ComboBox cboGender;
        private DataGridView dgvStudents;
    }
}
