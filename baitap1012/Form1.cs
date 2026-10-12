using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace baitap1012
{
    // 1. CLASS FORM1 PHẢI NẰM ĐẦU TIÊN ĐỂ DESIGNER HOẠT ĐỘNG
    public partial class Form1 : Form
    {
        private BindingList<Student> studentList = new BindingList<Student>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentList.Add(new Student { StudentId = "SV01", FullName = "Nguyễn Văn A", Age = 20, Gender = "Nam", AvatarPath = "" });
            studentList.Add(new Student { StudentId = "SV02", FullName = "Trần Thị B", Age = 21, Gender = "Nữ", AvatarPath = "" });

            bindingSource.DataSource = studentList;
            dgvStudents.DataSource = bindingSource;

            cboGender.Items.Clear();
            cboGender.Items.AddRange(new string[] { "Nam", "Nữ" });
            if (cboGender.Items.Count > 0) cboGender.SelectedIndex = 0;

            SetupDataBinding();

            bindingSource.CurrentChanged += BindingSource_CurrentChanged;
            LoadAvatarForCurrentStudent();
        }

        private void SetupDataBinding()
        {
            txtStudentId.DataBindings.Add("Text", bindingSource, "StudentId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add("Text", bindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", bindingSource, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            cboGender.DataBindings.Add("Text", bindingSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            LoadAvatarForCurrentStudent();
        }

        private void LoadAvatarForCurrentStudent()
        {
            if (bindingSource.Current is Student currentStudent)
            {
                if (!string.IsNullOrEmpty(currentStudent.AvatarPath) && File.Exists(currentStudent.AvatarPath))
                {
                    picAvatar.ImageLocation = currentStudent.AvatarPath;
                }
                else
                {
                    picAvatar.Image = null;
                }
            }
            else
            {
                picAvatar.Image = null;
            }
        }

        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student currentStudent)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "File hình ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                    ofd.Title = "Chọn ảnh đại diện";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        currentStudent.AvatarPath = ofd.FileName;
                        picAvatar.ImageLocation = currentStudent.AvatarPath;
                        bindingSource.ResetCurrentItem();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hoặc thêm sinh viên trước khi chọn ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ các ô nhập liệu
            string id = txtStudentId.Text.Trim();
            string name = txtFullName.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string gender = cboGender.SelectedItem != null ? cboGender.SelectedItem.ToString() : "Nam";

            // 2. Kiểm tra để trống các trường bắt buộc
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentId.Focus();
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập Họ tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ageText))
            {
                MessageBox.Show("Vui lòng nhập Tuổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }

            // 3. Kiểm tra định dạng Tuổi (phải là số nguyên > 0)
            if (!int.TryParse(ageText, out int age) || age <= 0)
            {
                MessageBox.Show("Tuổi phải là một số nguyên hợp lệ lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge.SelectAll();
                txtAge.Focus();
                return;
            }

            // 4. Kiểm tra trùng Mã SV trong danh sách
            foreach (Student s in studentList)
            {
                if (s.StudentId.Equals(id, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại! Vui lòng nhập mã khác.", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStudentId.SelectAll();
                    txtStudentId.Focus();
                    return;
                }
            }

            // 5. Nếu tất cả hợp lệ -> Tạo đối tượng mới và thêm vào danh sách
            Student newStudent = new Student
            {
                StudentId = id,
                FullName = name,
                Age = age,
                Gender = gender,
                AvatarPath = picAvatar.ImageLocation ?? ""
            };

            bindingSource.Add(newStudent);
            bindingSource.MoveLast(); // Chuyển con trỏ tới sinh viên vừa thêm

            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    bindingSource.RemoveCurrent();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bindingSource.ResetCurrentItem();
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "File CSV (*.csv)|*.csv";
                sfd.DefaultExt = "csv";
                sfd.FileName = "DanhSachSinhVien.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            sw.WriteLine("Mã SV,Họ tên,Tuổi,Giới tính,Đường dẫn Avatar");

                            foreach (Student student in studentList)
                            {
                                string line = string.Format("\"{0}\",\"{1}\",{2},\"{3}\",\"{4}\"",
                                    student.StudentId,
                                    student.FullName,
                                    student.Age,
                                    student.Gender,
                                    student.AvatarPath);

                                sw.WriteLine(line);
                            }
                        }

                        MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }

    // 2. CHUYỂN CLASS STUDENT XUỐNG DƯỚI CÙNG
    public class Student
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string AvatarPath { get; set; }
    }
}