using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Test
{
    class Program
    {
        // Function to create a simple animation of the dice rolling. - McClay - 20.11.2017
        static void Boston()
        {
            Dice(Roller(), 10); // Repeated funcion calls of Dice and Roller functions including a thread.sleep to create the animation effect. - Worth changing into a loop with changing delays. - McClay - 20.11.2017
            Dice(0, 5);
            Dice(Roller(), 10);
            Dice(0, 5);
            Dice(Roller(), 10);
            Dice(0, 5);
            Dice(Roller(), 20);
            Dice(0, 5);
            Dice(Roller(), 30);
            Dice(0, 5);
            Dice(Roller(), 80);
            Dice(0, 5);
            Dice(Roller(), 150);
            Dice(0, 5);
            Dice(Roller(), 200);
            Dice(0, 5);
            Dice(Roller(), 400);
            Dice(0, 5);
            Dice(Roller(), 500);
            Dice(0, 5);
            Dice(Roller(), 900);
        }

        // Function called to draw the menu. - McClay - 24.11.2017
        static void Menu()
        {

        }

        // Main function. Calls required functions when needed. In constant state of change as Methods and Classes are created. - McClay
        static void Main()
        {

            Menu();
            
            Boston();
            Console.ReadKey();
            Boston();
            Console.ReadKey();
            Boston();
            Console.ReadKey();
            Boston();
            Console.ReadKey();
            Boston();
            Console.ReadKey();
            Boston();
            Console.ReadKey();



            /* while (true)
                 try { Dice(int.Parse(Console.ReadLine())); }
                 catch { break; }*/
        }

        // Function called to return the random number required for Dice(). - McClay - 17.11.2017
        // Creates a new Random iteration every time it is called to create a more random sequence of numbers. Less efficient however. - McClay - 20.11.2017
        static int Roller()
        {
            Random dice = new Random();
            return dice.Next(1, 7);
        }

        // Function called to write out the dice on the console. - McClay - 17.11.2017
        // Requires 1-6 numeric input as well as delay in milliseconds. - McClay - 20.11.2017
        static void Dice(int print, int delay)
        {
            string point1 = " ";
            string point2 = " ";
            string point3 = " ";
            string point4 = " ";
            string point5 = " ";
            string point6 = " ";
            string point7 = " ";

            // Switch used to define the state of each point on the dice. Initialised as " " above. Changed to "X" based on the switch case. - McClay - 17.11.2017
            switch (print) 
            {

                case 1:
                    point4 = "X";
                    break;
                case 2:
                    point1 = "X";
                    point7 = "X";
                    break;
                case 3:
                    point1 = "X";
                    point4 = "X";
                    point7 = "X";
                    break;
                case 4:
                    point1 = "X";
                    point2 = "X";
                    point6 = "X";
                    point7 = "X";
                    break;
                case 5:
                    point1 = "X";
                    point2 = "X";
                    point4 = "X";
                    point6 = "X";
                    point7 = "X";
                    break;
                case 6:
                    point1 = "X";
                    point2 = "X";
                    point3 = "X";
                    point5 = "X";
                    point6 = "X";
                    point7 = "X";
                    break;
            }

            //Console.Clear();
            Console.SetCursorPosition(0, 0);
            // Series of WriteLines substitute each point on the dice with the relevant variable. A space is used for no dot to preserve the width of each line. - McClay - 17.11.2017
            Console.WriteLine("---------------");
            Console.WriteLine("|             |");
            Console.WriteLine("|   {0}     {1}   |", point1, point2);
            Console.WriteLine("|             |");
            Console.WriteLine("|   {0}  {1}  {2}   |", point3, point4, point5);
            Console.WriteLine("|             |");
            Console.WriteLine("|   {0}     {1}   |", point6, point7);
            Console.WriteLine("|             |");
            Console.WriteLine("---------------");

            Thread.Sleep(delay);

        }     




        
    }




























    public class ConsoleSpinner
    {

        static void Main2(string[] args)
        {
            var spin = new ConsoleSpinner();
            Console.WriteLine("Beep Boop");
            Console.WriteLine("Beep Boop");
            Console.WriteLine("Beep Boop");
            Console.WriteLine("Beep Boop");
            Console.WriteLine("Beep Boop");
            while (true)
            {
                spin.Turn();
            }
        }


        int counter;

        public void Turn()
        {
            counter++;
            switch (counter % 26)
            {
                case 0: Console.Write("a"); counter = 0; break;
                case 1: Console.Write("b"); break;
                case 2: Console.Write("c"); break;
                case 3: Console.Write("d"); break;
                case 4: Console.Write("e"); break;
                case 5: Console.Write("f"); break;
                case 6: Console.Write("g"); break;
                case 7: Console.Write("h"); break;
                case 8: Console.Write("i"); break;
                case 9: Console.Write("j"); break;
                case 10: Console.Write("k"); break;
                case 11: Console.Write("l"); break;
                case 12: Console.Write("m"); break;
                case 13: Console.Write("n"); break;
                case 14: Console.Write("o"); break;
                case 15: Console.Write("p"); break;
                case 16: Console.Write("q"); break;
                case 17: Console.Write("r"); break;
                case 18: Console.Write("s"); break;
                case 19: Console.Write("t"); break;
                case 20: Console.Write("u"); break;
                case 21: Console.Write("v"); break;
                case 22: Console.Write("w"); break;
                case 23: Console.Write("x"); break;
                case 24: Console.Write("y"); break;
                case 25: Console.Write("z"); break;
            }
            Thread.Sleep(250);
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
    
}
