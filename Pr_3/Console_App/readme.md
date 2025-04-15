# Projekt: Obliczenia wielowątkowe .NET

## Opis
Ten projekt jest przykładem obliczeń wielowątkowych w .NET.
Zawiera różne techniki i podejścia do programowania równoległego, w tym użycie Task Parallel Library (TPL), async/await, a także zarządzanie wątkami i synchronizację.

## Przegląd klas

**Matrix** - Klasa reprezentująca macierz. Zawiera metody do generowania i mnożenia macierzy.

Pola:
- **matrix** zmienna przechowująca macierz jako tablicę dwuwymiarową.
- **rows** liczba wierszy w macierzy.
- **columns** liczba kolumn w macierzy.

Metody:
- **PrintMatrix()**: Wyświetla zawartość macierzy w konsoli, iterując przez wszystkie wiersze i kolumny.
- **PrintMatrixMultiply(int[,] result)**: Wyświetla wynik mnożenia macierzy, iterując przez wiersze i kolumny wyniku.
- **MultiplyMatrixThread(Matrix mat, int num_of_thread, bool ifPrint)**: Mnoży macierze z użyciem wielowątkowości, uruchamiając wątki równolegle i wyświetla wynik, jeśli `ifPrint` jest `true`.
- **MultiplyRows(int startRow, int endRow, Matrix mat, int[,] result)**: Mnoży wiersze macierzy w określonym zakresie, zapisując wynik do tablicy wynikowej.
- **MultiplyMatrixParallel(Matrix mat, int num_of_thread, bool ifPrint)**: Mnoży macierze równolegle, uruchamiając zadania równocześnie i wyświetla wynik, jeśli `ifPrint` jest `true`.

# Wyniki badań
W tabeli poniżej przedstawiono wyniki badań dotyczące wydajności różnych podejść do mnożenia macierzy w .NET. Badania przeprowadzono na komputerze z procesorem **Intel(R) Core(TM) i5-8350U CPU @ 1.70GHz** i **16 GB RAM**.
Wyniki w poniższej tabeli uśredniony czas z 10 uruchomień dla każdej kombinacji wymiarów macierzy i liczby wątków.

| Matrix dimension | Number of Threads | Parallel/Threads | Time |
|------------------|-------------------|------------------|------|
| 500x500 | 1 |  Parallel | 1367 |
| 500x500 | 1 |  Threads | 1247 |
| 500x500 | 2 |  Parallel | 771 |
| 500x500 | 2 |  Threads | 685 |
| 500x500 | 4 |  Parallel | 536 |
| 500x500 | 4 |  Threads | 521 |
| 500x500 | 6 |  Parallel | 479 |
| 500x500 | 6 |  Threads | 494 |
| 500x500 | 8 |  Parallel | 450 |
| 500x500 | 8 |  Threads | 526 |
| 750x750 | 1 |  Parallel | 5213 |
| 750x750 | 1 |  Threads | 4682 |
| 750x750 | 2 |  Parallel | 2956 |
| 750x750 | 2 |  Threads | 2670 |
| 750x750 | 4 |  Parallel | 2071 |
| 750x750 | 4 |  Threads | 2008 |
| 750x750 | 6 |  Parallel | 1876 |
| 750x750 | 6 |  Threads | 1717 |
| 750x750 | 8 |  Parallel | 1763 |
| 750x750 | 8 |  Threads | 1647 |
| 1000x1000 | 1 |  Parallel | 18863 |
| 1000x1000 | 1 |  Threads | 17226 |
| 1000x1000 | 2 |  Parallel | 10621 |
| 1000x1000 | 2 |  Threads | 10529 |
| 1000x1000 | 4 |  Parallel | 6904 |
| 1000x1000 | 4 |  Threads | 6796 |
| 1000x1000 | 6 |  Parallel | 6219 |
| 1000x1000 | 6 |  Threads | 5638 |
| 1000x1000 | 8 |  Parallel | 5521 |
| 1000x1000 | 8 |  Threads | 4902 |