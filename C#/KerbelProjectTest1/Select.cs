using System;
using System.Drawing; 
using System.Windows.Forms;

namespace KerbelProjectTest1
{
    public partial class Select : Form
    {
        public int selectedRocket { get; private set; }
        public string SelectedRocketName { get; private set; }
        Starting str = new Starting();
        public Select()
        {
            InitializeComponent();
            selectedRocket = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Hide();
            str.sound.Play();
            str.ShowDialog();
            Close();
        }

        private void reset_Spaceship()
        {
            spaceship1.Size = new Size(spaceship1.MinimumSize.Width, spaceship1.MinimumSize.Height);
            spaceship1.Location = new Point(spaceship1.Location.X, 156);

            spaceship2.Size = new Size(spaceship2.MinimumSize.Width, spaceship2.MinimumSize.Height);
            spaceship2.Location = new Point(spaceship2.Location.X, 156);

            spaceship3.Size = new Size(spaceship3.MinimumSize.Width, spaceship3.MinimumSize.Height);
            spaceship3.Location = new Point(spaceship3.Location.X, 156);

            spaceship4.Size = new Size(spaceship4.MinimumSize.Width, spaceship4.MinimumSize.Height);
            spaceship4.Location = new Point(spaceship4.Location.X, 156);

            spaceship5.Size = new Size(spaceship5.MinimumSize.Width, spaceship5.MinimumSize.Height);
            spaceship5.Location = new Point(spaceship5.Location.X, 156);
        } 

        private int currentWeight = 0, currentAcceleration = 0, currentTankSize = 0, currentTopSpeed = 0;  

        private void AnimateBar(ref int currentStat, int targetStat, PictureBox statbar)
        {
            int difference = targetStat - currentStat;

            int numberOfSteps = Math.Abs(difference); 
            int step = (int)Math.Sign(difference);  

            if (step == 1)  
            {   
                for (int i = 0; i < numberOfSteps; i++)
                {
                    step = 1;
                    currentStat += step;
                    UpdateBarImage(statbar,currentStat);
                    System.Threading.Thread.Sleep(100);
                    Application.DoEvents();
                }
            }
            else if (step == -1)
            {
                for (int i = 0; i < numberOfSteps; i++) 
                {
                    step = 1;
                    currentStat -= step;
                    UpdateBarImage(statbar,currentStat);
                    System.Threading.Thread.Sleep(100);
                    Application.DoEvents();
                }
            }
        }

        private void UpdateBarImage(PictureBox statbar,int currentStat)
        {
            string imageName = "stats_bar_" + currentStat; // 1-6
            statbar.Image = (Image)KerbelProjectTest1.Properties.Resources.ResourceManager.GetObject(imageName);
        }

        private void spaceship1_Click(object sender, EventArgs e)
        {
            reset_Spaceship();
            str.sound.Play();
            spaceship1.Size = new Size(spaceship1.MaximumSize.Width, spaceship1.MaximumSize.Height);
            selectedRocket = 1;
            lbl_spaceship_name.Text = "PA Rocket v" + selectedRocket;
            SelectedRocketName = lbl_spaceship_name.Text;

            int weight_ss = 1, topspeed_ss = 1, acceleration_ss = 3, tanksize_ss = 1;

            AnimateBar(ref currentWeight, weight_ss,status_weight);
            AnimateBar(ref currentAcceleration, acceleration_ss, status_acceleration);
            AnimateBar(ref currentTankSize, tanksize_ss, status_tank_size);
            AnimateBar(ref currentTopSpeed, topspeed_ss, status_top_speed);

        }

        private void spaceship2_Click(object sender, EventArgs e)
        {
            reset_Spaceship();
            str.sound.Play();
            spaceship1.Size = new Size(spaceship2.MaximumSize.Width, spaceship2.MaximumSize.Height);
            selectedRocket = 2;
            lbl_spaceship_name.Text = "PA Rocket v" + selectedRocket;
            SelectedRocketName = lbl_spaceship_name.Text;

            int weight_ss = 2, topspeed_ss = 2, acceleration_ss = 4, tanksize_ss = 3;

            AnimateBar(ref currentWeight, weight_ss, status_weight);
            AnimateBar(ref currentAcceleration, acceleration_ss, status_acceleration);
            AnimateBar(ref currentTankSize, tanksize_ss, status_tank_size);
            AnimateBar(ref currentTopSpeed, topspeed_ss, status_top_speed);

        }
        private void spaceship3_Click(object sender, EventArgs e)
        {
            reset_Spaceship();
            str.sound.Play();
            spaceship1.Size = new Size(spaceship3.MaximumSize.Width, spaceship3.MaximumSize.Height);
            selectedRocket = 3;
            lbl_spaceship_name.Text = "PA Rocket v" + selectedRocket;
            SelectedRocketName = lbl_spaceship_name.Text;


            int weight_ss = 4, topspeed_ss = 3, acceleration_ss = 5, tanksize_ss = 5;

            AnimateBar(ref currentWeight, weight_ss, status_weight);
            AnimateBar(ref currentAcceleration, acceleration_ss, status_acceleration);
            AnimateBar(ref currentTankSize, tanksize_ss, status_tank_size);
            AnimateBar(ref currentTopSpeed, topspeed_ss, status_top_speed);
        }

