class Program
{
    static void Main(string[] args)
    {
        // przyjmujemy dane od użytkownika
        Console.Write("Podaj kwotę kredytu (od 10000 do 100000 PLN): ");
        double kwotaKredytu = double.Parse(Console.ReadLine());
        Console.Write("Podaj ilość rat (od 6 do 96): ");
        int iloscRat = int.Parse(Console.ReadLine());

        // sprawdzamy, czy podane dane są poprawne
        if (kwotaKredytu < 10000 || kwotaKredytu > 100000 || iloscRat < 6 || iloscRat > 96)
        {
            Console.WriteLine("Podane dane są niepoprawne!");
            return;
        }

        // obliczamy wysokość odsetek
        double oprocentowanie = 0.05;
        double odsetki = kwotaKredytu * oprocentowanie;

        // obliczamy wysokość raty miesięcznej
        double rata = (kwotaKredytu + odsetki) / iloscRat;

        // wyświetlamy wynik
        Console.WriteLine("Wysokość raty miesięcznej wynosi: " + rata.ToString("F2") + " PLN.");
    }
}

