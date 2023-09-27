string? word = string.Empty;

// interacting
while (word == null || word.Length == 0)
{
    Console.Write("Please enter a word");
    Console.WriteLine();
    word = Console.ReadLine();
    
}

string CurrentGuess = string.Empty;

//Defines amount of letters
while (CurrentGuess.Length < word.Length)
{
    CurrentGuess += "_"; // CurrentGuess = CurrentGuess + "_"
}

bool won = false;
int lives = 5;
// HP
while (!won && lives > 0)
{
    Console.Clear();
    Console.WriteLine(CurrentGuess);
    Console.WriteLine("Guesses Left: " + lives);


    string? input = string.Empty;
    // Start of game
    while (input == null || (input.Length != 1 && input.Length != word?.Length))
    {
        Console.Write("Please guess a letter or the whole word");
        Console.WriteLine();
        input = Console.ReadLine();
        Console.WriteLine();
    }

    bool foundCorrect = false;
    // Guessing Word or Letter
    if (word == input)
    {
        won = true;
    }
    else if (input?.Length == 1)
    {
        for (int i = 0; i < word?.Length; i++)
        {
            if (word[i].ToString() == input) // (Input.Equals(word[i]))
            {
                foundCorrect = true;
                CurrentGuess = CurrentGuess.Remove(i, 1).Insert(i, input);
            }
        }
    }


    if (!foundCorrect && !won)
    {
        lives--;
    }
    if (CurrentGuess == word)
    {
        won = true;
    }
}

// End of game
Console.Clear();
if (won)
{
    Console.WriteLine("You won with " + lives + " lives left");
}
else
{
    Console.WriteLine("You lose, the word was " + word);
}