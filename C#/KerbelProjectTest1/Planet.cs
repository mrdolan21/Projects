using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace KerbelProjectTest1
{
    public class Planet
    {
        private static readonly Random random = new Random();

        public int Radius { get; set; }
        public int X_Position { get; set; }
        public int Y_Position { get; set; }
        public int HitBox { get; set; }
        public Image PlanetImage { get; set; }
        public Planet(int radius)
        {
            Radius = radius;
            X_Position = random.Next(200,750);
            Y_Position = random.Next(200,550);
            HitBox = (radius * 2) - 5;
            PlanetImage = KerbelProjectTest1.Properties.Resources.moon2;
        }

    }
}