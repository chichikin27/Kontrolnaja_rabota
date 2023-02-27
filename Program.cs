
Console.Write("Введитие колиество элементов: ");
int size = int.Parse(Console.ReadLine()!);
string[] array = new string[size];
int count = size;
Console.WriteLine("===========================================");
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i] = Console.ReadLine();
}
Console.WriteLine("===========================================");
Console.WriteLine("Вы ввели следующие элементы: ");
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
Console.WriteLine("===========================================");
Console.WriteLine("Элементы содержащие три и меньше символов: ");
for(int i = 0; i < array.Length; i++)

{
    if(array[i].Length <= 3)
    {
        Console.WriteLine(array[i]);
        count = count - 1;
    }
    else if(count == size)
    {
        Console.WriteLine("Таких элементов нету");
        break;
    }

}
