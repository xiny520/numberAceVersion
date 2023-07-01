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
    public partial class customPage : Form
    {
        public customPage()
        {
            InitializeComponent();
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            gamePage gamepage = new gamePage();
            gamepage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide this form (gamepage)
            homePage back = new homePage(); // link to homepage
            back.Show(); // show homepage form
        }
    }
}
