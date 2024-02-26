using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for the number of random integers to generate
        Console.Write("Enter the number of random integers to generate: ");
        if (int.TryParse(Console.ReadLine(), out int count))
        {
            // Generate random integers
            int[] numbers = GenerateRandomIntegers(count);

            // Display the random numbers
            Console.WriteLine("\nRandom Numbers:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // Calculate and display the total from the add method
            int addResult = Add(numbers);
            Console.WriteLine($"Total from Add method: {addResult}");

            // Calculate and display the total from the multiply method
            int multiplyResult = Multiply(numbers);
            Console.WriteLine($"Total from Multiply method: {multiplyResult}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static int[] GenerateRandomIntegers(int count)
    {
        Random random = new Random();
        int[] numbers = new int[count];

        for (int i = 0; i < count; i++)
        {
            numbers[i] = random.Next(1, 11);
        }

        return numbers;
    }

    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}