using System;

namespace SkalProj_Datastrukturer_Minne
{
    //TODO
    //HACK
    //UNDONE
    //UnresolvedMergeConflict dd

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
                    + "\n6. Fibonacci "
                    + "\n7. Fibonacci series"
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
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

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
                    Console.WriteLine($"F({n:02D5}) = {f:D10} at time {endTime}");
                }
            }
        }

        private static void FibonacciCalc()
        {
            Console.WriteLine("Enter number to fibonacci ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"F({n}) = {Fibonacci(n)} ");
        }

        private static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);

        }

        private static void CheckRecusion()
        {
            Console.WriteLine("Enter number to calculate n even");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{RecursiveEven(n)}");
        }

        /// <summary>
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

        }


        /// <summary>
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
                    else
                    {
                        wellFormatted = false;
                        break;
                    }
                }
                output += item;
            }

            // check if same amount of 
            if (myStack.Count > 0)
                wellFormatted = false;

            if (wellFormatted)
                Console.WriteLine("\nThe string is well formated.\n");
            else
                Console.WriteLine("\nThe string is badly formated.\n");

            Console.WriteLine($"{output}\n");
        }



        static int RecursiveEven(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return RecursiveEven(n - 1) + 2;
        }
    }
}

