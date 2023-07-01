using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberAceVersion
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            customPage f3 = new customPage();
            f3.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage f2 = new loginPage();
            f2.Show();
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // minimises the browser
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // maximises the browser

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the browser
        }
    }
}
