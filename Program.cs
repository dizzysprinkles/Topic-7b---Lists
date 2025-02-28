namespace Topic_7b___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() {"Arthur Dent", "Marvin" };
            
            names.Add("Trillian");
            names.Add("Ford Prefect");

            for (int i = 0; i < names.Count; i++)
                Console.WriteLine(names[i]);

            for (int i = 0; i < names.Count; i++)
                names[i] = names[i].ToUpper();  

            Console.WriteLine();
            Console.WriteLine();
            names.Sort();


            for (int i = 0; i < names.Count; i++)
                Console.WriteLine(names[i]);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter a name to add to the list:");
                names.Add(Console.ReadLine().ToUpper());
                Console.WriteLine();
            }

            names.Sort();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < names.Count; i++)
                Console.WriteLine(names[i]);

            Console.WriteLine("There are " + names.Count() + " names in the list");

            Console.WriteLine();
            Console.WriteLine("What name would you like to remove from the list? ");
            names.Remove(Console.ReadLine().ToUpper());

            Console.WriteLine();
            Console.WriteLine("There are now " + names.Count() + " names in the list.");

            names.Clear();

        }
    }
}
