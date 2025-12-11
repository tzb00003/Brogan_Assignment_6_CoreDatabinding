namespace Brogan_Assignment_6_CoreDatabinding
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //IPersonGetter personGetter = new PersonGetter();
            IPersonGetter personGetter = new PersonListGetter();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(personGetter));
        }
    }
}