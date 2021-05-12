using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulky2colory
{
    public class Bazoviy
    {
        public int value;
        public Rectangle r;
        public virtual void Draw( Graphics g) {
            //замість цього методу викликаються перевантажені дочірних класів
        }
        public void Zmina() {
            value = 3 - value; //1 чи 2
        }
    }
}
