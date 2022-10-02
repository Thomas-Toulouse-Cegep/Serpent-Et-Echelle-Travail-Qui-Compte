using Travail1.Controllers;
using Travail1.Models;

namespace Travail1.Controls
{
    public class AffichageJoueur : PictureBox
    {
        public Joueur joueur;
        private Controleur controleur;

        public AffichageJoueur(Joueur joueur) :
            base()
        {
            this.joueur = joueur;
            BackColor = Color.Transparent;
            Height = 801;
            Width = 801;
            Image = joueur.Dessiner();

            abonnement();
        }

        public void abonnement()
        {
            joueur.joueurBouger += Joueur_joueurBouger;
            // joueur.JoueurChangerPoints += Controleur_JoueurChangerPoint;
        }

        private void Joueur_joueurBouger(object? sender, int e)
        {
            Image = joueur.Dessiner();
        }
    }
}