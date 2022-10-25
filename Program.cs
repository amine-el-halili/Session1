class Program
{
    public static void Main()
    {
        string input = "";
        int num = -1;
        
        // check the input if is a number
        do
        {
            Console.Write("Enter a number: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out num) && (num != -1));


        bool isTrue = true;
        for (int i = 2; (i < num) && isTrue; i++)
        {
            if (num % i == 0)
            {
                isTrue = false;
            }
        }

        // output the result
        if (isTrue)
        {
            Console.WriteLine(input + " is a prime number");
        }
        else
        {
            Console.WriteLine(input + " is not a prime number");
        }
    }
}