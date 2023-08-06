using System;
using System.Diagnostics;
using System.Drawing; 
using System.Threading; 
using System.Windows.Forms;

namespace KerbelProjectTest1
{
    
    public partial class Launch : Form
    {
        public string name_rocket;
        Starting strt = new Starting();
        Select slct = new Select();
        public int Initial_Angle, gaspercentage;
        private double timeStep = 0.001;
        private double gravitationalAcceleration = 550;

        private double elapsedTime = 0;

        private readonly System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private Rocket Rocket;
        private Planet Planet;


        public Launch(string selectedRocketName)
        {
            InitializeComponent();
            up_angle.Click += Button_Click;
            down_angle.Click += Button_Click;
            up_gas.Click += Button_Click;
            down_gas.Click += Button_Click;

            Paint += new PaintEventHandler(PaintRocket);
            FormClosing += new FormClosingEventHandler(StopSimulation);

            Rocket = new Rocket(selectedRocketName);
            spaceshipname.Text = Rocket.Name;

            Rocket.UpdateRocketAngle(Initial_Angle);

            Planet = new Planet(30);
            
            timer.Interval = (int)(timeStep * 1000);
            timer.Tick += new EventHandler(UpdateRocketPosition);
            gaspercentage = 100;
            Initial_Angle = 20;

            UpdateAngleLabel();
            UpdateGasLabel();
        }
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            double initialVelocity = Rocket.InitialVelocity * (gaspercentage / 100.0);
            Rocket.UpdateInitialVelocity(initialVelocity);

            insert_Angle.Location = new Point(1280, 720);
            insert_Gas.Location = new Point(1280, 720);
            up_angle.Location = new Point(1280, 720);
            up_gas.Location = new Point(1280, 720);
            down_angle.Location = new Point(1280, 720);
            down_gas.Location = new Point(1280, 720);

            strt.sound.Play();
            strt.launch.Play();
            Thread.Sleep(3000);
            timer.Start();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
            strt.sound.Play();
            slct.ShowDialog();
            Close();
        }
        public void PaintRocket(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; 

            double Animate_Rotation = Math.Atan2(Rocket.GetRocketX(), Rocket.GetRocketY()) * (180 / Math.PI) + Initial_Angle;

            double rotationAngle = 90 * (elapsedTime / (Rocket.InitialVelocity * Math.Sin(Initial_Angle * Math.PI / 180)));

            Animate_Rotation += rotationAngle; 
            float rocketXCoord = (float)Rocket.GetRocketX();
            float rocketYCoord = Height - (float)Rocket.GetRocketY();

            g.TranslateTransform(rocketXCoord, rocketYCoord);
            g.RotateTransform(((float)Animate_Rotation)-10);
            g.DrawImage(Rocket.RocketImage, -10, -10, 50, 50);
            g.ResetTransform(); 
            float targetXCoord = (float)Planet.X_Position;
            float targetYCoord = Height - (float)Planet.Y_Position;
            float planetRadius = Planet.Radius;

            g.DrawImage(Planet.PlanetImage, targetXCoord - planetRadius, targetYCoord - planetRadius, planetRadius * 2, planetRadius * 2);
        }
        public void UpdateRocketPosition(object sender, EventArgs e)
        {
            Rocket.UpdatePosition(elapsedTime, gravitationalAcceleration);
            Invalidate();

            if (IsCollision(Rocket, Planet))
            {
                timer.Stop();
                WIN.Image = KerbelProjectTest1.Properties.Resources.you_win;
                WIN.Location = new Point(325, 482);
                comet.Location = new Point(365, 350);
                btnLaunch.Location = new Point(1280, 720);
                star_close.Location = new Point(762, 12);
                strt.launch.Stop();
                strt.win.Play();
            }
            else if (Rocket.GetRocketX() >= Planet.X_Position + 20)
            {
                timer.Stop();
                WIN.Image = KerbelProjectTest1.Properties.Resources.you_lose;
                WIN.Location = new Point(325, 482);
                explosion.Location = new Point(365, 350);
                btnLaunch.Location = new Point(1280, 720);
                star_close.Location = new Point(762, 12);
                strt.launch.Stop();
                strt.lose.Play();
            }

            elapsedTime += timeStep;
        }
        public bool IsCollision(Rocket Spaceship, Planet planet)
        {
            RectangleF rocketHitbox = new RectangleF(((float)Spaceship.GetRocketX() - Spaceship.HitBox / 2)-30, ClientSize.Height - (float)Spaceship.GetRocketY() - Spaceship.HitBox / 2, Spaceship.HitBox * 3, Spaceship.HitBox * 3);

            int planetHitBoxSize = planet.HitBox;
            RectangleF planetHitbox = new RectangleF((float)planet.X_Position - planetHitBoxSize / 2, ClientSize.Height - (float)planet.Y_Position - planetHitBoxSize / 2, planetHitBoxSize, planetHitBoxSize);

            return rocketHitbox.IntersectsWith(planetHitbox);
        }
        public void StopSimulation(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            Application.Exit();
        }
        private void pictureBox35_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            strt.sound.Play();
            Button button = (Button)sender;

            if (button == up_gas)
            {
                gaspercentage += 10;
                UpdateGasLabel();
            }
            else if (button == down_gas)
            {
                gaspercentage -= 10;
                UpdateGasLabel();
            }
            else if (button == up_angle)
            {
                Initial_Angle += 10;
                UpdateAngleLabel();
                Rocket.UpdateRocketAngle(Initial_Angle);

            }
            else if (button == down_angle)
            {
                Initial_Angle -= 10;
                UpdateAngleLabel();
                Rocket.UpdateRocketAngle(Initial_Angle);

            }
        }
        private void UpdateGasLabel()
        {
            insert_Gas.Text = $"Gas: {gaspercentage}";
        }
        private void UpdateAngleLabel()
        {
            insert_Angle.Text = $"Angle: {Initial_Angle}";
        }
    }
}
