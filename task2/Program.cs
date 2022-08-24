//программа выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет
int start = 1;
int stop = 65536;

int value = new Random().Next(start, stop+1);
Console.WriteLine(value);

if (value < 100)
{
  Console.WriteLine("У данного числа третьей цифры нет");  
}
else
{
    if (value < 1000)
    {
        int digit_third = value % 10;
        Console.WriteLine("Третья цифра данного числа: "+digit_third);
    }
    else
    {
        if (value < 10000)
        {
            int digit_two = value % 100;
            int digit_third = digit_two/10;
            Console.WriteLine("Третья цифра данного числа: "+digit_third);
        }
        else
        {
            int digit_three = value % 1000;
            int digit_third = digit_three/100;
            Console.WriteLine("Третья цифра данного числа: "+digit_third);
        }
    }
}

