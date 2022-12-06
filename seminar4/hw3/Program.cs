internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[8];
        Console.Write("[");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(0, 999);
            if (i < numbers.Length - 1) Console.Write($"{numbers[i]}, ");

            else Console.Write(numbers[i]);
        }
        Console.Write("]");
    }
}