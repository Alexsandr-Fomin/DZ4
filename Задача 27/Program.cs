// Задача 27: Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число больше нуля");
int num = int.Parse(Console.ReadLine());
if (num<=0)
{
    Console.WriteLine("Вы ввели неверно число");
}
else
{
    // int result = num%10;
    // num = num/10;
    // int summ = result;
    // Console.WriteLine(num);
    // Console.WriteLine(summ);
    int summ = 0;
    while(num>0)
    {
        int result = num%10;
        num = num/10;
        summ = summ + result;
    }
    Console.WriteLine(summ);

}
