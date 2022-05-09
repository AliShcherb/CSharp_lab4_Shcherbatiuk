namespace CSharp_lab4_Shcherbatiuk.Tools.Navigation
{
    internal enum ViewType
    {
        AddEdit = 0,
        PersonGrid = 1,
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}