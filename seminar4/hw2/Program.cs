<<<<<<< HEAD
﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите число");
        int i = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        if (i > 0)
        {
            while (i > 0)
            {
                int num = i % 10;
                i = i / 10;
                sum = sum + num;
            }
            Console.Write("сумма всех цифр в числе равна: " + sum);
        }

        if (i < 0)
        {
            Console.WriteLine("Введено неправильное число");
        }
    }
=======
﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите число");
        int i = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        if (i > 0)
        {
            while (i > 0)
            {
                int num = i % 10;
                i = i / 10;
                sum = sum + num;
            }
            Console.Write("сумма всех цифр в числе равна: " + sum);
        }

        if (i < 0)
        {
            Console.WriteLine("Введено неправильное число");
        }
    }
>>>>>>> 0a7e6acc1e4ebc40cd41bf3c0adfc30777e608aa
}