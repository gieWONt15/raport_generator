namespace zadanie_4.Formatters;

public class FormatterFactory
{
    public IRaportFormatter StwórzFormatter(string format)
    {
        switch (format.ToLower())
        {
            case "csv":
                return new CsvFormatter();
            case "json":
                return new JsonFormatter();
            case "xml":
                return new XmlFormatter();
            default:
                throw new ArgumentException("Nieobsługiwany format pliku", nameof(format));
        }
    }
}