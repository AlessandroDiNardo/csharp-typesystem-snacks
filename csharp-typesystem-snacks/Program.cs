// See https://aka.ms/new-console-template for more information

/*1. L’utente inserisce due numeri in successione. Il software stampa il maggiore.
Console.WriteLine("L’utente inserisce due numeri in successione. Il software stampa il maggiore.");

//L'utente inserisce il primo numero
Console.WriteLine("Inserisci il primo numero: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

//L'utente inserisce il secondo numero
Console.WriteLine("Inserisci il secondo numero: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

//Controllo dei numeri
if(firstNum > secondNum)
{
    Console.WriteLine($"Il numero più grande è il: {firstNum}"); //controlla se il primo è maggiore del secondo e stampa il primo in caso fosse vero
}
else if(secondNum > firstNum)
{
    Console.WriteLine($"Il numero più grande è il: {secondNum}"); // controlla se il secondo è maggiore del primo e stampa il seconda se fosse vero
}
else if (firstNum == secondNum)
{
   Console.WriteLine("I numeri sono uguali."); // controlla se i numeri sono uguali e stampa un messaggio 
}
*/

// 2. L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
Console.WriteLine("L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.");
Console.WriteLine("");

//L'utente inserisce la prima parola
Console.WriteLine("Inserisci la prima parola: ");
string firstWord = Console.ReadLine();

//L'utente inserisce la seconda parola
Console.WriteLine("Inserisci la seconda parola: ");
string secondWord = Console.ReadLine();
Console.WriteLine("");

if (
    firstWord.Length > secondWord.Length)
{
    Console.WriteLine(secondWord);
}
else if(firstWord.Length < secondWord.Length)
{
    Console.WriteLine(firstWord);
}
else if(firstWord.Length == secondWord.Length)
{
    Console.WriteLine("Le parole hanno la stessa lunghezza");
}

