using Travail1.Models;
using Travail1.Models.Case;
using Travail1.Models.Point;

namespace Travail1.Controllers
{
    public class Controleur
    {
        private Case[] cases;
        private Joueur[] joueurs;
        public Points pts = new Points(0);
        private int i;
        private int id;
        private bool gameOver;
        private Random RandSeed = new Random(69);

        private int nbEchelle = 0;
        private int nbSaut = 0;
        private int nbSerpent = 0;
        private int nbTrape = 0;

        public Joueur[] Joueurs { get => joueurs; }
        public int Id { get => id; set => id = value; }
        public bool GameOver { get => gameOver; set => gameOver = value; }
        public Case[] Cases { get => cases; set => cases = value; }

        public event EventHandler<Joueur> joueurBouger;

        public event EventHandler<int> JoueurChangerPoints;

        public Controleur()
        {
            InitialiserCases();
            InitialiserJoueurs("", "");

            Id = 0;
        }

        private void InitialiserCases()
        {

            cases = new Case[64];

            //3 premieres cases safe
            for (int i = 0; i < 4; i++)
            {
                cases[i] = new Case(new Points(i), i);
            }

            //3 dernieres caases safe
            for (int i = 61; i < cases.Length; i++)
            {
                cases[i] = new Case(new Points(i), i);
            }

            //autres cases random
            for (int i = 3; i < cases.Length - 3; i++)
            {
                int randCase = RandSeed.Next(0, 5);

                //case echelle
                if (randCase == 1)
                {
                    cases[i] = new CaseEchelle(new Points(0), i);
                    nbEchelle++;
                }

                //case saut
                else if (randCase == 2)
                {
                    cases[i] = new CaseSaut(new Points(0), i);
                }

                //case trape
                else if (randCase == 3)
                {
                    cases[i] = new CaseTrappe(new Points(0), i);
                }
                else if (randCase == 4)
                {
                    cases[i] = new CaseTrappe(new Points(0), i);
                }
                else
                {
                    cases[i] = new Case(new Points(i), i);
                }
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
                foreach (var uneCase in Cases)
                {
                    uneCase.Dessiner(graphics);
                }
            }
            return bitmap;
        }

        public void penis()
        {
            MessageBox.Show(joueurs[id].Position.ToString());
            pts.ajouterpoint(joueurs[id].Position, joueurs[id].Points);
            MessageBox.Show(joueurs[id].Points.ToString());
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
                penis();
                gameOver = true;
            }
            else
            {
                gameOver = false;
                joueurs[id].Position = new_position;
                penis();
                Tour();
            }
        }

        private void Tour()
        {
            if (id == 0)
            {
                id = 1;

                // i = pts.ChangedPoint();
                //i=pts.ObtenirPoints();
                // joueurs[id].Points = pts.ObtenirPoints();
            }
            else
            {
                id = 0;
                //joueurs[id].Point.ChangedPoint();
                //joueurs[id].Points = pts.ObtenirPoints();
            }
        }

        private bool Echelle()
        {
            if (nbEchelle == 4)
            {
                return false;
            }
            else
            {
                return true;
            }

            nbEchelle++;
        }

        private bool Saut()
        {
            if (nbSaut == 4)
            {
                return false;
            }
            else
            {
                return true;
            }

            nbSaut++;
        }

        private bool Serpent()
        {
            if (nbSerpent == 4)
            {
                return false;
            }
            else
            {
                return true;
            }

            nbSerpent++;
        }

        private bool Trape()
        {
            if (nbTrape == 4)
            {
                return false;
            }
            else
            {
                return true;
            }

            nbTrape++;
        }
    }
}