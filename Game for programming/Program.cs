using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_for_programming
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary> 
        public static string connectionString;
        [STAThread]  
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            connectionString = File.ReadAllText("Config.txt").Trim();
            string musicFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Music");
            DataManager.Instance.LoadData(connectionString);
            MusicManager.initialize(musicFolder);
            Application.Run(new Menu());
        }
    }
}
