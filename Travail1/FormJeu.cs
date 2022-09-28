using Travail1.Controllers;
using Travail1.Controls;
using Travail1.Views;

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
            abonnement();
        }

        public void abonnement()
        {
            controleur.JoueurChangerNom += Controleur_JoueurChangerNom;
        }

        private void Controleur_JoueurChangerNom(object? sender, string nom)
        {
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
            //debug
            int avant = controleur.Joueurs[id].Position;
            lstDebug.Items.Add("joueur = " + controleur.Joueurs[id].Nom);
            lstDebug.Items.Add("avant = " + avant.ToString());
            //a garder
            controleur.AvancerJoueur();
            //debug
            int apres = controleur.Joueurs[id].Position;
            lstDebug.Items.Add("apres = " + apres.ToString());
            lstDebug.Items.Add("de = " + (apres - avant).ToString());
            //a garder
            Tour();
            //debug
            lstDebug.Items.Add("TOUR SUIVANT");
            if (controleur.GameOver == true)
            {
                this.Hide();
                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
                Close();
            }
        }

        private void Tour()
        {
            if (id == 0)
            {
                id = 1;
                lblJoueur.Text = controleur.Joueurs[id].Nom;
                lblJoueur.ForeColor = Color.Red;
            }
            else
            {
                id = 0;
                lblJoueur.Text = controleur.Joueurs[id].Nom;
                lblJoueur.ForeColor = Color.Blue;
            }
        }

        private void FormJeu_Load(object sender, EventArgs e)
        {
            lblJoueur.Text = controleur.Joueurs[id].Nom;
            lblJoueur.ForeColor = Color.Blue;
        }

        private void userInfoJoueur1_Load(object sender, EventArgs e)
        {
        }
    }
}