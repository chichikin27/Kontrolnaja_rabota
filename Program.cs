

Console.Write("Введитие колиество элементов: ");
int size = int.Parse(Console.ReadLine()!);
string[] array = new string[size];

for(int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i] = Console.ReadLine();
}