# Projekt: Obliczenia Wielowątkowe i Przetwarzanie Obrazów w .NET

## Opis
Celem projektu jest zapoznanie się z przetwarzaniem wielowątkowym w technologii .NET, implementacja algorytmów równoległych dla różnych zadań obliczeniowych oraz zastosowanie ich do przetwarzania obrazów. Projekt zawiera aplikacje konsolową oraz aplikację Windows Forms, które wykonują zadania związane z przetwarzaniem wielowątkowym, takie jak mnożenie macierzy i przetwarzanie obrazów.

## Zadania

### 1. Mnożenie Macierzy

W ramach tego zadania zaprojektowano aplikację, która umożliwia porównanie czasów obliczeń dla sekwencyjnego i równoległego mnożenia macierzy z użyciem technologii .NET. Program wykorzystuje zarówno niskopoziomowe (klasa `Thread`), jak i wysokopoziomowe (biblioteka `Parallel`) podejścia do zrównoleglania obliczeń.

**Funkcje:**
- Generowanie losowych macierzy.
- Możliwość ustawienia liczby wątków do obliczeń.
- Porównanie czasów obliczeń dla różnych rozmiarów macierzy.

### 2. Wielowątkowe Przetwarzanie Obrazów

Aplikacja umożliwia przetwarzanie obrazów za pomocą wielowątkowości. Program wykorzystuje równoległe wykonywanie filtrów na obrazach, takich jak:
- Progowanie
- Szarość
- Negatyw
- Odbicie lustrzane

Każdy filtr jest wykonywany w oddzielnym wątku, co umożliwia równoczesne przetwarzanie wielu operacji.

**Funkcje:**
- Ładowanie obrazów za pomocą `OpenFileDialog`.
- Przetwarzanie obrazu przy użyciu wątków (lub `Parallel`).
- Wyświetlanie wyników przetwarzania w `PictureBox`.

### 3. Analiza Prędkości Obliczeń

W ramach zadania przeprowadzono analizę przyspieszenia obliczeń przy użyciu wielu wątków w porównaniu do wersji sekwencyjnej. Przeprowadzono testy na różnych rozmiarach macierzy i dla różnych liczby wątków, a wyniki zostały zapisane w tabelach i wykresach.

## Struktura projektu

Projekt składa się z dwóch głównych folderów:

1. **Aplikacja Konsolowa:**  
   Implementacja algorytmu mnożenia macierzy w aplikacji konsolowej, wykorzystująca zarówno podejście sekwencyjne, jak i wielowątkowe. Program obsługuje parametry wejściowe i wyświetla wyniki obliczeń w konsoli.

2. **Aplikacja Windows Forms:**  
   Aplikacja okienkowa, w której można załadować obraz, nałożyć różne filtry i wyświetlić wynik. Wszystkie operacje na obrazach są wykonywane równolegle, dzięki czemu program jest szybki i skalowalny.