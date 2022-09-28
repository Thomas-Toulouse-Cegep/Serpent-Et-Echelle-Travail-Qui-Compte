using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Controls;
using Travail1.Models;
using Travail1.Models.Case;
using Travail1.Models.Point;
using static System.Net.Mime.MediaTypeNames;

namespace Travail1.Controllers
{
    public class Controleur
    {
        private Case[] cases;
        private Joueur[] joueurs;
        private int id;

        public Joueur[] Joueurs { get => joueurs; }
        public int Id { get => id; set => id = value; }

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
            cases = new Case[64];
            for (int i = 0; i < cases.Length; i++)
            {
                cases[i] = new Case(new Points(0), i);
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
            Random random = new Random();
            joueurs[id].Position = joueurs[id].Position + random.Next(1, 7);
            Tour();
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
    }
}