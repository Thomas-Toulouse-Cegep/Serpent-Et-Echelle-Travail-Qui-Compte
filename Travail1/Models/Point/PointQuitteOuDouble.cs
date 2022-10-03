using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail1.Models.Point
{
    internal class PointQuitteOuDouble : Points
    {
        private int valeur;
        private Random rndDouble;

        public PointQuitteOuDouble(int valeur) : base(valeur)
        {
            this.valeur = valeur;
        }

        public override int ajouterpoint(int pointCourant, int pointTotal)
        {
            int luck;
            luck = rndDouble.Next(1, 3);
            if (luck is 1)
            {
                pointCourant = 0;
            }
            else if (luck is 2)
            {
                pointCourant = pointCourant * 2;
            }
            pointTotal = pointTotal + pointCourant;
            pointTotal = valeur;
            return pointTotal;
        }
    }
}