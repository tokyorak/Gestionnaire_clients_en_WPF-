using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TutoWPF_3_2_MVVM.ViewModel.FrameworkMVVM
{
    public class ComponentNotifierBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyChanges<T>(ref T member, T value,[CallerMemberName] string name = null)
        {
            if (!Equals(member, value))
            {
                member = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
