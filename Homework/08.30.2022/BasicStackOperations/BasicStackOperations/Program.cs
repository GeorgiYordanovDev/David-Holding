namespace BasicStackOperations
{
    internal class Program
    {
        static void Main()
        {
            var stack = new Stack<int>();

            string[] commandsArray = Console.ReadLine().Split().ToArray(); // N S X
            int pushElements = int.Parse(commandsArray[0]); //N
            int popElements = int.Parse(commandsArray[1]); //S
            int checkForElement = int.Parse(commandsArray[2]); //X

            string[] elementsArray = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < pushElements; i++)
            {
                stack.Push(int.Parse(elementsArray[i]));
            }
            for (int i = 0; i < popElements; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(checkForElement))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count() == 0){
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}