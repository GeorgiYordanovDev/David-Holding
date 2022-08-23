namespace CountCharsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Counter(input);
        }

        static void Counter(string input)
        {
            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < input.Count(); i++)
            {
                if ((input[i] != ' '))
                {
                    if (dictionary.ContainsKey(input[i]))
                    {
                        dictionary[input[i]]++;

                    }
                    else
                    {
                        dictionary[input[i]] = 1;
                    }
                }
                
            }

            foreach (KeyValuePair<char, int> item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}