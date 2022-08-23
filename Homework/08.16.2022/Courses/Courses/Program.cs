namespace Courses
{
    internal class Program
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, List<string>>();

            do
            {
                string[] commandArray = Console.ReadLine().Split(" : ").ToArray();

                if (commandArray[0] == "end") break;

                string courseName = commandArray[0];
                string studentName = commandArray[1];
                List<string> studentNames = new List<string>();
                studentNames.Add(studentName);

                if (dictionary.ContainsKey(courseName))
                {
                    dictionary[courseName].Add(studentName);
                }
                else
                {
                    dictionary.Add(courseName, studentNames);
                }
            }
            while (true);

            foreach (KeyValuePair<string, List<string>> item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                item.Value.ForEach(element => Console.WriteLine($"-- {element}"));
            }
        }
    }
}