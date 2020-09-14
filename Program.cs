using System;

namespace Rosa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Always the variables at the top
            bool runMenu = true;
            string userInput;

            // Save big strings in a variable so it's more simple when they are neeeded
            string welcomeMessage = "-----------------Welcome!-----------------\n" + "I'm HAM (Happily Automated Mathematician). \n" +
                "How may I be of assistance today? \n" + "Press any key to continue";

            WriteLine(welcomeMessage);
            Console.ReadKey();

            do
            {
                // An array filled with objects
                object[] arr = new object[5]; 
                arr[0] = "Addition"; 
                arr[1] = "Subtracion"; 
                arr[2] = "Multiplication"; 
                arr[3] = "Division"; 
                arr[4] = "Exit"; 

                Console.Clear();
                // Loop through the array 
                for(var i = 0; i < arr.Length; i++){
                    WriteLine(i+1 + " for: " + arr[i]);
                }

                WriteLine("Please select number and hit enter");
                // Console.Write("------Calculator Menu------\n" +
                //     "Enter 1 for Addition. \n" +
                //     "Enter 2 for Subtracion.\n" +
                //     "Enter 3 for Multiplication\n" +
                //     "Enter 4 for Division.\n" +
                //     "Enter Quit to exit.\n" +
                //     "Selection:");

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                       Addition();
                        break;

                    case "2":
                        Subtraction();
                        break;

                    case "3":
                        Multiplication();
                        break;

                    case "4":
                        Division();
                        break;

                    case "quit":
                    case "Quit":
                        runMenu = false;
                        break;

                    default:
                        WriteLine("Not a valid input. Please try again.");
                        WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }
            while (runMenu);


        }

         static double TextToNumber(string textNumber)
         {
            double number = 0.0;

            double.TryParse(textNumber, out number);

            return number;
         }
        static void Addition()
        {
            double numberOne;
            double numberTwo;
            double additionResult;
            string additionString = "--------Addition--------";
            string additionMessage = "Please enter the number that you wish to add: ";
            string additionMessageResult = "That adds up to: ";

                Console.Clear();
                WriteLine(additionString);
                PleaseEnterNum();

                    numberOne = TextToNumber(Console.ReadLine());

                    WriteLine(additionMessage);
                    numberTwo = TextToNumber(Console.ReadLine());

                additionResult = numberOne + numberTwo;

            WriteLine(additionMessageResult + additionResult);
          
            BackToMainMenu();

        }

         static void Subtraction()
         {
            double numberOne;
            double numberTwo;
            double subtractionResult;
            string subtractionString = "------Subtraction------";
            string subtractionMessage = "Please enter the number that you wish to subtract: ";
            string subtractionMessageResult = "That subtracts to: ";

                Console.Clear();
                WriteLine(subtractionString);
                PleaseEnterNum();
           
                    numberOne = TextToNumber(Console.ReadLine());

                    WriteLine(subtractionMessage);

                    numberTwo = TextToNumber(Console.ReadLine());

                subtractionResult = numberOne - numberTwo;

            WriteLine(subtractionMessageResult + subtractionResult);
            
            BackToMainMenu();

        } 

         static void Multiplication()
         {
            double numberOne;
            double numberTwo;
            double multiplicationResult;
            string multiplicationString = "--------Multiplication--------";
            string multiplicationMessage = "Please enter the number that you wish to multiply with: ";
            string multiplicationMessageResult = "That multiplies to: ";

                Console.Clear();
                WriteLine(multiplicationString);
                PleaseEnterNum();
            
                    numberOne = TextToNumber(Console.ReadLine());

                    WriteLine(multiplicationMessage);
                    numberTwo = TextToNumber(Console.ReadLine());

                multiplicationResult = numberOne * numberTwo;

            WriteLine(multiplicationMessageResult + multiplicationResult);
            
            BackToMainMenu();

        } 
         static void Division()
         {
            double numberOne;
            double numberTwo;
            double divisionResult;
            string divisionString = "--------DIVISION--------";
            string divisionMessage = "Please enter the number that you wish to divide by: ";
            string divisionMessageResult = "That divides to: ";
            string divisionErrorString = "I'm sorry, you can not divide by zero. Please try another number:";

            Console.Clear();
            WriteLine(divisionString);
            PleaseEnterNum();
            numberOne = TextToNumber(Console.ReadLine());

                WriteLine(divisionMessage);
                numberTwo = TextToNumber(Console.ReadLine());

                    if (numberTwo == 0.0 )
                    {
                        WriteLine(divisionErrorString);
                        numberTwo = TextToNumber(Console.ReadLine());
                    }

            divisionResult = numberOne / numberTwo;

            WriteLine(divisionMessageResult + divisionResult);
            BackToMainMenu();

         }
        static void PleaseEnterNum()
        {
            WriteLine("Please enter a number: ");
        }

        static void BackToMainMenu()
        {
            WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
