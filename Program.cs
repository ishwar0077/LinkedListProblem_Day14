namespace LinkedListPracticeProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Linked List Program");

            //Ability to create Linked List by adding 30 and 56 to 70
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();
        }
    }
}
