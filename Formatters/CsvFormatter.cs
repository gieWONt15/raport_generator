using System.IO;
using zadanie_4.Models;

namespace zadanie_4.Formatters;

public class CsvFormatter : IRaportFormatter
{
    public void ZapiszRaport(List<Sprzedaz> dane)
    {
        using (StreamWriter sw = new StreamWriter("raport.csv"))
        {
            sw.WriteLine("Produkt,Ilość,Cena,Data");
            foreach (var s in dane)
            {
                sw.WriteLine($"{s.Produkt},{s.Ilosc},{s.Cena},{s.Data:yyyy-MM-dd}");
            }
        }
    }
}