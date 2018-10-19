using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using XamFormsMVVMExample.ViewModels.Base;

namespace XamFormsMVVMExample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private int _clicks = 0;

        public int Clicks
        {
            get { return _clicks; }
            set
            {
                _clicks = value;
                RaisePropertyChanged();
            }
        }

        private double _sliderValue;

        public double SliderValue
        {
            get { return _sliderValue; }
            set
            {
                _sliderValue = value;
                RaisePropertyChanged();
            }
        }

        private string _canExecuteText;

        public string CanExecuteText
        {
            get { return _canExecuteText; }
            set {
                if (value != _canExecuteText)
                {
                    _canExecuteText = value;
                    RaisePropertyChanged();
                    TestCommand.RaiseCanExecuteChanged();
                }
            }
        }



        private DelegateCommand _clickCommand;
        public DelegateCommand ClickCommand
        {
            get { return _clickCommand = _clickCommand ?? new DelegateCommand(ClickCommandDelegate); }
        }

        private void ClickCommandDelegate()
        {
            Clicks++;
        }

        private DelegateCommand _testCommand;
        public DelegateCommand TestCommand
        {
            get { return _testCommand = _testCommand ?? new DelegateCommand(TestCommandDelegate, () => !string.IsNullOrEmpty(CanExecuteText)); }
        }

        private void TestCommandDelegate()
        {

        }
    }
}
