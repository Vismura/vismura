internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число A");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B");
        int b = Convert.ToInt32(Console.ReadLine());
        int step = a;

        if (a < 1)
        {
            Console.WriteLine("Введено неправильное число А");
        }

        else if (b < 0)
        {
            Console.WriteLine("Введено неправильное число B");
        }

        else
        {
            for (int i = 1; i < b; i++)
            {
                step = step * a;
            }
            Console.WriteLine("A в степени B равно: " + step);
        }
    }
}