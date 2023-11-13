namespace ListAndDictionary
{
    internal class Program
    {
        // List variable containing names of persons
        private static List<string> personList = new List<string>();

        // Dictionary containing person name and age where the string TKey is for name and the int TValue is for age
        private static Dictionary<string, int> personAgeDictionary = new Dictionary<string, int>();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Person Manager!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add New Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Find Person");
                Console.WriteLine("4. List All Persons");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        RemovePerson();
                        break;
                    case "3":
                        FindPerson();
                        break;
                    case "4":
                        DisplayAllPersons();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public static void AddPerson()
        {
            // TODO 1: Request user input for the person's name.
            Console.WriteLine("Please input person's name: ");
            string personName = Console.ReadLine().ToLower();

            // TODO 2: Validate if the person already exists in the personList.
            // TODO 3: Add the person to the personList if they don't already exist.
            // TODO 4: Provide user feedback for successful addition or if the person already exists in personList.
            if (personList.Contains(personName))
            {
                Console.WriteLine($"{personName} already exists in the personList.");
            }
            else
            {
                personList.Add(personName);
                Console.WriteLine($"{personName} has been added to the personList.");
            }

            // TODO 5: Validate if the person already exists in the personAgeDictionary.
            // TODO 6: If they don't exist, request age input and add the person to the personAgeDictionary.
            //         NOTE!: Remember to add both TKey and TValue
            // TODO 7: Provide user feedback for successful addition or if the person already exists in personAgeDictionary.
            if (personAgeDictionary.ContainsKey(personName))
            {
                Console.WriteLine($"{personName} already exists in the personAgeDictionary.");
            }
            else
            {
                Console.WriteLine("Please input age: ");
                if (int.TryParse(Console.ReadLine(), out int personAge))
                {
                    personAgeDictionary.Add(personName, personAge);
                    Console.WriteLine($"{personName} with age {personAge} has been added to the personAgeDictionary.");
                }
                else
                {
                    Console.WriteLine("Invalid age input, please input a valid integer.");
                }
            }
        }

        public static void RemovePerson()
        {
            // TODO 8: Request user input for the name of the person to remove.
            // TODO 10: Provide user feedback for successful removal or if the person doesn't exist in personList.
            Console.WriteLine("Please input name for removal: ");
            string personNameRemove = Console.ReadLine().ToLower();

            // TODO 9: Remove the person from personList if they exist.
            if (personList.Contains(personNameRemove))
            {
                personList.Remove(personNameRemove);
                Console.WriteLine($"{personNameRemove} has been removed from the personList.");
            }
            else
            {
                Console.WriteLine($"{personNameRemove} not found within the personList");
            }

            // TODO 11: Remove the person from personAgeDictionary if they exist.
            // TODO 12: Provide user feedback for successful removal or if the person doesn't exist in personAgeDictionary.
            if (personAgeDictionary.ContainsKey(personNameRemove))
            {
                personAgeDictionary.Remove(personNameRemove);
                Console.WriteLine($"{personNameRemove} has been removed from the personAgeDictionary.");
            }
            else
            {
                Console.WriteLine($"{personNameRemove} not found within the personAgeDictionary.");
            }
        }

        public static void FindPerson()
        {
            // TODO 13: Request user input for the name of the person to find.
            Console.WriteLine("Please input name to find: ");
            string personFind = Console.ReadLine().ToLower();

            // TODO 14: Check if the person is in personList and provide appropriate feedback.
            if (personList.Contains(personFind))
            {
                Console.WriteLine($"{personFind} has been found in the personList.");
            }
            else
            {
                Console.WriteLine($"{personFind} not found within the personList.");
            }

            // TODO 15: Check if the person is in personAgeDictionary and provide appropriate feedback.
            if (personAgeDictionary.ContainsKey(personFind))
            {
                Console.WriteLine($"{personFind} has been found in the personAgeDictionary.");
            }
            else
            {
                Console.WriteLine($"{personFind} not found within the personAgeDictionary.");
            }
        }

        public static void DisplayAllPersons()
        {
            // TODO 16: Iterate over personList and display each person's name.
            if (personList.Count == 0 && personAgeDictionary.Count == 0)
            {
                Console.WriteLine("No persons to display.");
                return;
            }

            Console.WriteLine("Persons in personList: ");
            foreach (var personN1 in personList)
            {
                Console.WriteLine($"Names: {personN1}");
            }

            // TODO 17: Iterate over personAgeDictionary and display each person's name and age.

            Console.WriteLine("Persons in personAgeDictionary: ");
            foreach (var personN2 in personAgeDictionary)
            {
                Console.WriteLine($"Names: {personN2}");
            }

            // TODO 18: Consider handling the case where the lists are empty by providing feedback to the user. ---> Done in TODO 16
        }
    }
}
