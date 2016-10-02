using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laberinto
{
    public partial class Form1 : Form
    {
        private System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");
        private int score;
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
            score = -1;
        }

        private void labelFinish_MouseHover(object sender, EventArgs e)
        {
            // Show a congratulatory MessageBox, then close the form.
            MessageBox.Show("\nEnhorabuena!!!!\n", "Has Ganado!!!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        /// <summary>
        /// Coloca el cursor en la esquina de comienzo
        /// </summary>
        private void MoveToStart()
        {
            startSoundPlayer.Play();
            startLabel.Show();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
            score += 1;
            labelScore.Text = score.ToString();

        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void startLabelMouseLeave(object sender, EventArgs e)
        {
            startLabel.Hide();
        }
        
        private void label111_Click(object sender, EventArgs e)
        {

        }

    }
}
