//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты первой точки");
            Console.Write("X: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Z: ");
            int z1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки");
            Console.Write("X: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Z: ");
            int z2 = Convert.ToInt32(Console.ReadLine());

        int d = ((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
        Console.Write("Расстояние = " );
        Console.Write(Math.Sqrt(d));
    }
}