using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulky2colory
{
    public class Kulka2: Bazoviy
    {
        //конструктор
        public Kulka2(Rectangle rec) {
            r = rec;
            value = 2;
        }
        //ця функція малювання замінює батьківську завдяки override
        public override void Draw(Graphics g)
        {
            Pen pen;
            if (value == 1) pen = new Pen(Color.Red, 3);
            else pen = new Pen(Color.Blue, 3);
            g.DrawEllipse(pen, r);
        }
    }
}
