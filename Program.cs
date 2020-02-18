using System;

namespace Homeworks
{
    class Program
    {

        static void Main(string[] args)
        {
            Homework_1 hw1 = new Homework_1();
            Homework_2 hw2 = new Homework_2();
            Homework_3 hw3 = new Homework_3();

            // Credit(hw1);
            // Hypotenuse(hw1);
            // StraightLineEquation(hw1);
            // Roots(hw1);
            // MaxPlusThree(hw1);
            // EuclideanDivision(hw1);
            // CoordinateSystem(hw1);
            // Radius(hw1);
            // Factorial(hw1);
            // ValueTable(hw1);
            // SumAndMultDigits(hw1);
            // Evidence(hw1);

            // ReverseNumber(hw2);
            // Calc(hw2);
            // CheckRandomGenerator(hw2);
            // GuessRandomNumber(hw2);
            // Fibonacci(hw2);
            // MaxInArray(hw2);
            // ReverseAnArray(hw2);
            // SwapArr(hw2);
            // ArithmeticalMean(hw2);
            // SumBetweenMinMax(hw2);

            // QtyDigits(hw3);
            // Rectangle(hw3);
            // NumberOfDividers(hw3, hw2);
            // TicTacToe(hw3);
            // SwapDiagonals(hw3);
            // CountingBigNumbers(hw3, hw2);

            /*  Human antosha = new Human("Antoshka", 35);
              antosha.GetInfo();
              //Human antosha = new Human("Antoshka");
              //Human antosha = new Human(35);
              //antosha.name = "Antoshka";
              Human petya = new Human("Petya", 66);
              petya.GetInfo();
              Human sergey = new Human("Sergey", 33);
              sergey.GetInfo();

              Human kirill = new Human()
              {
                  name = "Kirill", 
                  age = 23 
              };

              kirill.GetInfo();
              */

            // ------------ 
            
            

            Console.ReadLine();
        }
       
        static int Random(int min, int max)
        {
            Random rnd = new Random();
            int randomNumner = rnd.Next(min, max);
            return randomNumner;
        }

        //        HOMEWORK 1
        static void Credit(Homework_1 hw1)
        {
            double percentage;
            int years, loanAmount;

            Console.WriteLine("Введите сумму кредита");
            loanAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество лет");
            years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите проценты");
            percentage = (Convert.ToDouble(Console.ReadLine())) / 100;

            Console.WriteLine($"Сумма кредита: {loanAmount}");
            Console.WriteLine($"На {years} лет");
            Console.WriteLine($"Под {percentage * 100}%");
            Console.WriteLine();

            double[] payments = hw1.CalcCreditPayments(loanAmount, years, percentage);

            Console.WriteLine($"Ежемесячные выплаты: {payments[0]}");

            Console.WriteLine($"Суммарная выплата: {payments[1]}");
        }

        static void Hypotenuse(Homework_1 hw1)
        {
            //{a^2}+{b^2}={c^2}
            double cathet_1, cathet_2, hypotenuse;

            cathet_1 = Random(1, 10);
            cathet_2 = Random(1, 10);

            hypotenuse = hw1.CalcHypotenuse(cathet_1, cathet_2);

            Console.WriteLine($"Катет1: {cathet_1}, катет2: {cathet_2}, гипотенуза: {hypotenuse}");
        }

        static void StraightLineEquation(Homework_1 hw1)
        {
            // Вывести уравнение прямой по координатам двух точек
            // y = kx + b ; k = (y1 - y2) / (x1 - x2); b = y2 - k * x2

            float x1, y1, x2, y2;

            x1 = Random(-10, 10);
            y1 = Random(-10, 10);
            x2 = Random(-10, 10);
            y2 = Random(-10, 10);


            float[] result = hw1.CalcStraightLineEquation(x1, y1, x2, y2);

            Console.WriteLine($"A({x1};{y1})");
            Console.WriteLine($"B({x2};{y2})");
            Console.WriteLine($"y={result[0]}*x + {result[1]}");
        }

