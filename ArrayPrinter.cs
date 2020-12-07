using System;

public class ArrayPrinter
{
    public static void Print(int[] input)
    {
        for (int k = 0; k < input.Length; k++)
        {
            Console.Write(input[k] + " ");
        }
        Console.WriteLine();
    }
}
