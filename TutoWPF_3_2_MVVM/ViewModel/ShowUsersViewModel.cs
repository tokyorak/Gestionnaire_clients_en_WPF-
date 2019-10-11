using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TutoWPF_3_2_MVVM.Model;
using TutoWPF_3_2_MVVM.ViewModel.FrameworkMVVM;
using TutoWPF_3_2_MVVM.ViewModel.Interface;

namespace TutoWPF_3_2_MVVM.ViewModel
{
    public class ShowUsersViewModel : ComponentNotifierBase, IShowUsersViewModel
    {
        #region One User
        private Utilisateur utilisateurChoisi;
        public Utilisateur UtilisateurChoisi
        {
            get => utilisateurChoisi;
            set => NotifyChanges(ref utilisateurChoisi, value);
        }
        #endregion

        #region Users List
        private ObservableCollection<Utilisateur> utilisateurs;
        public ObservableCollection<Utilisateur> Utilisateurs
        {
            get => utilisateurs;
            set => NotifyChanges(ref utilisateurs, value);
        }
        #endregion

        /// <summary>
        /// Set the commands bindings
        /// </summary>
        #region Commands
        private ICommand cmdAdd;
        /// <summary>
        /// Add command
        /// </summary>
        public ICommand CmdAdd
        {
            get
            {
                if (cmdAdd == null)
                    cmdAdd = new RelayCommand<object>(o =>
                    {
                        Utilisateur nouvelleEntree = new Utilisateur() { Adresse = new AdresseUtilisateur() };
                        UtilisateurChoisi = nouvelleEntree;
                        Utilisateurs.Add(nouvelleEntree);
                    });
                return cmdAdd;
            }
        }

        private ICommand cmdDelete;
        /// <summary>
        /// Delete command needs a user as parameter
        /// </summary>
        public ICommand CmdDelete
        {
            get
            {
                if (cmdDelete == null)
                    cmdDelete = new RelayCommand<Utilisateur>(user =>
                    {
                        Utilisateurs.Remove(user);
                    });
                return cmdDelete;
            }
        }

        private ICommand cmdReset;
        /// <summary>
        /// Reset command needs a user as parameter
        /// </summary>
        public ICommand CmdReset
        {
            get
            {
                if (cmdReset == null)
                    cmdReset = new RelayCommand<Utilisateur>(user =>
                    {
                        user.Nom = user.Prenom = user.Sexe = user.Profession = string.Empty;
                        user.Age = 0;
                        user.Adresse.Numero = user.Adresse.CodePostal = 0;
                        user.Adresse.Voie = user.Adresse.Ville = user.Adresse.Pays = string.Empty;
                    });
                return cmdReset;
            }
        }
        #endregion

        #region Constructor
        public ShowUsersViewModel()
        {
            utilisateurs = new ObservableCollection<Utilisateur>();
            // Add an empty chosen user?
        }
        #endregion
    }
}
