namespace ConsoleAppAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Task 1*/

            //int[] array = { 4, 6, 7, 2, 4, 10, 8, 10, 4, 2, 6, 8, 2, 5, 7 };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    int count = 1;
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine("Number " + array[i] + " repeated  " + count + "times");
            //}



            /*Task 2*/

            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            int currentIndex = 0;

            while (currentIndex < size)
            {
                Console.WriteLine("Do you want to add an element? (yes(y)/no(n))");
                string response = Console.ReadLine();

                if (response == "yes" || response == "y")
                {
                    Console.WriteLine("Enter the element: ");
                    array[currentIndex] = Convert.ToInt32(Console.ReadLine());

                    currentIndex++;
                }
                else if (response == "no" || response == "n")
                {
                    Console.WriteLine("Program stopped");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter yes/y or no/n.");
                }
            }
            Console.WriteLine("Array elements: ");
            for (int i = 0; i < currentIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();

        }
    }
}