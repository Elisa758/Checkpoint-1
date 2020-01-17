using System;

namespace Checkpoint_1
{
    class Program
    {
        static int[] ArrayIntUsers()
        {
            Console.WriteLine("Enter a number for the length of your array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] usersArray = new int[n];
            for (int i = 0; i < usersArray.Length; i++)
            {
                Console.WriteLine("Enter an integer : ");
                usersArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < usersArray.Length; i++)
            {
                Console.WriteLine(usersArray[i]);
            }
            return usersArray;
        }

        static int SumArrray(int[] userArray)
        {
            
            int sum = 0; 

            for (int i=0; i<userArray.Length; i++)
            {
                sum = sum + userArray[i];
            }
            return sum;                        
        }

        static float MeanArray (int[] userArray)
        {
            int lengthArray = userArray.Length;
            float mean = (float) SumArrray(userArray) /lengthArray ;
            return mean;

        }

        static int[] AscendingOrderSortArray (int[] userArrayToSort)
        {
            for(int i=0; i<userArrayToSort.Length; i++)
            {
                for(int j=i+1; j< userArrayToSort.Length; j++)
                {
                    if(userArrayToSort[j]<userArrayToSort[i])
                    {
                        int temp = userArrayToSort[i];
                        userArrayToSort[i] = userArrayToSort[j];
                        userArrayToSort[j] = temp;
                    }
                }
            }
            for(int i=0; i<userArrayToSort.Length; i++)
            {
                Console.WriteLine(userArrayToSort[i]);
            }
            return userArrayToSort;
        }
        
        static void Main(string[] args)
        {
            int[] example = ArrayIntUsers();
            
            int sum = SumArrray(example);
            Console.WriteLine("sum = " + sum);

            float mean = MeanArray(example);
            Console.WriteLine("mean = " + mean);

            AscendingOrderSortArray(example);



        }
    }
}
