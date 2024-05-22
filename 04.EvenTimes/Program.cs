/*
3
2
-1
2

5
1
2
3
1
5

 */

int rows = int.Parse(Console.ReadLine());

Dictionary<int, int> numbers = new Dictionary<int, int>();

for (int row = 0; row < rows; row++)
{
    int number = int.Parse(Console.ReadLine());

    if (!numbers.ContainsKey(number))
    {
        numbers.Add(number, 1);
        continue;
    }
    numbers[number]++;
}

foreach ((int key, int value) in numbers)
{
    if (value % 2 == 0)
    {
        Console.WriteLine(key);
        return;
    }
}