<<<<<<< HEAD
﻿
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите трёхзначное число");
        int Numbers = Convert.ToInt32(Console.ReadLine());
        string stringNumber = Convert.ToString(Numbers);

        if (stringNumber.Length > 2)
        {
            Console.WriteLine("Третья цифра => " + stringNumber[2]);
        }    
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    }
=======
﻿
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите трёхзначное число");
        int Numbers = Convert.ToInt32(Console.ReadLine());
        string stringNumber = Convert.ToString(Numbers);

        if (stringNumber.Length > 2)
        {
            Console.WriteLine("Третья цифра => " + stringNumber[2]);
        }    
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    }
>>>>>>> 0a7e6acc1e4ebc40cd41bf3c0adfc30777e608aa
}