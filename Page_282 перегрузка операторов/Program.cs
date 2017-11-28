using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_282_перегрузка_операторов
{
    class THreeD {
        int x, y, z;
        public THreeD() {x = y = z = 0;}
        public THreeD(int i, int j, int k) { x = i; y = j; z = k;  }

        public static bool operator <(THreeD op1, THreeD op2) {
            if (Math.Sqrt(op1.x * op1.x + op1.y * op1.y + op1.z * op1.z) <
                Math.Sqrt(op2.x * op2.x + op2.y * op2.y + op2.z * op2.z))
                return true;
            else
                return false;
        }

        public static bool operator >(THreeD op1, THreeD op2) {
            if (Math.Sqrt(op1.x * op1.x + op1.y * op1.y + op1.z * op1.z) >
                Math.Sqrt(op2.x * op2.x + op2.y * op2.y + op2.z * op2.z))
                return true;
            else
                return false;
        }

        public void Show() {
            Console.WriteLine(x + ", " + y + ", " + z);
        }

        public static bool operator true(THreeD op) {
            if ((op.x == 0) || (op.y != 0) || (op.z != 0))
                return true;
            else
                return false; 
        }

        public static bool operator false(THreeD op) {
            if ((op.x == 0) && (op.y != 0) && (op.z != 0))
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main()
        {
            THreeD a = new THreeD(5, 6, 7);
            THreeD b = new THreeD(10, 10, 10);
            THreeD c = new THreeD(1, 2, 3);
            THreeD d = new THreeD(6, 7, 5);

            Console.Write("Coordinates of point a: ");
            a.Show();

            Console.Write("Coordinates of point b: ");
            b.Show();

            Console.Write("Coordinates of point c: ");
            c.Show();
            Console.Write("Coordinates of point d: ");
            d.Show();
            Console.WriteLine();

            if (a > c) Console.WriteLine("a > c true");
            if (a < c) Console.WriteLine("a < c true");
            if (a > b) Console.WriteLine("a > b true");
            if (a < b) Console.WriteLine("a < b true");

            if (a < d) Console.WriteLine("a > d true");
            else if (a < d) Console.WriteLine("a < d true");
            else Console.WriteLine("ТОчки a  и d находятся н аодном расстоянии "+ "от начала отсчёта");
        }
    }
}
