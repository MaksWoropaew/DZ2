// Напишите программу, которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет, является ли этот день выходным.
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день недели: ");
            int num_day = Convert.ToInt32(Console.ReadLine());
            if( num_day == 1) Console.WriteLine("Понедельник");
            if( num_day == 2) Console.WriteLine("Вторник");
            if( num_day == 3) Console.WriteLine("Среда");
            if( num_day == 4) Console.WriteLine("Четверг");
            if( num_day == 5) Console.WriteLine("Пятница");
            if( num_day == 6) Console.WriteLine("Выходной");
            if( num_day == 7) Console.WriteLine("Выходной");
            if( num_day >  7) Console.WriteLine("НЕ число от 1 до 7");
        }
    }
}
