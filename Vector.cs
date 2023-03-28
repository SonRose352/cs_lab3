using System;

class Vector
{
    //Поля
    public double[] Array { get; set; }

    //Конструкторы
    public Vector()
    {
        Array = new double[3] { 0, 0, 0 };
    }
    public Vector(double[] Array)
    {
        this.Array = (double[])Array.Clone();
    }

    //Метод ввода
    public void input()
    {
        Console.Write("Введите размерность вектора: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Array = new double[n];
        Console.WriteLine("Введите элемнеты вектора:");
        for (int i = 0; i < n; i++)
        {
            Array[i] = Convert.ToDouble(Console.ReadLine());
        }
    }

    //Метод ToString
    public override string ToString()
    {
        string answer = "";
        for (int i = 0; i < Array.Length; i++)
        {
            answer += Array[i].ToString() + " ";
        }
        return answer;
    }

    //Метод, возвращающий модуль вектора
    public double module()
    {
        double sum = 0;
        for (int i = 0; i < Array.Length; i++)
        {
            sum += Math.Pow(Array[i], 2);
        }
        return Math.Sqrt(sum);
    }

    //Метод, возвращающий наибольший элемент вектора
    public double max_elem()
    {
        double max_elem = Array[0];
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] > max_elem)
            {
                max_elem = Array[i];
            }
        }
        return max_elem;
    }

    //Метод, возвращающий индекс наименьшего элемнета
    public int min_elem_index()
    {
        int I = 0;
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] < Array[I])
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
        foreach (double elem in Array)
        {
            if (elem > 0)
            {
                n++;
            }
        }
        v.Array = new double[n];
        int k = 0;
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] <= 0)
                k++;
            else
                v.Array[i - k] = Array[i];
        }
        return v;
    }

    //Статический метод, возвразающий сумму двух векторов
    public static Vector sum(Vector v1, Vector v2)
    {
        Vector v = new Vector();
        v.Array = new double[v1.Array.Length];
        for (int i = 0; i < v1.Array.Length; i++)
        {
            v.Array[i] = v1.Array[i] + v2.Array[i];
        }
        return v;
    }

    //Статичемкий метод, возвращающий скалярное произведение двух векторов
    public static double scalyar(Vector v1, Vector v2)
    {
        double result = 0;
        for (int i = 0; i < v1.Array.Length; i++)
        {
            result += v1.Array[i] * v2.Array[i];
        }
        return result;
    }

    //Статический метод, возвращающий результат проверки двух векторов на раавенство
    public static bool equality(Vector v1, Vector v2)
    {
        for (int i = 0; i < v1.Array.Length; i++)
        {
            if (v1.Array[i] != v2.Array[i])
                return false;
        }
        return true;
    }
}