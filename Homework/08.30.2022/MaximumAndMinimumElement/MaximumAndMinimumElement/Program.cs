namespace MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main()
        {
            var stack = new Stack<int>();

            int repeats = int.Parse(Console.ReadLine());

            for (int i = 0; i < repeats; i++)
            {
                string[] array = Console.ReadLine().Split().ToArray();

                if (array[0] == "1")
                {
                    stack.Push(int.Parse(array[1])); 
                }
                else if (array[0] == "2")
                {
                    if (stack.Count() != 0)
                    {
                        stack.Pop();
                    }
                    
                }
                else if (array[0] == "3")
                {
                    if (stack.Count() != 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (array[0] == "4")
                {
                    if (stack.Count() != 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
                else
                {
                    throw new Exception("Enter a valid expression.");
                }
            }
            int x = 0;
            foreach (int i in stack)
            {
                x++;
                if (stack.Count() - x != 0)
                {
                    Console.Write($"{i}, ");
                    
                }
                else
                {
                    Console.Write($"{i}");
                }
                
            }
        }
    }
}
