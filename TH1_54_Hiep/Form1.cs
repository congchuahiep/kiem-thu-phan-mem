using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH1_54_Hiep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelNumber2_54_Hiep_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCong_54_Hiep_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;

            a = int.Parse(textBoxNumber1_54_Hiep.Text);
            b = int.Parse(textBoxNumber2_54_Hiep.Text);

            Calculation_54_Hiep c = new Calculation_54_Hiep(a, b);
            ketqua = c.Execute("+");

            textBoxKetQua_54_Hiep.Text = ketqua.ToString();
        }

        private void buttonTru_54_Hiep_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;

            a = int.Parse(textBoxNumber1_54_Hiep.Text);
            b = int.Parse(textBoxNumber2_54_Hiep.Text);

            Calculation_54_Hiep c = new Calculation_54_Hiep(a, b);
            ketqua = c.Execute("-");

            textBoxKetQua_54_Hiep.Text = ketqua.ToString();
        }

        private void buttonNhan_54_Hiep_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;

            a = int.Parse(textBoxNumber1_54_Hiep.Text);
            b = int.Parse(textBoxNumber2_54_Hiep.Text);

            Calculation_54_Hiep c = new Calculation_54_Hiep(a, b);
            ketqua = c.Execute("*");

            textBoxKetQua_54_Hiep.Text = ketqua.ToString();
        }

        private void buttonChia_54_Hiep_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;

            a = int.Parse(textBoxNumber1_54_Hiep.Text);
            b = int.Parse(textBoxNumber2_54_Hiep.Text);

            Calculation_54_Hiep c = new Calculation_54_Hiep(a, b);
            ketqua = c.Execute("/");

            textBoxKetQua_54_Hiep.Text = ketqua.ToString();
        }
    }
}
