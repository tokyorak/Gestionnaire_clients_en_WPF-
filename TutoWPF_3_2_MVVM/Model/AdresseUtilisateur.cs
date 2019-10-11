using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoWPF_3_2_MVVM.Model
{
    public class AdresseUtilisateur: ViewModel.FrameworkMVVM.ComponentNotifierBase
    {
        private int numero;
        private string voie;
        private int codePostal;
        private string ville;
        private string pays;

        public int Numero
        {
            get => numero;
            set => NotifyChanges(ref numero, value);
        }
        public string Voie
        {
            get => voie;
            set => NotifyChanges(ref voie, value);
        }
        public int CodePostal
        {
            get => codePostal;
            set => NotifyChanges(ref codePostal, value);
        }
        public string Ville
        {
            get => ville;
            set => NotifyChanges(ref ville, value);
        }
        public string Pays
        {
            get => pays;
            set => NotifyChanges(ref pays, value);
        }
    }
}
