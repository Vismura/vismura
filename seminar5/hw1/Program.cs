<<<<<<< HEAD
﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomNumbers(numbers);
        PrintArray(numbers);
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
            if (numbers[i] % 2 == 0)
                count++;

        Console.WriteLine($"Из них чётные: {count}");

        void FillArrayRandomNumbers(int[] numbers)
        {
            for (int a = 0; a < numbers.Length; a++)
            {
                numbers[a] = new Random().Next(100, 1000);
            }
        }
        void PrintArray(int[] numbers)
        {
            Console.Write("[ ");
            for (int a = 0; a < numbers.Length; a++)
            {
                Console.Write(numbers[a] + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
=======
﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomNumbers(numbers);
        PrintArray(numbers);
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
            if (numbers[i] % 2 == 0)
                count++;

        Console.WriteLine($"Из них чётные: {count}");

        void FillArrayRandomNumbers(int[] numbers)
        {
            for (int a = 0; a < numbers.Length; a++)
            {
                numbers[a] = new Random().Next(100, 1000);
            }
        }
        void PrintArray(int[] numbers)
        {
            Console.Write("[ ");
            for (int a = 0; a < numbers.Length; a++)
            {
                Console.Write(numbers[a] + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
>>>>>>> 0a7e6acc1e4ebc40cd41bf3c0adfc30777e608aa
}