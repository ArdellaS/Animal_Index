using System;
using System.Collections;
using System.Collections.Generic;



namespace Exercise35
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "cow", "elephant", "jaguar", "horse", "crow" };
            int[] nums = new int[2];
            Console.WriteLine("Welcome");
            do
            {
                nums = NFromUser();

            } while (!InRange(nums, animals));

            int first = nums[0];
            int second = nums[1];
            Console.WriteLine($"The animal at index: {first+1} is {animals[first]}.\nThe letter at index {second + 1} is {animals[first][second]}");
        }

        static bool InRange(int[] nums, string[] animals)
        {
            int first = nums[0];
            int second = nums[1];

            if (first >= animals.Length || first < 0)
            {
                Console.WriteLine("First index number out of range.");
                return false;
            }
            if (second >= animals[first].Length || second < 0)
            {
                Console.WriteLine("Second index number not in range");
                return false;
            }
            return true;
        }

        private static int[] NFromUser()
        {
            int[] output = new int[2];
            bool done = false;

            while (!done)
            {
                Console.Write("Enter two indices: ");
                string rawUserInput = Console.ReadLine();
                string[] userInputStrings = rawUserInput.Split(" ");

                for (int i = 0; i < output.Length; i++)
                {
                    if (!int.TryParse(userInputStrings[i], out output[i]))
                    {
                        Console.Write("Please give two valid positive indicies, seperated by a space.");
                        done = false;
                    }
                    else
                    {
                        //reducing user input uhhh to creature valid index notation or something like that. whatever note works best for you
                        output[i]--;
                        done = true;

                    }
                }
            }
            return output;

        }
    }
}
