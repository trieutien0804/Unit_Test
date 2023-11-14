using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            Calculation cal = new Calculation(a, b);
            txtKetQua.Text = cal.Excecute("+").ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            Calculation cal = new Calculation(a, b);
            txtKetQua.Text = cal.Excecute("-").ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            Calculation cal = new Calculation(a, b);
            txtKetQua.Text = cal.Excecute("*").ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            Calculation cal = new Calculation(a, b);
            txtKetQua.Text = cal.Excecute("/").ToString();
        }
    }
}
