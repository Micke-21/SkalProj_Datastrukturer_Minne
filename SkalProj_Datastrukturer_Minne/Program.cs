namespace SkalProj_Datastrukturer_Minne
{
    //UnresolvedMergeConflict   Testar vilka
    //UNDONE                    "Todo" taggar
    //HACK                      som finns!
    //TODO                      Verkar som det går att skapa egna taggar i betalvarianterna av VS.

    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"

                    + "\n5. RecursiveEven"
                    + "\n6. Recursive Fibonacci "
                    + "\n7.   Recursive Fibonacci series"
                    + "\n8. Iterative even"
                    + "\n9. Iterative Fibonacci"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.

                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     * 
                     */
                    case '5':
                        CheckRecusion();
                        break;
                    case '6':
                        FibonacciCalc();
                        break;
                    case '7':
                        FibonacciSeries();
                        break;
                    case '8':
                        CheckIterativeEven();
                        break;
                    case '9':
                        ItertiveFibonacciSeries();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }


        /// <summary>
        /// Övning 1
        /// Examines the datastructure List
        /// <ToDO></ToDO>
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            Console.WriteLine($"Enter word to add + or remove -");
            string input = Console.ReadLine();
            Console.WriteLine("List Capacity: {0}", theList.Capacity);
            while (input != "")
            {
                char nav = input[0]; // ?? 'x';

                string value = input.Substring(1); //input.getvalueordefault()
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        break;
                    default:
                        Console.WriteLine("Input have to strat whit + or -");
                        break;

                }
                Console.WriteLine($"Elements in list {theList.Count}, List Capacity: {theList.Capacity} ");
                input = Console.ReadLine();
            }
            //ToDo 1.2 När övar listans kapacitet? När den blir full och nästa element skall läggas till.
            //ToDo 1.3 Med hu mycket ökar kapacitetien? 4 första gången, sen 8, 16, 32 resp 64. Så den verkar fördubblas! Är inte det dumt när den blir stor? 
            //ToDo 1.4 Varför ökar inte kapacitet i samma takt som element läggs till?
            //      Antar att det har något med att det tar resurser att utöka det så då blir det väl effektivare att göra det i block!
            //ToDo 1.5 Minskal Kapaciteten när element tas bort ur listan? Nej
            //ToDo 1.6 När är det då fördelaktigt att använda en egendefinierad array istälet för en lista?
            //      Använd en Array när jag vet på förhand hur många element man behöver...


            //HACK theList.TrimExcess(), theList.Clear() bra att hafunktioner till en lista :-)
        }


        /// <summary>
        /// Övning 2
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            var q = new Queue<string>();

            q.Enqueue("Kalle");
            Console.WriteLine("Kalle ställde sig i kön, {0} i kö.", q.Count);
            q.Enqueue("Greta");
            Console.WriteLine("Greta ställde sig i kön, {0} i kö.", q.Count);

            Console.WriteLine($"{q.Dequeue()} lämnar kassan, nu {q.Count} i kö.");

            q.Enqueue("Stina");
            Console.WriteLine("Stina ställde sig i kön, {0} i kö.", q.Count);

            Console.WriteLine($"{q.Dequeue()} lämnar kassan, nu {q.Count} i kö.");

            q.Enqueue("Olle");
            Console.WriteLine("Olle ställde sig i kön, {0} i kö.", q.Count);


            Console.WriteLine($"{q.Dequeue()} lämnar kassan, nu {q.Count} i kö.");

            Console.WriteLine($"{q.Dequeue()} lämnar kassan, nu {q.Count} i kö.");

            q.Enqueue("David");
            Console.WriteLine("David ställde sig i kön, {0} i kö.", q.Count);
            q.Enqueue("Demitris");
            Console.WriteLine("Demitris ställde sig i kön, {0} i kö.", q.Count);
            q.Enqueue("Pelle");
            Console.WriteLine("Pelle ställde sig i kön, {0} i kö.", q.Count);
            q.Enqueue("Långben");
            Console.WriteLine("Långben ställde sig i kön, {0} i kö.", q.Count);

            Console.WriteLine($"{q.Dequeue()} lämnar kassan, nu {q.Count} i kö.");

            Console.WriteLine($"{q.Dequeue()} lämnar kassan, nu {q.Count} i kö.");
            Console.WriteLine($"{q.Dequeue()} lämnar kassan, nu {q.Count} i kö.");
            Console.WriteLine($"{q.Dequeue()} lämnar kassan, nu {q.Count} i kö.");

            Console.WriteLine();
        }


        /// <summary>
        /// Övning 3
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            //ToDo 3.1 Varför är det inte så smart att använda en stack i det här fallet? Den som ställde sig först i kön får aldrig betala och gå hem och ha fredagsmys!

            var myStack = new Stack<string>();

            do
            {
                Console.WriteLine("Skriv in en text.");
                var input = Console.ReadLine();

                if (input == "")
                    break;

                foreach (char item in input!)
                {
                    myStack.Push(item.ToString());
                }

                while (myStack.Count > 0) { Console.Write(myStack.Pop()); }

                Console.WriteLine();
            } while (true);

        }


        /// <summary>
        /// Övning 4
        /// Checks Parenthesis in an entered string
        /// </summary>
        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            //Todo 4.1 Vilken datastruktura använder jag: En Stack.


            char[]? leftParenthesis = new char[] { '(', '{', '[', '<' };
            char[]? rightParenthesis = new char[] { ')', '}', ']', '>' };
            Stack<char>? myStack = new();

            Console.WriteLine("Enter a string to investigate:");
            string input = Console.ReadLine();// .Trim();
            char corrispondingParanthesis = ' ';
            bool wellFormatted = true;
            string output = "";

            foreach (char item in input)
            {
                if (leftParenthesis.Contains(item))
                {
                    //push
                    myStack.Push((char)item);
                    //Console.WriteLine($"Number of left paranthesis on the stack {myStack.Count}.");
                }
                else if (rightParenthesis.Contains(item))
                {
                    //Check and pop
                    if (myStack.Count > 0)
                    {
                        switch (myStack.Pop())
                        {
                            case '(':
                                corrispondingParanthesis = ')';
                                break;
                            case '[':
                                corrispondingParanthesis = ']';
                                break;
                            case '{':
                                corrispondingParanthesis = '}';
                                break;
                            case '<':
                                corrispondingParanthesis = '>';
                                break;
                            default:
                                break;
                        }

                        if (corrispondingParanthesis != item)
                        {
                            wellFormatted = false;
                            break;
                        }
                    }
                    else // no left paranthesis left => more right paranthesis than left
                    {
                        wellFormatted = false;
                        break;
                    }
                }
                output += item;
            }

            // check if same amount of paranthesis > 0 => more left than right 
            if (myStack.Count > 0)
                wellFormatted = false;

            if (wellFormatted)
                Console.WriteLine("\nThe string is well formated.\n");
            else
                Console.WriteLine("\nThe string is badly formated.\n");

            Console.WriteLine($"{output}\n");
        }


        /// <summary>
        /// Övning 5.2.1
        /// Used for user input to call the RecursiveEven
        /// </summary>
        private static void CheckRecusion()
        {
            Console.WriteLine("Enter number to calculate n even");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{RecursiveEven(n)}");
        }


        /// <summary>
        /// Övning 5.2.2
        /// Caculates the n Even number by recursion
        /// </summary>
        /// <param name="n">N the number to calculate</param>
        /// <returns>Returns the n even number</returns>
        static int RecursiveEven(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return RecursiveEven(n - 1) + 2;
        }


        /// <summary>
        /// Övning 5.3.1
        /// Startpoint of the Calculation of the Fibonacci number
        /// </summary>
        private static void FibonacciCalc()
        {
            Console.WriteLine("Enter number to fibonacci ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"F({n}) = {Fibonacci(n)} ");
        }


        /// <summary>
        /// Övning 5.3
        /// Calculates the Fibonacci number by Recursion
        /// </summary>
        /// <param name="n">N the number to calculate</param>
        /// <returns>Returna the Fibonaccinumber</returns>
        private static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }


        /// <summary>
        /// Övning 5.3.4 Extra
        /// Calcualtes a series of Fibonacci number by using recursion
        /// Enter a number and it loops and calculate the fibonacci series 
        /// </summary>
        private static void FibonacciSeries()
        {
            var startTime = DateTime.Now;
            var endTime = DateTime.Now - startTime;
            int f;
            Console.WriteLine("Enter number of how long fibonacci series. ");
            int no = int.Parse(Console.ReadLine());
            if (no < 0 || no > 46)
                Console.WriteLine("N must be > 0 and < 47");
            else
            {
                for (int n = 0; n <= no; n++)
                {
                    startTime = DateTime.Now;
                    f = Fibonacci(n);
                    endTime = DateTime.Now - startTime;

                    //Console.WriteLine($"F({n:D3}) = {f:D10} at time {endTime}");
                    Console.WriteLine($"F({n:D}) = {f:D} at time {endTime}");
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Övning 6.2.1
        /// Methode for get the input and call the Calculate n Even
        /// </summary>
        private static void CheckIterativeEven()
        {
            Console.WriteLine("Enter number to calculate even ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"The even value for n {n} är {IterativeEven(n)}");
        }


        /// <summary>
        /// Övning 6.2.2
        /// Calculates the n Even number
        /// </summary>
        /// <param name="n">N the number to iterate</param>
        /// <returns>Returns the n even number</returns>
        private static int IterativeEven(int n)
        {
            if (n == 0) return 0;

            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                result += 2;
            }
            return result;
        }


        /// <summary>
        /// Övning 6.3.1
        /// Testing of the interactive FibonacciSeries
        /// </summary>
        private static void ItertiveFibonacciSeries()
        {
            Console.WriteLine("Enter number to fibonacci ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"F({n}) = {IterativeFibonacci(n)} \n");


            //Testing 
            //for (int n = 0; n <= 100; n++)
            //    Console.WriteLine($"F({n}) = {IterativeFibonacci(n)} ");

            //TODO värdet kan bli större än vad en int kan hantera och då blir det negativt! Går det att kolla? Ja använd checked()

        }
        /*
         * 
         * ToDO 6 Fråga: Utgå ifrån era nyvunna kunskaper om iteration, rekursion och minneshantering. Vilken av
         * ovanstående funktioner är mest minnesvänlig och varför?
         * I iterationsvarianten används variabler som loopas och gör beräkningar..
         * I Rekursionsvarianden skapas ett nytt metodanrop ("object") för varje iteration i bräkningen så därför är denna metod mer minneskrävande. 
         * 
         * 
        */


        /// <summary>
        /// Övning 6.3.2
        /// Calculates the n fibonacci number by iteration
        /// </summary>
        /// <param name="n">N the number to calculate</param>
        /// <returns>Returns the n fibonacci number</returns>
        private static ulong IterativeFibonacci(int n)
        {
            ulong fn = 1, f1 = 0, f2 = 1;
            ulong result;

            if (n == 0)
                result = 0;
            else if (n == 1)
                result = 1;
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    try
                    {
                        fn = checked(f1 + f2);
                        f1 = f2;
                        f2 = fn;
                    }
                    catch (OverflowException oe)
                    {
                        Console.WriteLine($"The number ({n}) give to big result!! {oe.Message}");
                        break;
                    }
                }
                result = fn;
            }

            return result;

            //Hämtat hjälp från nätet
            //https://www.c-sharpcorner.com/UploadFile/19b1bd/calculate-fibonacci-series-in-various-ways-using-C-Sharp/
            //
        }

    }
}

