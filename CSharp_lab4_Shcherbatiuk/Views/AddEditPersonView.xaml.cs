using CSharp_lab4_Shcherbatiuk.Tools.Navigation;
using CSharp_lab4_Shcherbatiuk.ViewModels;

namespace CSharp_lab4_Shcherbatiuk.Views
{
    /// <summary>
    /// Interaction logic for AddEditPersonView.xaml
    /// </summary>
    public partial class AddEditPersonView:  INavigatable
    {
        public AddEditPersonView()
        {
            InitializeComponent();
            DataContext = new AddEditViewModel();
        }
    }

}
