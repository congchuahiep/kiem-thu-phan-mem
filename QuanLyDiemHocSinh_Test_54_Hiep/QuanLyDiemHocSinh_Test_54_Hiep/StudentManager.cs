using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocSinh_Test_54_Hiep
{
    public class StudentManager
    {
        public List<Student> students { get; private set; }

        public StudentManager()
        {
            students = new List<Student>();
        }

        public void AddStudent(string id, string fullName)
        {
            // Kiểm tra trường có trống hay không
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Mã sinh viên không được để trống.");

            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Họ tên sinh viên không được để trống.");

            if (students.Any(s => s.Id == id))
                throw new InvalidOperationException("Mã sinh viên đã tồn tại.");

            var student = new Student(id, fullName);
            students.Add(student);
        }


        public void DeleteStudent(string id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                throw new KeyNotFoundException("Không tìm thấy sinh viên với mã này.");

            students.Remove(student);
        }

        public void UpdateStudent(string id, string newFullName)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                throw new KeyNotFoundException("Không tìm thấy sinh viên với mã này.");

            if (string.IsNullOrWhiteSpace(newFullName))
                throw new ArgumentException("Tên sinh viên không được để trống.");

            student.FullName = newFullName;
        }

        public void AddScoreToStudent (string id, string subject, string score)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                throw new KeyNotFoundException("Không tìm thấy sinh viên.");

            if (!double.TryParse(score, out double scoreValue))
                throw new FormatException("Điểm không hợp lệ!");

            if (string.IsNullOrWhiteSpace(subject))
                throw new ArgumentException("Môn học không được để trống.");

            student.AddScore(subject, scoreValue); // cập nhật hoặc thêm mới
        }

        public void DeleteScoreFormStudent (string id, string subject)
        {
            var student = students.FirstOrDefault(s => s.Id==id);

            if (student == null)
                throw new KeyNotFoundException("Không tìm thấy sinh viên.");

            student.RemoveScore(subject);
        }

        public double CalculateAvgScore (string id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                throw new KeyNotFoundException("Không tìm thấy sinh viên.");

            return student.GetAverageScore();
        }

        public string CalculateGrate (string id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                throw new KeyNotFoundException("Không tìm thấy sinh viên.");

            return student.GetGrade();
        }
    }
}
