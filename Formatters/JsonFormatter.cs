using System.Text.Json;
using zadanie_4.Models;

namespace zadanie_4.Formatters;

public class JsonFormatter : IRaportFormatter
{
    public void ZapiszRaport(List<Sprzedaz> dane)
    {
        string json = JsonSerializer.Serialize(dane, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("raport.json", json);
    }
}