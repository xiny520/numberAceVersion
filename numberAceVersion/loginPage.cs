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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide this form (gamepage)
            homePage back = new homePage(); // link to homepage
            back.Show(); // show homepage form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide this form (gamepage)
            homePage back = new homePage(); // link to homepage
            back.Show(); // show homepage form
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
        }
    }
}
