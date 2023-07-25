string[] array;
Console.WriteLine("Введите массив через запятую: ");
string str = Console.ReadLine()!;
array = str.Split(',');
var n = new string [array.Length];
int i = 0;
foreach (var value in array)
    {
    if (value.Length <= 3)
        {
            result[size] = value;
            size++;
        }
    }