using Travail1.Models;
using Travail1.Models.Case;
using Travail1.Models.Point;

namespace Travail1.Controllers
{
    public class Controleur
    {
        private Case[] cases;
        private Joueur[] joueurs;
        private int id;
        private bool gameOver;
        public Joueur[] Joueurs { get => joueurs; }
        public int Id { get => id; set => id = value; }
        public bool GameOver { get => gameOver; set => gameOver = value; }

        public event EventHandler<Joueur> joueurBouger;

        public event EventHandler<string> JoueurChangerNom;

        public Controleur()
        {
            InitialiserCases();
            InitialiserJoueurs("", "");

            Id = 0;
        }

        private void InitialiserCases()
        {
            int seed = SeedGenerator(69);
            MessageBox.Show(seed.ToString());

            cases = new Case[64];
            for (int i = 0; i < cases.Length; i++)
            {
                cases[i] = new CaseEchelle(new Points(0), i);
            }
        }

        public void InitialiserJoueurs(string nomJoueur1, string nomJoueur2)
        {
            joueurs = new Joueur[2];

            joueurs[0] = new Joueur(0, nomJoueur1, Color.Blue);
            joueurs[1] = new Joueur(1, nomJoueur2, Color.Red);
        }

        public Bitmap DessinerPlancheJeu()
        {
            Bitmap bitmap = new Bitmap(801, 801);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                foreach (var uneCase in cases)
                {
                    uneCase.Dessiner(graphics);
                }
            }
            return bitmap;
        }

        public void AvancerJoueur()
        {
            int new_position = 0;
            Random random = new Random();

            new_position = joueurs[id].Position + random.Next(1, 7);
            if (new_position > 63)
            {
                gameOver = false;
                Tour();
            }
            else if (new_position == 63)
            {
                joueurs[id].Position = new_position;
                gameOver = true;
            }
            else
            {
                gameOver = false;
                joueurs[id].Position = new_position;
                Tour();
            }

        }

        private void Tour()
        {
            if (id == 0)
            {
                id = 1;
            }
            else
            {
                id = 0;
            }
        }

        private int SeedGenerator(int seed)
        {
            Random RandSeed = new Random(seed);
            int finalSeed = RandSeed.Next();
            return finalSeed;
        }
    }
}