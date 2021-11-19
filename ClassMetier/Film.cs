using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceCinema.ClassMetier
{
    public class Film
    {
        private int numeroFilm;
        private string titreFilm;
        private int anneFilm;
        //on créé la liste des réalisateurs
        private List<Realisateur> realisateurFilm;
        //on créé la liste des acteurs
        private List<Acteur> acteurFilm;

        //Constructeur
        public Film(int unNumero, string unTitre, int uneAnneDeSortie, Realisateur unRealisateur)
        {
            //passage en public
            NumeroFilm = unNumero;
            TitreFilm = unTitre;
            AnneFilm = uneAnneDeSortie;
            RealisateurFilm = new List<Realisateur>();
            ActeurFilm = new List<Acteur>();
        }

        public int NumeroFilm { get => numeroFilm; set => numeroFilm = value; }
        public string TitreFilm { get => titreFilm; set => titreFilm = value; }
        public int AnneFilm { get => anneFilm; set => anneFilm = value; }
        public List<Realisateur> RealisateurFilm { get => realisateurFilm; set => realisateurFilm = value; }
        public List<Acteur> ActeurFilm { get => acteurFilm; set => acteurFilm = value; }
    }
}
