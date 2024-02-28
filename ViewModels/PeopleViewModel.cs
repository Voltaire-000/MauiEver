using MauiEver.Models;
using MauiEver.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiEver.ViewModels
{
    public class PeopleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private readonly PeopleService peopleService;
        private ObservableCollection<Person> _people;
        //private List<Person> _people;

        public PeopleViewModel(PeopleService peopleService)
        {
            this.peopleService = peopleService;
            //_people = peopleService.GetPeople();
            _people = new ObservableCollection<Person>(peopleService.GetPeople());
        }

        public ObservableCollection<Person> People
        {
            get { return _people; }
            set
            {
                _people = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerArgumentExpression(nameof(People))]string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        //public List<Person> People
        //{
        //    get { return _people; }
        //    set
        //    {
        //        _people = value;
        //        OnPropertyChanged();
        //    }
        //}

        //protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}


    }
}
