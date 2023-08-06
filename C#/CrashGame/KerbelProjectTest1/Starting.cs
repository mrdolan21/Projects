using System;
using System.Media;
using System.Windows.Forms; 

namespace KerbelProjectTest1
{
        public partial class Starting : Form
        {
        public SoundPlayer lose = new SoundPlayer("junior_8_bit.wav"); 
        public SoundPlayer sound = new SoundPlayer("select-rocket.wav");  

        public SoundPlayer launch = new SoundPlayer("rocket-launch.wav");
        public SoundPlayer win = new SoundPlayer("WIN_Kirby_64.wav");
        public Starting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sound.Play(); 
            Select f2 = new Select();
            f2.ShowDialog();
            this.Close();

        }
  
        private void pictureBox6_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
