using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QLNS.setupviewmodel

{
    public class ViewModel : BaseViewModel
    {
        public ICommand closewindow { get; set; }

        public ViewModel()
        {
            this.closewindow = new RelayCommand<object>((p) => { return true; }, close);
        }

        public void close(object a)
        {
            Window window = a as Window;
            window.Close();
        }
    }
}
