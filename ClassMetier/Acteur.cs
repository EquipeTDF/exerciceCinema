using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceCinema.ClassMetier
{
    public class Acteur
    {
        private int idActeur;
        private string nomActeur;
        private string prenomActeur;
        private bool cesariseActeur;
        private string photoActeur;

        //Constructeur
        public Acteur(int unIdActeur, string unNomActeur, string unPrenomActeur, bool unCesariseActeur, string unePhotoActeur)
        {
            IdActeur = unIdActeur;
            NomActeur = unNomActeur;
            PrenomActeur = unPrenomActeur;
            CesariseActeur = unCesariseActeur;
            PhotoActeur = unePhotoActeur;
        }

        public int IdActeur { get => idActeur; set => idActeur = value; }
        public string NomActeur { get => nomActeur; set => nomActeur = value; }
        public string PrenomActeur { get => prenomActeur; set => prenomActeur = value; }
        public bool CesariseActeur { get => cesariseActeur; set => cesariseActeur = value; }
        public string PhotoActeur { get => photoActeur; set => photoActeur = value; }
    }
}
