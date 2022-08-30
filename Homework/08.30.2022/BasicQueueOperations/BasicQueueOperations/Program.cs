namespace BasicQueueOperations
{
    internal class Program
    {
        static void Main()
        {
            var queue = new Queue<int>();

            string[] commandsArray = Console.ReadLine().Split().ToArray(); // N S X
            int pushElements = int.Parse(commandsArray[0]); //N
            int popElements = int.Parse(commandsArray[1]); //S
            int checkForElement = int.Parse(commandsArray[2]); //X

            string[] elementsArray = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < pushElements; i++)
            {
                queue.Enqueue(int.Parse(elementsArray[i]));
            }
            for (int i = 0; i < popElements; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(checkForElement))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count() == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}