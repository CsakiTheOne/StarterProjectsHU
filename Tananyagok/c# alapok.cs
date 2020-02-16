// Könyvtárak importálása
using System;
using System.IO;

// A könyvtár, amiben a program van. Igen, ezt is lehet using-olni
namespace Basics
{
    // Statikus osztály, amiből nem lehet példányokat csinálni
    static class Program
    {
        // A főprogram egy függvény, amivel indul a program
        // Az 1. paraméterben kapjuk meg, hogy milyen paraméterekkel indul a program, ha parancssorból nyitjuk meg
        // Statikus osztályban csak statikus függvények, változók lehetnek
        public static void Main(string[] args)
        {
            // Változók primitív adattípussal. Primitívek a számok, bool, char, stb.
            int x;
            // Változó beállítása
            x = 3;
            // Osztály példányosítása. Ez egy új kocka lesz, aminek mérete: 3 (x tartalma)
            Cube kocka = new Cube(x);
            // Egység kocka méretének lekérése
            // Az osztályt kell írnunk ide, mert statikus függvény, amit meg akarunk hívni
            int unitSize = Cube.UnitCube().Size;
        }
    }

    // Egy példányozható osztály
    class Cube
    {
        // Konstruktor: ez fut le, ha példányt készítünk az osztályból
        public Cube() { /* most épp üres */ }
        // Konstruktor paraméterrel
        public Cube(int size)
        {
            Size = size;
        }

        // Egy olvasható, írható tulajdonság (nagy kezdőbetű)
        public int Size { get; set; }

        // Egy privát változó, amit kívülről nem láthatunk (kis kezdőbetű)
        (private) int unitSize

        // Nem statikus osztályban lehet statikus függvény vagy változó
        // De példányból nem fogjuk látni
        public static Cube UnitCube()
        {
            return new Cube(1);
        }
    }
}