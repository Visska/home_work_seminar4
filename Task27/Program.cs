/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

int GetSumDigit(int number)
{
    int sum = 0;
    while(number > 0)
    {
        int digit = number % 10;
        sum += digit;
        number = number / 10;

    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumDigit = GetSumDigit(userNumber);
Console.WriteLine($"Сумма цифр в числе {userNumber} равна {sumDigit}");