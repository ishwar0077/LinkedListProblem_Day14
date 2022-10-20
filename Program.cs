namespace LinkedListPracticeProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Linked List Program");

            Console.WriteLine("problem : Ability to insert 30 between 56 and 70");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.Display();
            Console.WriteLine("Inserting 30 Value Between 56 And 70:");
            list.insertbetween(56, 30);
            list.Display();
        }
    }
}
