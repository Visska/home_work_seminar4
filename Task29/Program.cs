/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/

void FillArrayNumber(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void printArray(int[] array)
{
    Console.Write("[");
    for (var i =0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if(i < array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
Console.Clear();
int[] arrayRandomNumber = new int[8];
FillArrayNumber(arrayRandomNumber);
printArray(arrayRandomNumber);