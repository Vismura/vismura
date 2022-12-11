internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите день недели");
        int daynumber = Convert.ToInt32(Console.ReadLine());
        if (daynumber < 6)
        {
            Console.WriteLine("Рабочий");
        }
        else
        {
            Console.WriteLine("Выходной!");
        }
    }
}