namespace HomeWork_3._7_Итоговое_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ваше имя {name} и ваш возраст {age}");
            Console.Write("Введите вашу дату рождения: ");
            string birthday = Console.ReadLine();
            Console.WriteLine($"Ваша дата рождения {birthday}");



            Console.ReadLine();

        }
    }
}