        static void Roots(Homework_1 hw1)
        {
            // Найти корни квадратного уравнения. ax^{2}+bx+c = 0,
            // d = b2 - 4ac
            // где x — неизвестное, a,b,c — коэффициенты, причём a!= 0.
            // d>0 корней два  -b +/- Math.Sqrt(d)) / (2 * a)
            // d==0 корень один -(b / (2 * a))
            // d<0 корней нет
            double a, b, c;

            a = Random(-100, 100);
            b = Random(-100, 100);
            c = Random(-100, 100);

            if (a == 0)
            {
                a = Random(-100, 100);
            }

            Console.WriteLine($"a={a}, b={b}, c={c}");

            double[] rootsArr = hw1.CalcRoots(a, b, c);

            if (rootsArr.Length == 2)
            {
                Console.WriteLine($"Дискриминант > 0, корени равны {rootsArr[0]} и {rootsArr[1]}");
            }
            else if (rootsArr.Length == 1)
            {
                Console.WriteLine($"Дискриминант < 0, корень равен {rootsArr[0]}");
            }
            else
            {
                Console.WriteLine($"Дискриминант < 0, корней на множестве действительных чисел нет. {rootsArr[0]}");
            }
        }

        static void MaxPlusThree(Homework_1 hw1)
        {
            //(max(a*b*c, a+b+c) + 3)
            int a, b, c, sum, mult, result;
            a = Random(-10, 10);
            b = Random(-10, 10);
            c = Random(-10, 10);
            sum = hw1.Add(a, b, c);
            mult = hw1.Mult(a, b, c);
            result = hw1.CalcMaxPlusThree(a, b, c);
            Console.WriteLine($"a={a}, b={b}, c={c}");


            if (sum > mult)
            {
                Console.WriteLine($"a+b+c больше a*b*c. Результат = {result}");
            }
            else if (sum < mult)
            {
                Console.WriteLine($"a*b*c больше a+b+c. Результат = {result}");
            }
            else
            {
                Console.WriteLine($"a*b*c равно a+b+c. Результат = {result}");
            }

            Console.WriteLine(result);
        }

        static void EuclideanDivision(Homework_1 hw1)
        {
            // Вводятся два целых числа. (рандом от -100 до 100) Проверить, делится ли первое на второе. 
            // Вывести на экран сообщение об этом, а также остаток (если он есть) и частное (в любом случае). 

            int a, b;

            a = Random(-100, 100);
            b = Random(-100, 100);
            Console.WriteLine($"a: {a}, b: {b}");

            int[] result = hw1.CalcEuclideanDivision(a, b);

            if (b != 0)
            {
                if (a % b == 0)
                {
                    Console.WriteLine($"a делится на b без остатка. Частное равно {result[0]}");
                }
                else
                {
                    Console.WriteLine($"a делится на b с остатком. Частное равно {result[0]}, остаток равен {result[1]}");
                }
            }
            else
            {
                Console.WriteLine("Делить на ноль нельзя!");
            }
        }

        static void CoordinateSystem(Homework_1 hw1)
        {
            // Определить, какой четверти принадлежит точка с координатами (x, y). x и y - рандом от -10 до 10

            int x, y;

            //x = Random(-100, 100);
            //y = Random(-100, 100);
            x = 0;
            y = 0;

            int quarter = hw1.DefineQuarter(x, y);

            if (quarter != 0)
            {
                Console.WriteLine($"В яблочко! x: {x}, y: {y}");
            }
            else
            {
                Console.WriteLine($"{quarter} четверть x: {x}, y: {y}");
            }


        }

        static void Radius(Homework_1 hw1)
        {
            // вводятся координаты А (x;y) рандом от -15 до 15 точки и радиус круга (r), рандом от -10 до 10
            // определить, принадлежит ли данная точка кругу, если его центр находится в начале координат. 
            double x, y, r, hypotenuse;

            //x = Random(-15, 15);
            //y = Random(-15, 15);
            //r = Random(-10, 10);
            x = -4;
            y = 8;
            r = 10;
            hypotenuse = hw1.CalcHypotenuse(x, y);
            bool result = hw1.IsInToCircle(x, y, r);

            if (r >= 0)
            {
                if (result)
                {
                    Console.WriteLine($"Точка ({x};{y}) принадлежит окружности.");
                }
                else
                {
                    Console.WriteLine($"Точка ({x};{y}) не принадлежит окружности.");
                }
            }
            else
            {
                Console.WriteLine("Радиус не может быть меньше нуля");
            }
            Console.WriteLine($"радиус: {r}, гипотенуза: {hypotenuse}");
        }

