using szkola_obiektowo;
Console.WriteLine("Hello, World!");
osoba osoba = new osoba(); //tworzenie obiektu klasy osoba
osoba.imie = "Genowefa"; //publiczne wiec mozna zmieniac wartosc pola imie

Console.WriteLine("imię osoba");
Console.WriteLine(osoba.imie); //wyswietlenie wartosci pola imie
osoba osoba2 = new osoba("Brunhilda", 80);
Console.WriteLine("imię osoba2");
Console.WriteLine(osoba2.imie);
Console.WriteLine(osoba2); //metoda ToString() wyswietla wartosci pol imie i wiek