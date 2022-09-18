Console.Clear();
string[] str = new string[3];
int count = 0;
int j = 0;
for (int i = 0; i < str.Length; i++)
{
    str[i] = Console.ReadLine();
    if (str[i].Length <= 3)
        count ++;
}
string[] resstr = new string[count];
for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length <= 3 )
    {
        resstr[j] = str[i];
        j++;
    }
}
foreach (var el in resstr)
    Console.WriteLine(el);