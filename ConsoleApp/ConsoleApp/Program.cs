
using Microsoft.Win32.SafeHandles;
internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Marek";
        string name2 = "Ania";
        string name3 = "Ewa";
        char female = 'K';
        char male = 'M';
        int ageOfMark = 16;
        int ageAnn = 29;
        int ageEwa = 33;
        bool woman = true;
        bool ageUnder30 = ageAnn < 30;
        bool mature = ageOfMark > 18;

        if (ageUnder30 = true)
        {
            if (woman == true)
            { Console.WriteLine("Ania jest kobietą poniżej 30 lat.");
            }
        }
       
        if (mature == true)
        { Console.WriteLine("Marek jest pełnoletni.");
        }
        else
        { Console.WriteLine("Marek jest niepełnoletni."); 
        }

        Console.WriteLine(name3 + " ma lat " + ageEwa + ".");
    }
}