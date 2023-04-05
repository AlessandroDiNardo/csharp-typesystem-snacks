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
    Console.WriteLine(firstWord + " " + secondWord);
}
else if(firstWord.Length < secondWord.Length)
{
    Console.WriteLine(firstWord + " " + secondWord);
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



//4. Calcola la somma e la media dei numeri da 2 a 10.
int sum = 0; //dichiaro variabile somma con valore 0
double avarage; // dichiaro variabile per la media

for (var i = 2; i <= 10; i++) //ciclo per calcolare somma dei numeri da 2 a 10
{
    sum += i; // somma dei numeri
}

var res = sum; //la somma viene salvata in questa variabile res per il risultato
avarage = sum / 9; //calcolo della media

Console.WriteLine($"la somma è: {res}"); //stampa risultato somma 
Console.WriteLine($"la media è: {avarage}"); //stampa media



//5. Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
Console.WriteLine("Inserisci un numero: ");// Viene chiesto all'utente di inserire un numero
int num = Convert.ToInt32(Console.ReadLine()); //l'utente inserisce un numero

if(num % 2 == 0) //conmdizione per verificare se il numero è pari o dispari
{
    Console.WriteLine($"Il numero che hai inserito è pari: {num}"); //se il numero è pari viene inserito a schermo
}
else
    Console.WriteLine($"Il numero che hai inserito è dispari quindi vieni stampato il numero successivo: {num + 1}");  // se il numero è dispari viene stampato il numero successivo



//6. In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
string[] people = { "Luca", "Marco", "Luigi", "Francesco", "Alessandro", "Antonio", "Angela", "Luisa", "Maria", "Miriam" }; //inizializzo un array con degli elemtni all'interno
Console.WriteLine("Inserisci il tuo nome: ");// Viene chiesto all'utente di inserire il suo nome 
string newPeople = Console.ReadLine();//L'utente inserisce il suo nome

if (people.Contains(newPeople)) //Condizione per controllare se il nome dell'utente fa parte della lista
{
    Console.WriteLine("Puoi entrare"); //Se è nella lista può entrare
}
else
    Console.WriteLine("Non puoi entrare");



//7. Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
int[] num = new int[6]; //dichiaro un array di grandezza 6
int newNum; //dichiaro variabile per il numero inserito dall'utente

Console.WriteLine("Inserisci 6 numeri: ");

for (int i = 0; i < 6; i++) // ciclo for per inserire 6 volte un numero dall'utente, questo viene controllato e se è diospari inserito all'itenro dell'array
{
    newNum = Convert.ToInt32(Console.ReadLine());
    if (newNum % 2 == 1) // controllo del numero se è dispari
    {
        num[i] = newNum; // se numero dispari viene inserito nell'array
    }
}

Console.WriteLine("Numeri dispari inseriti:"); 
foreach (int oddNum in num) // ciclo per stampare i numeri dispari
{
    Console.WriteLine(oddNum);
}



//8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
int[] num =  { 3, 2, 3, 7, 4, 5, 8, 1, 2}; //Creo un array con 9 numeri all'interno
int sum = 0; // dichiaro variabile somma con valore 0

for (int i = 0; i < num.Length; i += 2) //ciclo for per fare la somma dei numeri all'interno in posizione dispari
{
    sum += num[i];
}

Console.WriteLine("I numeri sonno:");

foreach (int i in num) // ciclo per stampare l'array di numeri
{
    Console.WriteLine(i);
}   

Console.WriteLine($"La somma dei numeri in posizione dispari è: {sum}");  // stampa della somma dei numeri in posizione dispari



//9. Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
int[] num = Array.Empty<int>(); //Creo array vuoto
int sum = 0; // dichiaro variabile somma con valore 0

do //ciclo do, l'utente inseirisce un numero finchè la somma è 50
{
Console.WriteLine("Inserisci un numero: ");
int newNum = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref num, num.Length + 1); //numero viene inserito nell'array
num[num.Length - 1] = newNum;

sum += newNum; // somma dei numeri inseriti

} while (sum < 50);
{
    if (sum > 50) // se la somma è maggiore di 50 epaare un messaggio di ritentare altrimenti esce la somma di 50 dei numeri inseriti
    {
        Console.WriteLine($"Mi spiace la somma è: {sum}, ritenta");
    }else
         Console.WriteLine($"La somma è: {sum}");
}

Console.WriteLine("Hai inserito i seguenti numeri");
foreach(var newNUm in num) // ciclo per mostrare i numeri inseriti
{
    Console.WriteLine(newNUm);
}
*/



//10. Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.
Console.Write("Inserisci un numero: "); //L'utente inserisce un numero
int num = Convert.ToInt32(Console.ReadLine());

Random rand = new Random(); // funzioen per generare un numero random
for (int i = 0; i < num; i++) //ciclo per creare N array in base al numero inserito dall'utente
{
    int[] array = new int[10]; //creo array di 10 elementi
    for (int j = 0; j < 10; j++) // vengono aggiunti 10 numeri da 1 a 100 casuali
    {
        array[j] = rand.Next(1, 100);
    }
    Console.WriteLine("Array #" + (i + 1) + ": " + string.Join(", ", array)); //vengono stampati gli N array con i 10 elementi casuali
}
