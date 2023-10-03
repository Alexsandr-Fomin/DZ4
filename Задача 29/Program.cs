// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void FillArray(int[] array) //заполняет массив случайными числами и выводим
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10000);
        //Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
    // for (int i = 0; i < array.Length; i++)
    // {
    //     Console.Write(array[i]);
    // }
}
int[] array = new int[8];
FillArray(array);
Console.WriteLine(string.Join(", ", array));
