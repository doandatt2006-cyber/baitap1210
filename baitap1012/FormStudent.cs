using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap1012
{
    public partial class FormStudent : Form
    {
        // Quản lý dữ liệu bằng BindingList và BindingSource (Bài 4.6)
        private BindingList<Student> listStudent = new BindingList<Student>();
        private BindingSource bsStudent = new BindingSource();

        public FormStudent()
        {
            InitializeComponent();

            // Gán nguồn dữ liệu vào DataGridView
            bsStudent.DataSource = listStudent;
            dataGridView1.DataSource = bsStudent;
        }

        #region HÀM HỖ TRỢ CẬP NHẬT TRẠNG THÁI LÊN FORM CHA MDI (BÀI 4.7)
        private void UpdateParentStatus(string message)
        {
            if (this.MdiParent != null)
            {
                MethodInfo method = this.MdiParent.GetType().GetMethod("UpdateStatus");
                if (method != null)
                {
                    method.Invoke(this.MdiParent, new object[] { message });
                }
            }
        }
        #endregion

        #region BÀI 4.8: NẠP DỮ LIỆU BẤT ĐỒNG BỘ (ASYNC/AWAIT)
        private async Task<List<Student>> LoadStudentDataAsync(IProgress<int> progress)
        {
            return await Task.Run(() =>
            {
                List<Student> list = new List<Student>();
                int totalItems = 100;

                for (int i = 1; i <= totalItems; i++)
                {
                    Thread.Sleep(30);

                    list.Add(new Student
                    {
                        StudentId = $"SV{i:D02}",
                        FullName = $"Nguyễn Văn {i}",
                        Age = 18 + (i % 5),
                        Gender = (i % 2 == 0) ? "Nam" : "Nữ",
                        AvatarPath = ""
                    });

                    int percent = (i * 100) / totalItems;
                    progress?.Report(percent);
                }

                return list;
            });
        }

        private async void btnLoadData_Click(object sender, EventArgs e)
        {
            // 1. Khóa nút bấm
            btnLoadData.Enabled = false;
            progressBar1.Value = 0;
            lblPercent.Text = "0%";

            // 2. Báo cáo tiến trình lên Form con và Form cha
            var progress = new Progress<int>(percent =>
            {
                progressBar1.Value = percent;
                lblPercent.Text = $"{percent}%";
                UpdateParentStatus($"Đang nạp dữ liệu: {percent}%");
            });

            // 3. Thực thi nạp dữ liệu bất đồng bộ
            try
            {
                List<Student> result = await LoadStudentDataAsync(progress);

                // Cập nhật danh sách qua BindingList
                listStudent.Clear();
                foreach (var item in result)
                {
                    listStudent.Add(item);
                }

                UpdateParentStatus("Đã nạp thành công 100 sinh viên!");
                MessageBox.Show("Nạp dữ liệu hoàn tất!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xảy ra lỗi trong quá trình nạp: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 4. Mở lại nút bấm
                btnLoadData.Enabled = true;
            }
        }
        #endregion
    }
}