using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Об'ява змінних.
            int size;
            int numberMin = 1;
            int numberMax = 101;
            int arrayMin = 0;
            int arrayMax = 0;
            int sum = 0;
            double arif = 0;
            int neparni = 0;
            int currentNumber = 0;

            Random randomNumber = new Random();

            // Запитати про розмір масиву.
            Console.WriteLine("Уведіть розмір масиву?");
            size = int.Parse(Console.ReadLine());

            // Створення масиву.
            int[] array = new int[size];

            // Заповнити масив випадковими числами.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(randomNumber.Next(numberMin, numberMax));
                //Console.WriteLine("Номер " + (i + 1) + " = " + array[i]);
            }
            Console.WriteLine();

            // Пошук найбільшого значення масиву.
            arrayMax = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > arrayMax)
                {
                    arrayMax = array[i];
                }
            }

            // Пошук найменшого значення масиву.
            arrayMin = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < arrayMin)
                {
                    arrayMin = array[i];
                }
            }

            // Пошук загальної суми усіх елементів масиву.
            for (int i = 1; i < array.Length; i++)
            {
                sum = sum + array[i];
            }

            // Пошук середнього аріфметичного значення усіх елементів масиву,
            // Треба спочатку виклакати майбутній метод пошуку загальної суми.
            for (int i = 1; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            // А потім вже дізнатися середнє аріфметичне.
            arif = sum / array.Length;

            // Пошук непарних чисел.
            // Знаходження загальної кількості таких елементів.
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) != 0)
                {
                    neparni++;
                }
            }
            // Пошук непарних значень.
            // Створення нового массиву, що буде містити непарні числа.
            int[] arrayNeparni = new int[neparni];

            // Пошук непарних значень.
            // Заповнення нового масиву непарними числами.
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) != 0)
                {
                    arrayNeparni[currentNumber] = array[i];
                    currentNumber++;
                }
            }

            // Вивід інформації.
            Console.WriteLine("Створений масив розміром " + size);
            Console.WriteLine();

            Console.WriteLine("Він заповнений випадковими числами від " + numberMin + " по " + (numberMax - 1) + ":");
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Елемент " + (i + 1) + " = " + array[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Найбільше значення масиву = " + arrayMax);
            Console.WriteLine();

            Console.WriteLine("Найменьше значення масиву = " + arrayMin);
            Console.WriteLine();

            Console.WriteLine("Загальна сума усіх елементів масиву = " + sum);
            Console.WriteLine();

            Console.WriteLine("Середнє аріфмеичне усіх елементів масиву = " + arif);
            Console.WriteLine();

            Console.WriteLine("Загальна кількість усіх непарних значень = " + neparni);
            Console.WriteLine();

            Console.WriteLine("Це:");
            for (int i = 0; i < arrayNeparni.Length; i++)
            {
                Console.WriteLine("Елемент " + (i + 1) + " = " + arrayNeparni[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Усе!");
            Console.ReadKey();
        }
    }
}
