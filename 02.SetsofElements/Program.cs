/*
4 3
1
3
5
7
3
4
5

2 2
1
3
1
5

 */

int[] lenght = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int n = lenght[0];
int m = lenght[1];

HashSet<int> setN = new HashSet<int>();
HashSet<int> setM = new HashSet<int>();

for (int i = 0; i < n; i++)
{
    setN.Add(int.Parse(Console.ReadLine()));
}
for (int i = 0;i < m; i++)
{
    setM.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine(string.Join(" ", setN.Intersect(setM)));

