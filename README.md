# Aplikacja konsolowa – Generator raportów sprzedażowych

## 📌 Opis projektu

Ten program generuje losowe dane sprzedażowe i zapisuje je w pliku w wybranym przez użytkownika formacie: CSV, JSON lub XML.

Aplikacja wykorzystuje **wzorzec projektowy Simple Factory**, co ułatwia jej rozbudowę o nowe formaty (np. PDF w przyszłości).

---

## 🚀 Jak to działa?

1. Program generuje losowe dane sprzedaży (produkt, ilość, cena, data).
2. Użytkownik wybiera format raportu: `csv`, `json` lub `xml`.
3. Program tworzy odpowiedni formatter poprzez **Simple Factory**.
4. Dane zostają zapisane w pliku:
   - `raport_2025-04-10_14-35.csv`
   - `raport_2025-04-10_14-35.json`
   - lub `raport_2025-04-10_14-35.xml`
5. Program wyświetla komunikat o powodzeniu operacji.

---

## 🧱 Struktura projektu
```
zadanie_4/
│
├── Models/
│   └── Sprzedaz.cs
│
├── Formatters/
│   ├── IRaportFormatter.cs
│   ├── CsvFormatter.cs
│   ├── JsonFormatter.cs
│   ├── XmlFormatter.cs
│   └── FormatterFactory.cs
│
├── Program.cs
└── README.md
```
---

## 🏗️ Zastosowanie wzorca Simple Factory

Wzorzec **Simple Factory** został użyty w klasie `FormatterFactory`, która na podstawie wybranego formatu (`csv`, `json`, `xml`) zwraca odpowiedni obiekt implementujący interfejs `IRaportFormatter`.

Dzięki temu:

- logika tworzenia obiektów jest **oddzielona od logiki programu głównego**,
- kod jest bardziej **czytelny i elastyczny**,
- łatwo dodać nowe formaty (np. `PdfFormatter`) bez modyfikacji głównej logiki programu.

---

## 🔧 Jak uruchomić?

1. Otwórz projekt w Visual Studio, Riderze lub uruchom przez terminal.
2. Skompiluj i uruchom projekt.
3. Wprowadź jeden z obsługiwanych formatów (`csv`, `json`, `xml`).
4. Plik zostanie zapisany w katalogu `bin/Debug/netX.X/`.

---

## 🛠️ Możliwości rozbudowy

- Dodanie nowych formatterów (np. PDF).
- Obsługa wielu języków lub walut.
- Możliwość wczytania danych z pliku zamiast generowania losowych.

---

## 👨‍💻 Autor

Paweł Gierlotka

