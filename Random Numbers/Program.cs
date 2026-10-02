namespace Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tutorial
            Random generator = new Random();
            int min, max, eightBall, randNumb; //we will store our random number in this variable
            randNumb = generator.Next(10);
            Console.WriteLine("My random number is " + randNumb);
            Console.WriteLine("Here are some numbers from 0-4!");
            Console.Write(generator.Next(5) + " ");
            Console.Write(generator.Next(5) + " ");
            Console.Write(generator.Next(5) + " ");
            Console.Write(generator.Next(5) + " ");
            Console.Write(generator.Next(5) + " ");
            Console.WriteLine(generator.Next(5) + " ");
            Console.WriteLine();

            Console.WriteLine("Here are some numbers from 0-99!");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.WriteLine(generator.Next(100) + " ");
            Console.WriteLine();

            int num1 = generator.Next(10);
            int num2 = generator.Next(10);
            if (num1 == num2)
            {
                    Console.WriteLine("The random numbers were same! Weird.");
            }
            if (num1 != num2)
            {
                Console.WriteLine("The random numbers were different! Not weird.");
            }

            //Questions
            //1. change it to 0-6 for numbers from 0-5 and 0-101 for numbers from 0-100
            //2. It's picking random numbers from 1-4. To make the range 1-5 change it to 1-6. For 3-5 make it 3-6.
            //3. The random numbers are always the same everytime I run the program after adding the seed.
            //4. The random numbers are different from the ones in the first seed. But still repeats the same numbers everytime the program runs.

            //Task 1.
            Console.WriteLine("Enter a minimum value");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a maximum value");
            max = Convert.ToInt32(Console.ReadLine());
            Console.Write(generator.Next(min, (max + 1)) + " ");
            Console.WriteLine();

            //Task 2.

            //Task 3.
            Console.WriteLine("Press enter to roll 2 dice");
            Console.ReadLine();
            int die1 = generator.Next(1, 7);
            int die2 = generator.Next(1, 7);
            Console.WriteLine(die1);
            Console.WriteLine(die2);
            Console.WriteLine();
            Console.WriteLine($"{die1} + {die2} = {die1+die2}");
            Console.WriteLine();

            //Task 4.
            Console.WriteLine("Magic 8-ball");
            Console.WriteLine("Press enter to use:");
            Console.ReadLine();
            eightBall = generator.Next(10);
            if (eightBall == 0)
            { 
                Console.WriteLine("yea");
            }
            if (eightBall == 1)
            {
                Console.WriteLine("no.");
            }
            if (eightBall == 2)
            {
                Console.WriteLine("sorry, didn't get that");
            }
            if (eightBall == 3)
            {
                Console.WriteLine("idk");
            }
            if (eightBall == 4)
            {
                Console.WriteLine("Y");
            }
            if (eightBall == 5)
            {
                Console.WriteLine("N");
            }
            if (eightBall == 6)
            {
                Console.WriteLine(":)");
            }
            if (eightBall == 7)
            {
                Console.WriteLine(":(");
            }
            if (eightBall == 8)
            {
                Console.WriteLine("don't ask that.");
            }
            if (eightBall == 9)
            {
                Console.WriteLine("Great question!");
            }
            if (eightBall == 10)
            {
                Console.WriteLine("Yes");
            }
            if (eightBall == 11)
            {
                Console.WriteLine("No");
            }
            if (eightBall == 12)
            {
                Console.WriteLine("Ask again later!");
            }
            if (eightBall == 13)
            {
                Console.WriteLine("Better not tell you now");
            }
            if (eightBall == 14)
            {
                Console.WriteLine("I won't tell you.");
            }
            if (eightBall == 15)
            {
                Console.WriteLine("you smell bad :(");
            }

        }
        }
    }

