using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Тема: Інтерфейси
//Модуль 7

namespace _16._04._24_c_
{

    //Task_1
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    public class Array_1 : ICalc
    {
        private int[] array;

        public Array_1(int size)
        {
            array = new int[size];
        }
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public int Greater(int valueToCompare)
        {
            int greater_nums = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > valueToCompare)
                {
                    greater_nums++;
                }
            }
            return greater_nums;
        }

        public int Less(int valueToCompare)
        {
            int lower_nums = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < valueToCompare)
                {
                    lower_nums++;
                }
            }
            return lower_nums;
        }

        public void Show()
        {
            Console.Write("array 1:\t\t\t\t");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }


    //Task_2

    public interface IOutput_2
    {
        void ShowEven();
        void ShowOdd();
    }

    public class Array_2 : IOutput_2
    {
        private int[] array;

        public Array_2(int size)
        {
            array = new int[size];
        }
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public void ShowEven()
        {
            Console.Write("evens in array:\t\t\t\t");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.Write("odds in array:\t\t\t\t");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            Console.WriteLine();
        }

        public void Show()
        {
            Console.Write("array 2:\t\t\t\t");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

    }


    //Task_3

    public interface ICalc_2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
    public class Array_3 : ICalc_2
    {
        private int[] array;

        public Array_3(int size)
        {
            array = new int[size];
        }
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public int CountDistinct()
        {
            int unique_nums = 0;

            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool is_unique = true;
                for (int j = 0; j < index; j++)
                {
                    if (array[i] == array[j])
                    {
                        is_unique = false;
                        break;
                    }
                }
                if (is_unique)
                {
                    unique_nums++;
                    array[index] = array[i];
                    index++;
                }
            }
            return unique_nums;
        }
        public int EqualToValue(int valueToCompare) 
        {
            int equal_nums = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valueToCompare)
                {
                    equal_nums++;
                }
            }
            return equal_nums;
        }
        public void Show()
        {
            Console.Write("array 3:\t\t\t\t");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }


        internal class Program
    {
        static void Main(string[] args)
        {

            //Завдання 1
            //Створіть інтерфейс ICalc.У ньому мають бути два
            //методи:
            //■ int Less(int valueToCompare) — повертає кількість
            //менших значень, ніж valueToCompare;
            //■ int Greater(intvalueToCompare) — повертає кількість
            //більших значень, ніж valueToCompare.
            //Клас, створений раніше у практичному завданні Array,
            //має імплементувати інтерфейс ICalc.
            //Метод Less — повертає кількість елементів масиву
            //менших, ніж valueToCompare.
            //Метод Greater — повертає кількість елементів масиву
            //більших, ніж valueToCompare.
            //Напишіть код для тестування отриманої функціональності.

            Console.WriteLine($"Task 1\n");

            Array_1 array1 = new Array_1(5);
            array1[0] = 1;
            array1[1] = 3;
            array1[2] = 5;
            array1[3] = 6;
            array1[4] = 9;
            array1.Show();

            Console.Write("enter value to compare (0-9):\t\t");
            int user_num = int.Parse(Console.ReadLine());
            Console.WriteLine($"number of elements greater then {user_num}:\t{array1.Greater(user_num)}");
            Console.WriteLine($"number of elements less then {user_num}:\t\t{array1.Less(user_num)}");

            Console.WriteLine("\npress any key to continue");
            Console.ReadKey();
            Console.WriteLine();

            //Завдання 2
            //Створіть інтерфейс IOutput2.У ньому мають бути
            //два методи:
            //■ void ShowEven() — відображає парні значення контейнера з даними;
            //■ void ShowOdd() — відображає непарні значення контейнера з даними.
            //Клас, створений раніше у практичному завданні Array,
            //має імплементувати інтерфейс IOutput2.
            //Метод ShowEven — відображає парні значення з
            //масиву.
            //Метод ShowOdd — відображає непарні значення
            //масиву.
            //Напишіть код для тестування отриманої функціональності.

            Console.WriteLine($"Task 2\n");

            Array_2 array2 = new Array_2(5);
            array2[0] = 1;
            array2[1] = 3;
            array2[2] = 5;
            array2[3] = 6;
            array2[4] = 9;
            array2.Show();
            array2.ShowEven();
            array2.ShowOdd();

            Console.WriteLine("\npress any key to continue");
            Console.ReadKey();
            Console.WriteLine();

            //Завдання 3
            //Створіть інтерфейс ICalc2.У ньому мають бути два
            //методи:
            //■ int CountDistinct() — повертає кількість унікальних
            //значень у контейнері даних;
            //■ int EqualToValue(int valueToCompare) — повертає кількість значень, рівних valueToCompare.
            //Клас, створений раніше у практичному завданні Array,
            //має імплементувати інтерфейс ICalc2.
            //Метод CountDistinct — повертає кількість унікальних
            //значень в масив.
            //Метод EqualToValue — повертає кількість елементів
            //масиву, рівних valueToCompare.
            //Напишіть код для тестування отриманої функціональності.

            Console.WriteLine($"Task 3\n");

            Array_3 array3 = new Array_3(5);
            array3[0] = 1;
            array3[1] = 3;
            array3[2] = 5;
            array3[3] = 6;
            array3[4] = 9;
            array3.Show();
            Console.WriteLine($"number of unique elements:\t\t{array3.CountDistinct()}");
            Console.WriteLine($"number of elements equal to {user_num}:\t\t{array3.EqualToValue(user_num)}");

            Console.WriteLine();

        }
    }
}
