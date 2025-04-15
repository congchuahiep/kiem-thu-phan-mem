using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace TestWebDriver_54_Hiep
{
    public partial class AutoTest_WebDriver_54_Hiep : Form
    {
        public AutoTest_WebDriver_54_Hiep()
        {
            InitializeComponent();
        }

        private void ButtonAutoWeb_54_Hiep_Click(object sender, EventArgs e)
        {
            // Khởi tạo WebDriver cho Microsoft Edge
            IWebDriver driver = new EdgeDriver();

            try
            {
                // 1. Cấu hình Implicit Wait (Chờ ngầm định)
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                // 2. Điều hướng đến trang YouTube
                driver.Navigate().GoToUrl("https://www.youtube.com");

                // 3. Tìm kiếm từ khóa "Selenium WebDriver Tutorial"
                var searchBox = driver.FindElement(By.Name("search_query"));
                searchBox.SendKeys("Selenium WebDriver Tutorial");
                searchBox.SendKeys(OpenQA.Selenium.Keys.Enter);

                // 4. Chọn video đầu tiên trong kết quả tìm kiếm
                var firstVideo = driver.FindElement(By.XPath("(//a[@id='video-title'])[1]"));
                firstVideo.Click();

                // 5. Chờ video phát trong 5 giây
                Thread.Sleep(5000);

                // 6. Dừng video
                var videoPlayer = driver.FindElement(By.CssSelector(".html5-video-player"));
                videoPlayer.Click(); // Nhấn vào video để dừng

                // 7. Quay lại trang kết quả tìm kiếm
                driver.Navigate().Back();
                Thread.Sleep(2000); // Chờ 2 giây
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
            finally
            {
                // Đóng trình duyệt
                driver.Quit();
            }
        }
    }
    
}
