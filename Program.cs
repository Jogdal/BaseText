using stringManipulation;
using System.Console;

string text = BaseText.GetBaseText();

// Split into words
string[] completeWords = text.Split(' ');  
foreach(string word in completeWords)
{
    Console.WriteLine(word);
}


// Discard words of no interest
List<string> chosenWords = new ();

bool satisfied = false;
while (!satisfied)
{
    foreach (string word in completeWords)
    {
        Clear();
        Console.WriteLine($"Discard {word}? Hit 'y' - Keep with all other");
        char keyDiscard = ReadKey().KeyChar;
        if (keyDiscard != 'y')
        {
            chosenWords.Add(word);
        }
    }
    Clear();
    foreach (string word in completeWords)
    {
        Console.WriteLine(word);
    }
    Console.WriteLine("Are you satisfied with the selection? ( y / n )");
    char keySatisfied = ReadKey().KeyChar;
    if (keySatisfied != 'y')
    {
        satisfied = true;
    }
}

// Add Words to dictionary
Dictionary<string, string> glossary = new Dictionary<string, string>();

foreach (string word in chosenWords)
{
    Console.WriteLine("Enter a swedish word for {}");
    string? translation = Console.ReadLine();
    if (translation != null)
    {
        glossary.Add($"{word}", $"{translation}");
    } else
    {
        glossary.Add($"{word}", $"_");
    }
}



//  Begin adding translations