        static void Factorial(Homework_1 hw1)
        {
            // Вычислить факториал числа n. n - рандом от 1 до 15; 5! = 5 * 4 * 3 * 2 * 1 = 120

            int n = Random(1, 15);
            int fact = hw1.CalcFactorial(n);

            Console.WriteLine($"факториал числа {n}: {fact}");
        }

        static void ValueTable(Homework_1 hw1)
        {
            // Вывести таблицу значений функции y = -0.23x2 + x. Значения аргумента (x) задаются минимумом, максимумом и шагом. (как вариант, ещё и попробовать нарисовать в консоли)

            double x, y;

            for (x = -10; x <= 10; x++)
            {
                y = hw1.CalcFunctionValues(x);

                Console.Write("{0,7}", $"x = {x}");
                Console.Write($" | y = {y}\n");
                Console.WriteLine("___________________");
            }
        }

        static void SumAndMultDigits(Homework_1 hw1)
        {
            // Найти сумму и произведение цифр введенного натурального числа. рандом от 10000 до 100000000

            int x, sumRes = 0, multRes = 1;
            int[] sum = new int[] { }, mult = new int[] { };

            x = Random(10000, 100000000);

            Console.WriteLine($"x: {x}");

            while (x > 0)
            {
                sum = hw1.CalcSumDigitsInNumber(x, sumRes);
                sumRes = sum[1];
                mult = hw1.CalcMultDigitsInNumber(x, multRes);
                multRes = mult[1];
                x = sum[0];

                Console.WriteLine($"x = {x} сумма равна {sum[1]}, произведение равно {mult[1]}");
            }

            Console.WriteLine($"сумма равна {sum[1]}, произведение равно {mult[1]}");
        }

        static void Evidence(Homework_1 hw1)
        {
            // Докажите, что для множества натуральных чисел верно 1+2+...+n = n(n+1)/2

            int n = Random(1, 1000);

            int left = hw1.SumNaturalNumbers(n);
            int right = hw1.RightSideOfEquation(n);
            int[] result = hw1.EquationCheck(left, right);

            Console.WriteLine($"n = {n}");
            Console.WriteLine($"Левая часть = {left}, правая часть = {right}");
            Console.WriteLine($"Равно - {result[0]} раз, не равно - {result[1]} раз.");
        }

        //        HOMEWORK 2

        static void ReverseNumber(Homework_2 hw2)
        {
            //  123 => 321.

            int n, reverseN;
            n = Random(1, 100000);
            reverseN = hw2.FlipNumberBackwards(n);

            Console.WriteLine($"n = {n}, reverse = {reverseN}");
        }

        static void Calc(Homework_2 hw2)
        {
            char sign = '+';
            float num, result;

            Console.WriteLine("Введите первое число: ");
            try
            {
                result = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введите первое ЧИСЛО! You idiot! ");
                result = Convert.ToInt32(Console.ReadLine());
            }
            while (sign != '0')
            {

                Console.WriteLine("Введите знак: ");
                sign = Convert.ToChar(Console.ReadLine());

                if (sign != '+' && sign != '-' && sign != '*' && sign != '/')
                {
                    Console.WriteLine("Bloody hell! Вы ввели неверный знак");
                    Console.WriteLine("Введите знак: ");
                    sign = Convert.ToChar(Console.ReadLine());
                }

                Console.WriteLine("Введите второе число: ");
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите второе ЧИСЛО! You piece of shit! ");
                    num = Convert.ToInt32(Console.ReadLine());
                }

                if (sign == '+' || sign == '-' || sign == '*')
                {
                    result = hw2.SubstituteSign(result, num, sign);
                }
                else if (sign == '/')
                {
                    if (num != 0)
                    {
                        result = hw2.SubstituteSign(result, num, sign);
                    }
                    else
                    {
                        Console.WriteLine("Делить на ноль нельзя! You wanker!");
                        continue;
                    }
                }
                Console.WriteLine($"Результат {result}");
                Console.WriteLine($"\n");
            }
        }

        static void CheckRandomGenerator(Homework_2 hw2)
        {
            // Проверить корректность работы генератора псевдослучайных чисел на выборке не менее 1000 случайных чисел. 
            // Программа должна выдать около 50%. 
            // Можно увеличить число генераций, например до 10 тысяч. В таком случае отклонение от 50% будет меньше

            int count, amount = 10000;

            count = hw2.CheckRandom(amount);
            double percentage = hw2.CalcPercentage(count, amount);

            Console.WriteLine($"Even numbers {count} out of {amount}");
            Console.WriteLine($"Even numbers {percentage}%");
        }

