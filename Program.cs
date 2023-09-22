//DICTIONARY
using System.ComponentModel.Design;

string name = string.Empty;
string[] animalName = File.ReadAllLines("../../../data.txt");
int temp = 0;
Dictionary<string, int> dictionary = new Dictionary<string, int>();

foreach (string animal in animalName)
{
    string[] split = animal.Split(",");

    if (int.TryParse(split[1], out temp))

        dictionary.Add(split[0], temp);
    name += split[0] + ", ";
}

Console.WriteLine("Vänligen skriv in ett namn för att ta reda på födelseår.");
Console.WriteLine("Dessa namn finns att välja på: " + name);
Console.WriteLine();

string? input = Console.ReadLine().ToLower();
bool sant = true;

while (sant)
{
    if (dictionary.ContainsKey(input))
    {
        Console.Clear();
        Console.WriteLine("Namnet du skrev var: " + input);
        Console.WriteLine();
        Console.Write(input + " är född år: ");
        Console.WriteLine(2023 - dictionary[input]);
        sant = false;
    }

    else
    {
        Console.Clear();
        Console.WriteLine("Du skrev in ett felaktigt namn, vänligen försök igen.");
        Console.WriteLine();
        Console.WriteLine("Dessa namn finns att välja på: " + name);
        Console.WriteLine();
        input = Console.ReadLine().ToLower();
    }
}


