using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoWPF_3_2_MVVM.Model;
using TutoWPF_3_2_MVVM.ViewModel.Interface;

namespace TutoWPF_3_2_MVVM.ViewModel.Design
{
    public class DesignShowUsersViewModel : IShowUsersViewModel
    {
        public Utilisateur UtilisateurChoisi
        {
            get => new Utilisateur()
            {
                Nom = "John",
                Prenom = "Doe",
                Age = 42,
                Sexe = "M",
                Profession = "Actor",
                Adresse = new AdresseUtilisateur()
                {
                    Numero = 21,
                    Voie = "André Maginot",
                    CodePostal = 91400,
                    Ville = "ORSAY",
                    Pays = "Paris"
                }
            };
            set { }
        }
        public ObservableCollection<Utilisateur> Utilisateurs
        {
            get => new ObservableCollection<Utilisateur>() { UtilisateurChoisi };
            set { }
        }
    }
}
