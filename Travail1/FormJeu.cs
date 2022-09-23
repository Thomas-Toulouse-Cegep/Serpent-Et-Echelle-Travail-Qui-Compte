using Travail1.Controllers;
using Travail1.Controls;
using Travail1.Models;

namespace Travail1
{
    public partial class FormJeu : Form
    {
        private Controleur controleur;
        private AffichageJoueur[] affichageJoueurs;
        private int id = 0;

        public FormJeu(Controleur controleur)
        {
            InitializeComponent();
            this.controleur = controleur;
            picPlancheJeu.Image = controleur.DessinerPlancheJeu();
            InitAffichageJoueurs();
        }

        private void InitAffichageJoueurs()
        {
            affichageJoueurs = new AffichageJoueur[controleur.Joueurs.Length];
            for (int i = 0; i < controleur.Joueurs.Length; ++i)
            {
                affichageJoueurs[i] = new AffichageJoueur(controleur.Joueurs[i]);
            }
            picPlancheJeu.Controls.Add(affichageJoueurs[0]);
            for (int i = 1; i < affichageJoueurs.Length; ++i)
            {
                affichageJoueurs[i - 1].Controls.Add(affichageJoueurs[i]);
            }
        }


        private void btnAvancer_Click(object sender, EventArgs e)
        {
            controleur.AvancerJoueur();
            Tour();
        }

        private void Tour()
        {
            if(id == 0)
            {
                id = 1;
                lblJoueur.Text = controleur.Joueurs[1].Nom;
                lblJoueur.ForeColor = Color.Red;
            }
            else
            {
                id = 0;
                lblJoueur.Text = controleur.Joueurs[0].Nom;
                lblJoueur.ForeColor = Color.Blue;
            }
        }

        private void FormJeu_Load(object sender, EventArgs e)
        {
            Tour();
        }
    }
}