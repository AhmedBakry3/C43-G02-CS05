using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Session5
{
    internal class Program
    {

        #region Question 1 functions

        // Value type parameters [Passing by value] suitable c# example

        public static void SwapByValue(int X, int Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
        }

        // Value type parameters [Passing by reference] suitable c# example

        public static void SwapByReference(ref int X, ref int Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
        }


        #endregion

        #region Question 2 Functions

        // Value type parameters [Passing by value] suitable c# example

        public static int SumArrayByValue(int[] Numbers)
        {
            int sum = 0;
            Numbers= new int []{10,20,30,40};
            for (int i = 0; i <Numbers.Length; i++)
            {
                sum += Numbers[i];
            }
            return sum;

        }

        // Value type parameters [Passing by Reference] suitable c# example

        public static int SumArrayByReference(ref int[] Numbers)
        {
            int sum = 0;
            Numbers = new int[] { 10, 20, 30, 40 };
            for (int i = 0; i < Numbers.Length; i++)
            {
                sum += Numbers[i];
            }
            return sum;

        }

        #endregion

        #region  Question 3 Function
        public static void SumSub(int X, int Y, out int Sum , out int sub)
        {
            Sum = X + Y;
            sub = X - Y;
        }

        #endregion

        #region Question 4 Function 

        public static int SumOfDigits(int number)
        {
            int sum = 0;

            number = Math.Abs(number);

            while (number > 0)
            {
                sum += number % 10;  
                number /= 10;         
            }

            return sum;
        }



        #endregion

        #region Question 5 Function

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false; 
                }
            }

            return true; 
        }
        #endregion

        #region Question 6 Function

        public static void MinMaxArray(int[] numbers, ref int min, ref int max)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("Array can't be empty");
            }

            min = numbers[0];
            max = numbers[0];

            foreach (int number in numbers)
            {

                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number; 
                }
            }
        }
        #endregion

        #region Question 7 Function 

        public static int Factorial(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Factoiral can't be Negtive Number");
            }

            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;  
            }

            return result;
        }


        #endregion


        #region Question 8 Function
        public static string ChangeChar(string input, int index, char newChar)
        {
            if (index < 0 || index >= input.Length)
            {
                Console.WriteLine("Invalid index");
            }

            char[] charArray = input.ToCharArray();

            charArray[index] = newChar;

            return new string(charArray);
        }


        #endregion

        static void Main(string[] args)
        {
            #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a .

            // Value type parameters [Passing by value] => it just take a copy from variables and work with it in the function but it only modify in the function (in the function stack frame you will find paramters , local varaibles ) , nothing is modified in the original array (its like an information but you can't change it)

            // Value type parameters [Passing by reference] => it take the address of the variables and they act as the same Variable ( (Refernce | array)= Object) ( in the function stack frame you will find local variables only because paramters acts as original array in the function time) (and you will find the object in the heap) , as they refers to the same location(address) so if you modify anything in the function , the original array will be modified (its like an information but you can change it)


            // Value type parameters [Passing by value] suitable c# example 
            int A = 10;
            int B = 5;
            Console.WriteLine($"A = {A}"); //10
            Console.WriteLine($"B = {B}"); //5
            SwapByValue(A, B); //Passing by value
            Console.WriteLine($"A = {A}"); //10
            Console.WriteLine($"B = {B}"); //5

            // As you can see here in passing by value the values of A and B remain unchanged ,  the swap happened in the function , but it didnt modify the original array and swap didnt happen in the original array as it just take a copy from varaibles



            //Value type parameters[Passing by Reference] suitable c# example 
            int A = 10;
            int B = 5;
            Console.WriteLine($"A = {A}"); //10
            Console.WriteLine($"B = {B}"); //5
            SwapByReference(ref A, ref B); //Passing by Reference
            Console.WriteLine($"A = {A}"); //5
            Console.WriteLine($"B = {B}"); //10

            //// As you can see here in passing by Reference the values of A and B changed , the swap happened in the function , and it modified the original array and swap happened in the original array as they are the same and they refers to the same address 

            #endregion

            #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.


            // Reference type parameters [Passing by value] => they refers to the same address ( Refernce = array= Object) ,(in the function stack frame you will find paramters , local varaibles ) ( and you will find the object in the heap), the changes that happen in the function ,it will modify the original array (unless you reassigned array inside the function so you can't modify the original reference , it has the same reference passed but it cant change the reference itself )

            // Reference type parameters [Passing by Reference] => it take the address of the variables and they act as the same Variable ( (Refernce | array)= Object) ( in the function stack frame you will find local variables only because paramters acts as original array in the function time) ( and you will find the object in the heap) , the changes that happen in the function , it will modify the original array  (even if you reassigned the array inside the function it will affect the original reference , it can change the reference itself)



            //Reference type parameters[Passing by Value] suitable c# example 
            int[] Numbers = new int[] { 1, 2, 3, 4 };
            int result = SumArrayByValue(Numbers);
            Console.WriteLine(result); //100
            Console.WriteLine(Numbers[0]); //1

            //As the you can see in Passing by Value when we reassigned the array inside the function it didnt modify the original reference 


            //Reference type parameters[Passing by Reference] suitable c# example 
            int[] Numbers = new int[] { 1, 2, 3, 4 };
            int result = SumArrayByReference(ref Numbers);
            Console.WriteLine(result); //100
            Console.WriteLine(Numbers[0]); //10

            //As you can see in Passing by Reference when we reassigned the array inside the function , it modified the original refernce 

            #endregion

            #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            Console.Write("Please Enter the first Number : ");
            bool input1 = int.TryParse(Console.ReadLine(), out int A);

            Console.Write("Please Enter the Second Paramters : ");
            bool input2 = int.TryParse(Console.ReadLine(), out int B);

            int sumResult;
            int subResult;
            if (input1 && input2)
            {
                SumSub(A, B, out sumResult, out subResult);

                Console.Clear();

                Console.WriteLine($"Sum = {sumResult}");
                Console.WriteLine($"Sub = {subResult}");
            }
            else
            {
                Console.WriteLine("Invalid input , Please Enter a valid Numbers");
            }


            #endregion

            #region 4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            ///Output should be like
            ///Enter a number: 25
            ///The sum of the digits of the number 25 is: 7

            Console.Write("Enter a number: "); //25

            int.TryParse(Console.ReadLine(), out int number);

            int sum = SumOfDigits(number);

            Console.WriteLine($"The sum of the digits of the number {number} is: {sum}"); //7


            #endregion

            #region 5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not.

            Console.WriteLine($"Your Number return {IsPrime(6)}"); //Your Number return False

            Console.WriteLine($"Your Number return {IsPrime(7)}"); //Your Number return True
            #endregion

            #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            int[] numbers = { 3, 1, 7, 9, 2, 8, 5 };

            int min = 0;
            int max = 0;

            MinMaxArray(numbers, ref min, ref max);

            Console.WriteLine($"Maximum value: {max}"); // Output: 9
            Console.WriteLine($"Minimum value: {min}"); // Output: 1

            #endregion

            #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            int number = 5;

            int factorial = Factorial(number);
            Console.WriteLine($"Factorial of {number} = {factorial}"); //Factorial of 5  = 120

            #endregion

            #region 8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            string originalString = "Route Academy";

            string modifiedString = ChangeChar(originalString, 6, 'P');

            Console.WriteLine($"Original String: {originalString}"); //Route Academy
            Console.WriteLine($"Modified String: {modifiedString}"); //Route Pcademy



            #endregion

        }
    }
}
