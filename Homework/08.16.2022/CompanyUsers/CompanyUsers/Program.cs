namespace CompanyUsers
{
    internal class Program
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, List<string>>();

            do
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();

                if (input[0] == "End") break;

                string companyName = input[0];
                string employeeId = input[1];
                List<string> employees = new List<string>();
                employees.Add(employeeId);

                if (dictionary.ContainsKey(companyName))
                {
                    if (dictionary[companyName].Contains(employeeId))
                    {
                        continue;
                    }
                    else
                    {
                        dictionary[companyName].Add(employeeId);
                    }
                }
                else
                {
                    dictionary.Add(companyName, employees);
                }
            }
            while (true);

            foreach(KeyValuePair<string, List<string>> item in dictionary)
            {
                Console.WriteLine($"{item.Key}");
                item.Value.ForEach(id => Console.WriteLine($"-- {id}"));
                
            }

            /*
SoftUni -> AA12345
SoftUni -> BB12345
Microsoft -> CC12345
HP -> BB12345
End
            
SoftUni -> AA12345
SoftUni -> CC12344
Lenovo -> XX23456
SoftUni -> AA12345
Movement -> DD11111
End
            */
        }
    }
}