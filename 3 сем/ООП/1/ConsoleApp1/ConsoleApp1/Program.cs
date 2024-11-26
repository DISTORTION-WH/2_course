using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text;

namespace ConsoleApplication10
{    class Class1
    {
 
        [STAThread]

        static void Exa()
        {
            /*      Определите переменные всех возможных примитивных типов
                  С# и проинициализируйте их. Осуществите ввод и вывод их 
                  значений используя консоль.
      */
            Console.WriteLine("task1");
            bool a = true;
            Console.WriteLine(a);
            byte b = 17;
            Console.WriteLine(b);
            char c = 'a';
            Console.WriteLine(c);
            decimal d = 2.1m;
            Console.WriteLine(d);
            double e = 3.2;
            Console.WriteLine(e);
            float f = 134.45E-2f;
            Console.WriteLine(f);
            int g = 32;
            Console.WriteLine(g);
            uint h = 12;
            Console.WriteLine(h);
            nint i = 0;
            Console.WriteLine(i);
            nuint j = 0;
            Console.WriteLine(j);
            long k = 123;
            Console.WriteLine(k);
            ulong l = 323;
            Console.WriteLine(k);
            short m = 2;
            Console.WriteLine(m);
            ushort n = 12;
            Console.WriteLine(n);
            string o = "12";
            Console.WriteLine(o);
            Console.WriteLine(object.ReferenceEquals(o, "134"));
            dynamic p = 1;
            Console.WriteLine(p);

        }
        static void Exb()
        {
            Console.WriteLine("task2");
            sbyte a = 4;            // 0000100
            short b = a;    // 000000000000100
            
            Console.WriteLine("Неявное преобразование", a, " ", b);

            int aa = 4;
            int bb = 6;
            byte c = (byte)(a + b);
            Console.WriteLine("Явное преобразование", c);

            int n = Convert.ToInt32("23");
            Console.WriteLine("Операция Convert ", n);
        }
        static void Exc()
         {
            int number = 42; // Значимый тип int
            object boxedNumber = number; // Упаковка значения в ссылку на объект
            int unboxedNumber = (int)boxedNumber; // Распаковка значения из ссылки на объект
            Console.WriteLine(unboxedNumber); // Выводит 42
        }
        static void Exd()
        {
            int age = 42;
            Console.WriteLine("Явно типищированная", age);
            var name = "John Doe"; 
            Console.WriteLine("Неявно типизированная",name);
        }
        static void Exe()
        {
            int? val = null;

            if (val == null)
            {
                Console.WriteLine("Да, равно null");
            }
            else
            {
                Console.WriteLine("Нет, не равно null");
            }

        }
        static void Exf()
        {

            Console.WriteLine(" var number; не будет работать, тк мы не задали значение переменной, соответсвенно компилятор не может определить тип переменной," +
                "а код var number = 10; будет работать, тк мы задали значение 10");
           
        }
        static void Ex2a()
        {
            Console.WriteLine("hello");
            Console.WriteLine("фыва");

            Console.WriteLine("Строковые литералы представляют собой строки, тк при изменении содержимого строки, строк не меняется," +
                "а создается новый обьект с тем же названием, прошлый очищается от мусора и в новый обьект записывается результат действия со строками" +
                "https://learn.microsoft.com/ru-ru/dotnet/csharp/programming-guide/strings/");
            int ans = String.Compare("asdsd", "Hello Worlds?");
                Console.WriteLine(ans);
         
        } 
        static void Ex2b()
        {
            string str1 = "Hello";
            string str2 = "World";
            string str3;

            // Сцепление строк
            str3 = String.Concat(str1, str2);
            Console.WriteLine("Сцепление: " + str3);

            // Копирование строки
            string copyStr = String.Copy(str1);
            Console.WriteLine("Копия строки: " + copyStr);

            // Разделение строки на слова
            string sentence = "This is a sentence.";
            string[] words = sentence.Split(' ');
            Console.WriteLine("Разделение на слова:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Вставка подстроки в заданную позицию
            string originalStr = "The quick brown fox";
            string insertStr = "lazy ";
            int position = 4;
            string modifiedStr = originalStr.Insert(position, insertStr);
            Console.WriteLine("Вставка подстроки: " + modifiedStr);

            // Удаление заданной подстроки
            string removeStr = "quick ";
            string resultStr = originalStr.Replace(removeStr, "");
            Console.WriteLine("Удаление подстроки: " + resultStr);

            string name = "Alice";
            int age = 25;

            // Интерполяция строк
            string message = $"Привет, меня зовут {name} и мне {age} лет.";
            Console.WriteLine(message);

        }
        static void Ex2c()
        {
            string emptyString = ""; // Пустая строка
            string nullString = null; // Null строка

            // Использование метода string.IsNullOrEmpty
            bool isEmpty1 = string.IsNullOrEmpty(emptyString);
            bool isEmpty2 = string.IsNullOrEmpty(nullString);

            Console.WriteLine("Пустая строка: " + isEmpty1); // Выводит True
            Console.WriteLine("Null строка: " + isEmpty2); // Выводит True

            // Другие операции с пустой и null строками
            string concatenatedString = emptyString + "Hello"; // Конкатенация пустой строки с другой строкой
            Console.WriteLine("Конкатенация: " + concatenatedString); // Выводит "Hello"

            int length1 = emptyString.Length; // Получение длины пустой строки
            int length2 = nullString?.Length ?? 0; // Получение длины null строки с использованием условного оператора
            Console.WriteLine("Длина пустой строки: " + length1); // Выводит 0
            Console.WriteLine("Длина null строки: " + length2); // Выводит 0

            string trimmedString = emptyString.Trim(); // Удаление пробелов из пустой строки
            Console.WriteLine("Обрезанная пустая строка: " + trimmedString); // Выводит ""

            bool containsSubstring = emptyString.Contains("Hello"); // Проверка наличия подстроки в пустой строке
            Console.WriteLine("Содержит подстроку: " + containsSubstring); // Выводит False

        }
        static void Ex2d()
        {           
                StringBuilder sb = new StringBuilder("Hello, World!");

                // Удаление определенных позиций
                sb.Remove(5, 7);
                Console.WriteLine("После удаления: " + sb.ToString()); // Выводит "Hello!"

                // Добавление символов в начало и конец строки
                sb.Insert(0, "Привет, ");
                sb.Append(" Мир!");
                Console.WriteLine("После добавления: " + sb.ToString()); // Выводит "Привет, Hello! Мир!"
            
        }
        static void Ex3a()
        {
       
                int[,] matrix = new int[,]
                {
                            { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 }
                };

                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);

                // Вывод двумерного массива на консоль
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
          
        }
        static void Ex3b()
        {
                
                // Создание одномерного массива строк
                string[] array = new string[] { "apple", "banana", "cherry", "date" };

                // Вывод содержимого массива
                Console.WriteLine("Содержимое массива:");
                foreach (string element in array)
                {
                    Console.WriteLine(element);
                }

                // Вывод длины массива
                int length = array.Length;
                Console.WriteLine("Длина массива: " + length);

                // Замена произвольного элемента
                Console.WriteLine("Введите позицию элемента для замены (от 0 до " + (length - 1) + "):");
                int position = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите новое значение элемента:");
                string newValue = Console.ReadLine();

                if (position >= 0 && position < length)
                {
                    array[position] = newValue;
                    Console.WriteLine("Элемент успешно заменен.");
                }
                else
                {
                    Console.WriteLine("Некорректная позиция элемента.");
                }

                // Вывод обновленного содержимого массива
                Console.WriteLine("Обновленное содержимое массива:");
                foreach (string element in array)
                {
                    Console.WriteLine(element);
                }
            }
        static void Ex3c()
        {
            


            // Создание ступенчатого массива
            double[][] array = new double[3][];
            array[0] = new double[2];
            array[1] = new double[3];
            array[2] = new double[4];

            // Ввод значений массива с консоли
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine("Введите значение для элемента [{0}][{1}]:", i, j);
                    array[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Вывод содержимого массива
            Console.WriteLine("Содержимое массива:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Ex3d()
        {
            // Неявно типизированная переменная для массива
            var array = new[] { 1, 2, 3, 4, 5 };

            // Неявно типизированная переменная для строки
            var str = "Hello, World!";
            Console.WriteLine(str);
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + "\t");


        }
        static void Ex4a()
        {
            var tuple = (42, "Hello", 'A', "World", 1234567890UL);

            // Доступ к элементам кортежа
            int item1 = tuple.Item1;
            string item2 = tuple.Item2;
            char item3 = tuple.Item3;
            string item4 = tuple.Item4;
            ulong item5 = tuple.Item5;

            // Вывод значений элементов кортежа
            Console.WriteLine("Элемент 1: " + item1);
            Console.WriteLine("Элемент 2: " + item2);
            Console.WriteLine("Элемент 3: " + item3);
            Console.WriteLine("Элемент 4: " + item4);
            Console.WriteLine("Элемент 5: " + item5);

        }
        static void Ex4b()
        {
            var tuple = (42, "Hello", 'A', "World", 1234567890UL);

            // Вывод кортежа целиком
            Console.WriteLine(tuple);

            // Вывод выборочных элементов кортежа
            Console.WriteLine("Первый элемент: " + tuple.Item1);
            Console.WriteLine("Третий элемент: " + tuple.Item3);
            Console.WriteLine("Четвёртый элемент: " + tuple.Item4);

        }
        static void Ex4c()
        {
            //Распаковка с использованием именованных переменных:
            var tuple = (1, "hello", 3.14);
            var (x, y, z) = tuple;
            Console.WriteLine($"x: {x}, y: {y}, z: {z}");


           // Распаковка с использованием неименованных переменных:
            var tuple1 = (1, "hello", 3.14);
            var (a, b, c) = tuple1;
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");


            //Распаковка с пропуском некоторых значений:
            var tuple2 = (1, "hello", 3.14);
            var (_, _, d) = tuple2;
            Console.WriteLine($"d: {d}");

            //Распаковка с использованием переменной _ для пропуска значений:

            var tuple3 = (1, "hello", 3.14);
            var (e, _, _) = tuple3;
            Console.WriteLine($"e: {e}");



        }
        static void Ex4d()
        {
            var tuple1 = (1, "hello", 3.14);
            var tuple2 = (1, "hello", 3.14);

            if (tuple1 == tuple2)
            {
                Console.WriteLine("Кортежи равны");
            }
            else
            {
                Console.WriteLine("Кортежи не равны");
            }

        }
        static void Ex5() {
            int[] numbers = { 5, 2, 8, 1, 9 };
            string text = "Hello";

            var result = ProcessArrayAndString(numbers, text);

            Console.WriteLine($"Максимальный элемент: {result.max}");
            Console.WriteLine($"Минимальный элемент: {result.min}");
            Console.WriteLine($"Сумма элементов: {result.sum}");
            Console.WriteLine($"Первая буква строки: {result.firstLetter}");
        }
        static (int max, int min, int sum, char firstLetter) ProcessArrayAndString(int[] numbers, string text)
        {
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;

            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;

                if (number < min)
                    min = number;

                sum += number;
            }

            char firstLetter = text[0];

            return (max, min, sum, firstLetter);
        }
        static void Ex6()
        {


            static void CheckedFunction()
            {
                checked
                {
                    int maxValue = int.MaxValue;
                    Console.WriteLine($"Значение в блоке checked: {maxValue}");
                }
            }

            static void UncheckedFunction()
            {
                unchecked
                {
                    int maxValue = int.MaxValue + 10000;
                    Console.WriteLine($"Значение в блоке unchecked: {maxValue}");
                }
            }
            CheckedFunction();
            UncheckedFunction();
        }
        static void Main()
        {
             Exa();
            // Exb();
            // Exc();
            // Exd(); 
            // Exe();
            // Exf();
            // Ex2a();
            // Ex2b();
            // Ex2c();
            // Ex2d();
            // Ex3a();
            // Ex3b();
            // Ex3c();
            // Ex3d();
            // Ex4a();
            // Ex4b();
            // Ex4c();
            // Ex4d();
            // Ex5();
            // Ex6();



        }
    }
}
