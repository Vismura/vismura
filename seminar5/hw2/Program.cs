internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomNumbers(numbers);
        PrintArray(numbers);
        int sum = 0;

        for (int i = 0; i < numbers.Length; i += 2)
            sum = sum + numbers[i];

        Console.WriteLine($"Cумма элементов на нечётных позициях = {sum}");

        void FillArrayRandomNumbers(int[] numbers)
        {
            for (int a = 0; a < numbers.Length; a++)
            {
                numbers[a] = new Random().Next(1, 999);
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
}