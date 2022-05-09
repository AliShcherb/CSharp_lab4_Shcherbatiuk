using System.ComponentModel;
using System.Windows;

namespace CSharp_lab4_Shcherbatiuk.Tools
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        Visibility LoaderVisibility { get; set; }
        bool IsControlEnabled { get; set; }
    }
}