// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter number: " );
int number = int.Parse(Console.ReadLine());
int res = 2;
for( res = 2; res <= number; res +=2 )
if( res % 2 == 0 )
Console.Write($"{res} ");
