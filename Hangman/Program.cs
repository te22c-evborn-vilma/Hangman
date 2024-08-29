/*
- Ett ord väljs


Skriva ut så många _ som det finns i ordet

Ta in en gissning
Byt ut _ mot bokstaven där den finns i ordet
Om bokstaven inte finns, rita en till del av gubben

Om alla _ har blivit bokstäver: #winning
Om hela gubben är utritad: #losing

1. förlora - gissat fel för många gånger
2. byta ut streck till bokstäver
3. vinna
*/ 
// foreach (string letter in hiddenWord)
// {
//     Console.Write(letter);
// }

static string[] MakeUnderscores(string word)
{
    string[] underscores = new string[word.Length];

    for (int i = 0; i < underscores.Length; i++)
    {
        underscores[i] = "_";
    }

    return underscores;
}

string word = "watermelon";
List<string> wrongGuesses = new();

string[] hiddenWord = MakeUnderscores(word);

Console.WriteLine("Välkommen till hangman!");
int lives = 5;

while(wrongGuesses.Count < lives && string.Join("", hiddenWord) != word)
{
    Console.WriteLine(string.Join(" ", hiddenWord));
    Console.WriteLine("\nGissa en bokstav!");
    string guess = Console.ReadLine();

    if (word.Contains(guess[0]))
    {
        Console.WriteLine("yay");

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == guess[0])
            {
                hiddenWord[i] = guess[0].ToString();
            }
        }
        // int pos = word.IndexOf(guess[0]);
        // hiddenWord[pos] = guess;
    }
    else 
    {
        Console.WriteLine("boo");
        wrongGuesses.Add(guess);
    }
}

Console.WriteLine("Spelet är över!");
Console.ReadLine();

//string.Join funkar bara när man sätter ihop eller skriver ut i en string list eller string array