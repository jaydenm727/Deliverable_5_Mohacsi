/*
Name: Jayden Mohacsi
Date: 02/09/2023
Description: Randomly populate array with a specified length, then sum the items in the array
*/
namespace Deliverable_5_Mohacsi
{
    internal class Program
    {
        static int[] MethodOne(int x)
        {
            int[] randomArray = new int[x];
            Random random = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(15);
            }
            return randomArray;
        }

        static int MethodTwo(int[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int myInt;
            while (true)
            {
                Console.WriteLine("Please enter an integer between 5 and 15.");
                try
                {
                    myInt = int.Parse(Console.ReadLine());
                    if(myInt >= 5 && myInt <= 15)
                    {
                        break;
                    }
                }
                catch{}
            }

            int[] retunedArray = MethodOne(myInt);
            
            Console.WriteLine("The elements of the array are: " + String.Join(", ", retunedArray) + "\r\n");

            int returnedSum = MethodTwo(retunedArray);
            
            Console.WriteLine("The sum of the array is: " + returnedSum);
        }
    }
}