// программа принимает на вход случайно сгенерированное число (от 1 до 1 000 000) и проверяет, кратно ли оно одновременно 7 и 23
int start = 1;
int stop = 1000000;

int value = new Random().Next(start, stop+1);
Console.WriteLine(value);

int a = 7;
int b = 23;
int product = a * b;
int rem = value % product;
if (rem == 0)
{
    Console.WriteLine("число "+value+" кратно одновременно и "+a+" и "+b);
}
else
{
    Console.WriteLine("число "+value+" не является одновременно кратным чисел "+a+", "+b);
}
