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
        }

        public void abonnement()
        {
            //   controleur.JoueurChangerPoint += Controleur_JoueurChangerPoint;
        }

        private void Controleur_JoueurChangerPoint(object? sender, int e)
        {
            controleur.penis();
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
            lstDebug.Items.Add("point= " + controleur.Joueurs[id].Points);

            //a garder
            //controleur.penis();
            Tour();
            // abonnement();

            //debug
            lstDebug.Items.Add("TOUR SUIVANT");
            if (controleur.GameOver == true)
            {
                if (controleur.Joueurs[0].Points > controleur.Joueurs[1].Points)
                {
                    MessageBox.Show("Le joueur " + controleur.Joueurs[id].Nom + " � gagner et il a " + controleur.Joueurs[id].Points + " Points.");
                }
                else if (controleur.Joueurs[1].Points > controleur.Joueurs[0].Points)
                {
                    MessageBox.Show("Le joueur " + controleur.Joueurs[id].Nom + " � gagner et il a " + controleur.Joueurs[id].Points + " Points.");
                }
                else
                {
                    MessageBox.Show("Le joueur " + controleur.Joueurs[0].Nom + " et le joueur " + controleur.Joueurs[1].Nom + " sont en �galit� avec " + controleur.Joueurs[id].Points + " Points.");
                }

                this.Hide();
                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
                Close();
            }
            // controleur.Cases[controleur.Joueurs[id].Position].Points = controleur.Joueurs[id].Position ;
            //controleur.Joueurs[id].Points += controleur.Cases[controleur.Joueurs[id].Position];
        }

        private void Tour()
        {
            if (id == 0)
            {
                id = 1;
                lblJoueur.Text = controleur.Joueurs[id].Nom;
                lblJoueur.ForeColor = Color.Red;
                abonnement();
            }
            else
            {
                id = 0;
                lblJoueur.Text = controleur.Joueurs[id].Nom;
                lblJoueur.ForeColor = Color.Blue;
                abonnement();
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