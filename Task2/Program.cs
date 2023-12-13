// Задача 2: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
//А(0,n)= n+1;
//A(m,0)= A(m-1,1);
//A(m,n)= A(m-1, A(m,(n-1)));
// поставила пределы небольшие, поскольку даже с ними пишет, что "stack overflow". 
//не рискнула запросить с консоли, проверить невозможно)


int АckFunction (int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(n == 0)
    {
        return АckFunction(m - 1, 1);
    }
    
        return АckFunction(m - 1, АckFunction(m, (n - 1)));
}

int m = new Random().Next(1, 6); 
Console.WriteLine(m);
int n = new Random().Next(1, 6);
Console.WriteLine(n);
Console.WriteLine(АckFunction(m, n));