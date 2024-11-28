//[x] Lag et enkelt kommandobasert program med følgende meny: 
// 
//[x] 1. RotateText
// 
//[x] 2. Change word
// 
//[x] Etter brukeren har valgt 1 eller to skal de promptes for å skrive inn et ord. Ordet skal ta enten snus eller endres med følgende funksjoner
// 
//[x] 1 -> En funksjon som tar en tekst som parameter og som returnerer teksten snudd i motsatt rekkefølge. For eksempel skal 'Terje' bli til 'ejreT.
// 
//[x] 2 -> En funksjon som bytter ut alle 'e' med 'a' i tekst du sender inn

var userInput = "";
string reversedText = "";



Console.WriteLine("Welcome! What would you like to do today?\n");
Console.WriteLine("[1] Rotate Text\n[2] Change Word");
var userChoice = Console.ReadLine();
Menu();

void Menu()
{
    switch (userChoice)
    {
        case "1":
            Console.WriteLine("Great! Write what you want reversed:");
            userInput = Console.ReadLine();
            ReverseText(userInput);
            Console.WriteLine($"\nYour reversed text is:\n{reversedText}");
            break;
        case "2":
            Console.WriteLine("Great! Give me a prompt and i will change it for you");
            userInput = Console.ReadLine();
            Console.WriteLine($"Your new phrase is:\n{ChangeWord(userInput.ToCharArray())}");
            break;
        default:
            Console.WriteLine("Sorry, that wasn't one of the choices");
            Menu();
            break;
    }
}

string ReverseText(string userInput)
{

    foreach (var letter in userInput)
    {
        reversedText = letter + reversedText;
    }
    return reversedText;
}



string ChangeWord(char[] changeWord)
{
    for (int i = 0;i < changeWord.Length; i++)
    {
        if (changeWord[i] == 'e')
        {
            changeWord[i] = 'a';
        }
    }

    return new string(changeWord);
}