using exerciceCinema.ClassMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace exerciceCinema
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //on créé les réalisateurs

            Realisateur r1 = new Realisateur(1, "James Cameron", "images/réalisateurs/jamesCameron.jpg");
            Realisateur r2 = new Realisateur(2, "Conrad Vernon", "images/réalisateurs/images/conradVernon.jpg");
            Realisateur r3 = new Realisateur(3, "Erika Leonard", "images/réalisateurs/erikaLeonard.jpg");

            //on créé les films

            Film f1 = new Film(1, "Le Titanic", 1997, r1);
            Film f2 = new Film(2, "Saucage party", 2016, r2);
            Film f3 = new Film(3, "50 nuances de grey", 2012, r3);

            //on créé les acteurs

            Acteur a1 = new Acteur(1, "Rogen", "Seth", false, "images/Acteurs/rogenSeth.jpg");
            Acteur a2 = new Acteur(2, "Wiig", "Kristen", false, "images/Acteurs/kristenWiig.jpg");
            Acteur a3 = new Acteur(3, "Hunnam", "Charlie", false, "images/Acteurs/charlieHunnam.jpg");
            Acteur a4 = new Acteur(4, "Dornan", "Jamie", false, "images/Acteurs/jamieDornan.jpg");
            Acteur a5 = new Acteur(5, "DiCaprio", "Leonardo", true, "images/Acteurs/leonardoDicaprio.jpg");
            Acteur a6 = new Acteur(6, "Winslet", "Kate", false, "images/Acteurs/kateWinslet.jpg");

            //On attribu un film à un acteur

            f1.RealisateurFilm.Add(r1);
            f2.RealisateurFilm.Add(r2);
            f3.RealisateurFilm.Add(r3);

            //On attribu les acteurs à leurs films
            f1.ActeurFilm.Add(a1);
            f1.ActeurFilm.Add(a2);
            f2.ActeurFilm.Add(a3);
            f2.ActeurFilm.Add(a4);
            f3.ActeurFilm.Add(a5);
            f3.ActeurFilm.Add(a6);

            //On range les films dans la liste film

            List<Film> lesFilms = new List<Film>();
            lesFilms.Add(f1);
            lesFilms.Add(f2);
            lesFilms.Add(f3);

            //On lie lesFilms au list view Film

            lvFilm.ItemsSource = lesFilms;
        }

        private void lvFilm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvRealisateur.ItemsSource = (lvFilm.SelectedItem as Film).RealisateurFilm;
            lvActeur.ItemsSource = (lvFilm.SelectedItem as Film).ActeurFilm;
        }

    }
}
