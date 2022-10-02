using Travail1.Controllers;

namespace Travail1.Controls
{
    public partial class UserInfoJoueur : UserControl
    {
        /// <summary>
        /// il va faut faire comme dans bouger pour obtenir les infos
        /// </summary>
        private Controleur controleur;

        public UserInfoJoueur()

        {
            InitializeComponent();
        }

        public Controleur Controleur
        {
            get => controleur;
            set { SetControleur(value); }
        }

        private void SetControleur(Controleur? controleur)
        {
            if (controleur is null)
            {
                lbAffichageJoueur1.Text = "";
                lbAffichageJoueur2.Text = "";
                lbaffichagepointJoueur1.Text = "";
                lbaffichagepointJoueur2.Text = "";
            }
            else
            {
                Desabonner();
            }
            this.controleur = controleur;
            if (controleur is not null)
            {
                InitAffichage();
                Abonner();
            }
        }

        private void Abonner()
        {
            // controleur.JoueurChangerNom += Joueur_ChangedName;
        }

        private void Joueur_ChangedName(object? sender, string nom)
        {
            lbAffichageJoueur1.Text = nom;
        }

        private void Desabonner()
        {
            if (controleur is not null)
            {
                // controleur.JoueurChangerNom -= Joueur_ChangedName;
            }
        }

        private void InitAffichage()
        {
            lbAffichageJoueur1.Text = controleur.Joueurs[0].Nom;
            lbAffichageJoueur2.Text = controleur.Joueurs[1].Nom;
            lbaffichagepointJoueur1.Text = controleur.Joueurs[0].Points.ToString();
            lbaffichagepointJoueur2.Text = controleur.Joueurs[1].Points.ToString();
        }

        private void UserInfoJoueur_Load(object sender, EventArgs e)
        {
        }
    }
}