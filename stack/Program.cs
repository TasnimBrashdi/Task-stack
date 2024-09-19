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
            
            }
       

        }
    }

