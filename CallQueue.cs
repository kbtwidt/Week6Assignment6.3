using System;
using System.Collections.Generic;
using System.Text;

namespace Week6Assignment6._3
{
    internal class Node
    {
        public string Name { get; set; }
        public Node next;
        public Node(string name)
        {
            this.Name = name;
            this.next = null;
        }
    }

    class CallQueue
    {
        Node front, rear;
        int size;
        public CallQueue()
        {
            front = null;
            rear = null;
            size = 0;
        }
        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(string name)
        {
            Node newNode = new Node(name);
            if(IsEmpty())
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
            size++;
        }
        public string Dequeue()
        {
            if(IsEmpty())
            {
                return "Queue is empty";
            }
            string name = front.Name;
            front = front.next;
            size--;
            if(IsEmpty())
            {
                rear = null;
            }
            return name;
        }
        public void Display()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node tempNode = front;
            Console.WriteLine("Customers in Call Queue: ");
            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Name);
                tempNode = tempNode.next;
            }
        }
    }
}
