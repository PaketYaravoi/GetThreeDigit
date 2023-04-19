/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.Clear();

Console.WriteLine("Программа для поиска третьей цифры из случайного, целого числа, на отрезке от 1 до 2000000000");
Console.Write("Нажмите клавишу Enter для генирации случайного числа");
Console.ReadLine();

int RandomDigit(int arg1, int arg2)
{
    int number = new Random().Next(arg1, arg2);
    return number;
}

int random = RandomDigit(1, 2000000000);
Console.WriteLine($"Случайное число -  {random}");
Console.WriteLine("Нажмите клавишу Enter для поиска нужной цифры");
Console.ReadLine();

if(random < 100)
{
    Console.WriteLine("Число не является трехзначным, пожалуйста перезапустите программу");
   
}
else
{
    int DellDigit (int rightEdge)
{
    rightEdge = random;
    while(rightEdge > 999)
    {
        rightEdge = rightEdge / 10;
    }
    return rightEdge;
}
int finish = DellDigit(random);
if(finish > 9)
{
    finish = finish % 10;
}
Console.WriteLine($"Искомое число - {finish}");
}




/*while (random >= 100, | <= 99)
{
    Console.WriteLine(random);
    random = random / 10;
   Console.WriteLine("Данное число не трехзначное");
}
*/



