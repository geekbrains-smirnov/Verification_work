
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

void StringsNew(string[] strs, string[]str)
{
    int count = 0;
    for(int i = 0; i<strs.Length; i++)
    {
        if(strs[i].Length<=3)
        {
            str[count] = strs[i];
            count++;
        }
        
    }
}
AmountStrings(strs);
StringsNew(strs,str);
Console.WriteLine();
Console.WriteLine("Массив из строк с символами меньше или равное 3: ");
PrintStrings(str);



