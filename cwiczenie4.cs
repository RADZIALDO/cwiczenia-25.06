using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie4
{
    enum Plec
    {
        Mezczyzna,
        Kobieta
    }
    struct Student
    {
        public string Nazwisko;
        public int NrAlbumu;
        public double Ocena;
        public Plec Plec;
    }
    internal class Program
    {
        static void WypelnijStudenta(ref Student student)
        {
            Console.Write("Podaj nazwisko studenta: ");
            student.Nazwisko = Console.ReadLine();

            Console.Write("Podaj numer albumu: ");
            student.NrAlbumu = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Podaj ocenę studenta(2.0 - 5.0):");
                student.Ocena = double.Parse(Console.ReadLine());

                if (student.Ocena < 2.0)
                    student.Ocena = 2.0;
                else if (student.Ocena > 5.0)
                    student.Ocena = 5.0;
            } while (student.Ocena < 2.0 || student.Ocena > 5.0);

            Console.Write("Podaj płeć studenta (0 - mezczyzna, 1 - kobieta): ");
            int plecVal = int.Parse(Console.ReadLine());
            student.Plec = (Plec)plecVal;
        }
        static double ObliczSrednia(Student[] grupa)
        {
            double sumaOcen = 0.0;
            foreach(var student in grupa) 
            {
                sumaOcen += student.Ocena;
            }

            double srednia = sumaOcen / grupa.Length;
            return srednia;
        }
        static void WyswietlStudenta(Student student)
        {
            Console.WriteLine($"Nazwisko: {student.Nazwisko}, Numer albumu: {student.NrAlbumu}, Ocena: {student.Ocena}, Płeć: {student.Plec}");
        }
        static void Main(string[] args)
        {
            Student[] grupa = new Student[5];

            for(int i = 0; i < grupa.Length; i++) 
            {
                Console.WriteLine($"Wprowadz dane studenta: {i + 1}");
                WypelnijStudenta(ref grupa[i]);
            }

            Console.WriteLine("\nDane studentów: ");

            foreach(var student in grupa)
            {
                WyswietlStudenta(student);
            }

            double srednia = ObliczSrednia(grupa);
            Console.WriteLine($"\nŚrednia ocen wszystkich studentów: {srednia}");

            Console.ReadKey();
        }
    }
}
