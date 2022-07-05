/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/
int PowNumber(int number, int grade)
{
    int result = 1;
    for (int i = 0; i < grade; i++)
    {
        result *= number;
    }
    return result;
}
Console.Clear();
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int meanNumA = PowNumber(numberA, numberB);
Console.WriteLine($"Значение числа А = {numberA} в натуральной степени B = {numberB} равно = {meanNumA}.");