using System;
using System.Collections.Generic;
using System.Text;

namespace szkola_obiektowo
{
    public class osoba
    {
        public string imie;
        public int wiek;
        //imie, wiek - pola klasy
        //konstruktor - metoda wywolywana przy tworzeniu obiektu
        //przypisuje wartosci poczatkowe do pol klasy
        public osoba(string imie, int wiek)
        {
            this.imie = imie;
            this.wiek = wiek;
        }
        public osoba()
        {
         
        }
        //przeciazanie konstruktora - metody o tej samej nazwie
        //roznej liczbie lub typie argumentow

        public override string ToString()
        {
            return "imię: "+imie + " wiek: "+ wiek;
        }

    }
}
