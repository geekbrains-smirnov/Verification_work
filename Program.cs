
Console.Write("Введите количество строк, которые хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine()); 
string[] strs = new string[n];
string[] str = new string[n];
void AmountStrings(string[]strs)
{
for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку: ");
        strs[i] = Console.ReadLine();
    }
}

void PrintStrings(string[] strs)
{
    
    for (int i = 0; i < n; i++)
        {
            Console.Write($"{strs[i]} ");
        }
        Console.WriteLine();
}        




