# Projekt: Aplikacja bazodanowa .NET

Ten projekt demonstruje u�ycie .NET 8.0 z Entity Framework Core i SQLite do zarz�dzania prost� aplikacj� bazodanow�. Aplikacja obs�uguje u�ytkownik�w i zadania, pobieraj�c dane z zewn�trznych API i wykonuj�c operacje CRUD na bazie danych.

## Przegl�d klas

### 1. **`UserEntity`**
Ta klasa reprezentuje u�ytkownika w aplikacji.

#### W�a�ciwo�ci:
- **Id**: Unikalny identyfikator u�ytkownika.
- **FirstName**: Imi� u�ytkownika.
- **LastName**: Nazwisko u�ytkownika.
- **Age**: Wiek u�ytkownika.
- **Gender**: P�e� u�ytkownika.

### 2. **`ToDoEntity`**
Ta klasa reprezentuje zadanie przypisane do u�ytkownika.

#### W�a�ciwo�ci:
- **Id**: Unikalny identyfikator zadania.
- **Task**: Opis zadania.
- **IsDone**: Warto�� boolean wskazuj�ca, czy zadanie zosta�o uko�czone.
- **UserId**: Klucz obcy odnosz�cy si� do u�ytkownika przypisanego do zadania.

### 3. **`AppDbContext`**
Ta klasa definiuje kontekst bazy danych dla Entity Framework. Zarz�dza po��czeniem z baz� danych i udost�pnia metody do zapyta� i zapisywania danych.

#### Metody:
- **OnConfiguring**: Konfiguruje po��czenie z baz� danych SQLite.
- **OnModelCreating**: Konfiguruje model, w tym wstawianie pocz�tkowych danych, je�li to konieczne.

### 4. **`DownlowdDataFromAPI`**
Ta klasa odpowiada za pobieranie danych z zewn�trznych API.

#### Metody:
- **GetData**: Pobiera dane z okre�lonego API i zwraca je w postaci �a�cucha znak�w. Metoda ta jest asynchroniczna i u�ywa `HttpClient` do wykonywania zapyta� GET.

## Uwagi

- Aplikacja zak�ada u�ycie SQLite jako dostawcy bazy danych.
- Dane z zewn�trznych API s� pobierane asynchronicznie i zapisywane w bazie danych.
- Mo�esz uruchomi� migracje bazy danych lub r�cznie zaktualizowa� baz�, u�ywaj�c `Update-Database` w przypadku zmian w modelu.

## Przyk�ad u�ycia aplikacji

- Pobiera list� u�ytkownik�w i ich zadania z bazy danych lub API.
- Pozwala u�ytkownikowi zmienia� status zada� (uko�czone / nieuko�czone).
- Umo�liwia dodawanie nowych zada�, kt�re zostan� zapisane w bazie danych.