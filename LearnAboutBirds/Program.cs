namespace LearnAboutBirds
{
    using System;
    using System.Windows.Forms;

    static public class Program
    {
        static public MainFrame main;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main = new MainFrame();
            Application.Run(main);
        }
    }
}
