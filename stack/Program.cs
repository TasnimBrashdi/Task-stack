using System.Collections;
using System.Linq;
namespace stack
{
    internal class Program
    {
        static Stack<int> Max = new Stack<int>();
        static Stack<int> Min = new Stack<int>();
        static void Main(string[] args)
        {

            Console.WriteLine("- - - Reverse a String Using a Stack - - - ");
            Stack<string>reverse = new Stack<string>();
            Console.WriteLine("Enter word");
            string word=Console.ReadLine();
         
            foreach (char c in word)
            {

               reverse.Push(c.ToString());
            }

            foreach (string s in reverse)
            {
               
                Console.Write(s);
            }


            Console.WriteLine("\n- - -  Evaluate Postfix Expression - - - ");
            Postfix();


            // 5 1 2 + 4 * + 3 -

            Console.WriteLine("\n- - -  Check for Balanced Parentheses - - - ");
            string input1 = "(())";
            string input2 = "(()";
            if (IsBalanced(input1))
            {
                Console.WriteLine(input1 + " IS Balanced: YES");
            }
            else {
                Console.WriteLine(input1+ " IS Balanced: NO");

            }
            if (IsBalanced(input2))
            {
                Console.WriteLine(input2+ " IS Balanced: YES");
            }
            else
            {
                Console.WriteLine(input2+ " IS Balanced: NO");

            }

            Console.WriteLine("\n- - -  Find the Maximum Element in a Stack - - - ");
            Maxmim();


            Console.WriteLine("\n- - -  Reverse a Queue - - - ");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(9);
            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Enqueue(7);
            queue.Enqueue(5);
            Console.WriteLine(" Queue:");
            foreach (int q in queue)
            {
                Console.Write(q + " ");
            }
            // Reverse the queue
            ReverseQueue(queue);
            Console.WriteLine("\nReversed Queue:");
            foreach (int q in queue)
            {
                Console.Write(q + " ");
            }


            Console.WriteLine("\n- - -   Check if a Queue is a Palindrome  - - - ");

            Queue<int> Palindrome = new Queue<int>();
           
            Palindrome.Enqueue(1);
            Palindrome.Enqueue(2);
            Palindrome.Enqueue(3);
            Palindrome.Enqueue(2);
            Palindrome.Enqueue(1);
         
        
            bool result = PalindromeQ(Palindrome);
            Console.WriteLine($"Is the queue a palindrome? {result}");


        }
        static void Postfix() {

            Console.WriteLine("\n enter Expression ");
            string input = Console.ReadLine();
            Stack<int> postfix = new Stack<int>();
            List<string> Expression = new List<string>();
          
            foreach (char c in input) {
                if (c == ' ')
                {

                }
                else {
                    Expression.Add(c.ToString());

                }
            }
        
            for (int i = 0; i < Expression.Count(); i++) {
                try
                {
                    int number = int.Parse(Expression[i]);
                    postfix.Push(number);
                }
                catch
                {
                    string operators = Expression[i];

                    int n2 = postfix.Pop();
                    int n1 = postfix.Pop();
                    int result = 0;
                    switch (operators)
                    {
                        case "+":

                            result = n1 + n2;
                            break;
                        case "*":

                            result=n1 * n2;
                            break;
                        case "-":
                            if (n1 > n2) {result=n1 - n2; }
                            else { result=n2 - n1; }

                            break;
                        case "/":
                            if (n2 == 0)
                            {
                                Console.WriteLine("Error: Division by zero.");

                            }
                            result=n1 / n2;
                            break;
                        default:
                            Console.WriteLine("Error");

                            break;
                    }
                    postfix.Push(result);
                }

                }
            foreach(var v in postfix)
            {
                Console.WriteLine(v);
            }
        
   
        }

        static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char cha in input)
            {
                if (cha == '(')
                {
                    stack.Push(cha); 
                }
                else if (cha == ')')
                {
                  
                    if (stack.Count == 0)
                        return false;
                        stack.Pop(); 
                }
            }
      
            return stack.Count == 0;
        }


       
        static void Maxmim()
        {
            Stack<string> stackmax = new Stack<string>();
            int max = 0;
            Console.WriteLine("Enter integer numbers");
            string input = Console.ReadLine();
            foreach (char c in input) {
                try
                {
                    int n = int.Parse(c.ToString());
                    if (n > max)
                    {
                        max = n;

                    }
                    stackmax.Push(c.ToString());
                }
                catch  {
                    stackmax.Push(c.ToString());
                }
               
            }
            if (max != 0)
            {
                Console.WriteLine("Max: " + max);
            }
            else
            {
                Console.WriteLine("Empty number");
            }

        }
       


        static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
        
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
       
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }

        static bool PalindromeQ(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            int count = queue.Count;

            foreach (int q in queue)
            {
                stack.Push(q);
            }
        
            for (int i = 0; i < count; i++)
            {
                int q1 = queue.Dequeue();  
                int reverseq = stack.Pop();      

                queue.Enqueue(q1);
            
                if (q1 != reverseq)
                {
                    return false;
                }
            }
            return true;


        }




    }
}

