//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int n,int r )
{
    Console.Write(r+" ");
    if(r>=n)
    return; 
    r++;
    ShowNums(n,r);
}


Console.WriteLine("Введите N");
int n=Convert.ToInt32(Console.ReadLine());
ShowNums(n,1);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
void SumNums(int n,int m,int r)
{
    if(n>=m)
    {
        Console.WriteLine(r);
        return;
    }
    r+=n; 
    n++;
    SumNums(n,m,r);
}

Console.WriteLine("Введите N");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M");
int m=Convert.ToInt32(Console.ReadLine());
SumNums(n,m,0);
*/
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

Console.WriteLine("Введите M");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n=Convert.ToInt32(Console.ReadLine());
int ak=Akkerman(m,n);
Console.Write(ak);