        static void GuessRandomNumber(Homework_2 hw2)
        {
            // 4. Угадать случайное число не более чем за 10 попыток.     
            // После каждой неудачной попытки должно сообщаться больше или меньше введенное пользователем число, чем то, что загадано.                                     
            // Если за 10 попыток число не отгадано, то вывести загаданное число.          

            int number = Random(0, 101), counter = 0, guess, attempts = 10;

            Console.WriteLine(number);
            Console.WriteLine("Угадайте число от 0 до 100");

            while (counter <= attempts)
            {
                Console.WriteLine($"Попытка {counter}");
                guess = Convert.ToInt32(Console.ReadLine());
                string result = hw2.CheckEquality(number, guess);

                Console.WriteLine(result);
                if (result == "Вы угадали!") break;
                counter++;
            }

            if (counter > attempts)
            {
                Console.WriteLine($"Вы не угадали 10 раз. Число было равно {number}");
            }
        }

        static void Fibonacci(Homework_2 hw2)
        {
            // 5. Вывести на экран столько элементов ряда Фибоначчи, сколько указал пользователь.

            int n;
            Console.WriteLine("Задайте количество эллементов ряда");

            n = Convert.ToInt32(Console.ReadLine());
            int[] fibArr = hw2.FibonacciOfNumber(n);
            string fibStr = hw2.PrintArray(fibArr);

            Console.WriteLine(fibStr);
        }

        static void MaxInArray(Homework_2 hw2)
        {
            // Задан массив из 20 элементов (рандом от -100 до 100). Найти наибольший элемент массива и его индекс
            int length = 20;
            int[] arr = hw2.FillArray(length);
            int[] maxInArr = hw2.FindMaxInArray(arr);
            string arrStr = hw2.PrintArray(arr);

            Console.WriteLine(arrStr);
            Console.WriteLine();
            Console.WriteLine($"max = {maxInArr[0]}, index = {maxInArr[1]} ");
        }

        static void ReverseAnArray(Homework_2 hw2)
        {
            int length = 10;
            int[] arr, reverse;
            string arrStr, reverseArrStr;

            arr = hw2.FillArray(length);
            arrStr = hw2.PrintArray(arr);

            reverse = hw2.ReverseArray(arr);
            reverseArrStr = hw2.PrintArray(reverse);

            Console.WriteLine($"arr {arrStr}");
            Console.WriteLine($"reverse {reverseArrStr}");
        }

        static void SwapArr(Homework_2 hw2)
        {
            // Поменять местами первую и вторую половину массива, 
            // 1 2 3 4  => 3 4 1 2.
            // 1 2 3 4 5  =>  4 5 3 1 2
            int length = 6;
            int[] arr, swapArr;
            string arrStr, swapArrStr;

            arr = hw2.FillArray(length);
            arrStr = hw2.PrintArray(arr);

            swapArr = hw2.SwapArrayParts(arr);
            swapArrStr = hw2.PrintArray(swapArr);

            Console.WriteLine($"arr {arrStr}");
            Console.WriteLine($"swap {swapArrStr}");
        }

        static void ArithmeticalMean(Homework_2 hw2)
        {
            //4. Найти в массиве те элементы, значение которых меньше среднего арифметического, взятого от всех элементов массива.
            int length = 6;
            int[] arr = hw2.FillArray(length);
            string arrStr = hw2.PrintArray(arr);
            Console.WriteLine($"arr {arrStr}");

            int arithmMean = hw2.CalcArithmeticalMean(arr);
            int[] newArr = hw2.GetNumbLessAv(arr, arithmMean);
            string newArrStr = hw2.PrintArray(newArr);
            Console.WriteLine($"arr {newArrStr}");

        }

        static void SumBetweenMinMax(Homework_2 hw2)
        {
            // 5. В массиве найти сумму элементов, находящихся между минимальным и максимальным элементами. 
            // Сами минимальный и максимальный элементы в сумму не включать.

            int length = 10, sum;
            int[] arr = hw2.FillArray(length, 0, 20);
            string arrStr = hw2.PrintArray(arr);
            Console.WriteLine($"arr {arrStr}");

            int[] maxResult = hw2.FindMaxInArray(arr);
            int[] minResult = hw2.FindMinInArray(arr);
            sum = hw2.GetSumBetweenMinMax(arr, minResult[1], maxResult[1]);

            Console.WriteLine($"max  = {maxResult[0]}, maxIndex  = {maxResult[1]}");
            Console.WriteLine($"min  = {minResult[0]}, minIndex  = {minResult[1]}");
            Console.WriteLine($"Sum = {sum}");
        }
        //        HOMEWORK 3

