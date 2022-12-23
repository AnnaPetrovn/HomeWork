/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

void MaxNumOfThree (int num1, int num2, int num3) {
    int index = 0;
    int [] num = {num1,num2,num3};
    int max = num[index];
    do
    {
        if (num[index]>max)
        max=num[index];
        index++;
    }
    while (index != 3);
    Console.WriteLine("максимальное число " + max);

}

int num1=1;
int num2=6;
int num3=7;
MaxNumOfThree(num1,num2,num3);