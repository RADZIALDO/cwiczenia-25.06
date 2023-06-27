using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie2
{
    struct Student
    {
        public string Imie;
        public string Nazwisko;
        public int NumerIndeksu;
        public int RokStudiow;
    }
    struct Przedmiot
    {
        public string Nazwa;
        public int Kod;
        public string Wykladowca;
    }
    struct NauczycielAkademicki
    {
        public string Imie;
        public string Nazwisko;
        public string StopienNaukowy;
        public string Specjalizacja;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Imie = "Jan";
            student.Nazwisko = "Kowalski";
            student.NumerIndeksu = 123456;
            student.RokStudiow = 2;

            Przedmiot przedmiot = new Przedmiot();
            przedmiot.Nazwa = "Programowanie";
            przedmiot.Kod = 101;
            przedmiot.Wykladowca = "dr. Nowak";

            NauczycielAkademicki nauczyciel = new NauczycielAkademicki();
            nauczyciel.Imie = "Anna";
            nauczyciel.Nazwisko = "Kowalska";
            nauczyciel.StopienNaukowy = "dr hab.";
            nauczyciel.Specjalizacja = "Sztuczna inteligencja";

            Console.WriteLine($"Student: {student.Imie} {student.Nazwisko}");
            Console.WriteLine($"Numer indeksu: {student.NumerIndeksu}");
            Console.WriteLine($"Rok studiów: {student.RokStudiow}");

            Console.ReadKey();
        }
    }
}
