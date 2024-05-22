using Lumi.MWM.ViewModel;
using projekt.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumi.MWM.ViewModel
{

    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ProductsViewCommand { get; set; }
        public RelayCommand AboutViewCommand { get; set; }
        public RelayCommand ManufacturersViewCommand { get; set; }
        public RelayCommand SuspensionViewCommand { get; set; }
        public RelayCommand CeilingViewCommand { get; set; }
        public RelayCommand WallViewCommand { get; set; }
        public RelayCommand FloorViewCommand { get; set; }
        public RelayCommand TableViewCommand { get; set; }
        public RelayCommand ChildrenViewCommand { get; set; }
        public RelayCommand PictureViewCommand { get; set; }
        public RelayCommand OutdoorViewCommand { get; set; }
        public RelayCommand InputViewCommand { get; set; }


        public HomeViewModel HomeWM { get; set; }
        public AboutViewModel AboutWM { get; set; }
        public ProductsViewModel ProductsWM { get; set; }
        public ManufacturersViewModel ManufacturersWM { get; set; }
        public SuspensionViewModel SuspensionWM { get; set; }
        public CeilingViewModel CeilingWM { get; set; }
        public WallViewModel WallWM { get; set; }
        public FloorViewModel FloorWM { get; set; }
        public TableViewModel TableWM { get; set; }
        public ChildrenViewModel ChildrenWM { get; set; }
        public PictureViewModel PictureWM { get; set; }
        public OutdoorViewModel OutdoorWM { get; set; }
        public InputViewModel InputWM { get; set; }


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
        public MainViewModel()
        {
            HomeWM = new HomeViewModel();
            AboutWM = new AboutViewModel();
            ProductsWM = new ProductsViewModel();
            ManufacturersWM = new ManufacturersViewModel();
            SuspensionWM = new SuspensionViewModel();
            CeilingWM = new CeilingViewModel();
            WallWM = new WallViewModel();
            FloorWM = new FloorViewModel();
            TableWM = new TableViewModel();
            ChildrenWM = new ChildrenViewModel();
            PictureWM = new PictureViewModel();
            OutdoorWM = new OutdoorViewModel();
            InputWM = new InputViewModel();


            CurrentView = HomeWM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeWM;
            });

            AboutViewCommand = new RelayCommand(o =>
            {
                CurrentView = AboutWM;
            });

            ProductsViewCommand = new RelayCommand(o =>
            {
                CurrentView = ProductsWM;
            });

            ManufacturersViewCommand = new RelayCommand(o =>
            {
                CurrentView = ManufacturersWM;
            });

            SuspensionViewCommand = new RelayCommand(o =>
            {
                CurrentView = SuspensionWM;
            });

            CeilingViewCommand = new RelayCommand(o =>
            {
                CurrentView = CeilingWM;
            });

            WallViewCommand = new RelayCommand(o =>
            {
                CurrentView = WallWM;
            });

            FloorViewCommand = new RelayCommand(o =>
            {
                CurrentView = FloorWM;
            });

            TableViewCommand = new RelayCommand(o =>
            {
                CurrentView = TableWM;
            });

            ChildrenViewCommand = new RelayCommand(o =>
            {
                CurrentView = ChildrenWM;
            });

            PictureViewCommand = new RelayCommand(o =>
            {
                CurrentView = PictureWM;
            });

            OutdoorViewCommand = new RelayCommand(o =>
            {
                CurrentView = OutdoorWM;
            });

            InputViewCommand = new RelayCommand(o =>
            {
                CurrentView = InputWM;
            });
        }
    }
}
