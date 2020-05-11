using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace FinalProject.ViewModel
{
    public class BaseVM : INotifyPropertyChanged
    {
        /*protected BaseVM()
        {
            RegisterCommands();
        }
        protected virtual void RegisterCommands(){}*/
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}