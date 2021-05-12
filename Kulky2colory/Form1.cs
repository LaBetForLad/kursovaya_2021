using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kulky2colory
{
    public partial class Form1 : Form
    {
        private Gra gra;
        public Form1()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
            gra = new Gra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //кнопка Нова гра
            int n = 7;
            if (radioButton1.Checked) n = 5;
            if (radioButton3.Checked) n = 9;
            gra.New_game(n, pictureBox1.Width);
            ris();
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //мишу відпустили
            if (gra.start) {
                int i1 = e.Y / (pictureBox1.Width / gra.N);
                int j1 = e.X / (pictureBox1.Width / gra.N);
                gra.Zmina(i1, j1);
                ris();
                pictureBox1.Refresh();
                bool rez = gra.Game_over();                
                if (rez) MessageBox.Show("Гра завершена");
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //малювання pictureBox1 
            ris();
        }
        private void ris()
        {
            //малювання
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            if (gra.start) gra.Draw(g);
        }
    }
}
