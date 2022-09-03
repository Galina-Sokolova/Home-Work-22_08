Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int N = 12;
int [] arr = new int[N];
Random rnd = new Random();
Console.Write("Массив: ");
for (int i = 0; i < N; i++)
{
  arr[i] = rnd.Next(-9, 10);
  Console.Write(arr[i]+" ");
}
void finding(int num)
{
  int count = 0;
  for (int i = 0; i < N; i++)
  {
    if (num == arr[i])
    {
      count++;
    }
  }
  if (count == 0)
  {
    Console.WriteLine($"В данном массиве нет числа {num}");
  }
  else
  {
    Console.WriteLine($"Число {num} встречается в массиве {count} раз");
  } 
}
Console.WriteLine("");
finding(num); 