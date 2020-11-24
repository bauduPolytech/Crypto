using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class Decrypt : Crypto
    {
        public string DeCrypt(string cle, string text)
        {
            ToCrypt = text;
            Cle = cle;
            remplirTableauDeCrypt();
            IntervertirColonnesDeCrypt();
            return tableauVersStringDecrypt();
        }

        //Transforme le tableau en chaine de caractrère (decrypt)
        private string tableauVersStringDecrypt()
        {
            string final = "";
            foreach (List<string> uneLigne in LeTab)
            {
                foreach (string uneColone in uneLigne)
                {
                    final += uneColone;
                }
            }
            return final.TrimEnd(' ');
        }

        //Remplie le tableau complet (Décyptage)
        private void remplirTableauDeCrypt()
        {
            int nbLigneMax = (ToCrypt.Length / Cle.Length);
            int nbColMax = Cle.Length;
            LeTab = remplirTableauFictif();
            for (int i = 0; i < nbLigneMax; i++)
            {
                List<string> uneLigne = new List<string>();
                for (int j = 0; j < nbColMax; j++)
                {
                    uneLigne.Add(" ");
                }
                LeTab.Add(uneLigne);
            }
            int ligneActuelle = 0;
            int coloneActuelle = 0;

            foreach (char c in ToCrypt)
            {
                if (ligneActuelle >= nbLigneMax)
                {
                    ligneActuelle = 0;
                    coloneActuelle++;
                }
                LeTab[ligneActuelle][coloneActuelle] = c.ToString();
                ligneActuelle++;
            }
        }

        //Intervertit les colonnes en fonction de la clé (décryptage)
        private void IntervertirColonnesDeCrypt()
        {
            listerL2Alphab();
            List<int> i = new List<int>();
            for (int j = 0; j < L2.Count; j++)
            {
                i.Add(j);
            }
            List<List<string>> leTabFinal = remplirTableauFictif();
            for (int colones = 0; colones < LeTab[0].Count; colones++)
            {
                if (i[colones] != L2[colones])
                {
                    IntervertirColonnes(colones, L2[colones]);
                    int temp = i[L2[colones]];
                    i[L2[colones]] = i[colones];
                    i[colones] = temp;
                }
            }
        }

        private List<List<string>> remplirTableauFictif()
        {
            List<List<string>> LeTabFinal = new List<List<string>>();
            int nbColonesNecessaire = Cle.Length;
            int nbLigneNecessaire = ToCrypt.Length / Cle.Length;
            for (int i = 0; i < nbLigneNecessaire + 1; i++)
            {
                List<string> uneLigne = new List<string>();
                for (int j = 0; j < nbColonesNecessaire; j++)
                {
                    uneLigne.Add(" ");
                }
                LeTabFinal.Add(uneLigne);
            }
            List<string> laLigne = new List<string>();
            for (int j = 0; j < nbColonesNecessaire; j++)
            {
                laLigne.Add(" ");
            }
            LeTabFinal.Add(laLigne);
            return LeTabFinal;
        }

    }
}
