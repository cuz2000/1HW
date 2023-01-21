// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


  


Console.WriteLine (" Введите 3 числа");

int num1 = Convert.ToInt32 ( Console.ReadLine());
int num2 = Convert.ToInt32 ( Console.ReadLine());
int num3 = Convert.ToInt32 ( Console.ReadLine());

  int result = num1;
    if (num2 > result) result = num2;
    if (num3 > result) result = num3;

Console.WriteLine ("Максимальное число из трех: " + result);
