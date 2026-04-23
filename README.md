# BioSequenceAnalyzer (Laboratorium 7)

## Opis projektu
Aplikacja okienkowa stworzona na zajęcia z Laboratorium 7. Głównym zadaniem programu jest analiza wprowadzonych sekwencji DNA i zliczanie wystąpień poszczególnych sekwencji nukleotydów (k-merów) o długości 4 znaków.

## Funkcjonalności
* Walidacja danych wejściowych: automatyczne oczyszczanie tekstu z białych znaków oraz usuwanie znaków innych niż A, C, G, T (wykorzystanie wyrażeń regularnych).
* Sprawdzanie minimalnej wymaganej długości sekwencji (min. 4 nukleotydy).
* Zliczanie unikalnych 4-nukleotydowych sekwencji przy użyciu algorytmu "przesuwnego okna".
* Automatyczne sortowanie wyników malejąco względem liczby wystąpień (zastosowanie LINQ).

## Technologie
* C# (.NET)
* Avalonia UI (XAML + Code-behind)

## Autor
* **Imię i nazwisko:** Kyrylo Kudrevych
* **Nr albumu:** 163695
