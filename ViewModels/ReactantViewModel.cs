using MauiEver.Models;
using MauiEver.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiEver.ViewModels
{
    public class ReactantViewModel(ReactantService reactantService) : INotifyPropertyChanged
    {
        private ObservableCollection<Reactant> _reactants = new(reactantService.GetReactants());
        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Reactant> Reactants
        {
            get { return _reactants; }
            set
            {
                _reactants = value;
                OnPropertyChanged(nameof(Reactants));
            }
        }

        private void OnPropertyChanged(string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
