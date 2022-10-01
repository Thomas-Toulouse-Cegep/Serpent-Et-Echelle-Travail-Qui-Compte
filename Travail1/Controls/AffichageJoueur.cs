using Travail1.Models;

namespace Travail1.Controls
{
    public class AffichageJoueur : PictureBox
    {
        public Joueur joueur;
        private int i;

        public AffichageJoueur(Joueur joueur) : base()
        {
            this.joueur = joueur;
            BackColor = Color.Transparent;
            Height = 801;
            Width = 801;
            Image = joueur.Dessiner();
            i = joueur.Points;
            abonnement();
        }

        public void abonnement()
        {
            joueur.joueurBouger += Joueur_joueurBouger;
        }

        private void Joueur_joueurBouger(object? sender, int e)
        {
            Image = joueur.Dessiner();
        }
    }
}