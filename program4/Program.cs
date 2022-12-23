/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */
void MultipleOfTwo()
{   
    Console.WriteLine("Введите количество целых значений массива");
    String nu = Console.ReadLine();
    int N = Convert.ToInt32(nu);
    int index = 0;
    int number = 1; 
    
    while(index < (N-1))
    {
        number++;
        index++;
        if(number%2==0)
        {
        Console.WriteLine($"четные числа массива {number}");
        }
    }
}
MultipleOfTwo();