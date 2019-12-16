using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace SimpleNotes.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            EraseCommand = new Command(() => TheNote = string.Empty);

            SaveCommand = new Command(() =>
            {
                if (!string.IsNullOrEmpty(TheNote))
                {
                    AllNotes.Add(TheNote);
                    TheNote = string.Empty;
                }
            });
        }



        public ObservableCollection<string> AllNotes { get; set; } = new ObservableCollection<string>();

        string theNote;
        public string TheNote
        {
            get => theNote;

            set
            {
                theNote = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TheNote)));
            }
        }


        public Command SaveCommand { get; }
        public Command EraseCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
