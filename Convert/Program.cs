namespace Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] chars = {"0","1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            Console.Write("Give me a broina system: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Give a num  to convert: ");
            int num = int.Parse(Console.ReadLine());
            Stack<string> digi = new Stack<string>();
            while (num > 0)
            {
                int index = num % p;
                digi.Push(chars[index]);
                num /= p;
            }
            foreach( string s in digi)
            {
                Console.Write(s + " ");
            }
        }
    }
}
