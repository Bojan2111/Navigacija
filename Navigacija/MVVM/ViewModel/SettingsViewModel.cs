using Navigacija.Core;
using Navigacija.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigacija.MVVM.ViewModel
{
    public class SettingsViewModel : Core.ViewModel
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

        public RelayCommand NavigateToHomeCommand { get; set; }

        public SettingsViewModel(INavigationService navigation)
        {
            Navigation = navigation;
            NavigateToHomeCommand = new RelayCommand(execute: o => { Navigation.NavigateTo<HomeViewModel>(); }, canExecute: o => true);
        }

    }
}
