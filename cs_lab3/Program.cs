using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main()
    {
        Vector vector1 = new Vector();
        vector1.input();
        //Console.WriteLine($"Метод ToString: {vector1.ToString()}");
        //Console.WriteLine($"Модуль вектора: {vector1.module()}");
        //Console.WriteLine($"Максимальный элемент: {vector1.max_elem()}");
        //Console.WriteLine($"Индекс минимального элемента: {vector1.min_elem_index()}");
        //Console.WriteLine($"Новый вектор: {vector1.new_vector().ToString()}");
        //Vector vector2 = new Vector();
        //vector2.input();
        //Console.WriteLine($"Второй вектор: {vector2.ToString()}");
        //Console.WriteLine($"Сумма векторов: {Vector.sum(vector1, vector2)}");
        //Console.WriteLine($"Скалярное произведение векторов: {Vector.scalyar(vector1, vector2)}");
        //Console.WriteLine($"Проверка на равенство двух векторов: {Vector.equality(vector1, vector2)}");
        //Console.WriteLine($"Находим элемент по индексу: {vector1.find_by_index(3)}");
        //vector1.change_elem(3, 6);
        //Console.WriteLine($"Новый вектор, полученный после замены элемента: {vector1.ToString()}");
        //vector2.random_elements(0, 10);
        //Console.WriteLine($"Вектор vector2 после заполнения случайными числами: {vector2.ToString()}");
        //Console.WriteLine($"Делаем линейный поиск элемента в векторе vector1: {vector1.lin_search(6)}");
        //Array.Sort(vector1.arr);
        //Console.WriteLine($"Вектор vector1 после сортировки: {vector1.ToString()}");
        //Console.WriteLine($"Проверка на отсортированность: {vector1.check_to_sort()}");
        //Console.WriteLine($"Бинарный поиск элемента в векторе vector1: {vector1.bynary_search(6)}");
        //vector1.sdvig(3);
        //Console.WriteLine($"Вектор vector1 после сдвига элементов на 3: {vector1.ToString()}");
        vector1.merge_sort();
        Console.WriteLine(vector1.ToString());
    }
}