using System;
using System.IO;

namespace Tasks;

class Program
{
    static void Main(string[] args)
    {

        string file1 = "Task1.txt";
        FileTasks.FillFileTask1(file1, 10);
        int result1 = FileTasks.SquareDifference(file1);

        Console.WriteLine("Задание 1:");
        Console.WriteLine("Квадрат разности = " + result1);


        string file2 = "Task2.txt";
        FileTasks.FillFileTask2(file2, 3, 5);
        int result2 = FileTasks.SumOddNumbers(file2);

        Console.WriteLine("\nЗадание 2:");
        Console.WriteLine("Сумма нечётных = " + result2);
        

        string inputFile = "Task3.txt";
        string outputFile = "result.txt";

        FileTasks.LastSymbols(inputFile, outputFile);
        Console.WriteLine("\nЗадание 3 выполнено.");
        Console.WriteLine("Создан файл result.txt");
        
        
        string binaryFile = "Task4.dat";
        FileTasks.FillBinaryFile(binaryFile, 15);
        int result4 =
            FileTasks.CountDoubleOddNumbers(binaryFile);

        Console.WriteLine("\nЗадание 4:");
        Console.WriteLine("Количество чисел = " + result4);
        
        // ---------- Часть вторая (6-9) ----------

        List<int> numbers =
            new List<int>()
            {
                1, 1, 2, 2, 2, 3, 4, 4, 5
            };

        List<int> result =
            CollectionTasks.RemoveRepeated(numbers);

        Console.WriteLine("Задание 6:");
        foreach (int item in result)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();


        LinkedList<int> linked =
            CollectionTasks.ConvertToLinkedList(numbers);
        
        Console.WriteLine("\nЗадание 7:");
        foreach (int item in linked)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();


        Console.WriteLine("\nЗадание 8:");
        CollectionTasks.Facultatives();


        Console.WriteLine("\nЗадание 9:");
        CollectionTasks.OddWordSymbols("text.txt");
    }
}