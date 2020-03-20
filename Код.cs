using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -4;
            //++(++x);
            //(x--)--;
            //++(x--);

            //!(-x);
            Console.WriteLine((byte)x);

            int a = 1, b = 0;
            double c = 1.0;
            //Console.WriteLine(a / b);
            Console.WriteLine(c / b);

            char i = 'i', j = 'j', k = 'k';
            bool tru = true, folse = false;
            //Console.WriteLine(i>j>k)

            int a1 = 10, b1= 3;
            bool t = (a1 >= b1 && a1 != 2 * b1 || a1 < 0);
            Console.WriteLine(t);

            int x1 = 5; int y1 = 10;
            int min = (x1 < y1) ? x1 : y1;
            Console.WriteLine(min);

            int q = 0;
            string da = "Да", net = "Нет";
            string answer = (q > 10) ? da : net;
            Console.WriteLine(answer);

            int a2 = 10, b2 = 3;
            int t1 = (a2++) - b2;
            b2+= t1 * a2;
            Console.WriteLine(t1);
            Console.WriteLine(b2);

            Console.Write("xx = ");
            float xx = float.Parse(Console.ReadLine());
            Console.Write("yy =");
            float yy = float.Parse(Console.ReadLine());
            if (xx > yy) Console.WriteLine("max = " + xx);
            else Console.WriteLine("max = " + yy);

            int Ball = 0;
            Console.Write("x = ");
            float xf = float.Parse(Console.ReadLine());
            Console.Write("y = ");
            float yf = float.Parse(Console.ReadLine());
            if (xf * xf + yf * yf <= 1) Ball = 10;  //окружность с радиусом 1
            else if (xf * xf + yf * yf <= 2) Ball = 5;  //окружность с радиусом 2
            else if (xf * xf + yf * yf <= 3) Ball = 1;  //окружность с радиусом 3
            else Ball = 0; // 
            Console.WriteLine("Ball = " + Ball);

            Console.Write("OPER = ");
            char oper = char.Parse(Console.ReadLine());
            bool ok = true;
            Console.Write("A = ");
            int aa = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            int bb = int.Parse(Console.ReadLine());
            float res = 0;
            switch (oper)
            {
                case '+': res = aa + bb; break;/*goto case'-'*/;   //1
                case '-': res = aa - bb; break;
                case '*': res = aa * bb; break;
                case ':': if (bb != 0)
                    {
                        res = (float)aa / bb; break;
                    }
                    else goto default;
                default: ok = false; break;
            }
            if (ok) Console.WriteLine("{0} {1} {2} = {3}", aa, oper, bb, res);
            //else Console.WriteLine("error");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int it = 1;
            while (n >= it) //пока i меньше или равно n 
            {
                if (n % 2 != 0)
                {
                    Console.Write(n); //выводим i на экран, затем увеличиваем его на 1       
                }
                n--;
            }

            Console.Write("N = ");
            int n1 = int.Parse(Console.ReadLine());
            int i1 = 1;
            do
            {
                if (n1 % 2 == 0)
                {
                    Console.Write(n1); //выводим i на экран, затем увеличиваем его на 1
                }
                n1--;
            }
            while (i1 <= n1);           //пока i меньше или равно n

            Console.Write("N = ");
            int n2 = int.Parse(Console.ReadLine());
            for (int i2 = 1; i2 <= n2;n2--)     //блок модификации пустой     
                Console.Write(n2*n2);

            Console.Write("n = ");
            int n3 = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m2 = int.Parse(Console.ReadLine());
            for (int ii = 1; ii <= n3; ++ii, Console.WriteLine())     //1
                for (int jj = 1; jj <= m2; ++jj)
                    Console.Write(" " +2);

            Console.Write("s = ");
            float s = float.Parse(Console.ReadLine());
            double p =  Math.Sqrt(s)/ 3.14;
            Console.WriteLine("p =" +p);

            Console.Write("a = "); int ab = int.Parse(Console.ReadLine());
            int ba = ab /100, bb1 = ab % 100 / 10;
            int max = (ba > bb1) ? ba : bb1;
            Console.WriteLine("max =" +max);

            Console.Write("x =");
            float xo = float.Parse(Console.ReadLine());
            Console.Write("y =");
            float yo = float.Parse(Console.ReadLine());
            if ((xo < 70 && xo>0) && (yo < 70 && yo > 0))
                Console.WriteLine("внутри");
            else if ((xo > 70 && xo < 0) || (yo > 70 && yo < 0))
                Console.WriteLine("вне");
            else Console.WriteLine("на границе");


            Console.Write("n =");
            byte n4 = byte.Parse(Console.ReadLine());
            if (n4 <= 100 && n4 >= 90) Console.WriteLine("отлично");
            else if (n4 <= 89 && n4 >= 70) Console.WriteLine("хорошо");
            else if (n4 <= 69 && n4 >= 50) Console.WriteLine("удовлетворительно");
            else if (n4 <= 49 && n4 > 0) Console.WriteLine("неудовлетворительно");

            Console.Write("n =");
            int n5 = int.Parse(Console.ReadLine());

            Console.Write("while: ");
            int i5 = n5;
            while (n5 % 100 !=0)
            {
                int aaa = n5 / 10, bbb = n5 % 10;
                if (aaa != bbb)
                {
                    Console.Write(" " + n5);
                }
                n5++;
            }
            n5 = i5;
            Console.Write("do while: ");
            do
            {
                int aaa = n5 / 10, bbb = n5 % 10;
                if (aaa != bbb)
                {
                    Console.Write(" " + n5);
                }
                n5++;
            }
            while (n5 % 100 != 0);
            n5 = i5;
            Console.Write("For: ");
            for (; n5 % 100 != 0;n5++)
            {
                int aaa = n5 / 10, bbb = n5 % 10;
                if (aaa != bbb)
                {
                    Console.Write(" " + n5);
                    n5++;
                }
            }
            Console.WriteLine();
            int nn = 5;
            for (int i6 = 0; i6 <= 5; ++i6, Console.WriteLine())
            {
                
                for (int j6 = 0; j6 < nn; ++j6)
                    Console.Write(" " + j6);
                nn--;
            }

        }
    }

}

