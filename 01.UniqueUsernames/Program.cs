/*
6
John
John
John
Peter
John
Boy1234

10
Peter
Maria
Peter
George
Sam
Maria
Sara
Peter
Sam
George

 */


int rows = int.Parse(Console.ReadLine());

HashSet<string> names = new HashSet<string>();

for (int row = 0; row < rows; row++)
{
    string name = Console.ReadLine();

    names.Add(name);
}

Console.WriteLine(string.Join(Environment.NewLine, names));
