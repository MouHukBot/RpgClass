using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.PortableExecutable;

namespace Class
{
    internal class Program
    {
        static void SelectionClass(string playerclass)
        {
            for (int i = 0; i < 10; i--)
            {
                Console.WriteLine("Выберете класс для вашего персонажа: ");
                Console.WriteLine("1.Рыцарь");
                Console.WriteLine("2.Охотник");
                Console.WriteLine("3.Маг");
                playerclass = Console.ReadLine();
                switch (playerclass)
                {
                    case "1":
                        playerclass = "Рыцарь";
                        i = 11;
                        break;
                    case "2":
                        playerclass = "Охотник";
                        i = 11;
                        break;
                    case "3":
                        playerclass = "Маг";
                        i = 11;
                        break;
                    default:
                        Console.WriteLine("Ошибка. Попробуйте еще раз выбрать класс");
                        break;
                }
            }
        }
        static void PointDistribution(string name, int health, int stamina, int strength, int agility, int intellect)
        {
            Console.WriteLine("Как вас зовут? ");
            name = Console.ReadLine();

            Console.WriteLine("Сколько у вас жизненой силы?");
            health = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько у вас стойкости?");
            stamina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько у вас силы");
            strength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько у вас ловкости");
            agility = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько у вас интелекта?");
            intellect = Convert.ToInt32(Console.ReadLine());
        }
        static void Main()
        {
            string name = "name", playerclass = "player";
            int health = 0, stamina = 0, strength = 0, agility = 0, intellect = 0;

            //проблемы с изменениями переменных внутри методов, так что я их снова заменю

            //SelectionClass(playerclass);
            for (int i = 0; i < 10; i--)
            {
                Console.WriteLine("Выберете класс для вашего персонажа: ");
                Console.WriteLine("1.Рыцарь\n2.Охотник\n3.Маг");
                playerclass = Console.ReadLine();
                switch (playerclass)
                {
                    case "1":
                        playerclass = "Рыцарь";
                        i = 11;
                        break;
                    case "2":
                        playerclass = "Охотник";
                        i = 11;
                        break;
                    case "3":
                        playerclass = "Маг";
                        i = 11;
                        break;
                    default:
                        Console.WriteLine("Ошибка. Попробуйте еще раз выбрать класс");
                        break;
                }
            }
            //PointDistribution(name, health, stamina, strength, agility, intellect);
            Console.WriteLine("Как вас зовут? ");
            name = Console.ReadLine();

            Console.WriteLine("Сколько у вас жизненой силы?");
            health = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько у вас стойкости?");
            stamina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько у вас силы");
            strength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько у вас ловкости");
            agility = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько у вас интелекта?");
            intellect = Convert.ToInt32(Console.ReadLine());

            var person = new Player(name, health, stamina, strength, agility, intellect, playerclass);
            Console.WriteLine($"\nВаше имя {person.Name}, Ваш класс {person.PlayerClass}");
            Console.WriteLine($"Ваши характеристики: ");
            Console.WriteLine($"Жизненая сила: {person.Health}   Стойкость: {person.Stamina}   Сила:{person.Strength}   Ловкость:{person.Agility}   Интелект:{person.Intellect}");
            Console.WriteLine("Сколько в сундуке слотов под хранение?");
            int storage = Convert.ToInt32(Console.ReadLine());
            var chest = new Storage(storage);
            string item1 = "Монета", item2 = "Ожерелье", item3 = "Кольцо", item4 = "Амулет" /*nothing = "Пустой слот"*/;
            for (int i = 0; i < storage; i++)
            {
                Random random = new Random();
                switch (random.Next(1, 6))
                {
                    case 1:
                        chest._storage[i] = item1;
                        break;
                    case 2:
                        chest._storage[i] = item2;
                        break;
                    case 3:
                        chest._storage[i] = item3;
                        break;
                    case 4:
                        chest._storage[i] = item4;
                        break;
                    default:
                        //chest._storage[i] = nothing;
                        break;
                }
            }
            Console.WriteLine("Содержимое сундука:");
            for (int i = 0; i < storage; i++)
            {
                Console.Write($"   {chest._storage[i]}");
            }
            Console.WriteLine("\nЗабрать содержимое сундука?\n1.Да\n2.Нет");
            for (int i = 0; i < 10; i--)
            {
                int answer = Convert.ToInt32(Console.ReadLine());
                int n = 0;
                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Содержимое вашего инвентаря:");
                        for (int j = 0; j < storage; j++)
                        {
                            //if (chest._storage[j] != nothing)
                            //{
                            person.PlayerInv.InventoryPlayer.Add(chest._storage[j]);
                            Console.WriteLine($"{person.PlayerInv.InventoryPlayer[j]}");
                            //chest._storage[j] = nothing;
                            //}
                            //else
                            //{
                            //person.PlayerInv.InventoryPlayer.Remove(nothing);
                            //}
                        }
                        i = 11;
                        break;
                    case 2:
                        Console.WriteLine("Вы ничего не взяли, так что ваш инвентарь пуст");
                        i = 11;
                        break;
                    default:
                        Console.WriteLine("Ошибка, вы ввели ответ не соответствуйщий условию");
                        break;
                }
            }
        }
    }
}