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
                     */
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


            //HACK theList.TrimExcess(), theList.Clear()
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

                foreach (var t in input)
                {
                    myStack.Push(t.ToString());
                }

                var count = myStack.Count;
                for (int i= 0; i < count; i++)
                {
                    Console.Write(myStack.Pop());
                }

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

        }

    }
}

