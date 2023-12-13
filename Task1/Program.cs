//Задача 1: Задайте значения M и N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.



void printNumbersBetweenMAndN(int m, int n)
{
    if(m <= n)
    {
        Console.Write ($"{m + " "}");
        printNumbersBetweenMAndN(m + 1, n);}
    return;
    
}

Console.WriteLine("Введите натуральное число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число побольше: ");
int n = int.Parse(Console.ReadLine()!);
printNumbersBetweenMAndN (m, n);