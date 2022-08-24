// программа принимает на вход случайно сгенерированное трёхзначное число и показывает вторую цифру этого числа
int start = 100;
int stop = 1000;

int value = new Random().Next(start, stop);
Console.WriteLine(value);

int digit_two = value%100;
int digit_second = digit_two/10;
Console.Write("Вторая цифра случайного числа: "+digit_second);
