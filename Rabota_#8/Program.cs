

namespace Rabota__8
{
    internal class Program
    {
        public static void Main() {

            //int[,] array =  //Создаем двумерный массив
            //{ 
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};
            // 3 и 5

            Console.WriteLine($"Укажите сколько строк массива: ");
            int line_array = Convert.ToInt32(Console.ReadLine());//Задаем размерность массива.
            Console.WriteLine($"Укажите сколько столбцов массива: ");
            int pillar_array = Convert.ToInt32(Console.ReadLine());//Задаем размерность массива.

            int[,] array = new int[line_array, pillar_array];

            for (int i = 0; i < line_array; i++)
            {
                for (int j = 0; j < pillar_array; j++)
                {
                    Console.WriteLine($"Введите значения: [{i},{j}] ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < line_array; i++)
            {
                for (int j = 0; j < pillar_array; j++)
                {
                    Console.WriteLine($"Ваш массив: {array[i, j]}");
                }
            }
            Zadania conclusion = new Zadania(array);//для вывода

            Console.WriteLine("1.Определить в нем количество элементов кратных 4.");//+
            Console.WriteLine("Задание 1: " + conclusion.Tasks_one());            
            Console.WriteLine("2.Определить в нем произведение нечетных элементов.");//+
            Console.WriteLine("Задание 2: " + conclusion.Tasks_two());            
            Console.WriteLine("3.Найти произведение индексов строк и сумму индексов столбцов для элементов массива больших 8.");
            // Console.WriteLine("Задание 3: " + conclusion.Tasks_three()); // +/-
         
            long quantity = 1;
            long quantity2 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 8)
                    {
                        quantity *= j;
                        quantity2 += j;
                    }
                }
            }
            Console.WriteLine("Задание 3: "); // +/-  
            Console.WriteLine($"Сумма строк: {quantity}");
            Console.WriteLine($"Произведение столбцов: {quantity2}");
         // Перепроверить условие !!!!!
        Console.WriteLine("4.Определить сумму квадратов индексов (как строк так и столбцов) элементов, делящихся на 4 без остатка.");//+
            Console.WriteLine("Задание 4: " + conclusion.Tasks_four());//+            
            Console.WriteLine("5.Определить сумму индексов всех (их может быть несколько) минимальных по величине элементов двумерного массива.");

                int MinValue = int.MaxValue;
                int quantity12 = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < MinValue)
                        {
                            MinValue = array[i, j];
                            quantity12 = 0;
                        }
                        if (array[i, j] == MinValue)
                        {
                            MinValue += i + j;
                        }
                    }
                }
                Console.WriteLine("Задание 5: "); // +/-  
                Console.WriteLine($"сумма Минимальная: {MinValue}");
              
              // Console.WriteLine("Задание 5: " + conclusion.Tasks_five()); //  ???????       
            Console.WriteLine("6.Определить в нем количество тех элементов, состоящих на позициях с нечетной суммой индексов, которые сами четны.");
            Console.WriteLine("Задание 6: " + conclusion.Tasks_six());//+            
            Console.WriteLine("7.Определить в нем сумму остатков от деления на 2 тех элементов, которые не кратны 2.");//+
            Console.WriteLine("Задание 7: " + conclusion.Tasks_seven());//+      
            Console.WriteLine("8.Определить в нем произведение остатков от деления на 4 тех элементов, которые не кратны чертырем.");//+
            Console.WriteLine("Задание 8: " + conclusion.Tasks_eight());//+
        }
    }
}