namespace MethodsExercise
{
    public class Program
    {
        public static string GetGreeting(string name)
        {
            return $"Hello, {name}!";
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

        static string PromptForInput(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine()?.Trim();
                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                Console.WriteLine("Input cannot be empty. Please try again.");
            }
        }

        static void Main(string[] args)
        {
            string name = PromptForInput("Please enter your name:");
            Console.WriteLine(GetGreeting(name));

            string color = PromptForInput("Please enter your favorite color:");
            Console.WriteLine($"Your favorite color is {color}.");

            string animal = PromptForInput("Please enter your favorite animal:");
            Console.WriteLine($"Your favorite animal is {animal}.");

            string band = PromptForInput("Please enter your favorite band:");
            Console.WriteLine($"Your favorite band is {band}.");

            Console.WriteLine("Thank you for sharing your preferences! Allow me to tell you a story based on these variables.");

            Console.WriteLine($@"
There was once a human named {name}. This human's favorite color was {color}.
Coincidentally, when walking into a bar, this human ran into a {color} {animal}.
This {color} {animal} was dancing to a song by {band}.
The human approached the {color} {animal} and asked, 'What is your name?'
The {color} {animal} said, 'My name is {name}, and you?'
The human said, 'No way, my name is {name} too!'
The human and his {animal} compatriot became fast friends. The end.
");

            Console.WriteLine(Add(27, 365));
            Console.WriteLine(Subtract(100, 50));
            Console.WriteLine(Multiply(6, 7));
            Console.WriteLine(Divide(100, 4));
        }
    }
}
