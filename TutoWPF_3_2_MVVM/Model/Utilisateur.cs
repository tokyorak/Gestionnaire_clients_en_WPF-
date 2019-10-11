using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoWPF_3_2_MVVM.Model
{
    public class Utilisateur: ViewModel.FrameworkMVVM.ComponentNotifierBase
    {
        private string nom;
        private string prenom;
        private int age;
        private string sexe;
        private string profession;
        private AdresseUtilisateur adresse;

        public string Nom
        {
            get => nom;
            set => NotifyChanges(ref nom, value);
        }
        public string Prenom
        {
            get => prenom;
            set => NotifyChanges(ref prenom, value);
        }
        public int Age
        {
            get => age;
            set => NotifyChanges(ref age, value);
        }
        public string Sexe
        {
            get => sexe;
            set => NotifyChanges(ref sexe, value);
        }
        public string Profession
        {
            get => profession;
            set => NotifyChanges(ref profession, value);
        }
        public AdresseUtilisateur Adresse
        {
            get => adresse;
            set => NotifyChanges(ref adresse, value);
        }
    }
}
