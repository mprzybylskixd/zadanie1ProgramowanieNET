using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MyApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Application app = new Application();
            MainWindow mainWindow = new MainWindow();
            app.Run(mainWindow);
        }
    }
}
