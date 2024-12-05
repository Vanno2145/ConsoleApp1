

using System.Numerics;

namespace ConsoleAPP
{
    using System;

    class Backpack
    {
        
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Fabric { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }

        
        private string[] itemNames;
        private double[] itemVolumes;
        private int itemCount = 0;
        private double currentVolume = 0;

       
        public event EventHandler<string> ItemAdded;

        
        public Backpack(int maxItems)
        {
            itemNames = new string[maxItems];
            itemVolumes = new double[maxItems];
        }

        
        public void AddItem(string name, double itemVolume)
        {
            if (itemCount >= itemNames.Length)
            {
                throw new InvalidOperationException("Рюкзак заполнен: нельзя добавить больше предметов.");
            }

            if (currentVolume + itemVolume > Volume)
            {
                throw new InvalidOperationException("Невозможно добавить объект: недостаточно места в рюкзаке.");
            }

            itemNames[itemCount] = name;
            itemVolumes[itemCount] = itemVolume;
            itemCount++;
            currentVolume += itemVolume;

           
            ItemAdded?.Invoke(this, name);
        }

        
        public void ShowContents()
        {
            Console.WriteLine("Содержимое рюкзака:");
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"- {itemNames[i]} ({itemVolumes[i]} л)");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Backpack backpack = new Backpack(5) 
            {
                Color = "Чёрный",
                Brand = "Nike",
                Fabric = "Нейлон",
                Weight = 1.2,
                Volume = 30
            };

            
            backpack.ItemAdded += (sender, itemName) =>
            {
                Console.WriteLine($"Предмет \"{itemName}\" добавлен в рюкзак.");
            };

            try
            {
                backpack.AddItem("Бутылка воды", 5);
                backpack.AddItem("Ноутбук", 15);
                backpack.AddItem("Книга", 10);
                backpack.AddItem("Футболка", 2);

              
                backpack.AddItem("Палатка", 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

          
            backpack.ShowContents();



            Func<string, string, bool> findword = (text, word) => text.Contains(word);

            
            string mybook = "Это пример книги, в которой мы ищем слово";
            string isword= "книга";

            
            bool find = findword(mybook, isword);

            if (find)
            {
                Console.WriteLine("Слово найдено!");
            }
            else
            {
                Console.WriteLine("Слово не найдено.");
            }



            int[] numbers = { -1, 2, 3, -4, 5, -6, 7, 0 };

            
            Func<int[], int> countPositiveNumbers = arr =>
            {
                int count = 0;
                foreach (var num in arr)
                {
                    if (num > 0)
                        count++;
                }
                return count;
            };

            
            int positiveCount = countPositiveNumbers(numbers);
            Console.WriteLine($"Количество положительных чисел: {positiveCount}");
        }
    }
}