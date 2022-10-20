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
            Console.WriteLine(node.data + ":Added SuccessFully");
        }
        public void insertbetween(int value, int data)
        {
            Node node = head;
            while (node.data != value)
            {
                node = node.next;
            }
            Node node1 = new Node(data);
            Node temp;
            temp = node.next;
            node.next = node1;
            node1.next = temp;

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
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}

