namespace Palendrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
           
            foreach (char c in word)
            {
                stack.Push(c);
            }

            bool pale = true;             
            foreach (char c in word)
            {
                if (stack.Pop() != c)
                {
                    pale = false;
                    break;
                }
            }          
            if (pale)
            {
                Console.WriteLine("is palendrom");
            }
            else
            {
                Console.WriteLine("it is not palendrom");
            }        
        }
    }
}
