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
            lbAffichageJoueur1.Text = Controleur.Nom1;
        }

        private void UserInfoJoueur_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Controleur.Nom1);
            lbAffichageJoueur1.Text = Controleur.Nom1;
        }
    }
}