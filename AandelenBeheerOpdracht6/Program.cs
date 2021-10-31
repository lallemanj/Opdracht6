using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AandelenBeheerOpdracht6
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //static void MainGUI()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new FormAandelen());
        //}
        static void Main()

        {

            AandelenBeheerData.Rss rssdata = new AandelenBeheerData.Rss();

            rssdata.ConnectionString = AandelenBeheerOpdracht6.Properties.Settings.Default.AandelenBeheerConnectionString;

            rssdata.Bewaar("Titel", "Ik", "Geen", "http://", DateTime.Now);

        }
    }
}
