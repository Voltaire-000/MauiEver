using MauiEver.Models;
using MauiEver.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiEver.ViewModels
{
    public class PeopleViewModel(PeopleService peopleService) : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private ObservableCollection<Person> _people = new(peopleService.GetPeople());

        public ObservableCollection<Person> People
        {
            get { return _people; }
            set
            {
                _people = value;
                OnPropertyChanged(nameof(People));
            }
        }

        protected void OnPropertyChanged(string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
