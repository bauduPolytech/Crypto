using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    public class Encrypt: Crypto
    {

        public Encrypt() : base()
        {

        }

        //Renvoie le Tableau complet avec la phrase à chiffrer sans le triage par colonne alphabétique
        private void remplirTableau()
        {
            remplirTableauFictif();
            int nbColoneMax = Cle.Length;
            int ligneActuelle = 0;
            int coloneActuelle = 0;

            foreach (char c in ToCrypt)
            {
                if (coloneActuelle >= nbColoneMax)
                {
                    coloneActuelle = 0;
                    ligneActuelle++;
                }
                LeTab[ligneActuelle][coloneActuelle] = c.ToString();
                coloneActuelle++;
            }
        }


        //Intervertit les colones en fonction du numéro donné par la liste l2
        private void IntervertirColonnes()
        {
            for (int i = 0; i < L2.Count; i++)
            {
                for (int j = 0; j < L2.Count - 1; j++)
                {
                    if (L2[j] > L2[j + 1])
                    {
                        int temp = L2[j];
                        L2[j] = L2[j + 1];
                        L2[j + 1] = temp;
                        IntervertirColonnes(j, j + 1);
                    }
                }
            }
        }

        //Transforme le Tableau en chaine de caractère ligne par ligne
        private string tableauVersString()
        {
            string final = "";
            for (int colonne = 0; colonne < LeTab[0].Count; colonne++)
            {
                for (int ligne = 0; ligne < LeTab.Count; ligne++)
                {
                    final += LeTab[ligne][colonne];
                }
            }
            return final;
        }

        public string Crypt(string toCrypt, string cle)
        {
            Cle = cle;
            ToCrypt = toCrypt;
            listerL2Alphab();
            remplirTableau();
            IntervertirColonnes();
            return tableauVersString();

        }
    }
}
