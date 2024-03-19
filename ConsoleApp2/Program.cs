namespace ConsoleApp2
{
 class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            
            Console.WriteLine("Inserting at the beginning of the list");
            list.InsertAtBeginning(5);
            list.InsertAtBeginning(10);
            list.InsertAtBeginning(15);
            
            
            list.Displaylist(); 
            Console.WriteLine("Inserting at the end of the list");
            list.InsertAtEnd(20);
            list.InsertAtEnd(25);
            list.InsertAtEnd(30);
            list.Displaylist();

            Console.WriteLine("Searching for elements");
            Console.WriteLine(list.Search(5));
            Console.WriteLine(list.Search(20));

        }
    }
}