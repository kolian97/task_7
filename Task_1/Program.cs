// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
void Main()
{
    int M = Read_int("Введите Значение M: ");
    int N = Read_int("Введите Значение N: ");
    Prom(M,N);
}
int Read_int(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
void Prom(int a, int b)
{
    if(b < a) return; // здесь ретурн нужен для проверки отрицательных элементов
    if(b == a)
    {
        System.Console.Write(a); //убираем запятую
    return;
    }
        System.Console.Write(a + ", ");
    Prom(a + 1,b);
}
Main();
