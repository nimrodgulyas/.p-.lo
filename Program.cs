Fejlec();
Console.WriteLine("Itt kezdődik a munka.");
Fejlec();

Csillagsor();
Console.WriteLine("  Csillagos ég");
Csillagsor();
Console.WriteLine(" Indul a verseny!");
Visszaszamlalas();
Console.WriteLine("\nPáros számok: ");
ParosSzamok();

void Fejlec()
{
    Console.WriteLine("====================");
    Console.WriteLine("  METÓDUSGYÁR");
    Console.WriteLine("====================");
}

void Csillagsor()
{
    
    for (int i = 0; i<15; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

void Visszaszamlalas()
{
    for (int i = 5; i>= 1; i--)
        Console.Write($@" {i}");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(" Rajt!");
    Console.ResetColor();
}

void ParosSzamok()
{
    {
        for (int i = 1; i <= 20; i++)
            if (i % 2 == 0)
            { 
                Console.Write($" {i}"); 
            }
    }
    Console.WriteLine();
}


/* 2. feladat */

Udvozol("Anna");
Udvozol("Bence");
string barat = "Csilla";
Udvozol(barat);

void Udvozol(string nev)
{
    Console.WriteLine($"Szia {nev}!Jó, hogy itt vagy.");
}

Sor(5);
Sor(12);
Sor(2 * 10);

Lampa(true);
Lampa(false);
Lampa(5 > 3);

Idojaras(-3.5);
Idojaras(12);
Idojaras(25);
Idojaras(31.2);

void Sor(int db)
{ 
        for (int i = 0; i <= db; i++)
        {
            Console.Write("-");
            if (i == db)
            {
                Console.WriteLine();
            }
        }
 
}

void Lampa(bool allapot)
{
    if (allapot == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Lámpa: BE");
        Console.ResetColor();
    }
    else if (allapot == false)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Lámpa: KI");
        Console.ResetColor();
    }
}

void Idojaras(double homerseklet)
{
if (homerseklet < 0)
    {
        Console.WriteLine($"{homerseklet}: fagy");
    }
else if (homerseklet >= 0 && homerseklet < 25)
    {
        Console.WriteLine($"{homerseklet}: kellemes");
    }
    else
    {
        Console.WriteLine($"{homerseklet}: meleg");
    }

}

/* 3. feladat */

Teglalap(6, 2);
Console.WriteLine();
Teglalap(3, 3);

void Teglalap (int sorszam, int magassag)
{
    for (int i = 0; i < magassag; i++)
    {
        for (int j = 0; j < sorszam; j++)
        {
            Console.Write("#");
        }
        Console.WriteLine();
    }
}