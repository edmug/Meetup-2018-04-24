using System;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;

namespace WpfSimpleBinding
{
    public partial class App
    {
        private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, ApplicationTitle(MainWindow?.Title));

            // Prevent default unhandled exception processing
            e.Handled = true;
        }

        internal static string ApplicationTitle(string title)
        {
            return !string.IsNullOrWhiteSpace(title) ? title : GetEntryAssemblyTitle();
        }

        private static string GetEntryAssemblyTitle()
        {
            try
            {
                var asm = Assembly.GetEntryAssembly();
                var title = asm.GetCustomAttribute<AssemblyTitleAttribute>();
                return title?.Title;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
