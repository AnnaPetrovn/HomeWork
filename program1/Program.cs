/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7;
a = 2 b = 10 -> max = 10;
a = -9 b = -3 -> max = -3*/

void  MaxMinNumber(Double number1, Double number2) 
{
if ( number1 > number2) 
Console.WriteLine(number1 +" большее число, " + number2 + "меньшее число");
else

 if (number1 < number2)
 Console.WriteLine( number1 + " меньшее число," + number2 + " большее число");

 else 
 if (number1 == number2)   
 Console.WriteLine( "числа" + number1 + "и" + number2 + "равны");
} 
Double num1 = 55.7;
Double num2 = 55.6;
MaxMinNumber(num2,num1);