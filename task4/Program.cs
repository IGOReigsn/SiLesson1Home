// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int num1=22,num2=3,num3=9;
int max=num1;
if (max<num2)
    {max=num2;}
if (max<num3)
    {max=num3;}
Console.WriteLine("Max="+ max);
