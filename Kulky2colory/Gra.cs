using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulky2colory
{
    public class Gra
    {
        private Bazoviy[,] a;      //дошка з кульками
        private int width ; //ширина малюнку
        public int N{ get; set; } //автоматична властивість
        public bool start; //ознака початку гри
       
        public Gra() {
            //конструктор
            N = 7;
            a = new Bazoviy[7, 7];
            start = false;
        }
        
        public void New_game(int n, int w) {
            //початок нової гри
            N = n;
            width = w;
            int dx = w / n;
            //створити масив кульок
            a = new Bazoviy[n, n];
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++)
                {
                    Rectangle r = new Rectangle(j * dx + 2, i * dx + 2, dx - 4, dx - 4);
                    a[i, j] = new Kulka1(r);
                    //можна змінити на інший вигляд без зміни решти програми
                    //a[i, j] = new Kulka2(r);
                }
            }
            //розфарбувати випадковим чином
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    a[i, j].value = rnd.Next(1,3);
                }
            }
            start = true;
        }
        public void Draw(Graphics g)
        {
            //малювання
            //Pen pen = new Pen(Color.Black);
            g.Clear(Color.White);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    a[i, j].Draw(g); //кулька малює сама себе 
                }
            }            
        }
        public bool Game_over()
        {
            //поверта істину, коли гра завершена
            bool rez = false;
            int k1 = 0, k2=0;
            //підрахунок різних кульок
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (a[i, j].value == 1) k1++;
                    else k2++;
                }
            }
            //перевірка кількості
            if (k1 == 0 || k2 == 0)
            {
                rez = true;
                start = false; //ознака, що гра завершена
            }
            return rez;
        }
        public void Zmina (int i1, int j1)
        {
            //зміна виду кульок в заданих рядку та стовпчику
            if (i1 < 0 || i1 >= N || j1 < 0 || j1 >= N) return;
            for (int i = 0; i < N; i++)
            {
                a[i, j1].Zmina();
            }
            for (int j = 0; j < N; j++)
            {
                if ( j != j1) a[i1, j].Zmina(); //вказана вже змінена, тому пропускаємо
            }
        }

    }
}
