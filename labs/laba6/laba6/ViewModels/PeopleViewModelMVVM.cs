using laba6.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace laba6.ViewModels
{
    internal class PeopleViewModelMVVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private ObservableCollection<PersonModelMVVM> _people =
        [
            new() { Id = 1, Name = "Dasha", Desc = "puteshestvennica", BirthDate = new DateOnly(2018, 4, 13) },
            new() { Id = 2, Name = "Tomas", Desc = "parovozik", BirthDate = new DateOnly(1984, 9, 4) }
        ];
        private PersonModelMVVM _selectedPerson;

        public ObservableCollection<PersonModelMVVM> People
        {
            get => _people;
            set
            {
                _people = value;
                OnPropertyChanged();
            }
        }

        public PersonModelMVVM SelectedPerson
        {
            get => _selectedPerson;
            set
            {
                _selectedPerson = value;
                OnPropertyChanged();
            }
        }

        public ICommand ShowWindowCommand => new RelayCommands(ShowWindow);
        public ICommand PushItemCommand => new RelayCommands(PushNewItem);
        public ICommand PopItemCommand => new RelayCommands(PopLastItem);

        private void ShowWindow(object parameter)
        {
            MainWindow mainWindow = new()
            {
                DataContext = this
            };
            mainWindow.Show();
        }

        private void PushNewItem(object parameter)
        {
            PersonModelMVVM newPerson = new();
            People.Add(newPerson);
            SelectedPerson = newPerson;
        }

        private void PopLastItem(object parameter)
        {
            if (People.Count > 0)
            {
                var lastPerson = People[People.Count - 1];
                People.Remove(lastPerson);
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand ResetProcessCommand => new RelayCommands(ResetProcess);
        public ICommand BeginProcessCommand => new RelayCommands(BeginProcess);
        public ICommand StopProcessCommand => new RelayCommands(StopProcess);

        private void BeginProcess(object parameter)
        {
            SelectedPerson?.BeginProcess();
        }

        private void ResetProcess(object parameter)
        {
            SelectedPerson?.ResetProcessAsync();
        }

        private void StopProcess(object parameter)
        {
            SelectedPerson?.StopProcess();
        }
    }
}
