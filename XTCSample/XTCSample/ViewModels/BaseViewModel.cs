using GalaSoft.MvvmLight;

namespace XTCSample.ViewModels
{
    public abstract class BaseViewModel:ViewModelBase
    {
        private bool _isLoading;

        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                if (value == _isLoading) return;
                _isLoading = value;
                RaisePropertyChanged(nameof(IsLoading));
            }
        }
    }
}
