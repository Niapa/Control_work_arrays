string[] array;
Console.WriteLine("Введите массив данных через запятую: ");
string str = Console.ReadLine()!;
array = str.Split(',');
var n = new string [array.Length];
int i = 0;
for (int i = 0; i<array.Length)