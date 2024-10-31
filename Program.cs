using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nMirror numbers between {n} and {m} are:");

        for (int i = n; i <= m; i++)
            if (IsMirrorNumber(i))
                Console.Write(i + " ");

        Console.WriteLine();
    }

    static bool IsMirrorNumber(int num)
    {
        int original = num, reversed = 0;

        while (num > 0)
        {
            int remainder = num % 10;
            reversed = reversed * 10 + remainder;
            num /= 10;
        }

        return original == reversed;
    }
}
