using System.Windows;
using CSharp_lab4_Shcherbatiuk.ViewModels;

namespace CSharp_lab4_Shcherbatiuk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
