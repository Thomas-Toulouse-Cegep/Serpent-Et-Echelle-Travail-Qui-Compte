using Travail1.Controllers;

namespace Travail1.Views

{
    public partial class FormMenu : Form
    {
        private Controleur controleur = new Controleur();

        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                this.Hide();
                controleur.InitialiserJoueurs(txtJoueur1.Text, txtJoueur2.Text);
                var formJeu = new FormJeu(controleur);
                formJeu.ShowDialog();
                Close();
            }
        }
    }
}