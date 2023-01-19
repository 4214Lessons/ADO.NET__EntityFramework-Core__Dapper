namespace ADONETLesson4_ClassicAsynchronous;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new ClassicAsynchronous());
    }
}