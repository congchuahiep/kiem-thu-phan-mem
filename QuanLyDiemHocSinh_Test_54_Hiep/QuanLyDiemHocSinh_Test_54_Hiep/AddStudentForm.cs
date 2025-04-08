using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyDiemHocSinh_Test_54_Hiep
{
    public partial class AddStudentForm: Form
    {
        private StudentManager studentManager;

        public AddStudentForm(StudentManager studentManager)
        {
            InitializeComponent();
            this.studentManager = studentManager;
        }

        private void buttonSave_54_Hiep_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxId_54_Hiep.Text.Trim();
                string fullName = textBoxName_54_Hiep.Text.Trim();

                // Xử lý phần tạo đối tượng mới (có thể quăng ra ngoại lệ)
                studentManager.AddStudent(id, fullName);

                // Nếu hợp lệ thì đóng dialog
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
