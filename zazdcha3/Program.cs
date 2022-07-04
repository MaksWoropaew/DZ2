// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи число: ");
            int anyNumber = Convert.ToInt32(Console.ReadLine());
            string anyNumberText = Convert.ToString(anyNumber);
            if (anyNumberText.Length > 2)
            {
                Console.WriteLine("третья цифра -> " + anyNumberText[2]);
            }
            else
            {
                Console.WriteLine("-> третьей цифры нет");
            }
        }
    }
}