        private void spaceship4_Click(object sender, EventArgs e)
        {
            reset_Spaceship();
            str.sound.Play();
            spaceship1.Size = new Size(spaceship4.MaximumSize.Width, spaceship4.MaximumSize.Height);
            selectedRocket = 4;
            lbl_spaceship_name.Text = "PA Rocket v" + selectedRocket;
            SelectedRocketName = lbl_spaceship_name.Text;

            int weight_ss = 3, topspeed_ss = 4, acceleration_ss = 3, tanksize_ss = 4;

            AnimateBar(ref currentWeight, weight_ss, status_weight);
            AnimateBar(ref currentAcceleration, acceleration_ss, status_acceleration);
            AnimateBar(ref currentTankSize, tanksize_ss, status_tank_size);
            AnimateBar(ref currentTopSpeed, topspeed_ss, status_top_speed);
        }

        private void spaceship5_Click(object sender, EventArgs e)
        {

            reset_Spaceship();
            str.sound.Play();
            spaceship1.Size = new Size(spaceship5.MaximumSize.Width, spaceship5.MaximumSize.Height);
            selectedRocket = 5;
            lbl_spaceship_name.Text = "PA Rocket v" + selectedRocket;
            SelectedRocketName = lbl_spaceship_name.Text;

            int weight_ss = 2, topspeed_ss = 6, acceleration_ss = 4, tanksize_ss = 3;

            AnimateBar(ref currentWeight, weight_ss, status_weight);
            AnimateBar(ref currentAcceleration, acceleration_ss, status_acceleration);
            AnimateBar(ref currentTankSize, tanksize_ss, status_tank_size);
            AnimateBar(ref currentTopSpeed, topspeed_ss, status_top_speed);
        }
        
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (selectedRocket != 0)
            {
                Hide();
                Launch f1 = new Launch(SelectedRocketName);
                str.sound.Play();
                f1.ShowDialog();
                Close();
            }
            else
            {
                lbl_error.Text = "Please Select a Spaceship";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            floating_spaceships_timer.Start();

        }
        private int initialYPosition = 156, levitationHeight = 20, animationStep = 3;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (selectedRocket)
            {
                case 1:
                    spaceship1.Location = new Point(spaceship1.Location.X, spaceship1.Location.Y - animationStep);

                    if (spaceship1.Location.Y <= initialYPosition - levitationHeight || spaceship1.Location.Y >= initialYPosition)
                        animationStep = -animationStep;
                    break;

                case 2: 
                    spaceship2.Location = new Point(spaceship2.Location.X, spaceship2.Location.Y - animationStep);

                    if (spaceship2.Location.Y <= initialYPosition - levitationHeight || spaceship2.Location.Y >= initialYPosition)
                        animationStep = -animationStep;
                    break;

                case 3: 
                    spaceship3.Location = new Point(spaceship3.Location.X, spaceship3.Location.Y - animationStep);

                    if (spaceship3.Location.Y <= initialYPosition - levitationHeight || spaceship3.Location.Y >= initialYPosition)
                        animationStep = -animationStep;
                    break;

                case 4: 
                    spaceship4.Location = new Point(spaceship4.Location.X, spaceship4.Location.Y - animationStep);
                    if (spaceship4.Location.Y <= initialYPosition - levitationHeight || spaceship4.Location.Y >= initialYPosition)
                        animationStep = -animationStep;
                    break;

                case 5: 
                    spaceship5.Location = new Point(spaceship5.Location.X, spaceship5.Location.Y - animationStep);

                    if (spaceship5.Location.Y <= initialYPosition - levitationHeight || spaceship5.Location.Y >= initialYPosition)
                        animationStep = -animationStep;
                    break;

                default:
                    break;
            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
