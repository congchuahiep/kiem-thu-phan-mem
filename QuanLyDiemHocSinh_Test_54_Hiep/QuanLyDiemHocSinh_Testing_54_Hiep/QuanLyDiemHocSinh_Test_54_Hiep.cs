using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyDiemHocSinh_54_Hiep;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace QuanLyDiemHocSinh_Testing_54_Hiep
{
    [TestClass]
    public class QuanLyDiemHocSinh_Test_54_Hiep
    {
        private StudentManager studentManager;

        [TestInitialize]
        public void Setup()
        {
            studentManager = new StudentManager();
        }

        // TC01: Kiểm tra thêm sinh viên thành công 
        // Thêm sinh viên với (id = "1", tên = "Thái Hoà") -> Thêm thành công (PASS)
        [TestMethod]
        public void TC01_Pass_AddStudent_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            Assert.AreEqual(1, studentManager.students.Count);
            Assert.AreEqual("Thái Hoà", studentManager.students[0].FullName);
        }

        // TC02: Kiểm tra thêm sinh viên với mã trống 
        // Thêm sinh viên với (id = "", tên = "Thái Hoà") -> Thêm không thành công (FAIL)
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TC02_Fail_AddStudent_54_Hiep()
        {
            studentManager.AddStudent("", "Thái Hoà");
        }

        // TC03: Kiểm tra thêm 2 sinh viên với mã giống nhau
        // Thêm sinh viên với (id = "1", tên = "Thái Hoà") -> Thêm thành công
        // Thêm sinh viên với (id = "1", tên = "Trần Hiệp") -> Thêm không thành công (FAIL)
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TC03_Fail_AddStudent_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddStudent("1", "Trần Hiệp");
        }

        // TC04: Kiểm tra xoá sinh viên
        // Xoá sinh viên với (id = "1") -> Xoá thành công (PASS)
        [TestMethod]
        public void TC04_Pass_DeleteStudent_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.DeleteStudent("1");
            Assert.AreEqual(0, studentManager.students.Count);
        }

        // TC05: Kiểm tra xoá sinh viên không tồn tại
        // Xoá sinh viên với (id = "1") -> Xoá không thành công (FAIL)
        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TC05_Fail_DeleteStudent_54_Hiep()
        {
            studentManager.DeleteStudent("1");
        }

        // TC06: Kiểm tra cập nhật sinh viên
        // Cập nhật sinh viên với (id = "1", tên = "Thái Hoà") -> Cập nhật thành công (PASS)
        [TestMethod]
        public void TC06_Pass_UpdateStudent_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.UpdateStudent("1", "Trần Hiệp");
            Assert.AreEqual("Trần Hiệp", studentManager.students[0].FullName);
        }

        // TC07: Kiểm tra cập nhật sinh viên không tồn tại
        // Cập nhật sinh viên với (id = "1", tên = "Trần Hiệp") -> Cập nhật không thành công (FAIL)
        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TC07_Fail_UpdateStudent_54_Hiep()
        {
            studentManager.UpdateStudent("1", "Trần Hiệp");
        }

        // TC08: Kiểm tra thêm điểm cho sinh viên
        // Thêm điểm cho sinh viên với (id = "1", môn = "Toán", điểm = "9") -> Thêm thành công (PASS)
        [TestMethod]
        public void TC08_Pass_AddScoreToStudent_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddScoreToStudent("1", "Toán", "9");
            Assert.AreEqual(9, studentManager.students[0].Scores["Toán"]);
        }

        // TC09: Kiểm tra thêm điểm cho sinh viên không tồn tại
        // Thêm điểm cho sinh viên với (id = "1", môn = "Toán", điểm = "9") -> Thêm không thành công (FAIL)
        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TC09_Fail_AddScoreToStudent_54_Hiep()
        {
            studentManager.AddScoreToStudent("1", "Toán", "9");
        }

        // TC10: Kiểm tra thêm điểm vào môn học
        // Thêm điểm cho sinh viên với (id = "1", môn = "Toán", điểm = "9") -> Thêm thành công (PASS)
        [TestMethod]
        public void TC10_Pass_DeleteScoreFormStudent_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddScoreToStudent("1", "Toán", "9");
            studentManager.DeleteScoreFormStudent("1", "Toán");
            Assert.IsFalse(studentManager.students[0].Scores.ContainsKey("Toán"));
        }

        // TC11: Xoá điểm không tồn tại
        // Xoá điểm cho sinh viên với (id = "1", môn = "Toán") -> Xoá không thành công (FAIL)
        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TC11_Fail_DeleteScoreFormStudent_54_Hiep()
        {
            studentManager.DeleteScoreFormStudent("1", "Toán");
        }

        // TC12: Kiểm tra tính điểm trung bình
        // Tính điểm trung bình cho sinh viên với (id = "1")
        // Thêm điểm cho sinh viên với (id = "1", môn = "Toán", điểm = "9")
        // Thêm điểm cho sinh viên với (id = "1", môn = "English", điểm = "8")
        // -> Điểm trung bình = 8.5 -> Tính đúng kỳ vọng (PASS)
        [TestMethod]
        public void TC12_Pass_CalculateAvgScore_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddScoreToStudent("1", "Toán", "9");
            studentManager.AddScoreToStudent("1", "English", "8");
            double avg = studentManager.CalculateAvgScore("1");
            Assert.AreEqual(8.5, avg);
        }

        // TC13: Kiểm tra tính điểm trung bình cho sinh viên không tồn tại
        // Tính điểm trung bình cho sinh viên với (id = "1") -> Tính không thành công (FAIL)
        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TC13_Fail_CalculateAvgScore_54_Hiep()
        {
            studentManager.CalculateAvgScore("1");
        }

        // TC14: Kiểm tra tính xếp loại cho sinh viên không có điểm
        // Tính điểm trung bình cho sinh viên với (id = "1") -> Điểm = 8.5 -> Giỏi (Pass)
        [TestMethod]
        public void TC14_Pass_CalculateGrate_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddScoreToStudent("1", "Toán", "9");
            studentManager.AddScoreToStudent("1", "English", "8");
            string grade = studentManager.CalculateGrate("1");
            Assert.AreEqual("Giỏi", grade);
        }

        // TC15: Kiểm tra tính xếp loại cho sinh viên không tồn tại
        // Tính xếp loại cho sinh viên với (id = "1") -> Tính không thành công (FAIL)
        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TC15_Fail_CalculateGrate_54_Hiep()
        {
            studentManager.CalculateGrate("1");
        }

        // TC16: Kiểm tra thêm điểm hợp lệ cho sinh viên
        // Thêm điểm với (id = "1", môn = "Toán", điểm = 9) -> Thêm thành công (PASS)
        [TestMethod]
        public void TC16_Pass_AddScore_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddScoreToStudent("1", "Toán", "9");
            Assert.AreEqual(9, studentManager.students[0].Scores["Toán"]);
        }

        // TC17: Kiểm tra thêm điểm không hợp lệ (điểm < 0)
        // Thêm điểm với (id = "1", môn = "Toán", điểm = -1) -> Thêm không thành công (FAIL)
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TC17_Fail_AddScore_InvalidScore_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddScoreToStudent("1", "Toán", "-1");
        }

        // TC18: Kiểm tra thêm điểm không hợp lệ (điểm > 10)
        // Thêm điểm với (id = "1", môn = "Toán", điểm = 11) -> Thêm không thành công (FAIL)
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TC18_Fail_AddScore_InvalidScore_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddScoreToStudent("1", "Toán", "11");
        }

        // TC19: Kiểm tra xoá điểm hợp lệ
        // Xoá điểm với (id = "1", môn = "Toán") -> Xoá thành công (PASS)
        [TestMethod]
        public void TC19_Pass_RemoveScore_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddScoreToStudent("1", "Toán", "9");
            studentManager.DeleteScoreFormStudent("1", "Toán");
            Assert.IsFalse(studentManager.students[0].Scores.ContainsKey("Toán"));
        }

        // TC20: Kiểm tra xoá điểm không tồn tại
        // Xoá điểm với (id = "1", môn = "Lý") -> Xoá không thành công (FAIL)
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TC20_Fail_RemoveScore_NonExistentSubject_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.DeleteScoreFormStudent("1", "Lý");
        }

        // TC21: Kiểm tra tính điểm trung bình khi không có điểm
        // Tính điểm trung bình với (id = "1") -> Điểm trung bình = 0 (PASS)
        [TestMethod]
        public void TC21_Pass_GetAverageScore_NoScores_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            double avg = studentManager.CalculateAvgScore("1");
            Assert.AreEqual(0, avg);
        }

        // TC22: Kiểm tra tính điểm trung bình với nhiều môn học
        // Thêm điểm với (id = "1", Toán = 9, Lý = 7) -> Điểm trung bình = 8 (PASS)
        [TestMethod]
        public void TC22_Pass_GetAverageScore_MultipleSubjects_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddScoreToStudent("1", "Toán", "9");
            studentManager.AddScoreToStudent("1", "Lý", "7");
            double avg = studentManager.CalculateAvgScore("1");
            Assert.AreEqual(8, avg);
        }

        // TC23: Kiểm tra tính xếp loại khi không có điểm
        // Tính xếp loại với (id = "1") -> Xếp loại = "" (PASS)
        [TestMethod]
        public void TC23_Pass_GetGrade_NoScores_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            string grade = studentManager.CalculateGrate("1");
            Assert.AreEqual("", grade);
        }

        // TC24: Kiểm tra tính xếp loại với điểm trung bình >= 8.5
        // Thêm điểm với (id = "1", Toán = 9, Lý = 8.5) -> Xếp loại = "Giỏi" (PASS)
        [TestMethod]
        public void TC24_Pass_GetGrade_Excellent_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddScoreToStudent("1", "Toán", "9");
            studentManager.AddScoreToStudent("1", "Lý", "8.5");
            string grade = studentManager.CalculateGrate("1");
            Assert.AreEqual("Giỏi", grade);
        }

        // TC25: Kiểm tra tính xếp loại với điểm trung bình >= 7
        // Thêm điểm với (id = "1", Toán = 7, Lý = 7) -> Xếp loại = "Khá" (PASS)
        [TestMethod]
        public void TC25_Pass_GetGrade_Good_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddScoreToStudent("1", "Toán", "7");
            studentManager.AddScoreToStudent("1", "Lý", "7");
            string grade = studentManager.CalculateGrate("1");
            Assert.AreEqual("Khá", grade);
        }

        // TC26: Kiểm tra tính xếp loại với điểm trung bình >= 5
        // Thêm điểm với (id = "1", Toán = 5, Lý = 5) -> Xếp loại = "Trung bình" (PASS)
        [TestMethod]
        public void TC26_Pass_GetGrade_Average_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddScoreToStudent("1", "Toán", "5");
            studentManager.AddScoreToStudent("1", "Lý", "5");
            string grade = studentManager.CalculateGrate("1");
            Assert.AreEqual("Trung bình", grade);
        }

        // TC27: Kiểm tra tính xếp loại với điểm trung bình < 5
        // Thêm điểm với (id = "1", Toán = 4, Lý = 4) -> Xếp loại = "Yếu" / Mong muốn "Trung bình" (FAIL)
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TC27_Pass_GetGrade_Weak_54_Hiep()
        {
            studentManager.AddStudent("1", "Thái Hoà");
            studentManager.AddScoreToStudent("1", "Toán", "4");
            studentManager.AddScoreToStudent("1", "Lý", "4");
            string grade = studentManager.CalculateGrate("1");
            Assert.AreEqual("Trung bình", grade);
        }


        // TC28: Kiểm tra nhập dữ liệu từ tệp CSV và tính toán điểm trung bình
        // Nhập dữ liệu từ tệp CSV (TestData_Student_54_Hiep.csv, TestData_Score_54_Hiep.csv)
        // Tính toán điểm trung bình và xếp loại cho từng sinh viên
        [TestMethod]
        public void TC28_Pass_ImportDataAndCalculate_54_Hiep()
        {
            // Đường dẫn tới tệp CSV
            string studentFilePath = "TestData_54_Hiep/TestData_Student_54_Hiep.csv";
            string scoreFilePath = "TestData_54_Hiep/TestData_Score_54_Hiep.csv";

            // Nhập dữ liệu từ tệp
            ImportStudents(studentFilePath);
            ImportScores(scoreFilePath);

            // Kiểm tra dữ liệu đã được nhập
            Assert.AreEqual(3, studentManager.students.Count);

            // Tính toán điểm trung bình và xếp loại
            foreach (var student in studentManager.students)
            {
                double avgScore = studentManager.CalculateAvgScore(student.Id);
                string grade = studentManager.CalculateGrate(student.Id);

                Console.WriteLine($"Student: {student.FullName}, Avg Score: {avgScore}, Grade: {grade}");
            }
        }

        // Nhập dữ liệu học sinh từ tep CSV
        private void ImportStudents(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines.Skip(1)) // Bỏ qua dòng tiêu đề
            {
                var parts = line.Split(',');
                string id = parts[0].Trim();
                string fullName = parts[1].Trim();
                studentManager.AddStudent(id, fullName);
            }
        }

        // Nhập dữ liệu điểm từ tep CSV
        private void ImportScores(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines.Skip(1)) // Bỏ qua dòng tiêu đề
            {
                var parts = line.Split(',');
                string id = parts[0].Trim();
                string subject = parts[1].Trim();
                string score = parts[2].Trim();
                studentManager.AddScoreToStudent(id, subject, score);
            }
        }
    }
}
