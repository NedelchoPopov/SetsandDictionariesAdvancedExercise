/*
4
Ce O
Mo O Ce
Ee
Mo

3
Ge Ch O Ne
Nb Mo Tc
O Ne

 */

int rows = int.Parse(Console.ReadLine());

SortedSet<string> elements = new SortedSet<string>();

for (int row = 0; row < rows; row++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    foreach (string element in input)
    {
        elements.Add(element);
    }
}

Console.WriteLine(string.Join(" ", elements));