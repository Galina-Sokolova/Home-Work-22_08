//программа выводит третью цифру случайно сгенерированного числа или сообщает, что третьей цифры нет
int start = 1;
int stop = 1000000;

int value = new Random().Next(start, stop+1);
Console.WriteLine(value);
int count = 0;
int disch = value;
//подсчет количества цифр в числе
while (disch > 0)
{
    count++;
    disch = disch / 10;
}
Console.WriteLine("количество цифр в числе: "+count);
int n = count - 3;
if (count < 3)
{
    Console.WriteLine("У данного числа третьей цифры нет");
}
else
{
    int degree = Convert.ToInt32(Math.Pow(10,n));
    int first_thee_digites = value / degree;
    int digit_third = first_thee_digites % 10;
    Console.WriteLine("Третья цифра данного числа: "+digit_third);
}
