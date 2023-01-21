// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine ("Введите число для проверки на четность");
int num = Convert.ToInt32 ( Console.ReadLine());
int result = num % 2;
    if ( result == 0)
        Console.WriteLine ( "Число " + num +" является чётным");

 else
      Console.WriteLine ( "Число "+ num + " является нечётным");