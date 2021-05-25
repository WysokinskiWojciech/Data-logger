Instrukcja użytkowania aplikacji do odczytu zmiennych ze sterownika PLC.
Główne okno programu:

![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image001.png) 

Okno informujące o konieczności wyboru typu komunikacji (Serial lub Ethernet)
 
![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image002.png) 

1.	Wpisz parametry komunikacji.
Wersja komunikacji szeregowej
 
![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image003.png) 

Wersja komunikacji z wykorzystaniem Ethernetu
 
![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image004.png) 

2.	Wciśnij Connect to PLC
Po nawiązaniu połączenia w prawym rogu pokaże się model sterownika i jego podstawowe parametry dotyczące OS.
 
![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image005.png) 

Gdy parametry komunikacji są błędne lub jest uszkodzony przewód sygnałowy, pojawia się komunikat o braku możliwości nawiązania połączenia ze sterownikiem PLC.
 
![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image006.png) 

3.	Dodawanie zmiennych odbywa się za pomocą przycisku ADD VARIABLE. Pojawia się okno z wyborem typu zmiennej (MB,MI,Ml itp.) oraz wpisaniem numeru zmiennej. Wybór zatwierdź przyciskiem OK.
 
![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image007.png)  
 
![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image008.png)  

![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image009.png) 

![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image010.png) 

4.	Odczyt zmiennych dokonywany jest za pomocą przycisku READ VALUES. W tym czasie sterownik jest odpytywany o wartości wszystkich zmiennych znajdujących się w tabeli. Odczyt danych jest dokonywany 1 raz.
 
![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image011.png) 

5.	Odczyt ciągły danych uruchamia się za pomocą przycisku RUN CONT. W trybie tym dokonuje się ciągły odczyt wszystkich zmiennych znajdujących się w tabeli danych. Interwał pomiędzy odczytami jest zdefiniowany za pomocą pola tekstowego LOOP TIME i jest wyrażony w milisekundach. UWAGA!!! Minimalny interwał pomiędzy odczytami waha się w przedziale 30-50 ms. Wartości zmiennych wraz z czasem zapisywane są w pliku tekstowym o nazwie zdefiniowanej w polu tekstowym FILE NAME.
 
![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image012.png) 

6.	Wykres wyświetlany jest po wciśnięciu przycisku PLOT. Osie X oraz Y są skalowane automatycznie. Legenda generowana jest w sposób automatyczny.
 
![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image013.png) 

Nadpisanie wartości danej zmiennej odbywa się za pomocą przycisku WRITE VALUES. W tym celu należy wpisać w odpowiedniej komórce wartość, zaznaczyć wiersz, wcisnąć przycisk WRITE VALUES.
Zatrzymanie odczytu ciągłego oraz zapisu do pliku polega na wciśnięciu przycisku STOP CONT.

![header_image](https://github.com/CERTBUD/Data-logger/blob/master/Help_pliki/image014.png) 