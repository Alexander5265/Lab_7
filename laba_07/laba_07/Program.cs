using System;
using System.IO;

namespace Tasks
{
    // Класс с решениями задач
    public static class FileTasks
    {
        // ---------------- ЗАДАНИЕ 1 ----------------

        // Заполнение файла случайными числами
        public static void FillFileTask1(string path, int count)
        {
            Random random = new Random();

            StreamWriter writer = new StreamWriter(path);

            for (int i = 0; i < count; i++)
            {
                writer.WriteLine(random.Next(-50, 51));
            }

            writer.Close();
        }

        // Квадрат разности максимального и минимального элементов
        public static int SquareDifference(string path)
        {
            StreamReader reader = new StreamReader(path);

            int number = int.Parse(reader.ReadLine());

            int max = number;
            int min = number;

            while (!reader.EndOfStream)
            {
                number = int.Parse(reader.ReadLine());

                if (number > max)
                    max = number;

                if (number < min)
                    min = number;
            }

            reader.Close();

            int difference = max - min;

            return difference * difference;
        }

        // ---------------- ЗАДАНИЕ 2 ----------------

        // Заполнение файла случайными числами
        public static void FillFileTask2(string path, int rows, int columns)
        {
            Random random = new Random();

            StreamWriter writer = new StreamWriter(path);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    writer.Write(random.Next(-50, 51) + " ");
                }

                writer.WriteLine();
            }

            writer.Close();
        }

        // Сумма нечётных элементов
        public static int SumOddNumbers(string path)
        {
            StreamReader reader = new StreamReader(path);

            int sum = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                string[] numbers = line.Split(
                    ' ',
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string item in numbers)
                {
                    int number = int.Parse(item);

                    if (number % 2 != 0)
                    {
                        sum += number;
                    }
                }
            }

            reader.Close();

            return sum;
        }

        // ---------------- ЗАДАНИЕ 3 ----------------

        // Создание файла с последними символами строк
        public static void LastSymbols(string inputPath, string outputPath)
        {
            StreamReader reader = new StreamReader(inputPath);
            StreamWriter writer = new StreamWriter(outputPath);

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (line.Length > 0)
                {
                    writer.WriteLine(line[line.Length - 1]);
                }
                else
                {
                    writer.WriteLine();
                }
            }

            reader.Close();
            writer.Close();
        }

        // ---------------- ЗАДАНИЕ 4 ----------------

        // Заполнение бинарного файла случайными числами
        public static void FillBinaryFile(string path, int count)
        {
            Random random = new Random();

            BinaryWriter writer =
                new BinaryWriter(File.Open(path, FileMode.Create));

            for (int i = 0; i < count; i++)
            {
                writer.Write(random.Next(1, 51));
            }

            writer.Close();
        }

        // Количество удвоенных нечётных чисел
        public static int CountDoubleOddNumbers(string path)
        {
            BinaryReader reader =
                new BinaryReader(File.Open(path, FileMode.Open));

            int count = 0;

            while (reader.BaseStream.Position <
                   reader.BaseStream.Length)
            {
                int number = reader.ReadInt32();

                if (number % 2 == 0 &&
                    (number / 2) % 2 != 0)
                {
                    count++;
                }
            }

            reader.Close();

            return count;
        }
    }
}