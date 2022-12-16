

        Console.WriteLine("Введите первое число ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье число ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        int max(int num1, int num2, int num3)
        {
            Math.Max(num1, num2, num3);
        }
        if (num1 == num2)
        {
            if (num2 == num3) Console.WriteLine("числа равны");   
        }
        else
        {
            int Max = max(num1, num2, num3);
            Console.WriteLine(Max);
        }
