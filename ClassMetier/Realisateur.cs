using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceCinema.ClassMetier
{
    public class Realisateur
    {
        private int idRealisateur;
        private string nomRealisateur;
        private string photoRealisateur;

        public Realisateur(int unIdeRealisateur, string unNomRealisateur, string unePhotoRealisateur)
        {
            IdRealisateur = unIdeRealisateur;
            NomRealisateur = unNomRealisateur;
            PhotoRealisateur = unePhotoRealisateur;
        }

        public int IdRealisateur { get => idRealisateur; set => idRealisateur = value; }
        public string NomRealisateur { get => nomRealisateur; set => nomRealisateur = value; }
        public string PhotoRealisateur { get => photoRealisateur; set => photoRealisateur = value; }
    }

}
