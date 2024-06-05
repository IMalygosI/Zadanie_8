using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Задание 1.Определить в нем количество элементов кратных 4.
//Задание 2.Определить в нем произведение нечетных элементов.
//Задание 3.Найти произведение индексов строк и сумму индексов столбцов для элементов массива больших 8.
//Задание 4.Определить сумму квадратов индексов (как строк так и столбцов) элементов, делящихся на 4 без остатка.
//Задание 5.Определить сумму индексов всех (их может быть несколько) минимальных по величине элементов двумерного массива.
//Задание 6.Определить в нем количество тех элементов, состоящих на позициях с нечетной суммой индексов, которые сами четны.
//Задание 7.Определить в нем сумму остатков от деления на 2 тех элементов, которые не кратны 2.
//Задание 8.Определить в нем произведение остатков от деления на 4 тех элементов, которые не кратны чертырем.

namespace Rabota__8
{
    internal class Zadania
    {
        private int[,] array;

        public Zadania(int[,] array_)
        {
            this.array = array_;
        }
        public int Tasks_one() {
            int quantity = 0;//количество
            foreach (int element in array) {
                if (element % 4 == 0) {
                    quantity++; //количество считаем
                }
            }
            return quantity;
        } // +
        public long Tasks_two() {
            long quantity = 1;// количество
            foreach (int element in array)
            {
                if (element % 2 != 0)
                {
                    quantity *= element;  // считаем
                }
            }
            return quantity;
        } // +
        public long Tasks_seven()
        {
            long quantity = 0;// количество
            foreach (int element in array)
            {
                if (element % 2 != 0)//находим остаток от деления
                {
                    quantity += element % 2;  // смотрим чтогбы не был кратен 2
                }
            }
            return quantity;
        } // +   
        public long Tasks_eight()
        {
            long quantity = 1;// количество
            foreach (int element in array)
            {
                if (element % 4 != 0)//находим остаток от деления
                {
                    quantity *= element % 4;  // смотрим чтогбы не был кратен 4
                }
            }
            return quantity;
        } // + вроде так  
        public long Tasks_four()
        {
            int quantity = 0;//остатков
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 4 == 0)
                    {
                        quantity = (i * i) + (j * j);
                    }
                }
            }
            return quantity;
        } // +/- вроде так +
        public void Tasks_three() {
            long quantity = 1;
            long quantity2 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 8)
                    {
                        quantity *= j ;
                        quantity2 += j;
                    }
                }
            }
            Console.WriteLine("Задание 3: "); // +/-  
            Console.WriteLine($"Сумма строк{quantity}");
            Console.WriteLine($"Произведение столбцов{quantity2}");
        } // Перепроверить условие !!!!!

        public long Tasks_six()
        {
            int quantity = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 != 0 && (array[i, j] % 2 == 0))
                    {
                        quantity++;
                    }
                }
            }
            return quantity;
        }//+
        
        public void Tasks_five()
        {
            int MinValue = int.MaxValue;
            int quantity = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < MinValue)
                    {
                        MinValue = array[i, j];
                        quantity = 0;
                    }
                    if (array[i, j] == MinValue)
                    {
                        MinValue += i + j;
                    }
                }
            }
            Console.WriteLine("Задание 5: "); // +/-  
            Console.WriteLine($"сумма Минимальная: {MinValue}");
        } //  */           
    }
}
