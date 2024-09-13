using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//jdauadad

namespace Part_4._5___Methods
{
    internal class Program
    {
        public static void KnockKnock(int jokeID)
        {
            if (jokeID == 0)
            {
                Console.WriteLine("Knock Knock");
                System.Threading.Thread.Sleep(500);
                Console.ReadLine();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Boo");
                System.Threading.Thread.Sleep(500);
                Console.ReadLine();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Don't cry, it's only a joke");
                System.Threading.Thread.Sleep(500);
            }
            else if (jokeID == 1)
            {
                Console.WriteLine("Knock Knock");
                System.Threading.Thread.Sleep(500);
                Console.ReadLine();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Lettuce");
                System.Threading.Thread.Sleep(500);
                Console.ReadLine();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Lettuce in, it's cold outside");
                System.Threading.Thread.Sleep(500);
            }
            else if (jokeID == 2)
            {
                Console.WriteLine("Knock Knock");
                System.Threading.Thread.Sleep(500);
                Console.ReadLine();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Chickens");
                System.Threading.Thread.Sleep(500);
                Console.ReadLine();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("No, chickens cluck, owls hoo");
                System.Threading.Thread.Sleep(500);
            }
            else if (jokeID == 3)
            {
                Console.WriteLine("Knock Knock");
                System.Threading.Thread.Sleep(500);
                Console.ReadLine();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Cash");
                System.Threading.Thread.Sleep(500);
                Console.ReadLine();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("No thanks, I'll have a peanut");
                System.Threading.Thread.Sleep(500);
            }
            else if (jokeID == 4)
            {
                while (jokeID < 10)
                {
                    Console.WriteLine("Knock Knock");
                    System.Threading.Thread.Sleep(500);
                    Console.ReadLine();
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Interrupting Cow");
                    System.Threading.Thread.Sleep(1300);
                    Console.WriteLine("MOO");
                    System.Threading.Thread.Sleep(500);
                }
            }
            else if (jokeID == 5)
            {
                Console.WriteLine("Knock Knock");
                System.Threading.Thread.Sleep(500);
                Console.ReadLine();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Dejav");
                System.Threading.Thread.Sleep(500);
                Console.ReadLine();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Knock Knock");
                System.Threading.Thread.Sleep(500);
            }
            else { Console.WriteLine("Sorry I ran out of jokes, choose a smaller number"); System.Threading.Thread.Sleep(500); }
            Console.Clear();
        }

        static void Main(string[] args)
        {
            int jokeID;
            string answer = "";

            while (answer == "leave" == false)
            {
                Console.WriteLine("What do you want to do? ('draw' for drawings, 'laugh' for jokes, 'leave' to exit)");
                answer = Console.ReadLine().ToLower();
                System.Threading.Thread.Sleep(500);
                Console.Clear();

                if (answer == "draw")
                {
                    while (answer == "draw")
                    {
                        Console.WriteLine("Which Simpson do you want to see?");
                        answer = Console.ReadLine().ToLower();

                        if (answer == "maggie") { Simpson.Maggie(); }
                        else if (answer == "bart") { Simpson.Bart(); }
                        else if (answer == "lisa") { Simpson.Lisa(); }
                        else if (answer == "homer") { Simpson.Homer(); }
                        else if (answer == "marge") { Simpson.Marge(); }
                        else { Console.WriteLine("I don't recognize that Simpson"); answer = "draw"; }
                        System.Threading.Thread.Sleep(500);
                        Console.Clear();
                    }
                }

                else if (answer == "laugh")
                {
                    Console.WriteLine("Do you wanna hear a joke? Give me a number");
                    jokeID = Convert.ToInt32(Console.ReadLine());
                    KnockKnock(jokeID);
                    Console.Clear();
                }

                else if (answer == "leave" == false)
                {
                    Console.WriteLine("I have no idea what you are talking about");
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                }
            }
        }
    }
}