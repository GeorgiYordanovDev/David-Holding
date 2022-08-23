namespace SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string>();
            int repeatNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < repeatNumber; i++)
            {
                string[] commandArray = Console.ReadLine().Split().ToArray();

                string command = commandArray[0];
                string username = commandArray[1];
                

                if (command == "register")
                {
                    string plateNumber = commandArray[2];

                    if (dictionary.ContainsKey(username))
                    {
                        Console.WriteLine($"Already registered with plate number {plateNumber}");
                    }
                    else
                    {
                        dictionary.Add(username, plateNumber);
                        Console.WriteLine($"{username} registered {plateNumber} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (dictionary.ContainsKey(username))
                    {
                        dictionary.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach(KeyValuePair<string, string> item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
