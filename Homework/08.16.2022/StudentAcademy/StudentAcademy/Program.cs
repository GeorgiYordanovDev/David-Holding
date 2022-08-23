namespace StudentAcademy
{
    internal class Program
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, float>();
            int rowInput = int.Parse(Console.ReadLine());
            List<float> floatList = new List<float>();

            for (int i = 0; i < rowInput; i++)
            {
                string name = Console.ReadLine();
                float grade = float.Parse(Console.ReadLine());
                floatList.Add(grade);

                

                if (dictionary.ContainsKey(name))
                {
                    float avarageGrade = floatList.Average();
                    dictionary[name] = avarageGrade;
                    floatList.RemoveAll(x => x > 0);
                }
                else
                {
                    dictionary.Add(name, grade);
                }
            }

            foreach(KeyValuePair<string, float> item in dictionary)
            {
                if (item.Value > 4.49)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.ToString("0.00")}");
                }
            }

        }
    }
}