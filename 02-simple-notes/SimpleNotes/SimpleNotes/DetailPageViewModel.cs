using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace SimpleNotes.ViewModels
{
    public class DetailPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public DetailPageViewModel(string note)
        {

        }



        string noteText;
        public string NoteText
        {
            get => noteText;

            set
            {
                noteText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NoteText)));
            }
        }


        public Command DismissPageCommand { get; }

    }
}
