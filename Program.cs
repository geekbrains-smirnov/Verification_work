




Console.Write("Введите массив через пробел состоящий из строк: ");
string array = Console.ReadLine();
string[] arr = array.Split();
foreach(string word in arr)
{
    if(word.Length<=3) Console.WriteLine(word);
    else Console.WriteLine("Длина строк больше 3 символов");
}
