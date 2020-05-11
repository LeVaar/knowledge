using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using DevExpress.Mvvm;
using System.Windows.Input;

namespace FinalProject.ViewModel
{
    public class MainViewModel : BaseVM
    {
        private Page Diseases;
        private Page Bait;
        private Page NormalSigns;
        private Page Periods;
        private Page Picture;
        private Page PossibleSigns;
        private Page Signs;
        private Page SignsPeriods;

        public Page CurrentPage { get; set; }

        public MainViewModel()
        {
            Diseases = new Pages.Diseases();
            Bait = new Bait();
            NormalSigns = new Pages.NormalSigns();
            Periods = new Pages.Periods();
            Picture = new Pages.Picture();
            PossibleSigns = new Pages.PossibleSigns();
            Signs = new Pages.Signs();
            SignsPeriods = new Pages.SignsPeriods();
            
            CurrentPage = Bait;
        }
        public ICommand DClick
        {
            get
            {
                return new DelegateCommand(() => { CurrentPage = Diseases; });
            }
        }
        public ICommand NormalClick
        {
            get
            {
                return new DelegateCommand(() => { CurrentPage = NormalSigns; });
            }
        }
        public ICommand PeriodClick
        {
            get
            {
                return new DelegateCommand(() => { CurrentPage = Periods; });
            }
        }
        public ICommand PictureClick
        {
            get
            {
                return new DelegateCommand(() => { CurrentPage = Picture; });
            }
        }
        public ICommand PossibleClick
        {
            get
            {
                return new DelegateCommand(() => { CurrentPage = PossibleSigns; });
            }
        }
        public ICommand SignsClick
        {
            get
            {
                return new DelegateCommand(() => { CurrentPage = Signs; });
            }
        }
        public ICommand SpClick
        {
            get
            {
                return new DelegateCommand(() => { CurrentPage = SignsPeriods; });
            }
        }
    }
}