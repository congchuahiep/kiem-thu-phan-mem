﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemHocSinh_Test_54_Hiep
{
    public partial class FormMain_54_Hiep: Form
    {

        private StudentManager studentManager;
        private Student selectedStudent = null;

        public FormMain_54_Hiep()
        {
            studentManager = new StudentManager();
            InitializeComponent();
        }

        private void FormMain_54_Hiep_Load(object sender, EventArgs e)
        {
            listBoxStudent_54_Hiep.DataSource = studentManager.students;
        }

        private void refreshStudentList_54_Hiep()
        {
            listBoxStudent_54_Hiep.DataSource = null;
            listBoxStudent_54_Hiep.DataSource = studentManager.students;
            listBoxStudent_54_Hiep.DisplayMember = "FullName";
        }

        private void buttonAddStudent_54_Hiep_Click(object sender, EventArgs e)
        {
            var addForm = new AddStudentForm(studentManager);
            var result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // cập nhật lại ListBox
                refreshStudentList_54_Hiep();
            }
        }

        private void listBoxStudent_54_Hiep_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedStudent = listBoxStudent_54_Hiep.SelectedItem as Student;

            if (selectedStudent != null)
            {
                textBoxStudentId_54_Hiep.Text = selectedStudent.Id;
                textBoxStudentName_54_Hiep.Text = selectedStudent.FullName;

                textBoxStudentName_54_Hiep.Enabled = true;
                buttonUpdateStudent_54_Hiep.Enabled = true;
                buttonDeleteStudent_54_Hiep.Enabled = true;
            }
            else
            {
                textBoxStudentId_54_Hiep.Text = "";
                textBoxStudentName_54_Hiep.Text = "";

                textBoxStudentName_54_Hiep.Enabled = false;
                buttonUpdateStudent_54_Hiep.Enabled = false;
                buttonDeleteStudent_54_Hiep.Enabled = false;
            }
        }

        private void buttonDeleteStudent_54_Hiep_Click(object sender, EventArgs e)
        {
            var selectedStudent = listBoxStudent_54_Hiep.SelectedItem as Student;
            if (selectedStudent == null) return;

            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xoá học sinh \"{selectedStudent.FullName}\"?",
                "Xác nhận xoá",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    studentManager.DeleteStudent(selectedStudent.Id);
                    // cập nhật lại ListBox
                    refreshStudentList_54_Hiep();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUpdateStudent_54_Hiep_Click(object sender, EventArgs e)
        {
            var selectedStudent = listBoxStudent_54_Hiep.SelectedItem as Student;
            if (selectedStudent == null) return;

            var newFullName = textBoxStudentName_54_Hiep.Text;

            try
            {
                studentManager.UpdateStudent(selectedStudent.Id, newFullName);
                // cập nhật lại giao diện nếu cần
                refreshStudentList_54_Hiep();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
