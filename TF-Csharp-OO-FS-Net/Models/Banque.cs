using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TF_Csharp_OO_FS_Net.Models;

namespace TF_Csharp_OO_FS_Net.Models
{
    internal class Banque
    {

        public string Nom { get; set; }

        private List<Compte> Comptes { get; set; } = new List<Compte>();

        public Compte? this[string numero]
        {
            get
            {
                foreach (Compte compte in Comptes)
                {
                    if (compte.Numero == numero)
                    {
                        return compte;
                    }
                }

                return null;


                // return Comptes.Find(c => c.Numero == numero); Librairie Linq

            }

        }

        public void Ajouter(Compte compte)
        {
            Comptes.Add(compte);
            Console.WriteLine($"Compte numero {compte.Numero} bien ajouté a la banque {Nom}.");
        }

        public void Supprimer(string numero)
        {
            Compte? compteAsupprimer = this[numero];

            if (compteAsupprimer != null)
            {
                Comptes.Remove(compteAsupprimer);
                Console.WriteLine($"Compte numero {compteAsupprimer.Numero} bien supprimé de la banque {Nom}.");
            }
            else
            {
                Console.WriteLine($"Compte numero {numero} introuvable.");
            }
        }

        //Ajouter une méthode « AvoirDesComptes » à la classe « Banque » recevant en
        //paramètre le titulaire(Personne) qui calculera les avoirs de 
        //tous ses comptes en utilisant l’opérateur « + ». 

        public double AvoirDesComptes(Personne titulaire)
        {
            // Recuperer les comptes du titulaire
            List<Compte> comptesDuTitulaire= new List<Compte>();

            foreach (Compte compte in Comptes)
            {
                if (compte.Titulaire == titulaire)
                {

                    comptesDuTitulaire.Add(compte);

                }
            }

            // Additionner tout les soldes des differents comptes

            double resultat = 0;

            foreach (Compte compte in comptesDuTitulaire)
            {
                resultat += compte;
            }

            // Retourner le resultat

            return resultat;
        }

    }
}


