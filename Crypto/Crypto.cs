using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    public class Crypto
    {
        private string toCrypt;
        private string cle;
        private List<int> l2;
        private List<List<string>> leTab;

        //Constructeur vide
        public Crypto()
        {

        }
        //Intervertit les colonnes col1 et col2 de leTab
        protected void IntervertirColonnes(int col1, int col2)
        {
            int nbLignes = LeTab.Count;
            for (int i = 0; i < nbLignes; i++)
            {
                string temp = LeTab[i][col1];
                LeTab[i][col1] = LeTab[i][col2];
                LeTab[i][col2] = temp;
            }
        }

        //Créer le tableau complet (lignes et colones) avec des valeurs nulles
        protected void remplirTableauFictif()
        {
            LeTab = new List<List<string>>();
            int nbColonesNecessaire = Cle.Length;
            int nbLigneNecessaire = ToCrypt.Length / Cle.Length;
            for (int i = 0; i < nbLigneNecessaire + 1; i++)
            {
                List<string> uneLigne = new List<string>();
                for (int j = 0; j < nbColonesNecessaire; j++)
                {
                    uneLigne.Add(" ");
                }
                LeTab.Add(uneLigne);
            }
            List<string> laLigne = new List<string>();
            for (int j = 0; j < nbColonesNecessaire; j++)
            {
                laLigne.Add(" ");
            }
            LeTab.Add(laLigne);
        }

        //Renvoie un tableau de chiffre (en string) qui identifie chaque lettre de la clé par ordre alphabétique
        //Ex : "Test" = "2013"
        protected void listerL2Alphab()
        {

            L2 = new List<int>();
            char[] char_cle = Cle.ToCharArray();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            int i = 0;
            foreach (char c in Cle)
            {
                L2.Add(0);
            }
            foreach (char c in alphabet)
            {

                for (int j = 0; j < char_cle.Length; j++)
                {
                    if (char_cle[j] == c)
                    {
                        L2[j] = i;
                        i++;
                    }
                }
            }
        }

        private static readonly Random random = new Random();
        public string GenererCle(int length = 5)
        {
            //const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"; // les charactères possibles dans la chaîne
            const string chars = "abcdefghijklmnopqrstuvwxyz"; // les charactères possibles dans la chaîne
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        protected string Cle { get => cle; set => cle = value; }
        protected List<int> L2 { get => l2; set => l2 = value; }
        protected List<List<string>> LeTab { get => leTab; set => leTab = value; }
        protected string ToCrypt { get => toCrypt; set => toCrypt = value; }
    }

    
}
