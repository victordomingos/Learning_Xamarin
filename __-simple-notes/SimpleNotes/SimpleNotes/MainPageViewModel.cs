using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace SimpleNotes.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public Command SelectedNoteChangedCommand { get; }

        string selectedNote;
        public string SelectedNote { get; set; }

        public MainPageViewModel()
        {
            AllNotes = new ObservableCollection<string>();

            SelectedNoteChangedCommand = new Command(async () =>
            {
                var detailVM = new DetailPageViewModel(SelectedNote);
                var detailPage = new DetailPage();
                detailPage.BindingContext = detailVM;

                await Application.Current.MainPage.Navigation.PushAsync(detailPage);
            });


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



        public ObservableCollection<string> AllNotes { get; set; }

        private string theNote;
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
