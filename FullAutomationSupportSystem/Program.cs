using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FullAutomationSupportSystem
{
    static class Programforuda
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
