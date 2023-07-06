// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter number_1: " );
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Enter number_2: " );
int number_2 = int.Parse(Console.ReadLine());
Console.Write("Enter number_3: " );
int number_3 = int.Parse(Console.ReadLine());
int max = 0;

if(number_1 > number_2) 
{ 
    max = number_1;
}
else
{
    max = number_2;
}
if(number_2 > number_3)
{
    max = number_2;
}
else
{
    max = number_3;
}
if(number_3 > number_1) 
{
    max = number_3;
}
else
{
    max = number_1;
}   
Console.WriteLine($"Maximum number {max}");
