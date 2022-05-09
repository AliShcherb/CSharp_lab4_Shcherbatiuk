using CSharp_lab4_Shcherbatiuk.Tools.Navigation;
using CSharp_lab4_Shcherbatiuk.ViewModels;

namespace CSharp_lab4_Shcherbatiuk.Views
{
    /// <summary>
    /// Interaction logic for PersonGridView.xaml
    /// </summary>
    public partial class PersonGridView : INavigatable
    {
        public PersonGridView()
        {
            InitializeComponent();
            DataContext = new PersonGridViewModel();
        }
    }
}
