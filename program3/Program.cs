/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два 
без остатка).

4 -> да
-3 -> нет
7 -> нет*/
void DividedIntoTwo()
{   Console.WriteLine("Введите число");
    string nu = Console.ReadLine();
    int number = Convert.ToInt32(nu);//функция для перевода строки в целое число//
    if (number%2==0) 
    {
        Console.WriteLine($"{number} делится на 2 без остатка");
    }
    else 
    {
        Console.WriteLine($"{number} не делится на 2 без остатка");
    }    
}
DividedIntoTwo();