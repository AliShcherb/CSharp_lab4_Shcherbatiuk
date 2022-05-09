using System.Collections.ObjectModel;
using CSharp_lab4_Shcherbatiuk.Models;

namespace CSharp_lab4_Shcherbatiuk.Tools.DataStorage
{
    internal interface IDataStorage
    {
        void AddPerson(Person person);
        void DeletePerson(Person person);
        void EditPerson(Person personToChange,Person editedPerson);
        void SaveChanges();
        ObservableCollection<Person> PersonsList { get; }
    }
}