namespace FashionBoutique
{
    internal class Program
    {
        static void Main()
        {
            var stack = new Stack<int>();

            int sum = 0;
            int rackCount = 1;

            string[] clothesValues= Console.ReadLine().Split().ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            for (int i = 0; i < clothesValues.Count(); i++)
            {
                stack.Push(int.Parse(clothesValues[i]));
            }
            do
            {
                if (stack.Count() != 0)
                {
                    if (stack.Peek() + sum < rackCapacity)
                    {
                        sum += stack.Pop();
                    }
                    else
                    {
                        rackCount++;
                        sum = 0;
                    }
                }
                else
                {
                    break;
                }
                
                
            } while (sum < rackCapacity);

            Console.WriteLine(rackCount);
        }
    }
}
