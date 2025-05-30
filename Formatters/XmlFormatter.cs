using zadanie_4.Models;
using System.Xml.Serialization;

namespace zadanie_4.Formatters;

public class XmlFormatter : IRaportFormatter
{
    public void ZapiszRaport(List<Sprzedaz> dane)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Sprzedaz>));

        using (FileStream fs = new FileStream($"raport_{DateTime.Now:yyyy-MM-dd_HH-mm}.xml", FileMode.Create))
        {
            serializer.Serialize(fs, dane);
        }
    }
}