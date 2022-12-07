internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 23: 
        //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        Console.Write("Введите число N: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            void que(int n)
            {
                int n1 = 1;
                while (n1 <= n)
                {
                    int sqe = n1 * n1 * n1;
                    Console.WriteLine($"{n1,5} | {sqe}");
                    n1++;
                }
            }
            que(num);
        }

        else
        {
            Console.Write("Неправильное число");
        }
    }
}