using Navigacija.Core;
using Navigacija.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigacija.MVVM.ViewModel
{
    public class HomeViewModel : Core.ViewModel
    {
        private INavigationService _navigation;

        public INavigationService Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand NavigateToSettingsCommand { get; set; }

        public HomeViewModel(INavigationService navigation)
        {
            Navigation = navigation;
            NavigateToSettingsCommand = new RelayCommand(execute: o => { Navigation.NavigateTo<SettingsViewModel>(); }, canExecute: o => true);
        }
    }
}
