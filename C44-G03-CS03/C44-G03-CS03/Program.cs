
namespace Assignment_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 - Write a program that allows the user to enter a number then print it.

            //int number;
            //Console.Write("Please enter a number: ");
            //bool check = int.TryParse(Console.ReadLine(), out number);
            //Console.Clear();
            //if (check == true)
            //{
            //    Console.WriteLine($"your number is : {number}");
            //}
            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

            //string input = "123abc";
            //// The following line will throw exeption because the string contains non-numeric characters.

            //int result = int.Parse(input);
            //Console.WriteLine($"Converted value: {result}");


            #endregion

            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float a = 1.5f, b = 2.55f, result = a + b;
            //Console.WriteLine(result);
            #endregion

            #region Q4 - Write C# program that Extract a substring from a given string.

            //string input = "ahmed test";
            //Console.WriteLine(input.Substring(6));

            #endregion

            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int a = 20;
            //int b = a;
            //b = 30;
            //Console.WriteLine($"a: {a}, b: {b}");

            #endregion

            #region ******Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //int[] arr01 = { 1, 2, 3, 4, 5 };
            //int[] arr02 = arr01;

            //arr02[1] = 100;

            //Console.WriteLine(arr01[1]);
            //Console.WriteLine(arr02[1]);

            #endregion

            #region Q7 - Write C# program that take two string variables and print them as one variable 

            //string first = "Ahmed";
            //string second = "Behairy";
            //string full = first + " " + second;
            //Console.WriteLine($"Full string: {full}");


            #endregion

            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.

            //double principal = 15;
            //double rate = 5;
            //double time = 2;
            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine(interest);
            #endregion

            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)

            //double weight = 92;
            //double height = 1.82;
            //double bmi = weight / (height * height);
            //Console.WriteLine(bmi);

            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
            ///that below 10 degrees is "Just Cold"
            ///above 30 degrees is "Just Hot"
            ///anything else is "Just Good"

            //Console.Write("Enter the temperature: ");
            //bool isValidInput = int.TryParse(Console.ReadLine(), out int temperature);

            //if (isValidInput)
            //{
            //    string result = (temperature > 30) ? "Just Hot" : (temperature < 10) ? "Just Cold" : "Just good";
            //    Console.WriteLine($"result is : {result}");

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid temperature.");
            //}



            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ///Ex:
            ///Today’s date : 20 , 11 , 2001
            ///Today's date : 20 / 11 / 2001
            ///Today's date : 20 – 11 – 2001

            //Console.Write("Enter the day: ");
            //bool isValidDay = int.TryParse(Console.ReadLine(), out int day);
            //Console.Write("Enter the month: ");
            //bool isValidMonth = int.TryParse(Console.ReadLine(), out int month);
            //Console.Write("Enter the year: ");
            //bool isValidYear = int.TryParse(Console.ReadLine(), out int year);
            //if (isValidDay && isValidMonth && isValidYear && day >= 1 && day <= 31 && month >= 1 && month <= 12)
            //{
            //    Console.WriteLine($"Today's date : {day} , {month} , {year}");
            //    Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //    Console.WriteLine($"Today's date : {day} - {month} - {year}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter valid date");
            //}

            #endregion

            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ///Example(1)
            ///Input: 12
            ///Output: Yes
            ///Example(2)
            ///Input: 9
            ///Output: No

            //Console.Write("Enter a number: ");
            //bool isValidInput = int.TryParse(Console.ReadLine(), out int number);
            //if (isValidInput)
            //{
            //    if (number % 3 == 0 && number % 4 == 0)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}

            #endregion

            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1)
            ///Input: -5
            ///Output: negative
            ///Example(2)
            ///Input: 10
            ///Output: positive

            //Console.Write("Enter an integer: ");
            //bool isValidInput = int.TryParse(Console.ReadLine(), out int number);
            //if (isValidInput)
            //{
            //    if (number < 0)
            //    {
            //        Console.WriteLine("negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("positive");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            #endregion

            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1)
            ///Input: 7,8,5
            ///Output:
            ///max element = 8
            ///min element = 5
            ///Example(2)
            ///Input: 3 6 9
            ///Outputs:
            ///Max element = 9
            ///Min element = 3

            //Console.Write("Enter first integer: ");
            //bool isValidInput1 = int.TryParse(Console.ReadLine(), out int firstNumber);
            //Console.Write("Enter second integer: ");
            //bool isValidInput2 = int.TryParse(Console.ReadLine(), out int secondNumber);
            //Console.Write("Enter third integer: ");
            //bool isValidInput3 = int.TryParse(Console.ReadLine(), out int thirdNumber);
            //if (isValidInput1 && isValidInput2 && isValidInput3)
            //{
            //    if (firstNumber > secondNumber && firstNumber > thirdNumber)
            //    {
            //        Console.WriteLine($"Max element = {firstNumber}");
            //    }
            //    else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            //    {
            //        Console.WriteLine($"Max element = {secondNumber}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Max element = {thirdNumber}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter valid integers.");
            //}


            #endregion

            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.Write("Enter an integer number: ");
            //bool isValidInput = int.TryParse(Console.ReadLine(), out int number);
            //if (isValidInput)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("Even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Odd");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant

            //Console.Write("Enter a character: ");
            //bool isValidInput = char.TryParse(Console.ReadLine(), out char character);
            //if (isValidInput)
            //{
            //    character = char.ToLower(character); // Convert to lowercase for easier comparison
            //    if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            //    {
            //        Console.WriteLine("vowel");
            //    }
            //    else
            //    {
            //        Console.WriteLine("consonant");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid character.");
            //}



            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31

            Console.Write("Enter month number (1-12): ");
            int month = int.Parse(Console.ReadLine());

            int days;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;

                case 2:
                    days = 28;
                    break;

                default:
                    Console.WriteLine("Invalid month number.");
                    return;
            }

            Console.WriteLine("Number of days: " + days);



            #endregion


        }
    }
}