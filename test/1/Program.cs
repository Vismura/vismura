
        int number = new Random().Next(10, 100);
        Console.WriteLine($"случайное число --> {number}");

        int max(int num)
        {
            int first = number / 10;
            int second = number % 10;
            if (first > second) return first;
            return second;
        }
        int Max = max(number);
        Console.WriteLine($"макс число --> {Max}");

