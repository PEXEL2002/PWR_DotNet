# Projekt: Aplikacja bazodanowa .NET

Ten projekt demonstruje u¿ycie .NET 8.0 z Entity Framework Core i SQLite do zarz¹dzania prost¹ aplikacj¹ bazodanow¹. Aplikacja obs³uguje u¿ytkowników i zadania, pobieraj¹c dane z zewnêtrznych API i wykonuj¹c operacje CRUD na bazie danych.

## Przegl¹d klas

### 1. **`UserEntity`**
Ta klasa reprezentuje u¿ytkownika w aplikacji.

#### W³aœciwoœci:
- **Id**: Unikalny identyfikator u¿ytkownika.
- **FirstName**: Imiê u¿ytkownika.
- **LastName**: Nazwisko u¿ytkownika.
- **Age**: Wiek u¿ytkownika.
- **Gender**: P³eæ u¿ytkownika.

### 2. **`ToDoEntity`**
Ta klasa reprezentuje zadanie przypisane do u¿ytkownika.

#### W³aœciwoœci:
- **Id**: Unikalny identyfikator zadania.
- **Task**: Opis zadania.
- **IsDone**: Wartoœæ boolean wskazuj¹ca, czy zadanie zosta³o ukoñczone.
- **UserId**: Klucz obcy odnosz¹cy siê do u¿ytkownika przypisanego do zadania.

### 3. **`AppDbContext`**
Ta klasa definiuje kontekst bazy danych dla Entity Framework. Zarz¹dza po³¹czeniem z baz¹ danych i udostêpnia metody do zapytañ i zapisywania danych.

#### Metody:
- **OnConfiguring**: Konfiguruje po³¹czenie z baz¹ danych SQLite.
- **OnModelCreating**: Konfiguruje model, w tym wstawianie pocz¹tkowych danych, jeœli to konieczne.

### 4. **`DownlowdDataFromAPI`**
Ta klasa odpowiada za pobieranie danych z zewnêtrznych API.

#### Metody:
- **GetData**: Pobiera dane z okreœlonego API i zwraca je w postaci ³añcucha znaków. Metoda ta jest asynchroniczna i u¿ywa `HttpClient` do wykonywania zapytañ GET.

## Uwagi

- Aplikacja zak³ada u¿ycie SQLite jako dostawcy bazy danych.
- Dane z zewnêtrznych API s¹ pobierane asynchronicznie i zapisywane w bazie danych.
- Mo¿esz uruchomiæ migracje bazy danych lub rêcznie zaktualizowaæ bazê, u¿ywaj¹c `Update-Database` w przypadku zmian w modelu.

## Przyk³ad u¿ycia aplikacji

- Pobiera listê u¿ytkowników i ich zadania z bazy danych lub API.
- Pozwala u¿ytkownikowi zmieniaæ status zadañ (ukoñczone / nieukoñczone).
- Umo¿liwia dodawanie nowych zadañ, które zostan¹ zapisane w bazie danych.