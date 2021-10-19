using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintToScreen {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread.CurrentThread.IsBackground = true;
            Thread.CurrentThread.Name = "Paint2Screen";
            Paint paint2screen = new Paint();

            Application.Run(paint2screen);
        }
    }
}
