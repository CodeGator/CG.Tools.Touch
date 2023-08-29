
namespace CG.Tools.Touch
{
    /// <summary>
    /// This class represents the main application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// This method is the main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Any arguments specified?
            if (!args.Any())
            {
                // Show the UI.
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
            }
            else
            {
                // We only use the first parameter.
                Utility.TouchFile(args[0]);
            }
        }
    }
}