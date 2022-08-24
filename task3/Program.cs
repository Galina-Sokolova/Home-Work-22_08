// программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Write("Введите номер дня недели, чтобы узнать, является ли этот день выходным: ");
int input = Convert.ToInt32(Console.ReadLine());
switch (input)
{
    case 1:
    Console.Write("понедельник - рабочий день");
    break;
    case 2:
    Console.Write("вторник - рабочий день");
    break;
    case 3:
    Console.Write("среда - рабочий день");
    break;
    case 4:
    Console.Write("четверг - рабочий день");
    break;
    case 5:
    Console.Write("пятница - рабочий день");
    break;
    case 6:
    Console.Write("УРА, суббота - ВЫХОДНОЙ");
    break;
    case 7:
    Console.Write("УРА, воскресенье - ВЫХОДНОЙ");
    break;
    default:
    Console.Write("дня недели с таким номером нет");
    break;
}
