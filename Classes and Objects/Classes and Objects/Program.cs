using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class Greeting
    {
        public string Hello(string input)
        {
            return "Hallooo " + input;
        }

        public void Bye()
        {
            Console.WriteLine("Baii");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            maths m = new maths();
            Greeting hi = new Greeting();
            Console.WriteLine(hi.Hello("Fred"));
            hi.Bye();

            Console.Write("Prime??: ");
            if (m.Prime(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.Write("Number??: ");
            int temp = int.Parse(Console.ReadLine());
            Console.Write("To the power of??: ");
            temp = m.POWA(temp, int.Parse(Console.ReadLine()));
            foreach (int i in m.Sequence())
            {

                Console.Write(i+"  ");
            }

            Console.Read();
        }
    }

    class maths
    {
        public int[] Sequence()
        {
            List<int> fib = new List<int>();
            int j = 1;
            int jp = 1;
            int temp;
            for (int i = 0; j<4000000; i++)
            {
                fib.Add(j);
                temp = j;
                j += jp;
                jp = temp;
            }

            return fib.ToArray();
        }
        public int POWA(int num1, int num2)
        {
            int output = 0;
            for (int i = 0; i < num2; i++)
            {
                output += num1;
            }

            return output;
        }
        public bool Prime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }

}
