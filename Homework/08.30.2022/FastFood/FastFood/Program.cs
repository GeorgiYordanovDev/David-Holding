namespace FastFood
{
    internal class Program
    {
        static void Main()
        {
            
            var queue = new Queue<int>();

            int foodQuantity = int.Parse(Console.ReadLine());
            while (foodQuantity < 0 || foodQuantity > 1000)
            {
                foodQuantity = int.Parse(Console.ReadLine());
            }

            string[] orderQuantityArray = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < orderQuantityArray.Count(); i++)
            {
                queue.Enqueue(int.Parse(orderQuantityArray[i]));
            }
            Console.WriteLine(queue.Max());

            do
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
                else if(foodQuantity - queue.Peek() < 0)
                {
                    
                    Console.Write("Orders left: ");
                    for (int i = 0; i < queue.Count; i++)
                    {
                        Console.Write(queue.Dequeue());
                    }
                    break;
                }
                foodQuantity -= queue.Dequeue();
            } while (foodQuantity != 0 || queue.Count() != 0);

            
            
        }
    }
}