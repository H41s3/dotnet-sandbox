using System;
using System.Collections.Generic;

namespace Vector
{

    public class AscendingIntComparer : IComparer<int>
    {
        public int Compare(int A, int B)
        {
            return A - B;
        }
    }

    public class DescendingIntComparer : IComparer<int>
    {
        public int Compare(int A, int B)
        {
            return B - A;
        }
    }

    public class EvenNumberFirstComparer : IComparer<int>
    {
        public int Compare(int A, int B)
        {
            return A % 2 - B % 2;
        }
    }

    class Tester
    {
        private static bool CheckAscending(Vector<int> vector)
        {
            for (int i = 0; i < vector.Count - 1; i++)
                if (vector[i] > vector[i + 1]) return false;
            return true;
        }

        private static bool CheckDescending(Vector<int> vector)
        {
            for (int i = 0; i < vector.Count - 1; i++)
                if (vector[i] < vector[i + 1]) return false;
            return true;
        }

        private static bool CheckEvenNumberFirst(Vector<int> vector)
        {
            for (int i = 0; i < vector.Count - 1; i++)
                if (vector[i] % 2 > vector[i + 1] % 2) return false;
            return true;
        }

        static void Main(string[] args)
        {
            string result = "";
            int problem_size = 20;
            int[] data = new int[problem_size]; data[0] = 333;
            Random k = new Random(1000);
            for (int i = 1; i < problem_size; i++) data[i] = 100 + k.Next(900);

            Vector<int> vector = new Vector<int>(problem_size);

            // ------------------ Default Sort ----------------------------------
            try
            {
                Console.WriteLine("\nTest A: Sort integer numbers applying Default Sort with the AscendingIntComparer: ");
                vector = new Vector<int>(problem_size);
                for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
                Console.WriteLine("Initial data: " + vector.ToString());
                vector.Sort(null, new AscendingIntComparer());
                Console.WriteLine("Resulting order: " + vector.ToString());
                if (!CheckAscending(vector))
                {
                    Console.WriteLine(" :: FAIL");
                    result = result + "-";
                }
                else
                {
                    Console.WriteLine(" :: SUCCESS");
                    result = result + "A";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" :: FAIL");
                Console.WriteLine(exception.ToString());
                result = result + "-";
            }

            try
            {
                Console.WriteLine("\nTest B: Sort integer numbers applying Default Sort with the DescendingIntComparer: ");
                vector = new Vector<int>(problem_size);
                for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
                Console.WriteLine("Initial data: " + vector.ToString());
                vector.Sort(null, new DescendingIntComparer());
                Console.WriteLine("Resulting order: " + vector.ToString());
                if (!CheckDescending(vector))
                {
                    Console.WriteLine(" :: FAIL");
                    result = result + "-";
                }
                else
                {
                    Console.WriteLine(" :: SUCCESS");
                    result = result + "B";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" :: FAIL");
                Console.WriteLine(exception.ToString());
                result = result + "-";
            }

            try
            {
                Console.WriteLine("\nTest C: Sort integer numbers applying Default Sort with the EvenNumberFirstComparer: ");
                vector = new Vector<int>(problem_size);
                for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
                Console.WriteLine("Initial data: " + vector.ToString());
                vector.Sort(null, new EvenNumberFirstComparer());
                Console.WriteLine("Resulting order: " + vector.ToString());
                if (!CheckEvenNumberFirst(vector))
                {
                    Console.WriteLine(" :: FAIL");
                    result = result + "-";
                }
                else
                {
                    Console.WriteLine(" :: SUCCESS");
                    result = result + "C";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" :: FAIL");
                Console.WriteLine(exception.ToString());
                result = result + "-";
            }


            // ------------------ BubbleSort ----------------------------------
            
            try
            {
                Console.WriteLine("\nTest D: Sort integer numbers applying BubbleSort with the AscendingIntComparer: ");
                vector = new Vector<int>(problem_size);
                for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
                Console.WriteLine("Initial data: " + vector.ToString());
                vector.Sort(new BubbleSort(), new AscendingIntComparer());
                Console.WriteLine("Resulting order: " + vector.ToString());
                if (!CheckAscending(vector))
                {
                    Console.WriteLine(" :: FAIL");
                    result = result + "-";
                }
                else
                {
                    Console.WriteLine(" :: SUCCESS");
                    result = result + "D";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" :: FAIL");
                Console.WriteLine(exception.ToString());
                result = result + "-";
            }

            try
            {
                Console.WriteLine("\nTest E: Sort integer numbers applying BubbleSort with the DescendingIntComparer: ");
                vector = new Vector<int>(problem_size);
                for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
                Console.WriteLine("Initial data: " + vector.ToString());
                vector.Sort(new BubbleSort(), new DescendingIntComparer());
                Console.WriteLine("Resulting order: " + vector.ToString());
                if (!CheckDescending(vector))
                {
                    Console.WriteLine(" :: FAIL");
                    result = result + "-";
                }
                else
                {
                    Console.WriteLine(" :: SUCCESS");
                    result = result + "E";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" :: FAIL");
                Console.WriteLine(exception.ToString());
                result = result + "-";
            }

            try
            {
                Console.WriteLine("\nTest F: Sort integer numbers applying BubbleSort with the EvenNumberFirstComparer: ");
                vector = new Vector<int>(problem_size);
                for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
                Console.WriteLine("Initial data: " + vector.ToString());
                vector.Sort(new BubbleSort(), new EvenNumberFirstComparer());
                Console.WriteLine("Resulting order: " + vector.ToString());
                if (!CheckEvenNumberFirst(vector))
                {
                    Console.WriteLine(" :: FAIL");
                    result = result + "-";
                }
                else
                {
                    Console.WriteLine(" :: SUCCESS");
                    result = result + "F";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" :: FAIL");
                Console.WriteLine(exception.ToString());
                result = result + "-";
            }



            // ------------------ SelectionSort ----------------------------------

            try
            {
                Console.WriteLine("\nTest G: Sort integer numbers applying SelectionSort with the AscendingIntComparer: ");
                vector = new Vector<int>(problem_size);
                for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
                Console.WriteLine("Initial data: " + vector.ToString());
                vector.Sort(new SelectionSort(), new AscendingIntComparer());
                Console.WriteLine("Resulting order: " + vector.ToString());
                if (!CheckAscending(vector))
                {
                    Console.WriteLine(" :: FAIL");
                    result = result + "-";
                }
                else
                {
                    Console.WriteLine(" :: SUCCESS");
                    result = result + "G";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" :: FAIL");
                Console.WriteLine(exception.ToString());
                result = result + "-";
            }

            try
            {
                Console.WriteLine("\nTest H: Sort integer numbers applying SelectionSort with the DescendingIntComparer: ");
                vector = new Vector<int>(problem_size);
                for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
                Console.WriteLine("Initial data: " + vector.ToString());
                vector.Sort(new SelectionSort(), new DescendingIntComparer());
                Console.WriteLine("Resulting order: " + vector.ToString());
                if (!CheckDescending(vector))
                {
                    Console.WriteLine(" :: FAIL");
                    result = result + "-";
                }
                else
                {
                    Console.WriteLine(" :: SUCCESS");
                    result = result + "H";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" :: FAIL");
                Console.WriteLine(exception.ToString());
                result = result + "-";
            }

            try
            {
                Console.WriteLine("\nTest I: Sort integer numbers applying SelectionSort with the EvenNumberFirstComparer: ");
                vector = new Vector<int>(problem_size);
                for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
                Console.WriteLine("Initial data: " + vector.ToString());
                vector.Sort(new SelectionSort(), new EvenNumberFirstComparer());
                Console.WriteLine("Resulting order: " + vector.ToString());
                if (!CheckEvenNumberFirst(vector))
                {
                    Console.WriteLine(" :: FAIL");
                    result = result + "-";
                }
                else
                {
                    Console.WriteLine(" :: SUCCESS");
                    result = result + "I";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" :: FAIL");
                Console.WriteLine(exception.ToString());
                result = result + "-";
            }



            // ------------------ InsertionSort ----------------------------------

            try
            {
                Console.WriteLine("\nTest J: Sort integer numbers applying InsertionSort with the AscendingIntComparer: ");
                vector = new Vector<int>(problem_size);
                for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
                Console.WriteLine("Initial data: " + vector.ToString());
                vector.Sort(new InsertionSort(), new AscendingIntComparer());
                Console.WriteLine("Resulting order: " + vector.ToString());
                if (!CheckAscending(vector))
                {
                    Console.WriteLine(" :: FAIL");
                    result = result + "-";
                }
                else
                {
                    Console.WriteLine(" :: SUCCESS");
                    result = result + "J";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" :: FAIL");
                Console.WriteLine(exception.ToString());
                result = result + "-";
            }

            try
            {
                Console.WriteLine("\nTest K: Sort integer numbers applying InsertionSort with the DescendingIntComparer: ");
                vector = new Vector<int>(problem_size);
                for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
                Console.WriteLine("Initial data: " + vector.ToString());
                vector.Sort(new InsertionSort(), new DescendingIntComparer());
                Console.WriteLine("Resulting order: " + vector.ToString());
                if (!CheckDescending(vector))
                {
                    Console.WriteLine(" :: FAIL");
                    result = result + "-";
                }
                else
                {
                    Console.WriteLine(" :: SUCCESS");
                    result = result + "K";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" :: FAIL");
                Console.WriteLine(exception.ToString());
                result = result + "-";
            }

            try
            {
                Console.WriteLine("\nTest L: Sort integer numbers applying InsertionSort with the EvenNumberFirstComparer: ");
                vector = new Vector<int>(problem_size);
                for (int i = 0; i < problem_size; i++) vector.Add(data[i]);
                Console.WriteLine("Initial data: " + vector.ToString());
                vector.Sort(new InsertionSort(), new EvenNumberFirstComparer());
                Console.WriteLine("Resulting order: " + vector.ToString());
                if (!CheckEvenNumberFirst(vector))
                {
                    Console.WriteLine(" :: FAIL");
                    result = result + "-";
                }
                else
                {
                    Console.WriteLine(" :: SUCCESS");
                    result = result + "L";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" :: FAIL");
                Console.WriteLine(exception.ToString());
                result = result + "-";
            }

            Console.WriteLine("\n\n ------------------- SUMMARY ------------------- ");
            Console.WriteLine("Tests passed: " + result);

            // ==================== STEP 6: Direct Array Tests ====================
            // These tests call Sort() directly on arrays — independent of Vector<T>.
            // Purpose: catch bugs in the algorithms themselves (not the Vector wrapper).

            Console.WriteLine("\n\n ------------------- STEP 6: Direct Array Tests ------------------- ");

            // --- Test M: Sort an already-sorted array (BubbleSort best case, should not disturb order)
            try
            {
                Console.WriteLine("\nTest M: BubbleSort on an already-sorted int array (ascending):");
                int[] sorted = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                new BubbleSort().Sort(sorted, 0, sorted.Length, new AscendingIntComparer());
                bool pass = true;
                for (int i = 0; i < sorted.Length - 1; i++) if (sorted[i] > sorted[i + 1]) { pass = false; break; }
                Console.WriteLine(" :: " + (pass ? "SUCCESS (already-sorted input stays sorted)" : "FAIL"));
                result += pass ? "M" : "-";
            }
            catch (Exception e) { Console.WriteLine(" :: FAIL\n" + e); result += "-"; }

            // --- Test N: Sort a reverse-sorted array (worst case for all three algorithms)
            try
            {
                Console.WriteLine("\nTest N: InsertionSort on a reverse-sorted array (worst case):");
                int[] rev = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                new InsertionSort().Sort(rev, 0, rev.Length, new AscendingIntComparer());
                bool pass = true;
                for (int i = 0; i < rev.Length - 1; i++) if (rev[i] > rev[i + 1]) { pass = false; break; }
                Console.WriteLine(" :: " + (pass ? "SUCCESS" : "FAIL"));
                result += pass ? "N" : "-";
            }
            catch (Exception e) { Console.WriteLine(" :: FAIL\n" + e); result += "-"; }

            // --- Test O: Sort a single-element array (edge case — nothing to sort)
            try
            {
                Console.WriteLine("\nTest O: SelectionSort on a single-element array:");
                int[] single = { 42 };
                new SelectionSort().Sort(single, 0, 1, new AscendingIntComparer());
                bool pass = single[0] == 42;
                Console.WriteLine(" :: " + (pass ? "SUCCESS" : "FAIL"));
                result += pass ? "O" : "-";
            }
            catch (Exception e) { Console.WriteLine(" :: FAIL\n" + e); result += "-"; }

            // --- Test P: Sort only a sub-range of the array (index and num matter)
            try
            {
                Console.WriteLine("\nTest P: BubbleSort on a sub-range [index=2, num=4] — elements outside range must not move:");
                int[] arr = { 99, 88, 5, 3, 4, 1, 77, 66 };
                new BubbleSort().Sort(arr, 2, 4, new AscendingIntComparer());
                // Elements at index 2..5 should be sorted ascending; 99, 88 at start and 77, 66 at end untouched
                bool pass = arr[0] == 99 && arr[1] == 88 &&
                            arr[2] <= arr[3] && arr[3] <= arr[4] && arr[4] <= arr[5] &&
                            arr[6] == 77 && arr[7] == 66;
                Console.WriteLine(" :: " + (pass ? "SUCCESS" : "FAIL"));
                result += pass ? "P" : "-";
            }
            catch (Exception e) { Console.WriteLine(" :: FAIL\n" + e); result += "-"; }

            // --- Test Q: Sort strings with InsertionSort (tests generic type K, not just int)
            try
            {
                Console.WriteLine("\nTest Q: InsertionSort on a string array (generic type test):");
                string[] words = { "banana", "apple", "cherry", "date", "apricot" };
                new InsertionSort().Sort(words, 0, words.Length, StringComparer.Ordinal);
                bool pass = true;
                for (int i = 0; i < words.Length - 1; i++)
                    if (string.Compare(words[i], words[i + 1], StringComparison.Ordinal) > 0) { pass = false; break; }
                Console.WriteLine(" :: " + (pass ? "SUCCESS" : "FAIL"));
                result += pass ? "Q" : "-";
            }
            catch (Exception e) { Console.WriteLine(" :: FAIL\n" + e); result += "-"; }

            // --- Test R: Null array must throw ArgumentNullException
            try
            {
                Console.WriteLine("\nTest R: BubbleSort with null array — expects ArgumentNullException:");
                new BubbleSort().Sort<int>(null, 0, 5, new AscendingIntComparer());
                Console.WriteLine(" :: FAIL (no exception thrown)");
                result += "-";
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine(" :: SUCCESS (ArgumentNullException thrown correctly)");
                result += "R";
            }
            catch (Exception e) { Console.WriteLine(" :: FAIL (wrong exception type)\n" + e); result += "-"; }

            // --- Test S: Negative index must throw ArgumentOutOfRangeException
            try
            {
                Console.WriteLine("\nTest S: SelectionSort with negative index — expects ArgumentOutOfRangeException:");
                int[] arr = { 1, 2, 3 };
                new SelectionSort().Sort(arr, -1, 2, new AscendingIntComparer());
                Console.WriteLine(" :: FAIL (no exception thrown)");
                result += "-";
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine(" :: SUCCESS (ArgumentOutOfRangeException thrown correctly)");
                result += "S";
            }
            catch (Exception e) { Console.WriteLine(" :: FAIL (wrong exception type)\n" + e); result += "-"; }

            // --- Test T: index + num beyond array length must throw ArgumentException
            try
            {
                Console.WriteLine("\nTest T: InsertionSort with index+num out of bounds — expects ArgumentException:");
                int[] arr = { 1, 2, 3 };
                new InsertionSort().Sort(arr, 1, 5, new AscendingIntComparer());
                Console.WriteLine(" :: FAIL (no exception thrown)");
                result += "-";
            }
            catch (ArgumentException)
            {
                Console.WriteLine(" :: SUCCESS (ArgumentException thrown correctly)");
                result += "T";
            }
            catch (Exception e) { Console.WriteLine(" :: FAIL (wrong exception type)\n" + e); result += "-"; }

            // --- Test U: null comparer falls back to Comparer<K>.Default
            try
            {
                Console.WriteLine("\nTest U: BubbleSort with null comparer — should use default comparer:");
                int[] arr = { 5, 3, 1, 4, 2 };
                new BubbleSort().Sort(arr, 0, arr.Length, null);
                bool pass = true;
                for (int i = 0; i < arr.Length - 1; i++) if (arr[i] > arr[i + 1]) { pass = false; break; }
                Console.WriteLine(" :: " + (pass ? "SUCCESS" : "FAIL"));
                result += pass ? "U" : "-";
            }
            catch (Exception e) { Console.WriteLine(" :: FAIL\n" + e); result += "-"; }

            Console.WriteLine("\n\n ------------------- FULL SUMMARY ------------------- ");
            Console.WriteLine("Tests passed: " + result);
            Console.ReadKey();
        }
    }
}
