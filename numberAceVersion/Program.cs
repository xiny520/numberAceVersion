using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberAceVersion
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static void addGo(object sender, EventArgs e)
        {
            gamePage.answer = gamePage.num1 + gamePage.num2;
            gamePage.instance.lb1.Text = gamePage.num1.ToString() + " + " + gamePage.num2.ToString();
        }
        public static void subGo(object sender, EventArgs e)
        {
            gamePage.answer = gamePage.num1 - gamePage.num2;
            gamePage.instance.lb1.Text = gamePage.num1.ToString() + " - " + gamePage.num2.ToString();
        }
        public static void mulGo(object sender, EventArgs e)
        {
            gamePage.answer = gamePage.num1 * gamePage.num2;
            gamePage.instance.lb1.Text = gamePage.num1.ToString() + " x " + gamePage.num2.ToString();
        }
        public static void divGo(object sender, EventArgs e)
        {
            int multi = gamePage.num1 * gamePage.num2;
            gamePage.answer = gamePage.num1;
            gamePage.instance.lb1.Text = multi.ToString() + " ÷ " + gamePage.num2.ToString();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new homePage());
        }
    }
}
