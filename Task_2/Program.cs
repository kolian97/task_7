// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// m = 2, n = 3 -> A(m,n) = 29

//A(m,n) а не A(n,m)!!
void Main()
{
    int m = Read_int("Введите Значение m: ");
    int n = Read_int("Введите Значение n: ");
    System.Console.WriteLine(A(m,n));
}
int Read_int(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int A(int m, int n)
{
    if(m ==0)
    return n + 1;
    else if(n==0)
    return A(m-1,1);
    else
    return A(m - 1,A(m,n-1));
}
Main();
