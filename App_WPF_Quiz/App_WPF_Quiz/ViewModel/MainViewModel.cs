using App_WPF_Quiz.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using App_WPF_Quiz.Views;

namespace App_WPF_Quiz.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public ICommand ShowStartViewCommand { get; }
        public ICommand ShowQuizSelectionViewCommand { get; }

        public MainViewModel()
        {
            ShowStartViewCommand = new RelayCommand(o => ShowStartView());
            ShowQuizSelectionViewCommand = new RelayCommand(o => ShowQuizSelectionView());
            // Ustawienie początkowego widoku
            CurrentView = new StartView();
        }

        private void ShowStartView()
        {
            CurrentView = new StartView();
        }

        private void ShowQuizSelectionView()
        {
            CurrentView = new QuizSelectionView();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
