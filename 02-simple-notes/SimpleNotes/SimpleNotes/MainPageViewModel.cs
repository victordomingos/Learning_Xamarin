﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace SimpleNotes.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {


        public MainPageViewModel()
        {
            EraseCommand = new Command(() => { TheNote = string.Empty; });

            SaveCommand = new Command(() =>
            {
                AllNotes.Add(TheNote);
                TheNote = string.Empty;
            });
        }



        public event PropertyChangedEventHandler PropertyChanged;


        public ObservableCollection<string> AllNotes { get; set; } = new ObservableCollection<string>();


        string theNote;

        public string TheNote
        {
            get => theNote;

            set
            {
                theNote = value;
                var args = new PropertyChangedEventArgs(nameof(TheNote));

                PropertyChanged?.Invoke(this, args);
            }
        }


        public Command SaveCommand { get; }

        public Command EraseCommand { get; }

    }
}
