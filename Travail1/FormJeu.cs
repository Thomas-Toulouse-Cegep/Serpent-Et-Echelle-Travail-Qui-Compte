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

        public FormJeu()
        {
            InitializeComponent();
            controleur = new Controleur();
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
            Random random = new Random();
            int nouvellePosition = random.Next(1,7);
            controleur.Joueurs[id].Position = controleur.Joueurs[id].Position + nouvellePosition;
            controleur.AvancerJoueur();
            Tour();
            MessageBox.Show(controleur.Joueurs[id].Position.ToString());
        }

        private void Tour()
        {
            if(id == 0)
            {
                id = 1;
                lblJoueur.Text = controleur.Joueurs[1].Nom;
            }
            else
            {
                id = 0;
                lblJoueur.Text = controleur.Joueurs[0].Nom;
            }
        }

        private void FormJeu_Load(object sender, EventArgs e)
        {
            lblJoueur.Text = controleur.Joueurs[0].Nom;
        }
    }
}