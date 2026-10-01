namespace Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tutorial
            Random generator = new Random(676767);
            int min, max, randNumb; //we will store our random number in this variable
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
            Console.ReadLine();    //Keeps the program from quitting

            //Questions
            //1. change it to 0-6 for numbers from 0-5 and 0-101 for numbers from 0-100
            //2. It's picking random numbers from 1-4. To make the range 1-5 change it to 1-6. For 3-5 make it 3-6.
            //3. The random numbers are always the same everytime I run the program after adding the seed.
            //4. The random numbers are different from the ones in the first seed. But still repeats the same numbers everytime the program runs.

            //Task 1.

            Console.WriteLine("Enter a minimum value");
            }
        }
    }

