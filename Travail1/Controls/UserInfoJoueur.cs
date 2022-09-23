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
        private Controleur controleur = new Controleur();

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
            // lbAffichageJoueur1.Text = Controleur.Joueurs[1].Nom;
            if (controleur is null)
            {
                lbAffichageJoueur1.Text = "";
                lbAffichageJoueur2.Text = "";
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
        }

        private void InitAffichage()
        {
            lbAffichageJoueur1.Text = controleur.Joueurs[0].Nom;
            lbAffichageJoueur2.Text = controleur.Joueurs[1].Nom;
        }

        /* private void SetDe(De? de)
         {
             if (de is null)
             {
                 lblAffichageTypeDe.Text = "";
                 lblAffichageValeurDe.Text = "";
             }
             else
             {
                 Desabonner(); // désabonne de l'ancien dé
             }
             this.de = de;
             if (de is not null)
             {
                 InitAffichage();
                 Abonner(); // abonne au nouveau dé
             }
         }*/

        /* private void Desabonner()
         {
             if (controleur is not null)
             {
                 controleur.joueurs[]. -= De_ValeurChanged;
             }
         }

         private void Abonner()
         {
             de.ValeurChanged += De_ValeurChanged;
         }
         */

        private void UserInfoJoueur_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Controleur.);

            //Controleur.InitialiserJoueurs(lbAffichageJoueur1.Text, lbAffichageJoueur2.Text);
        }
    }
}