using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        int[] numbers = { r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10) };
        var numberSubset = numbers[1..4];
        Console.WriteLine($"Total of the numbers array={Add(numbers)}");
        Console.WriteLine($"Total of the subset array={Add(numberSubset)}");
        Console.WriteLine($"Total of 10,20,30,40,50 = {Add(10, 20, 30, 40, 50)}");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = r.Next(1, 10);
        }

        // Display random numbers
        Console.WriteLine("Random Numbers:");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Calculate and display the total from the add method
        int addResult = Add(numbers);
        Console.WriteLine($"Total from Add method: {addResult}");

        // Calculate and display the total from the multiply method
        int multiplyResult = Multiply(numbers);
        Console.WriteLine($"Total from Multiply method: {multiplyResult}");
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

