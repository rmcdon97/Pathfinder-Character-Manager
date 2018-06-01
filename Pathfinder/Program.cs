using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CharacterForm());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

    }

    public class PathfinderTools
    {

    }


    class CharacterRace
    {
        private string raceName;
        private int[] statBonus;

        CharacterRace(string _raceName, int[] _statBonus)
        {
            raceName = _raceName;
            statBonus = _statBonus;
        }
    }

    
}
