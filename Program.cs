



// Console.Write("Введите размер массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// string[] str = new string[m];
// for(int i = 0; i<m; i++)
// {
//     Console.Write("Введите строку: ", i+1);
//     str[m] = Console.ReadLine();
// }
// Console.WriteLine("Вы ввели следующие строки:");
//             for (int i = 0; i < m; i++)
//             {
//                 Console.WriteLine(str[i]);
//             }
//             Console.Write("Нажмите [Enter] для выхода...");
//             Console.ReadLine();
// Console.Write("Введите массив через пробел состоящий из строк: ");
// str[m] = Console.ReadLine();
// // foreach(string word in arr)
// // {
// //     if(word.Length<=3) Console.WriteLine(word);
// //     else Console.WriteLine("Длина строк больше 3 символов");
// // }
// Console.WriteLine(str);


Console.Write("Введите количество строк, которые хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine()); 
string[] strs = new string[n]; 
void PrintStrings(string[] strs)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку: ");
        strs[i] = Console.ReadLine();
    }
    Console.WriteLine("Массив из строк: ");
    for (int i = 0; i < n; i++)
        {
            Console.Write($"{strs[i]} ");
        }
}        
PrintStrings(strs);

