using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Car_Driving
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        SoundPlayer sp = new SoundPlayer("Desiigner - Panda (ArminDehghan Remix).wav");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hover(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.BurlyWood;
            button2.BackColor = Color.BurlyWood;
            pictureBox1.Image = Properties.Resources.giphy;
            sp.PlayLooping();

        }

        private void hover2(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Brown;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Brown;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.BurlyWood;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.BurlyWood;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.giphy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.Stop();
            Form1 fn = new Form1();
            pictureBox1.Visible = false;
            fn.ShowDialog();
            
            Application.Exit();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
