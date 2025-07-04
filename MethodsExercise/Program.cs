﻿namespace MethodsExercise
{
    public class Program
    {
        public static void Storytime()
        {
            Console.WriteLine("What is your name?");
            
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine("");
            Console.WriteLine("What is your favorite color?");
            
            string color = Console.ReadLine();

            Console.WriteLine($"{color} is an excellent choice of color!");
            Console.WriteLine("");
            Console.WriteLine("What is your favorite animal?");
            
            string animal = Console.ReadLine();

            Console.WriteLine($"Wow! {animal}s are amazing creatures!");
            Console.WriteLine("");
            Console.WriteLine("What is your favorite genre of music?");
            
            string genre = Console.ReadLine();

            Console.WriteLine($"{genre} is the best style of music!");
            Console.WriteLine("");
            Console.WriteLine("Who is your favorite band in that style of music?");
            
            string band = Console.ReadLine();

            Console.WriteLine($"{band}! The best to ever do it!");
            Console.WriteLine("");
            Console.WriteLine("What is your favorite food?");
            
            string food = Console.ReadLine();

            Console.WriteLine($"{food}! That's my favorite too!");
            Console.WriteLine("");
            Console.WriteLine("What is your favorite car?");
            
            string car = Console.ReadLine();

            Console.WriteLine($"Wow! {car}s are the best!");
            Console.WriteLine("");
            Console.WriteLine($"Story time! I just met an amazing person named {name} and their favorite color is {color}. They love {animal}s. They love to eat {food}, just like me! They love to drive {car}s! And last but not least, their favorite genre of music is {genre}! Can you believe that?! And their favorite band in the {genre} style of music is {band}!");
            Console.WriteLine("");
            Console.WriteLine($"One day, {name} decided that they would travel the country following {band} around on tour for a whole week straight! They knew this would be a long journey, so they grabbed their {animal}, hopped in their {color} {car}, and stocked up on as much {food} as they possibly could!");
            Console.WriteLine("");
            Console.WriteLine($"Now it was time to hit the road! They traveled to the first show of {band}'s tour and it was a LONG line to get tickets, but {name} was determined to see {band} play live on stage. And lucky for {name}, {band} loves {animal}s, the color {color}, {car}s, and {food} too! {name} watched {band} play their whole set in its entirety every single night and ate {food} the entire time!");
            Console.WriteLine("");
            Console.WriteLine($"As the tour came to a close, {name} gathered their things, their {animal}, hopped back in their {color} {car} and headed back home!");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                //sum = sum + number;
                sum += number;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Storytime();
            Console.WriteLine(Add(2, 2));
            Console.WriteLine(Multiply(30, 2));
            Console.WriteLine(Subtract(40, 12));
            Console.WriteLine(Divide(160, 4));
            Console.WriteLine(Sum(5, 5, 5));
            Console.WriteLine(Sum(100, 100, 100));
            Console.WriteLine(Sum(85, 79, 120, 36, 59));
        }
    }
}
