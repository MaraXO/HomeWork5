using System;


class Program
{
    static void Main()
    {
        // TASK1
        //try
        //{
            
        //    Console.Write("Enter the start of the range: ");
        //    int start = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Enter the end of the range: ");
        //    int end = Convert.ToInt32(Console.ReadLine());

            
        //    Console.WriteLine("All numbers range:");
        //    for (int i = start; i <= end; i++)
        //    {
        //        Console.Write(i + " ");
        //    }
        //    Console.WriteLine();

            
        //    Console.WriteLine("All numbers in the range are in descending order:");
        //    for (int i = end; i >= start; i--)
        //    {
        //        Console.Write(i + " ");
        //    }
        //    Console.WriteLine();

            
        //    Console.WriteLine("All numbers that are multiples of 7:");
        //    for (int i = start; i <= end; i++)
        //    {
        //        if (i % 7 == 0)
        //        {
        //            Console.Write(i + " ");
        //        }
        //    }
        //    Console.WriteLine();

            
        //    int countMultiplesOf5 = 0;
        //    for (int i = start; i <= end; i++)
        //    {
        //        if (i % 5 == 0)
        //        {
        //            countMultiplesOf5++;
        //        }
        //    }
        //    Console.WriteLine("The number of numbers that are multiples of 5: " + countMultiplesOf5);
        //}
        //catch (FormatException)
        //{
        //    Console.WriteLine("Error: Incorrect number entered.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Error: " + ex.Message);
        //}

        //TASK2

        try
        {
            
            Console.Write("Enter the start of the range: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the end of the range: ");
            int end = Convert.ToInt32(Console.ReadLine());

            if (start > end)
            {
                Console.WriteLine("The start of the range must be less than or equal to the end of the range.");
                return;
            }


            int sumEven = 0, sumOdd = 0, sumMultiplesOf9 = 0;
            int countEven = 0, countOdd = 0, countMultiplesOf9 = 0;

            
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += i;
                    countEven++;
                }
                else
                {
                    sumOdd += i;
                    countOdd++;
                }

                if (i % 9 == 0)
                {
                    sumMultiplesOf9 += i;
                    countMultiplesOf9++;
                }
            }

            double avgEven = countEven > 0 ? (double)sumEven / countEven : 0;
            double avgOdd = countOdd > 0 ? (double)sumOdd / countOdd : 0;
            double avgMultiplesOf9 = countMultiplesOf9 > 0 ? (double)sumMultiplesOf9 / countMultiplesOf9 : 0;

            
            Console.WriteLine("Sum of even numbers: " + sumEven);
            Console.WriteLine("Sum of odd numbers: " + sumOdd);
            Console.WriteLine("Sum of numbers that are multiples of 9: " + sumMultiplesOf9);

            Console.WriteLine("Arithmetic average of even numbers: " + avgEven);
            Console.WriteLine("Arithmetic average of odd numbers: " + avgOdd);
            Console.WriteLine("Arithmetic average of numbers that are multiples of 9: " + avgMultiplesOf9);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Incorrect number entered.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }





    }
}