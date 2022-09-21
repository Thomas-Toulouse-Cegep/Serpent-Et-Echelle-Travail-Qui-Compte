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

        public Joueur[] Joueurs { get => joueurs; }

        public Controleur()
        {
            InitialiserCases();
            InitialiserJoueurs("");
        }

        private void InitialiserCases()
        {
            cases = new Case[64];
            for (int i = 0; i < cases.Length; i++)
            {
                cases[i] = new Case(new Points(0), i);
            }
        }

        public void InitialiserJoueurs(string nomJoueur)
        {
            joueurs = new Joueur[2];

            joueurs[0] = new Joueur(0, nomJoueur, Color.Blue);
            joueurs[1] = new Joueur(1, nomJoueur, Color.Red);
            //MessageBox.Show(joueurs[0].Nom);
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

        public void AvancerJoueur(Joueur? joueur)
        {
            if (joueur is null)
            {
                
            }
            
        }
    }
}