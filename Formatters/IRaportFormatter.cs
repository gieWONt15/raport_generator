using zadanie_4.Models;

namespace zadanie_4.Formatters;

public interface IRaportFormatter
{
    void ZapiszRaport(List<Sprzedaz> dane);
}