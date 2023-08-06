using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerbelProjectTest1
{
    public class Rocket
    {
        private static readonly Dictionary<string, (float HitBox, float InitialVelocity, Bitmap rocketimage)> RocketData = new Dictionary<string, (float, float,Bitmap)>()
        {
            { "PA Rocket v1", (9, 220, Properties.Resources.rocket_v1_noactive) },
            { "PA Rocket v2", (12, 240, Properties.Resources.rocket_v2_noactive) },
            { "PA Rocket v3", (15, 260, Properties.Resources.rocket_v3_noactive) },
            { "PA Rocket v4", (17, 280, Properties.Resources.rocket_v4_noactive) },
            { "PA Rocket v5", (21, 300, Properties.Resources.rocket_v5_noactive) }
        };

        public string Name { get; set; }
        public float HitBox { get; set; }
        public float InitialVelocity { get; private set; }
        public float FuelPercentage { get; set; }
        private double rocketX;
        private double rocketY;
        private readonly double rocketAngle;
        public float UpdatedVelocity;
        public float UpdatedAngle;
        public Image RocketImage { get; set; }

        public Rocket(string name)
        {
            if (RocketData.TryGetValue(name, out var data))
            {
                Name = name;
                HitBox = data.HitBox;
                InitialVelocity = data.InitialVelocity;
                RocketImage = data.rocketimage;
            }
            else
            {
                MessageBox.Show("Invalid rocket name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DrawRocket(Graphics g, double x, double y)
        {
            float rocketXCoord = (float)x;
            float rocketYCoord = g.VisibleClipBounds.Height - (float)y;
            g.DrawImage(RocketImage, rocketXCoord - 25, rocketYCoord - 25, 50, 50);
        }
        public void UpdatePosition(double elapsedTime, double gravitationalAcceleration)
        {
            double vx = UpdatedVelocity * Math.Cos(UpdatedAngle * Math.PI / 180);
            double vy = UpdatedVelocity * Math.Sin(UpdatedAngle * Math.PI / 180) - gravitationalAcceleration * elapsedTime;

            rocketX += vx * elapsedTime;
            rocketY += vy * elapsedTime - 0.5 * gravitationalAcceleration * Math.Pow(elapsedTime, 2);
        }
        public double GetRocketX()
        {
            return rocketX;
        }

        public double GetRocketY()
        {
            return rocketY;
        }
        public void UpdateRocketAngle(double angle)
        {
            UpdatedAngle = (float)angle;
        }
        public void UpdateInitialVelocity(double velocity)
        {
            UpdatedVelocity = (float)velocity;
        }
    }

}
