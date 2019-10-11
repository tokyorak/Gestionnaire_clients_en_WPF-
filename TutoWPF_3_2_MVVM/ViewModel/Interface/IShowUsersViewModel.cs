using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoWPF_3_2_MVVM.Model;

namespace TutoWPF_3_2_MVVM.ViewModel.Interface
{
    public interface IShowUsersViewModel
    {
        Utilisateur UtilisateurChoisi { get; set; }
        ObservableCollection<Utilisateur> Utilisateurs { get; set; }
    }
}
