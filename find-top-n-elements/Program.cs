
using System.Text.RegularExpressions;
public class Algo
{
    public static void Main()
    {

        getNMaxelements();
        // BubbleSort
        // Time complexity O(n^2) + O(n)
    }
        public static bool isDigit(string number)
        {
            bool isDigit;

            isDigit = int.TryParse(number, out int num);

           try
            {
            if (isDigit == false)
            {
                throw new Exception("Please enter a valid number");
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return isDigit;
        }

        public static bool isLarger(int[] arr,string number)
        {
            bool isLarger;

            isLarger = int.Parse(number) > arr.Length;
            try
            {
            if (isLarger == true)
            {
                throw new Exception("Please enter a value of N lower than the length of the array");
            }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isLarger;
        }

        internal static int[] GetArray()
        {
            Console.WriteLine("Enter the numbers you want to input in a comma separated string");

            //string[] inputarray;

            int[] array;

        //var regex = new Regex(@"\d+,?");

        //inputarray = Console.ReadLine().Split(",");

        //foreach (string str in inputarray)
        //{

        //}

        //while ()
        //{

        //}

        //Algo.GetN(arr);

        //return arr;
        int[] arr = Array.Empty<int>();

        while (true)
        {
            Console.WriteLine("Enter an element to the array (or enter 'stop' to finish)");
            string input = Console.ReadLine();
            if (input == "stop")
            {
                break;
            }
            int element = int.Parse(input);

            Array.Resize(ref arr, arr.Length + 1);

            arr[arr.Length - 1] = element;
        }

        Algo.GetN(arr);

        return arr;
    }

    internal static int GetN(int[] arr)
        {
            string number;
            int newNumber;

                   Console.WriteLine("Enter a number of n Max Elements you want to find");
                   number = Console.ReadLine();

                   newNumber = int.Parse(number);

                   Algo.isLarger(arr, number);

                   return newNumber;   
        }


        public static void getNMaxelements()
        {
       int i, j, n, temp;

            int[] result;

            int[] arr;

            arr = Algo.GetArray();

            n = Algo.GetN(arr);

            List<int> fromarr = arr.ToList();

            List<int> nMaxElementsList = new List<int>(n);

            for (i = 0; i < n; i++)
            {
                int maxIndex = i;
                for (j = i + 1; j < fromarr.Count; j++)
                {
                    if (fromarr[j] > fromarr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                nMaxElementsList.Add(fromarr[maxIndex]);

                fromarr[maxIndex] = fromarr[i];

            }
            result = nMaxElementsList.ToArray();

            for (int k = 0; k < result.Length; k++)
            {
                Console.WriteLine(result[k]);
            }
        }
}

// two exceptions to handle
//getn wouldnt get the value of the array until it has reached get max elements 