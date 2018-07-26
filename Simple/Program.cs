using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple {
    class Program {
        const int ARRAYLEN = 100; 
        const int MULT = 4; // Множитель разброса произвольных значений
        static Recursion binarySearch = new Recursion();

        static void Main(string[] args) {
            Random random = new Random();
            int[] arrayRandom = new int[ARRAYLEN];
            // Инициализация массива произвольными значениями
            for (int i=0;i<arrayRandom.Length; i++) {
                arrayRandom[i] = random.Next(0, MULT * ARRAYLEN);
            }
            // Сортировка
            Array.Sort(arrayRandom);
            // Вывод сортированного массива
            Show(arrayRandom);
            // Ввод значения для поиска
            Console.WriteLine();
            Console.WriteLine("Введите значение для поиска:");
            string readString = Console.ReadLine();
            int findValue;
            if (!int.TryParse(readString, out findValue)) {
                Console.WriteLine("Введено не число!");
                return;
            }
            
            Console.WriteLine("Индекс искомого элемента:");
            Console.Write(binarySearch.Find(findValue,arrayRandom));
            Console.ReadKey();
        }

        static void Show(int[] outArray) {
            Console.WriteLine("Массив для поиска");
            for (int i = 0; i < outArray.Length; i++) {            
                Console.Write("\t"+outArray[i]);
                if (i == Math.Sqrt(outArray.Length)) {
                    Console.WriteLine();
                }

            }
        }
    }
}
