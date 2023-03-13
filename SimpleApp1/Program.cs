//zadeklaruje sobie zmienną "a"
int a;

//inicjuję zmiennną "a"
a = 5;

//deklaracja z inicjalizacją
int b = 6;

//zapisz sumę a i b do zmiennej suma
int suma = a + b;

//wypisz na ekranie
//Console.WriteLine("Suma wyrazów a i b wynosi: " + suma.ToString());

//Pobierz liczbę a od użytkownika
Console.WriteLine("Podaj proszę liczbę a: ");
//zapisz do zmiennej odpowiedz (deklaracja bo nie mieliśmy jej wcześniej)
string odpowiedz = Console.ReadLine();
//skonwertuj łańcuch tekstowy na liczbę
a = int.Parse(odpowiedz);
//osbierz od użytkownika liczbę b
Console.WriteLine("Podaj proszę liczbę b: ");
//zapisujemy do stringa ale bez deklaracji bo zmiena juz instnieje
odpowiedz = Console.ReadLine();
//konwertujemy na liczbę
b = int.Parse(odpowiedz);   

//sumujemy wartość zmiennych
suma = a + b;
//wypisujemy na ekranie odpowiedź
Console.WriteLine("Suma wyrazów a i b wynosi: " + suma.ToString());