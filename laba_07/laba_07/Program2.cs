using System;
using System.Collections.Generic;
using System.IO;

namespace Tasks
{
    // Класс с заданиями 6-9
    public static class CollectionTasks
    {
        // ---------------- ЗАДАНИЕ 6 ----------------
        // Из каждой группы одинаковых подряд идущих элементов
        // оставить только один

        public static List<int> RemoveRepeated(List<int> list)
        {
            List<int> result = new List<int>();

            if (list.Count == 0)
            {
                return result;
            }

            result.Add(list[0]);

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] != list[i - 1])
                {
                    result.Add(list[i]);
                }
            }

            return result;
        }

        // ---------------- ЗАДАНИЕ 7 ----------------
        // Построить двунаправленный список
        // по однонаправленному

        public static LinkedList<int> ConvertToLinkedList(List<int> list)
        {
            LinkedList<int> linkedList =
                new LinkedList<int>();

            for (int i = 0; i < list.Count; i++)
            {
                linkedList.AddLast(list[i]);
            }

            return linkedList;
        }

        // ---------------- ЗАДАНИЕ 8 ----------------
        // Факультативы

        public static void Facultatives()
        {
            HashSet<string> allCourses =
                new HashSet<string>();

            allCourses.Add("Математика");
            allCourses.Add("Программирование");
            allCourses.Add("Физика");
            allCourses.Add("Английский");

            HashSet<string> student1 =
                new HashSet<string>();

            student1.Add("Математика");
            student1.Add("Программирование");

            HashSet<string> student2 =
                new HashSet<string>();

            student2.Add("Программирование");
            student2.Add("Физика");

            HashSet<string> student3 =
                new HashSet<string>();

            student3.Add("Программирование");
            student3.Add("Английский");

            // На какие ходят все студенты

            HashSet<string> allStudents =
                new HashSet<string>(student1);

            allStudents.IntersectWith(student2);
            allStudents.IntersectWith(student3);

            Console.WriteLine("Ходят все студенты:");

            foreach (string item in allStudents)
            {
                Console.WriteLine(item);
            }

            // На какие ходит хотя бы один

            HashSet<string> atLeastOne =
                new HashSet<string>();

            atLeastOne.UnionWith(student1);
            atLeastOne.UnionWith(student2);
            atLeastOne.UnionWith(student3);

            Console.WriteLine("\nХодит хотя бы один студент:");

            foreach (string item in atLeastOne)
            {
                Console.WriteLine(item);
            }

            // На какие не ходит никто

            HashSet<string> nobody =
                new HashSet<string>(allCourses);

            nobody.ExceptWith(atLeastOne);

            Console.WriteLine("\nНе ходит никто:");

            foreach (string item in nobody)
            {
                Console.WriteLine(item);
            }
        }

        // ---------------- ЗАДАНИЕ 9 ----------------
        // Символы из слов с нечётными номерами

        public static void OddWordSymbols(string path)
        {
            string text = File.ReadAllText(path);

            string[] words = text.Split(
                new char[] { ' ', ',', '.', '!', '?', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            HashSet<char> symbols =
                new HashSet<char>();

            for (int i = 0; i < words.Length; i++)
            {
                // нечётные слова
                if ((i + 1) % 2 != 0)
                {
                    string word = words[i];

                    for (int j = 0; j < word.Length; j++)
                    {
                        symbols.Add(word[j]);
                    }
                }
            }

            List<char> result =
                new List<char>(symbols);

            result.Sort();

            Console.WriteLine(
                "Символы в алфавитном порядке:");

            foreach (char c in result)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }
    }

}