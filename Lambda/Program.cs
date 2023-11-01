using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Program
    {
        //public  delegate void UYQUENVOID(int a, int b);

        static void in2so(int a, int b)
        {
            Console.WriteLine(a + " "+  b);
        }
        //public delegate int UYQUENReturn(int a, int b);
        static float tong2so(int a, int b)
        {
            return (float)a + b;
        }
        
        static void Main(string[] args)
        {
            Func<int, int, float> uyQuenFuc = tong2so;
            Console.WriteLine(uyQuenFuc(2, 3));
            Func<int, int, float> uqLambda =  ( a,  b) => { return (float)a + b + 5; };

            //UYQUENReturn uyquen2 = tong2so;
            //Console.WriteLine(uyquen2(2, 3));
            //UYQUENVOID uyquen1 = in2so;
            //uyquen1(1, 2);
            //Console.WriteLine("xxx");

            Console.ReadLine();

        }
    }
}