        static void QtyDigits(Homework_3 hw3)
        {
            // 1.Посчитать, сколько раз встречается определенная цифра в введенной последовательности чисел.
            // Количество вводимых чисел и цифра, которую необходимо посчитать, задаются вводом с клавиатуры.

            int amount, digit, num, count = 0;

            Console.WriteLine("Введите количество цифр:");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цифру которую надо найти:");
            digit = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= amount; i++)
            {
                // --------ЧИСЛА ВВОДЯТСЯ ПОЛЬЗОВАТЕЛЕМ--------------------
                Console.WriteLine("Введите число: ");
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверно задано число");
                    continue;
                }
                // --------РАНДОМНЫЕ ЧИСЛА --------------------------------
                //num = Random();
                //Console.WriteLine(num);
                count += hw3.FindNumberOfDigits(num, digit);
            }
            Console.WriteLine($"Число {digit} встречается {count} раз.");
        }

        static void Rectangle(Homework_3 hw3)
        {
            // Вывести на экран "прямоугольник", образованный из двух видов символов. 
            // Контур прямоугольника должен состоять из одного символа, а в "заливка" - из другого. 
            // Размеры прямоугольника, а также используемые символы задаются вводом с клавиатуры.

            string symb1, symb2;
            int w, h;
            Console.WriteLine("Введите ширину прямоугольника");
            w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту прямоугольника");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первый символ");
            symb1 = Console.ReadLine();
            Console.WriteLine("Введите второй символ");
            symb2 = Console.ReadLine();

            string[,] rectangle = hw3.MakeRectangle(w, h, symb1, symb2);
            string rectStr = hw3.PrintTwoDimensionalArrayString(rectangle);

            Console.WriteLine(rectStr);
        }

        static void NumberOfDividers(Homework_3 hw3, Homework_2 hw2)
        {
            //3. В введенном промежутке натуральных чисел найти те, количество делителей у которых не меньше введенного значения.  Для найденных чисел вывести на экран количество делителей и все делители.
            //	Примерный вывод:
            //	Числовой промежуток: 21 .. 30
            //	Количество делителей (не менее): 5
            //	24 - 8 - 1 2 3 4 6 8 12 24
            //	28 - 6 - 1 2 4 7 14 28
            //	30 - 8 - 1 2 3 5 6 10 15 30

            int a, b, minOfDiv, divCounter;
            int[] divArr;
            string divStr;

            Console.WriteLine("Введите промежуток натуральных чисел");
            Console.WriteLine("От: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("До: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество делителей должно быть не менее:");
            minOfDiv = Convert.ToInt32(Console.ReadLine());

            while (a <= b)
            {
                divCounter = hw3.CountDividers(a);
                divArr = hw3.NumberDividers(a, divCounter);

                if (divCounter >= minOfDiv)
                {
                    divStr = hw2.PrintArray(divArr);
                    Console.Write($"{a} - {divCounter} - {divStr} \n");
                }
                a++;
            }
        }

        static void TicTacToe(Homework_3 hw3)
        {
            int height, width;
            string arrStng;

            Console.WriteLine("Введите ширину поля");
            width = Convert.ToInt32(Console.ReadLine()); // номер ряда 
            Console.WriteLine("Введите высоту поля");
            height = Convert.ToInt32(Console.ReadLine()); // номер столбца

            string[,] arr = new string[height, width];
            arr = hw3.FillTwoDimensionalArraySrting(arr, "+");
            arrStng = hw3.PrintTwoDimensionalArrayString(arr);
            Console.Write(arrStng);


            int markedCellsCount = 0;
            do
            {
                int r, c;
                // ---------  ДВА ИГРОКА проверяем валидность координат -----------------------------------------

                //Console.WriteLine("Введите номер строки");
                //try
                //{
                //    r = Convert.ToInt32(Console.ReadLine()); // номер ряда 
                //}
                //catch
                //{
                //    Console.WriteLine("Неверно задано значение строки");
                //    continue;
                //}
                //Console.WriteLine("Введите номер столбца");
                //try
                //{
                //    c = Convert.ToInt32(Console.ReadLine()); // номер столбца
                //}
                //catch
                //{
                //    Console.WriteLine("Неверно задано значение столбца");
                //    continue;
                //}

                // ---------  КОМП С СОБОЙ ИГРАЕТ -----------------------------------------
                //r = rnd.Next(0, height);
                //c = rnd.Next(0, width);

                // ---------  ЧЕЛОВЕК-X & КОМП-O ----------------------------------------------
                if (markedCellsCount % 2 == 0)
                {
                AskRow:
                    Console.WriteLine($"Введите номер строки от 0 до {arr.GetLength(0) - 1}");
                    try
                    {

                        r = Convert.ToInt32(Console.ReadLine()); // номер ряда 
                        if (r > arr.GetLength(0) || r < 0)
                        {
                            Console.WriteLine("Неверно задано значение строки");
                            Console.WriteLine();
                            goto AskRow;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Неверно задано значение строки");
                        Console.WriteLine();
                        continue;
                    }

                AskColumn:
                    Console.WriteLine($"Введите номер столбца от 0 до {arr.GetLength(1) - 1}");
                    try
                    {

                        c = Convert.ToInt32(Console.ReadLine()); // номер столбца
                        if (c > arr.GetLength(0))
                        {
                            Console.WriteLine("Неверно задано значение столбца");
                            Console.WriteLine();

                            goto AskColumn;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Неверно задано значение столбца");
                        Console.WriteLine();
                        goto AskColumn;
                    }
                }
                else
                {
                    r = Random(0, height);
                    c = Random(0, width);
                }

                // --------- выбираем Х или О --------------
                string currentMarker = markedCellsCount % 2 == 0 ? "X" : "0";

                // --------- проверяем занята ли клетка -----------
                if (arr[r, c] != "+")
                {
                    Console.WriteLine("Увы! Эта клетка занята!");
                    continue;
                }
                // --------- ставим Х или О ------------------------
                arr[r, c] = currentMarker;

                arrStng = hw3.PrintTwoDimensionalArrayString(arr);
                Console.Write(arrStng);

                // --------- проверяем клетки вокруг ------------------------------------
                int markersCount = hw3.CheckCells(arr, r, c, currentMarker);

                // --------- ПОБЕДА ------------------------------------
                if (markersCount == 3)
                {
                    Console.WriteLine($"Игрок {currentMarker} победил!");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine();
                markedCellsCount++;
            }
            while (markedCellsCount <= 25);

            Console.WriteLine("Однако, ничья!");
        }

        static void SwapDiagonals(Homework_3 hw3)
        {

            //  В квадратной матрице 10x10 обменять значения элементов в каждой строке, расположенные на главной и побочной диагоналях.

            int length = 5;

            int[,] arr = new int[length, length];
            arr = hw3.FillTwoDimensionalArrayInt(arr);
            string arrStr = hw3.PrintTwoDimensionalArrayInt(arr); // Может ли метод принимать разные типы данных
            Console.WriteLine(arrStr);

            Console.WriteLine("------------------------");
            Console.WriteLine();

            arr = hw3.SwapDiag(arr);

            arrStr = hw3.PrintTwoDimensionalArrayInt(arr); // Может ли метод принимать разные типы данных
            Console.WriteLine(arrStr);
        }

        static void CountingBigNumbers(Homework_3 hw3, Homework_2 hw2)
        {
            //! 3. Найти количество элементов массива, которые больше своих левого, правого, верхнего и нижнего соседа одновременно.

            int l = 6, bigNumberCounter;
            int[,] arr = new int[l, l];
            int[] bigNumbers;
            string arrStr, bigNumbersStr;

            arr = hw3.FillTwoDimensionalArrayInt(arr);
            arrStr = hw3.PrintTwoDimensionalArrayInt(arr); // как вывести красиво ??

            Console.Write(arrStr);

            bigNumberCounter = hw3.CountBigNumbers(arr);
            bigNumbers = hw3.BigNumbersArr(arr, bigNumberCounter);
            bigNumbersStr = hw2.PrintArray(bigNumbers);

            Console.WriteLine($"bigNumbers - {bigNumbersStr}");
            Console.WriteLine($"bigNumberCounter - {bigNumberCounter}");
        }

    }
}
