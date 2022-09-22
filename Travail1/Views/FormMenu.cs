using Travail1.Models;
using Travail1.Controllers;
using Travail1.Models;

namespace Travail1.Views

{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formJeu = new FormJeu();
            var formMenu = new FormMenu();
            if (txtJoueur1.Text == "" || txtJoueur2.Text == "")
            {
                if (txtJoueur1.Text == "" && txtJoueur2.Text == "")
                {
                    MessageBox.Show("Veuillez choisir votre nom de joueur 1 et joueur 2");
                }
                else if (txtJoueur1.Text == "")
                {
                    MessageBox.Show("Veuillez choisir votre nom de joueur 1");
                }
                else
                {
                    MessageBox.Show("Veuillez choisir votre nom de joueur 2");
                }
            }
            else
            {
                Controleur controleur = new Controleur();

                controleur.InitialiserJoueurs(txtJoueur1.Text, txtJoueur2.Text);
                formJeu.Show();
                formMenu.Close();
            }
        }
    }
}