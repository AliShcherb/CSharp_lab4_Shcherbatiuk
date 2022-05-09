using System;
using System.Windows;
using CSharp_lab4_Shcherbatiuk.Models;
using CSharp_lab4_Shcherbatiuk.Tools.DataStorage;

namespace CSharp_lab4_Shcherbatiuk.Tools.Managers
{
    internal static class StationManager
    {
        private static IDataStorage _dataStorage;

        internal static Person SelectedUser { get; set; }
        internal static IDataStorage DataStorage => _dataStorage;

        internal static void Initialize(IDataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }

        internal static void CloseApp()
        {
            MessageBox.Show("ShutDown");
            Environment.Exit(1);
        }
    }
}