using zadanie_4.Formatters;
using zadanie_4.Models;

namespace zadanie_4;

class Program
{
    static void Main(string[] args)
    {
        List<Sprzedaz> dane = GenerujDaneLosowe();

        Console.WriteLine("Wybierz format raportu (csv, json, xml):");
        string format = Console.ReadLine().ToLower();
        
        FormatterFactory fabryka = new FormatterFactory();
        IRaportFormatter formatter;

        try
        {
            formatter = fabryka.StwórzFormatter(format);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        
        formatter.ZapiszRaport(dane);
    }
    
    static List<Sprzedaz> GenerujDaneLosowe()
    {
        string[] produkty = { "Wino", "Ser", "Kieliszki", "Korkociąg", "Deska do sera" };
        Random rnd = new Random();
        int liczbaRekordow = rnd.Next(5, 11);
        List<Sprzedaz> lista = new();
 
        for (int i = 0; i < liczbaRekordow; i++)
        {
            lista.Add(new Sprzedaz
            {
                Produkt = produkty[rnd.Next(produkty.Length)],
                Ilosc = rnd.Next(1, 10),
                Cena = Math.Round((decimal)(rnd.NextDouble() * 100), 2),
                Data = DateTime.Today.AddDays(-rnd.Next(30))
            });
        }
         
        return lista;
    }
}
