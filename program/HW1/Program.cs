internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine(num1);
        }
        else if (num1 < num2)
        {
            Console.WriteLine(num2);
        }
        else
        {
            Console.WriteLine("Оба числа равны");
        }
    }
}