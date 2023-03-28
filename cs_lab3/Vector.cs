using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Vector
{
    //Поля
    public double[] arr { get; set; }

    //Конструкторы
    public Vector()
    {
        arr = new double[3] { 0, 0, 0 };
    }
    public Vector(double[] Array)
    {
        this.arr = (double[])Array.Clone();
    }

    //Метод ввода
    public void input()
    {
        Console.Write("Введите размерность вектора: ");
        int n = Convert.ToInt32(Console.ReadLine());
        arr = new double[n];
        Console.WriteLine("Введите элемнеты вектора:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }
    }

    //Метод ToString
    public override string ToString()
    {
        string answer = "";
        for (int i = 0; i < arr.Length; i++)
        {
            answer += arr[i].ToString() + " ";
        }
        return answer;
    }

    //Метод, возвращающий модуль вектора
    public double module()
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += Math.Pow(arr[i], 2);
        }
        return Math.Sqrt(sum);
    }

    //Метод, возвращающий наибольший элемент вектора
    public double max_elem()
    {
        double max_elem = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max_elem)
            {
                max_elem = arr[i];
            }
        }
        return max_elem;
    }

    //Метод, возвращающий индекс наименьшего элемнета
    public int min_elem_index()
    {
        int I = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < arr[I])
            {
                I = i;
            }
        }
        return I;
    }

    //Метод, возвращающий новый вектор
    public Vector new_vector()
    {
        Vector v = new Vector();
        int n = 0;
        foreach (double elem in arr)
        {
            if (elem > 0)
            {
                n++;
            }
        }
        v.arr = new double[n];
        int k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] <= 0)
                k++;
            else
                v.arr[i - k] = arr[i];
        }
        return v;
    }

    //Статический метод, возвразающий сумму двух векторов
    public static Vector sum(Vector v1, Vector v2)
    {
        Vector v = new Vector();
        v.arr = new double[v1.arr.Length];
        if (v1.arr.Length != v2.arr.Length)
            throw new Exception("Векторы разной размерности");
        for (int i = 0; i < v1.arr.Length; i++)
        {
            v.arr[i] = v1.arr[i] + v2.arr[i];
        }
        return v;
    }

    //Статичемкий метод, возвращающий скалярное произведение двух векторов
    public static double scalyar(Vector v1, Vector v2)
    {
        double result = 0;
        if (v1.arr.Length != v2.arr.Length)
            throw new Exception("Векторы разной размерности");
        for (int i = 0; i < v1.arr.Length; i++)
        {
            result += v1.arr[i] * v2.arr[i];
        }
        return result;
    }

    //Статический метод, возвращающий результат проверки двух векторов на равенство
    public static bool equality(Vector v1, Vector v2)
    {
        if (v1.arr.Length != v2.arr.Length)
            return false;
        for (int i = 0; i < v1.arr.Length; i++)
        {
            if (v1.arr[i] != v2.arr[i])
                return false;
        }
        return true;
    }

    //Метод для возврата одного элемента вектора по индексу
    public double find_by_index(int i)
    {
        return arr[i];
    }

    //Метод для изменения одного из элементов по индексу
    public void change_elem(int i, double new_elem)
    {
        arr[i] = new_elem;
    }

    //Метод для заполнения вектора случайными числами
    public void random_elements(int a, int b)
    {
       Random random = new Random();
       for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.NextDouble() * (b - a) + a;
        }
    }

    //Метод для линейного поиска элемента в массиве
    public int lin_search(double elem)
    {
        return Array.IndexOf(arr, elem);
    }

    //Метод для проверки того, что массив упорядочен по возрастанию
    public bool check_to_sort()
    {
        Vector v = new Vector();
        v.arr = (double[])arr.Clone();
        Array.Sort(v.arr);
        for (int i = 0; i < arr.Length; i++)
        {
            if (v.arr[i] != arr[i])
                return false;
        }
        return true;
    }

    //Метод для бинарного поиска элемента в массиве
    public int bynary_search(double elem)
    {
        return Array.BinarySearch(arr, elem);
    }

    //Метод для циклического сдвига элементов вектора на заданное число позиций вправо
    public void sdvig(int n)
    {
        double[] new_arr = new double[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            new_arr[(i + n) % arr.Length] = arr[i];
        }
        arr = (double[])new_arr.Clone();
    }

    //Метод для проверки того, что в массиве на чётных местах находятся только отрицательные элементы
    public bool otric_in_chet()
    {
        for (int i = 0; i < arr.Length; i += 2)
        {
            if (arr[i] >= 0)
                return false;
        }
        return true;
    }