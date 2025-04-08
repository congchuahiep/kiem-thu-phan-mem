using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyDiemHocSinh_Test_54_Hiep
{
    public class Student
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public Dictionary<string, double> Scores { get; set; }

        public Student(string id, string fullName)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Scores = new Dictionary<string, double>();
        }

        public void AddScore(string subjectName, double score)
        {
            if (score < 0 || score > 10)
                throw new ArgumentException("Điểm phải từ 0 đến 10.");

            Scores[subjectName] = score;
        }

        public void RemoveScore(string subject)
        {
            if (!Scores.ContainsKey(subject))
                throw new InvalidOperationException("Không tìm thấy môn học để xoá.");

            Scores.Remove(subject);
        }

        public double GetAverage()
        {
            if (Scores.Count == 0) return 0;

            return Scores.Values.Average();
        }

        public string GetGrade()
        {
            double avg = GetAverage();

            if (avg >= 8.5) return "Giỏi";
            else if (avg >= 7) return "Khá";
            else if (avg >= 5) return "Trung bình";
            else return "Yếu";
        }
    }
}
