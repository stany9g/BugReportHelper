using System.Collections.ObjectModel;
using BugReportHelper.Model;
using BugReportHelper.Service;
using ImTools;
using Prism.Commands;
using Prism.Mvvm;

namespace BugReportHelper.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly ISthService _service;
        private string _title = "Prism Application";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private ObservableCollection<Vbs> _vbsPaths;

        public ObservableCollection<Vbs> VbsPaths
        {
            get => _vbsPaths;
            set => SetProperty(ref _vbsPaths, value);
        }

        private string _path = @"d:\dev\drives\o";

        public string Path
        {
            get => _path;
            set => SetProperty(ref _path, value);
        }

        public DelegateCommand UpdateCommand { get; set; }

        public MainWindowViewModel(ISthService service)
        {
            _service = service;

            UpdateCommand = new DelegateCommand(Update);

            VbsPaths = new ObservableCollection<Vbs>(_service.LoadInfo(Path));
        }


        private void Update()
        {
            VbsPaths.Add(new Vbs()
            {
                TextToCopy = "new item from update", IsSelected = true
            });
        }
    }
}
