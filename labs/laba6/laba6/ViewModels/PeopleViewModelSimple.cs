using laba6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace laba6.ViewModels
{
    public class PeopleViewModelSimple
    {
        private List<PersonModelSimple> _people;
        private PersonModelSimple _selectedPerson;
        public PersonModelSimple SelectedPerson { get; set; }
        public List<PersonModelSimple> People
        {
            get => _people;
            set => _people = value;
        }
        public PeopleViewModelSimple()
        {
            _people =
            [
                new() { Id = 1, Name = "Dasha", Desc = "puteshestvennica", BirthDate = new DateOnly(2018, 4, 13) },
                new() { Id = 2, Name = "Tomas", Desc = "parovozik", BirthDate = new DateOnly(1984, 9, 4) }
            ];
        }

        public ICommand ShowWindowCommand => new RelayCommands(ShowWindow);
        public ICommand ChangeItemCommand => new RelayCommands(ChangeItem);
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

        private void ChangeItem(object parameter)
        {
            if (_selectedPerson != null)
            {
                var obj = _people.FirstOrDefault(x => x.Id == _selectedPerson.Id);
                if (obj != null
                    && obj.Name != _selectedPerson.Name
                    && obj.BirthDate != _selectedPerson.BirthDate
                    && obj.Desc != _selectedPerson.Desc)
                {
                    obj.Name = _selectedPerson.Name;
                    obj.BirthDate = _selectedPerson.BirthDate;
                    obj.Desc = _selectedPerson.Desc;
                    MessageBox.Show("Успешно обновленно");
                    return;
                }
                MessageBox.Show("Не удалось обновить");
            }
        }

        private void PushNewItem(object parameter)
        {
            PersonModelSimple newPerson = new();
            People.Add(newPerson);
            SelectedPerson = newPerson;
        }//Не можу понять почему не работает но вроде всё правильно написанно

        private void PopLastItem(object parameter)
        {
            if (People.Count > 0)
            {
                var lastPerson = People[People.Count - 1];
                People.Remove(lastPerson);
            }
        }//Не можу понять почему не работает но вроде всё правильно написанно
    }
}
