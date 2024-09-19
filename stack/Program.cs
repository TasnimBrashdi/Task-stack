using System.Collections;
using System.Linq;
namespace stack
{
    internal class Program
    {
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
    }
}

