using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            //controleur.joueurBouger += De_ValeurChanged;
        }
        private void Desabonner()
        {
            if (controleur is not null)
            {
               // controleur.joueurBouger -=;
            }
        }

        private void InitAffichage()
        {
            lbAffichageJoueur1.Text = controleur.Joueurs[0].Nom;
            lbAffichageJoueur1.Text = controleur.Joueurs[1].Nom;
        }

     

        private void UserInfoJoueur_Load(object sender, EventArgs e)
        {

        }
    }
}