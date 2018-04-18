using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QLNS.setupviewmodel
{
    class Viewmodel : BaseViewModel
    {
        #region
        public ICommand closewindowCommand { get; set; }
        #endregion
        public Viewmodel()
        {
            closewindowCommand = new RelayCommand<login>((p) => { return p==null? false : true; }, (p) => { getwindow(p); });
        }
        void getwindow(login p)
        {
            FrameworkElement t = p.Parent as FrameworkElement;
        }
    }

}
