using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models.Point;

namespace Travail1.Models.Case
{
    internal class CaseEchelle : Case
    {
        public CaseEchelle(PointQuitteOuDouble points, int position) : base(points, position)
        {
        }

        private PointF ObtenirCoordonees()
        {
            int y = (7 - (position / 8));
            int x = (position % 8);
            if ((position / 8) % 2 == 1)
            {
                x = 7 - x;
            }
            return new PointF { X = x * largeur, Y = y * largeur };
        }

        public override void Dessiner(Graphics graphics)
        {
            var coordonees = ObtenirCoordonees();
            var font = new Font("Calibri", 20);
            graphics.FillRectangle(Brushes.DarkCyan, coordonees.X, coordonees.Y, largeur, largeur);
            graphics.DrawString((position + 1).ToString(), font, Brushes.Black, coordonees.X + 30, coordonees.Y + 30);
        }
    }
}