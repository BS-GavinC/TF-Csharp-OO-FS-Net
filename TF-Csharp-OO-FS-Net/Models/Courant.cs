using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Models
{
    public class Courant : Compte
    {

        #region Props

        private double _ligneDeCredit;

        public double LigneDeCredit
        {
            get { return _ligneDeCredit; }
            set
            {
                if (value >= 0)
                {
                    _ligneDeCredit = value;
                }
            }
        }


        #endregion

        #region Methodes

        public override void Retrait(double montant)
        {
            base.Retrait(montant,LigneDeCredit);
        }
        protected override double CalculInteret()
        {
            return Solde >= 0 ? Solde * .03 : Solde * .0975;
        }

        #endregion

    }
}
