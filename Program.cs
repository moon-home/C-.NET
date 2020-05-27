using System;

using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            while (true) {
                Cal.WriteLineWithColor("Which question would you like to review?", ConsoleColor.Cyan);
                for (int i = 1; i < 11; i++) {
                    Cal.WriteLineWithColor($"  {i}. question {i}", ConsoleColor.Blue);
                }
                
                
                int n = 0;
                do {
                    try
                    {
                        string choice = Console.ReadLine();
                        n = Int32.Parse(choice);
                        
                    }
                    catch (FormatException)
                    {
                        Cal.WriteLineWithColor("Please chose from 1-10", ConsoleColor.Red);
                    };
                } while (n==0);

                switch (n)
                {
                    case 1:
                        Cal.Q1();
                        break;

                    case 2:
                        Cal.Q2();
                        break;

                    case 3:
                        Cal.Q3();
                        break;

                    case 4:
                        Cal.Q4();
                        break;

                    case 5:
                        Cal.Q5();
                        break;

                    case 6:
                        Cal.Q6();
                        break;

                    case 7:
                        Cal.Q7();
                        break;

                    case 8:
                        Cal.Q8();
                        break;

                    case 9:
                        Cal.Q9();
                        break;

                    case 10:
                        Cal.Q10();
                        break;

                    default:
                        Console.WriteLine("default");
                        break;
                }
            }
        }





    }
}
