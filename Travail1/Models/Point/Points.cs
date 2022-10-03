﻿using Travail1.Models.Case;

namespace Travail1.Models.Point
{
    public class Points
    {
        private int valeur;

        public Points(int valeur)
        {
            this.Valeur = valeur;
        }

        public int Valeur { get => valeur; set => valeur = value; }

        public virtual int ajouterpoint(int pointCourant, int pointTotal)
        {
            //pointTotal = pointTotal + pointCourant;
            Valeur = pointTotal + pointCourant;
            return Valeur;
        }

        public virtual int ObtenirPoints(int pointsTotal)
        {
            Valeur = pointsTotal;
            return Valeur;
        }
    }
}