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
                Joueur joueur1 = new Joueur(1, txtJoueur1.Text, Color.Red);
                Joueur joueur2 = new Joueur(2, txtJoueur2.Text, Color.Blue);
                formJeu.Show();
                formMenu.Close();
            }
        }
    }
}