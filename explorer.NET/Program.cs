using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Przestrzeń nazw zawierająca definicje typów programu.
/// </summary>
namespace explorerNET
{
    /// <summary>
    /// Klasa zawierająca funkcję Main().
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Funkcja rozpoczynająca pracę aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
