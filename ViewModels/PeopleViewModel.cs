using AddressBook;
using MauiEver.Models;
using MauiEver.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiEver.ViewModels
{
    internal class PeopleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private readonly PeopleService? peopleService;
        private readonly List<Person>? _people;

        public PeopleViewModel(PeopleService peopleService)
        {
            this.peopleService = peopleService;
            _people = peopleService.GetPeople();
        }

        public List<Person> people
        {
            get { return people; }
            set
            {
                people = value;
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
