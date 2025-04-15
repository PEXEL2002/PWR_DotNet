# Projekt: Wykorzystanie wielowątkowości w obróbce grafiki .NET

## Opis
W tym folderze znajduje się projekt, który demonstruje wykorzystanie wielowątkowości w obróbce grafiki w .NET. Projekt ten ma na celu pokazanie, jak można efektywnie przetwarzać obrazy przy użyciu wielu wątków, co może znacznie przyspieszyć operacje związane z grafiką.
Wizualizacja efektów jest prectawiona przy pomocy GUI napisanego w u Windows Forms.

## Opis obrabianych obrazów
- `ApplyGrayscale(Bitmap img)`
Konwertuje obraz na odcienie szarości, ustawiając każdemu pikselowi równą wartość dla składowych R, G i B na podstawie ich średniej.
- `ApplyNegative(Bitmap img)`
Konwertuje obraz na negatyw, odwracając kolory każdego piksela.
- `ApplyThreshold(Bitmap img, int threshold)`
Konwertuje obraz na czarno-biały, ustawiając piksele powyżej progu na biały, a poniżej na czarny.
- `ApplyMirror(Bitmap img)`
Odbija obraz w poziomie, zamieniając miejscami piksele z lewej i prawej strony.

