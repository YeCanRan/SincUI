using SincUI.Forms;

namespace SincUI.Demo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            SincSplasher.Show(typeof(Splash));
            Application.Run(new MainForm());
        }
    }
}