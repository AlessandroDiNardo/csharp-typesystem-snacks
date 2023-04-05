// See https://aka.ms/new-console-template for more information

/*
//1. L’utente inserisce due numeri in successione. Il software stampa il maggiore.
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



//  3. Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.
int[] num = new int[10]; //dichiaro un array con 10 elemnti di tipo int all'interno
int sum = 0; //inizializzo variabile somma a 0
Console.WriteLine("Inserisci 10 numeri: ");

for (var i=0; i < 10; i++) //ciclo for per far inserire all'uitente 10 numeri
{
    int newNum = Convert.ToInt32(Console.ReadLine()); //l'utente inserisce 10 numeri
    num[i] = newNum; // ogni numero inserito viene pushato all'interno dell'array
}
 
for (var i=0; i < num.Length; i++) //ciclo per far stampare il risultato sommando i numeri all'interno dell'array
{
    sum += num[i]; //somma dei numeriù
}

var res = sum; //la somma viene salvata in questa variabile res per il risultato
Console.WriteLine($"La somma è: {res}"); //stampa del risultato
*/



//Calcola la somma e la media dei numeri da 2 a 10.
int sum = 0;
double avarage;

for (var i = 2; i <= 10; i++)
{
    sum += i;
}

avarage = sum / 9;

Console.WriteLine($"la somma è: {sum}");
Console.WriteLine($"la media è: {avarage}");