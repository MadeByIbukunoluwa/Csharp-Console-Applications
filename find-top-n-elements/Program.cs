

public class Algo
{
    public static void Main()
    {
        int[] testarr = { 87, 21, 34, 21, 35, 6, 39, 19, 0, -2, 34, 98 };
        //int[] testarr1 = { 87, 00, 54, 74, 890, 12, 39, 87, 0, -2, 34, 98 };
        //int[] testarr2 = { 87, 21, 34, 21, 31, 6, 39, 54, 0, -2, 34, 98 };
        int no = 3;
        getNMaxelements(testarr, no);

        // BubbleSort
        // Time complexity O(n^2) + O(n)
    }
        public static bool isDigit(string number)
        {
            bool isDigit;

            isDigit = int.TryParse(number, out int num);

            if (isDigit == false)
            {
                Console.WriteLine("Please enter a valid number");
            }

            return isDigit;
        }

        public static bool isLarger(int[] arr,string number)
        {
            bool isLarger;

            isLarger = int.Parse(number) > arr.Length;

            if (isLarger == true)
            {
                Console.WriteLine("Please enter a value of N lower than the length of the array");
            }
            return isLarger;
        }

        internal static int[] GetArray()
        {
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
            return arr;
        }

        internal static int GetN(int[] arr)
        {
            string number;
            int newNumber;

            Console.WriteLine("Enter a number of n Max Elements you want to find");
            //check if n number of elements is greater than array length 
            do
            {
                number = Console.ReadLine();
                Algo.isLarger(arr,number);
                Algo.isDigit(number);
            }
            while (Algo.isDigit(number) == false && Algo.isLarger(arr, number)); 

            newNumber = int.Parse(number);

            return newNumber;
        }


        public static void getNMaxelements(int[] arr, int n)
        {
            int i, j = 0,temp;
            //List<int> list; 
            arr = Algo.GetArray();
            n = Algo.GetN(arr);

        for (i = 0; i < arr.Length - 1; i++)
        {
            for (j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        for (int k = 0; k < n; k++)
        {
            Console.WriteLine(arr[arr.Length - 1 - k]);
        }
    }
}

// two exceptions to handle 