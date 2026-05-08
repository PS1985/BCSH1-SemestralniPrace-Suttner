using BCSH1_SemestralniPrace_Suttner.Forms;

namespace BCSH1_SemestralniPrace_Suttner
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormHlavni());
        }
    }
}