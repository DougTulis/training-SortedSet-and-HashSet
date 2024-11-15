using System.Collections.Generic;

namespace Training_SortedSet_and_Hashset {
    internal class Program {
        static void Main(string[] args) {

            HashSet<int> hash = new HashSet<int>();

            string[] Vetcourses = { "A", "B", "C" };

            for (int i = 0; i < Vetcourses.Length; i++) {
                Console.Write("How many students on Course " + Vetcourses[i] + "?");
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++) {
                    hash.Add(int.Parse(Console.ReadLine()));
                }
            }
            int quantity = hash.Count;
            Console.WriteLine("Total students: " + quantity);

        }
    }
}
