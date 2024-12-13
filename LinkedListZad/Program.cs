using System.Collections;
namespace LinkedListZad
{
    internal class Program
    {
        static int[] nums = { 10, -15, 100, 0, -200 };
        static void Main(string[] args)
        {
            //da se syzdade zadcha koqto da wkrava chisla ot klaviaturata i da gi slaga na 3-to mqsto po 3 nachina s 3 metoda
            //I.s Array list
            //II.da go napyhava v LinkedList
            //III.s Stack

            Console.Write("which number do you wnat on third position::");
            int addNum = int.Parse(Console.ReadLine());
            ArrayList updatedList = AddInArraylist(addNum);
            int inser = int.Parse(Console.ReadLine());
            
            //for (int i = 0; i < updatedList.Count; i++)
            //{
            //    Console.WriteLine(updatedList);
            //}
            Console.WriteLine(string.Join("",LInkedLIst(inser)));

        }
        static ArrayList AddInArraylist(int addNum)
        {
            ArrayList list1 = new ArrayList();
            list1.AddRange(nums);
            list1.Insert(2, addNum);
            return list1;
        }
        static LinkedList<int> LInkedLIst(int inser)
        {
            LinkedList<int> list = new LinkedList<int>();
            LinkedListNode <int >linkedListNode = list.First.Next;
            list.AddAfter(linkedListNode,inser);
            return list;
        }
        static Stack<int> Stack()
        {

        }
    }
}
