﻿
using Microsoft.Win32.SafeHandles;
internal class Program
{
    private static void Main(string[] args)
    {
        int number = 5657779;
        string numberToString = number.ToString();
        char[] letters = numberToString.ToCharArray();
     

        int counter0 = 0;
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;
        int counter5 = 0;
        int counter6 = 0;
        int counter7 = 0;
        int counter8 = 0;
        int counter9 = 0;
      

        foreach (char letter in letters)
        { if (letter == '0')
            { counter0++; }
            
        else if (letter == '1')
            { counter1++; }
            else if (letter == '2')
            { counter2++; }
            else if (letter == '3')
            { counter3++; }
            else if (letter == '4')
            { counter4++; }
            else if (letter == '5')
            { counter5++; }
            else if (letter == '6')
            { counter6++; }
            else if (letter == '7')
            { counter7++; }
            else if (letter == '8')
            { counter8++; }
            else if (letter == '9')
            { counter9++; }
        }

        Console.WriteLine("Liczba wejściowa: ");
        Console.WriteLine(number);
 
        Console.WriteLine("Ilość cyfr 0 ");
        Console.WriteLine(counter0);

        Console.WriteLine("Ilość cyfr 1 ");
        Console.WriteLine(counter1);

        Console.WriteLine("Ilość cyfr 2 ");
        Console.WriteLine(counter2);

        Console.WriteLine("Ilość cyfr 3 ");
        Console.WriteLine(counter3);

        Console.WriteLine("Ilość cyfr 4 ");
        Console.WriteLine(counter4);

        Console.WriteLine("Ilość cyfr 5 ");
        Console.WriteLine(counter5);

        Console.WriteLine("Ilość cyfr 6 ");
        Console.WriteLine(counter6);

        Console.WriteLine("Ilość cyfr 7 ");
        Console.WriteLine(counter7);
        
        Console.WriteLine("Ilość cyfr 8 ");
        Console.WriteLine(counter8);

        Console.WriteLine("Ilość cyfr 9 ");
        Console.WriteLine(counter9);
    }
}