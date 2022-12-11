
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
}