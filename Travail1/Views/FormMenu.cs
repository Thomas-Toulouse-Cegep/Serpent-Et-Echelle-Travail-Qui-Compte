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
            if (txtJoueur1.Text is "" || txtJoueur2.Text is "")
            {
                if (txtJoueur1.Text is null)
                {
                    MessageBox.Show("Veuillez choisir votre nom de joueur 1");
                }
                else if (txtJoueur2.Text is null)
                {
                    MessageBox.Show("Veuillez choisir votre nom de joueur 1");
                }
                else
                {
                    MessageBox.Show("Veuillez choisir votre nom de joueur 1 et joueur");
                }
            }
            else
            {
                Controleur controleur = new Controleur();

                controleur.InitialiserJoueurs(txtJoueur1.Text);
                controleur.InitialiserJoueurs(txtJoueur2.Text);
                formJeu.Show();
                formMenu.Close();
            }
        }
    }
}