using System;
using System.Collections.ObjectModel;
using System.IO;
using CSharp_lab4_Shcherbatiuk.Models;
using CSharp_lab4_Shcherbatiuk.Tools.Managers;

namespace CSharp_lab4_Shcherbatiuk.Tools.DataStorage
{
    internal class SerializedDataStorage : IDataStorage
    {
        private ObservableCollection<Person> _persons;

        internal SerializedDataStorage()
        {
            try
            {
                _persons = SerializationManager.Deserialize<ObservableCollection<Person>>(FileFolderHelper.StorageFilePath);
            }
            catch (FileNotFoundException)
            {
                _persons = new ObservableCollection<Person>();
                FillPersonsRandomly();
                SaveChanges();
            }
        }

        private void FillPersonsRandomly()
        {
            DateTime minDate = new DateTime(1900, 1, 1);
            DateTime maxDate = DateTime.Today;
            int daySpan = maxDate.Subtract(minDate).Days;
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                AddPerson(new Person($"{GenerateName(8)}",
                    $"{GenerateName(10)}",
                    $"{GenerateName(10)}@gamil.com",
                    minDate.AddDays(rand.Next(1, daySpan))));
            }
        }
        public static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; 
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }
        public void AddPerson(Person person)
        {
            _persons.Add(person);
            SaveChanges();
        }

        public void DeletePerson(Person person)
        {
            _persons.Remove(person);
            SaveChanges();
        }

        public void EditPerson(Person personToChange, Person editedPerson)
        {
            _persons[_persons.IndexOf(personToChange)] = editedPerson;
            SaveChanges();
        }


        public ObservableCollection<Person> PersonsList
        {
            get => _persons;
            set => _persons = value;
        }

        public void SaveChanges()
        {
            SerializationManager.Serialize(_persons, FileFolderHelper.StorageFilePath);
        }
    }
}