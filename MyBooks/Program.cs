namespace MyApplication
{
    static internal class Program
    {
        [System.STAThread]
        static internal void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new StartupLanguageForm());  
        }
    }
}
