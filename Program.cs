namespace Week6Assignment6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallQueue newQueue = new CallQueue();
            newQueue.Enqueue("Willem");
            newQueue.Enqueue("Norman");
            newQueue.Enqueue("Sean");
            newQueue.Enqueue("Stanley");

            newQueue.Display();

            Console.WriteLine($"\nServing Caller: " + newQueue.Dequeue() + "\n");
            newQueue.Display();
            Console.WriteLine($"\nServing Caller: " + newQueue.Dequeue() + "\n");
            newQueue.Display();
            Console.WriteLine($"\nServing Caller: " + newQueue.Dequeue() + "\n");
            newQueue.Display();
            Console.WriteLine($"\nServing Caller: " + newQueue.Dequeue() + "\n");
            newQueue.Display();
            Console.WriteLine($"\nServing Caller: " + newQueue.Dequeue() + "\n");
            newQueue.Display();

        }
    }
}
