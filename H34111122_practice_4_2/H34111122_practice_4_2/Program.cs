namespace H34111122_practice_4_2;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    
    public static Form1 Form_chat = new Form1();

    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        //Form_chat = new Form1();
        Application.Run(Form_chat);
    }
}
