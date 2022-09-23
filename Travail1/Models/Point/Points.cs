using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail1.Models.Point
{
    public class Points
    {
        private Random random = new Random();
        private int valeur;
        private int chance;

        public Points(int valeur)
        {
            this.valeur = valeur;
        }

        public int ObtenirPoints(Joueur joueur)
        {
            int point = joueur.Points;
            int position = joueur.Position;

            //joueur.Points = position;

            int chance = random.Next(1, 101);
            if (chance <= 40)
            {
                valeur = valeur + position;
                point = point + valeur;
            }
            else if (chance > 40 & chance <= 80)
            {
                valeur = valeur - position;
                point = point + valeur;
            }
            else if (chance > 80 & chance <= 90)
            {
                valeur = position * 2;
                point = point + valeur;
            }
            else
            {
                valeur = position * 0;
                point = point + valeur;
            }
            return valeur;
        }
    }
}