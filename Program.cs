

Console.Write("Введитие колиество элементов: ");
int size = int.Parse(Console.ReadLine()!);
string[] array = new string[size];

for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i] = Console.ReadLine();
}
Console.WriteLine("Вы ввели следующие строки: ");
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
