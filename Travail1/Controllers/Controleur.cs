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
        private int id;
        private bool gameOver;
        private Random RandSeed = new Random(69);

        private int nbEchelle = 0;
        private int nbSaut = 0;
        private int nbSerpent = 0;
        private int nbTrape = 0;
        private Random random = new Random();

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
                int randCase = RandSeed.Next(0, 8);

                //case echelle
                if (randCase == 1)
                {
                    //4 case echelle
                    if (Echelle())
                    {
                        //pas a la fin
                        if (i < 57)
                        {
                            cases[i] = new CaseEchelle(new PointQuitteOuDouble(0), i);
                            nbEchelle++;
                        }
                        else
                        {
                            cases[i] = new Case(new Points(i), i);
                        }
                    }
                    else
                    {
                        cases[i] = new Case(new Points(i), i);
                    }
                }

                //case saut
                else if (randCase == 2)
                {
                    //4 case saut
                    if (Saut())
                    {
                        cases[i] = new CaseSaut(new Points(0), i);
                        nbSaut++;
                    }
                    else
                    {
                        cases[i] = new Case(new Points(i), i);
                    }
                }

                //case Serpent
                else if (randCase == 3)
                {
                    //4 case Serpent
                    if (Serpent())
                    {
                        //pas au debut
                        if (i > 8)
                        {
                            cases[i] = new CaseTrappe(new PointNegatif(0), i);
                            nbSerpent++;
                        }
                        else
                        {
                            cases[i] = new Case(new Points(i), i);
                        }
                    }
                    else
                    {
                        cases[i] = new Case(new Points(i), i);
                    }
                }

                //case trape
                else if (randCase == 4)
                {
                    //4 case trape
                    if (Trape())
                    {
                        cases[i] = new CaseTrappe(new PointNegatif(0), i);
                        nbTrape++;
                    }
                    else
                    {
                        cases[i] = new Case(new Points(i), i);
                    }
                }

                //case
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
            int ss = pts.ajouterpoint(joueurs[id].Position, Convert.ToInt32(joueurs[id].points));
            joueurs[id].points = ss;
            MessageBox.Show("lol = " + joueurs[id].Points.ToString());
        }

        public void AvancerJoueur()
        {
            Random random = new Random();
            int newPosition = joueurs[id].Position + random.Next(1, 7);
            int next = 0;

            if (newPosition > 63)
            {
                gameOver = false;
                Tour();
            }
            else if (newPosition == 63)
            {
                joueurs[id].Position = newPosition;
                penis();
                gameOver = true;
            }
            else
            {
                gameOver = false;

                string nextCase = cases[newPosition].GetType().Name;
                MessageBox.Show(nextCase);

                if (nextCase == "CaseEchelle")
                {
                    next = nextEchelle();
                    newPosition = newPosition + next;
                }
                else if (nextCase == "CaseSaut")
                {
                    next = nextSaut();
                    newPosition = newPosition + next;
                }
                else if (nextCase == "CaseSerpent")
                {
                    next = nextSerpent();
                    newPosition = newPosition - next;
                }
                else if (nextCase == "CaseTrappe")
                {
                    next = nextTrappe();
                    newPosition = newPosition - next;
                    if (newPosition < 0)
                    {
                        newPosition = 0;
                    }
                }

                joueurs[id].Position = newPosition;
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
        }

        private int nextEchelle()
        {
            return 6;
        }

        private int nextSaut()
        {
            int nb = random.Next(1, 4);
            return nb;
        }

        private int nextSerpent()
        {
            return 6;
        }

        private int nextTrappe()
        {
            int nb = random.Next(5, 11);
            return nb;
        }
    }
}