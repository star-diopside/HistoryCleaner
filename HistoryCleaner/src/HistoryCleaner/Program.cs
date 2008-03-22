using System;
using System.Windows.Forms;
using MyLib.CustomControls;

namespace HistoryCleaner
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new ToolStripColorTable());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}