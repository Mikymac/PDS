using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {

        static void Main(string[] args)
        {

            float[] table = { 0, 0, 0, 0, 0, 0 };
            float[] back;
            int loop = 2147483;
            float percent = 0;

            /*
             * 2147483 loops returned these values??
99.97447
99.96152
99.93015
99.92563
99.94388
99.92606
*/

            for (int i = 0; i < loop; i++)
            {
                percent = ((i+1) / (float)loop) * 100;
                Console.Write("\r"+percent); 
                

                back = Run2();
                for (int j = 0; j < table.Length; j++)
                {
                    table[j] += back[j];
                }
                
            }

            for (int i = 0; i < table.Length; i++)
                table[i] /= loop;

                

            Console.WriteLine("\nFinal output: {0}", string.Join(" / ", table));

            Console.ReadLine();
        }


        static float[] Run2()
        {
            float[] table = { 0, 0, 0, 0, 0, 0 };

            float[] freq1 = Run();
            //Console.WriteLine(string.Join(" ", freq1));
            float[] freq2 = Run();
            //Console.WriteLine(string.Join(" ", freq2));
            float[] freq3 = Run();
            //Console.WriteLine(string.Join(" ", freq3));
            float[] freq4 = Run();
            //Console.WriteLine(string.Join(" ", freq4));
            float[] freq5 = Run();
            //Console.WriteLine(string.Join(" ", freq5));
            float[] freq6 = Run();
            //Console.WriteLine(string.Join(" ", freq6));
            float[] freq7 = Run();
            //Console.WriteLine(string.Join(" ", freq7));
            float[] freq8 = Run();
            //Console.WriteLine(string.Join(" ", freq8));
            float[] freq9 = Run();
            //Console.WriteLine(string.Join(" ", freq9));
            float[] freq0 = Run();
            //Console.WriteLine(string.Join(" ", freq0));
            float ave;

            for (int i = 0; i < table.Length; i++)
            {
                ave = freq0[i] + freq1[i] + freq2[i] + freq3[i] + freq4[i] + freq5[i] + freq6[i] + freq7[i] + freq8[i] + freq9[i];
                ave /= 10;
                table[i] += ave;
            }

            //Console.WriteLine(string.Join(" - ", table));

            return table;

        }

        static float[] Run()
        {

            float[] nums = { 1, 2, 3, 4, 5, 6 };
            float[] freq = { 0, 0, 0, 0, 0, 0 };
            int roll;

            Random rand = new Random();

            for (int i = 0; i < 600; i++)
            {
                roll = Roll(rand);
                //Console.Write(roll + " ");
                foreach (int j in nums)
                {
                    if (j == roll)
                    {
                        //index = ;
                        freq[Array.IndexOf(nums, j)] += 1;
                    }
                }
            }

            

            return freq;
        }

        static public int Roll(Random rand)
        {
            int dice = rand.Next(1, 7);
            return dice;
        }
    }
}
