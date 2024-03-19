using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            head = null;
        }
        public void InsertAtBeginning(int newdata)
        {
            Node newNode = new Node(newdata);
            newNode.next = head;
            head = newNode;
        }
        public void Displaylist()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void InsertAtEnd(int newdata)
        {
            Node newNode = new Node(newdata);
            if(head == null)
            {
                head = newNode;
                return;
            }
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
                if (temp == null)
                {
                    temp.next = newNode;
                    
                }
            }
            
        }

        public bool Search(int key)
        {
            Node current = head;
            while(current != null)
            {
                if (current.data == key)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        
        }
    }
}
