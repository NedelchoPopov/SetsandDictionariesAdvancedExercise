/*
SoftUni rocks

Did you know Math.Round rounds to the nearest even integer?

 */

SortedDictionary<char, int> symbols = new();

string text = Console.ReadLine();

for (int c = 0; c < text.Length; c++)
{
    char symbol = text[c];

    if (!symbols.ContainsKey(symbol))
    {
        symbols.Add(symbol, 0);
    }
    symbols[symbol]++;
}

foreach ((char symbol, int count) in symbols)
{
    Console.WriteLine($"{symbol}: {count} time/s");
}