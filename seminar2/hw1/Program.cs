internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите трёхзначное число");
        int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
        string stringNumber = Convert.ToString(threeDigitNumber);
        Console.WriteLine("Вторая цифра => " + stringNumber[1]);
    }
}