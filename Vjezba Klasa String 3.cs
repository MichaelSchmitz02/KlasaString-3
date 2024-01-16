using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {   
        Console.Write("Unesite niz znakova: ");
        string unos = Console.ReadLine();    
        string sVelika = unos.ToUpper();
        string sMala = unos.ToLower();
        string sPrvaTri = unos.Substring(0, Math.Min(3, unos.Length));
        string sZadnjihPet = unos.Substring(Math.Max(0, unos.Length - 5));
        string s8_11 = (unos.Length >= 11) ? unos.Substring(7, 4) : "Niz nema dovoljno znakova za s8_11";
        Console.WriteLine("Uneseni niz: " + unos);
        Console.WriteLine("sVelika: " + sVelika);
        Console.WriteLine("sMala: " + sMala);
        Console.WriteLine("sPrvaTri: " + sPrvaTri);
        Console.WriteLine("sZadnjihPet: " + sZadnjihPet);
        Console.WriteLine("s8_11: " + s8_11);
    }
}
