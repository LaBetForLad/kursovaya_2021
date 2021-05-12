using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulky2colory
{
    public class Kulka1: Bazoviy
    {
        //конструктор
        public Kulka1(Rectangle rec)
        {
            r = rec;
            value = 1;
        }
        //ця функція малювання замінює батьківську завдяки override
        public override void Draw(Graphics g) {
            SolidBrush brush;
            if (value == 1) brush = new SolidBrush(Color.Red);
            else brush = new SolidBrush(Color.Blue);
            g.FillEllipse(brush, r);
        }
    }
}
