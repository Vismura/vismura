internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int max(int num1, int num2)
        {
            if (num1 > num2) return num1;
            return num2;
        }
        if (num1 == num2)
        {
            Console.WriteLine("числа равны");
        }
        else
        {
            int Max = max(num1, num2);
            Console.WriteLine(Max);
        }
    }
}