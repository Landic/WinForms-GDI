namespace Volkov_HW_3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Form1 view = new Form1();
            AutorBooksPresenter presenter = new AutorBooksPresenter(view);
            Application.Run(view);
        }
    }
}