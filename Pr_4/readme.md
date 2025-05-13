# Laboratorium 4 – Aplikacja Webowa w ASP.NET Core

## Opis

Celem laboratorium jest zapoznanie się z podstawami tworzenia aplikacji webowych przy użyciu technologii **ASP.NET Core** i **Blazor**, a także implementacja aplikacji bazodanowej oraz jej publikacja w chmurze **Microsoft Azure**.

Projekt składa się z trzech głównych zadań:
1. Utworzenie aplikacji Blazor.
2. Implementacja aplikacji bazodanowej z systemem oceniania.
3. Publikacja aplikacji w chmurze Azure.

## Wymagania

- .NET 8.0 LTS
- Visual Studio z zainstalowaną obsługą ASP.NET Core i Azure
- Konto studenckie Microsoft (do hostowania w Azure)
- Podstawowa znajomość C#, Blazor i Entity Framework

## Zadania

### Zadanie 1 – Aplikacja Blazor

- Stworzenie projektu **Blazor Web App**
- Konfiguracja:
  - Authentication: None
  - HTTPS: Tak
  - Render mode: Server
  - Sample pages: Tak
- Modyfikacje:
  - Dodanie prostego licznika
  - Strona z prognozą pogody:
    - rozszerzenie do 10 dni
    - licznik dni ciepłych (>15°C)
    - przyciski filtrowania i przywracania
    - filtracja po nazwie dnia tygodnia

### Zadanie 2 – Aplikacja bazodanowa

- Nowy projekt Blazor z autoryzacją użytkowników (Individual Accounts)
- Funkcjonalności:
  - System oceniania (np. filmy, gry, książki)
  - Przechowywanie i wyświetlanie obrazków (URL)
  - Widok szczegółowy z możliwością aktualizacji średniej oceny
  - Widok listy z sortowaniem i ograniczoną informacją
  - Ograniczony dostęp do stron dla niezalogowanych użytkowników
  - Modyfikacja menu nawigacyjnego

- Opcjonalne rozszerzenia (dla najwyższej oceny):
  - Logowanie przez Google/Microsoft
  - Osadzanie zewnętrznych komponentów (np. mapa, Twitter)
  - Przesył danych między różnymi aplikacjami webowymi
  - Możliwość dodania plików (np. z dysku, kamerki)

### Zadanie 3 – Publikacja w Azure

- Publikacja aplikacji webowej jako **Azure App Service**
- Konfiguracja:
  - Hosting plan (Free, East US)
  - Tworzenie zasobów i grupy zasobów
- Hostowanie bazy danych:
  - Azure SQL Database
  - Tworzenie serwera i połączenia (connection string)
  - Migracje bazy danych (automatyczne lub ręczne)
- Ustawienie zmiennej środowiskowej `ASPNETCORE_ENVIRONMENT` na `Development` w Azure
