class Program
{
    /// <summary>
    /// check if a number is a prime number
    /// </summary>
    public static bool isPrime(int num)
    {
        if (num < 0) return false;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0) return false;
        }

        return true;
    }

    public static void doExercice1()
    {
        int num = Session1.readInt("Enter a number: ");

        bool isTrue = isPrime(num);
        // output the result
        if (isTrue)
        {
            Console.WriteLine(num.ToString() + " is a prime number");
        }
        else
        {
            Console.WriteLine(num.ToString() + " is not a prime number");
        }
    }
}

class Exercice2
{
    /// <summary>
    /// insert a number in a sorted array with keeping array sorted
    /// </summary>
    /// <param name="arr">the source array</param>
    /// <param name="num">the number which you want to insert</param>
    public static void insertInto(int[] arr, int num)
    {

        bool isTrue = false;
        int next = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {   
            // if (num < arr[i]) start shifting
            if ((num < arr[i]) && !isTrue)
            {
                next = arr[i];
                arr[i] = num;
                isTrue = true;
                i++;
            }

            if (isTrue)
            {
                // save the current value for next and assign last value at the current position 
                int swap = arr[i];
                arr[i] = next;
                next = swap;
            }
        }

        arr[arr.Length - 1] = (!isTrue) ? num : next;
    }
    public static void doExercice2()
    {
        // this is just for testing
        int[] arr = new int[7];
        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        arr[3] = 4;
        arr[4] = 5;
        arr[5] = 6;

        int num = Session1.readInt("Enter a number: ");

        insertInto(arr, num);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("arr[" + i + "] = " + arr[i]);
        }
        
    }
}

class Session1
{
    /// <summary>
    /// Read an integer from console with posibility of adding a message before
    /// </summary>
    /// <param name="msg"></param>
    /// <returns></returns>
    public static int readInt(string msg = "")
    {
        string input = "";
        int num;
        do
        {
            Console.Write(msg);
            input = Console.ReadLine();

        } while (!int.TryParse(input, out num));

        return num;
    }

    public static void Main()
    {
        Program.doExercice1();
        Exercice2.doExercice2();
    }
}