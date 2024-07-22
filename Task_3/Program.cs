// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void Main()
{
    int[] arras = [1, 2, 5, 0, 10, 34];
    on_the_contrary(arras);
}
void on_the_contrary(int[] array,int count = 0)
{
    if(count > array.Length - 1) return;
    on_the_contrary(array,count + 1);
    System.Console.Write(array[count] + " ");
}

Main();