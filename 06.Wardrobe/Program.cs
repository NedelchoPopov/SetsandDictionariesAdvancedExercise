/*
4
Blue -> dress,jeans,hat
Gold -> dress,t-shirt,boxers
White -> briefs,tanktop
Blue -> gloves
Blue dress

4
Red -> hat
Red -> dress,t-shirt,boxers
White -> briefs,tanktop
Blue -> gloves
White tanktop

5
Blue -> shoes
Blue -> shoes,shoes,shoes
Blue -> shoes,shoes
Blue -> shoes
Blue -> shoes,shoes
Red tanktop

 */

using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());

        Dictionary<string, Dictionary<string, int>> wardrobe = new();

        for (int row = 0; row < rows; row++)
        {
            string[] input = Console.ReadLine()
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

            string color = input[0];
            string[] clothes = input[1]
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (!wardrobe.ContainsKey(color))
            {
                wardrobe.Add(color, new());
            }
            for (int i = 0; i < clothes.Length; i++)
            {
                if (!wardrobe[color].ContainsKey(clothes[i]))
                {
                    wardrobe[color].Add(clothes[i], 0);
                }
                wardrobe[color][clothes[i]]++;
            }

        }

        string[] findClouth = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string findColor = findClouth[0];
        string clouth = findClouth[1];

        foreach ((string color, Dictionary<string, int> clothes) in wardrobe)
        {
            Console.WriteLine($"{color} clothes:");

            foreach (var item in clothes)
            {
                if (color == findColor && item.Key == clouth)
                {
                    Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    continue;
                }
                Console.WriteLine($"* {item.Key} - {item.Value}");
            }
            
        }
    }
}