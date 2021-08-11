using Prism.Mvvm;

namespace BugReportHelper.Model
{
    public class Vbs : BindableBase
    {
        private string _textToCopy;

        public string TextToCopy
        {
            get => _textToCopy;
            set => SetProperty(ref _textToCopy, value);
        }

        private bool _isSelected;

        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }

    }
}