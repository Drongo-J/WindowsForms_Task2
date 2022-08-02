using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Task2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1()); // Questionnaire form
            Application.Run(new Form2()); // Calculator

            // Questionnaire form template - https://th.bing.com/th/id/R.14d42a962b6e353de52ec0dc14fd5d67?rik=E2UkGZOgWBtuIA&pid=ImgRaw&r=0
            // Calculator template - https://cdn.dribbble.com/users/2748004/screenshots/6805175/dailyui.004.jpg
        }
    }
}
