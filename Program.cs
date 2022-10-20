namespace LinkedListPracticeProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Linked List Program");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ability to delete the first element in the LinkedList of sequence 56->30->70 ");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Console.WriteLine("----  Before deleting  -----");
            list.Display();
            Console.WriteLine("--------  After deleting  ----------");
            list.popfirst();
            list.Display();
        }
    }
}
