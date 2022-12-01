internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt32(Console.ReadLine());
        double[] numbers = new double[size];
        FillArrayRandomNumbers(numbers);
        Console.WriteLine("Вот наш массив: ");
        PrintArray(numbers);
        double min = int.MaxValue;
        double max = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

        void FillArrayRandomNumbers(double[] numbers)
        {
            for (int a = 0; a < numbers.Length; a++)
            {
                numbers[a] = Convert.ToDouble(new Random().Next(100, 100000)) / 100;
            }
        }
        void PrintArray(double[] numbers)
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
}