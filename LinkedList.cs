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
            if (head == null)
            {
                this.head = node;
                Console.WriteLine(node.data + " Added Successfully");
            }
            else
            {
                Node address = new Node(data);
                Node h1 = null;
                h1 = this.head;
                this.head = address;
                Node temp = address;
                temp.next = h1;
                Console.WriteLine(address.data + " Added Successfully");
            }
        }

        public void Display()
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList Is Empty");
            }
            else
            {
                Console.WriteLine("Values In LinkedList Are:");
                while (this.head != null)
                {
                    Console.Write(this.head.data + " ");
                    this.head = this.head.next;
                }
            }

        }
    }
}
