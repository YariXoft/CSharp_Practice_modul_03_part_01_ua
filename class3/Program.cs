using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    //4 class Cuty
    class City
    {
        private string nazvaMista;
        private string nazvaKrainy;
        private int kilkist;
        private int kodMista;
        private string[] rayony;//райони міста

        public City(string nazvaMista, string nazvaKrainy, int kilkist, int kodMista, string[] rayony)
        {
            this.nazvaMista = nazvaMista;
            this.nazvaKrainy = nazvaKrainy;
            this.kilkist = kilkist;
            this.kodMista = kodMista;
            this.rayony = rayony;
        }

        public City(string nazvaMista, string nazvaKrainy, int kilkist, int kodMista) : this(nazvaMista, nazvaKrainy, kilkist, kodMista, new string[0])
        {
        }

        // Методи класу для введення та виведення даних
        public void InputData()
        {
            Console.WriteLine("Введiть назву мiста:");
            nazvaMista = Console.ReadLine();

            Console.WriteLine("Введiть назву країни:");
            nazvaKrainy = Console.ReadLine();

            Console.WriteLine("Введiть кiлькiсть жителiв у мiстi:");
            int.TryParse(Console.ReadLine(), out kilkist);

            Console.WriteLine("Введiть телефонний код мiста:");
            int.TryParse(Console.ReadLine(), out kodMista);

            Console.WriteLine("Введiть назви районiв мiста (через кому):");
            rayony = Console.ReadLine().Split(',');
        }

        public void DisplayData()
        {
            Console.WriteLine($"Назва мiста: {nazvaMista}");
            Console.WriteLine($"Назва країни: {nazvaKrainy}");
            Console.WriteLine($"Кiлькiсть жителiв: {kilkist}");
            Console.WriteLine($"Телефонний код мiста: {kodMista}");
            Console.WriteLine("Назви районiв мiста:");
            foreach (string i in rayony)
            {
                Console.WriteLine(i);
            }
        }
        public void SetNazvaMista(string name)
        {
            nazvaMista = name;
        }
        public string GetNazvaMista()
        {
            return nazvaMista;
        }
    }
    internal class Program
    {
        static void Main()
        {
            //1
            int start = 2;
            int finish = 5;
            int res1 = CalcDiapazone(start, finish);
            Console.WriteLine($"1. Добуток дiапазону вiд {start} до {finish} = {res1}");

            //2 
            int num2 = 21;//за умови число більше 1
            bool res2;
            res2 = PerevirkaProsteCyslo(num2);
            if (res2) Console.WriteLine($"2. Число {num2} є числом Фiбоначчi");
            else Console.WriteLine($"2. Число {num2} не є числом Фiбоначчi");

            //3 
            int[] arr = { 5, 8, 2, 1, 4, 0, 9 };
            Console.WriteLine($"3. масив: ");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            int select;
            Console.WriteLine("\nЯк сортувати: 1 - за зростанням, 0 - за зменшенням:");

            while (!int.TryParse(Console.ReadLine(), out select) || (select != 0 && select != 1))
            {
                Console.WriteLine("Невiрний ввiд. Будь ласка, введiть 1 або 0.");
            }
            if (select == 1) BubbleSortMinToMax(arr);           
            else if (select == 0) BubbleSortMaxToMin(arr);
            Console.WriteLine($"Сортований масив: ");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //4 
            Console.WriteLine("ex.4 City");
            City city = new City("", "", 0, 0);
            city.InputData();
            city.DisplayData();

        }
        //1
        static int CalcDiapazone(int start, int finish)
        {
            int res = 1;
            for (int i = start; i <= finish; i++)
            {
                res *= i;
            }
            return res;
        }

        //2
        static bool PerevirkaProsteCyslo (int num2)
        {
            int a = 0;
            int b = 1;

            while (b < num2)//перевірка чи є наше число в списку Фібоначі
            {
                int temp = b;
                b = a + b;
                a = temp;
            }
            if (b == num2) return true;
            else return false;
        }

        //3 
       static void BubbleSortMinToMax(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void BubbleSortMaxToMin(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }


}
