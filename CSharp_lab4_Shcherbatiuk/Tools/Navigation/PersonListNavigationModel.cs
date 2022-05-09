using System;
using PersonGridView = CSharp_lab4_Shcherbatiuk.Views.PersonGridView;
using AddEditPersonView = CSharp_lab4_Shcherbatiuk.Views.AddEditPersonView;

namespace CSharp_lab4_Shcherbatiuk.Tools.Navigation
{
    internal class PersonListNavigationModel : BaseNavigationModel
    {
        
        public PersonListNavigationModel(IContentOwner contentOwner) : base(contentOwner)
        {

        }

        protected override void InitializeView(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.PersonGrid:
                    AddView(ViewType.PersonGrid, new PersonGridView());
                    break;
                case ViewType.AddEdit:
                    AddView(ViewType.AddEdit, new AddEditPersonView());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
            }
        }
    }
}