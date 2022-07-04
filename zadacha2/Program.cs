// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи трёхзначное число: ");
            int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
            string stringNumber = Convert.ToString(threeDigitNumber);
            Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);           
          
        }
    }
}
