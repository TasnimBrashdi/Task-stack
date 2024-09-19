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
            List<string> words = new List<string>();
            foreach (char c in word)
            {

               reverse.Push(c.ToString());
            }

            foreach (string s in reverse)
            {
                words.Add(s);
                Console.Write(s);
            }

        }
       
    }
}
