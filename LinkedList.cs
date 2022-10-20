using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPracticeProblem
{
    public class LinkedList
    {
        Node head = null;
        public void Add(int data)
        {
                Node node = new Node(data);
                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine(node.data + ":Appended SuccessFully");
           
        }
            public void Display()
            {
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("LinkedList Is Empty");
                }
                else
                {
                    Console.WriteLine("Values In LinkedList Are:");
                    while (temp != null)
                    {
                        Console.Write(temp.data + " ");
                        temp = temp.next;
                    }
                }

            }
        
    }
}
