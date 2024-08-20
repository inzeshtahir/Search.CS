// dataset
List<int> numbers = [17, 166, 288, 324, 531, 792, 946, 157, 276, 441, 533, 355, 228, 879, 100, 421, 23, 490, 259, 227, 216, 317, 161, 4, 352, 463, 420, 513, 194, 299, 25, 32, 11, 943, 748, 336, 973, 483, 897, 396, 10, 42, 334, 744, 945, 97, 47, 835, 269, 480, 651, 725, 953, 677, 112, 265, 28, 358, 119, 784, 220, 62, 216, 364, 256, 117, 867, 968, 749, 586, 371, 221, 437, 374, 575, 669, 354, 678, 314, 450, 808, 182, 138, 360, 585, 970, 787, 3, 889, 418, 191, 36, 193, 629, 295, 840, 339, 181, 230, 150];
while (true)
            {
                Console.WriteLine("Choose an operation: 1. Basic Search 2. Range Search 3. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BasicSearch(numbers);
                        break;
                    case "2":
                        RangeSearch(numbers);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }

        static void BasicSearch(List<int> numbers)
        {
            Console.Write("Enter an integer to search: ");
            if (int.TryParse(Console.ReadLine(), out int searchValue))
            {
                int index = numbers.IndexOf(searchValue);
                if (index >= 0)
                {
                    Console.WriteLine($"Number {searchValue} found at index {index}.");
                }
                else
                {
                    Console.WriteLine($"Number {searchValue} not found in the collection.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        static void RangeSearch(List<int> numbers)
        {
            int lowerBound = 0;
            int upperBound = int.MaxValue;

            Console.Write("Enter the lower bound of the range (or press Enter to default to 0): ");
            string lowerInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(lowerInput))
            {
                if (!int.TryParse(lowerInput, out lowerBound))
                {
                    Console.WriteLine("Invalid input. Setting lower bound to 0.");
                    lowerBound = 0;
                }
            }

            Console.Write("Enter the upper bound of the range (or press Enter to default to maximum value): ");
            string upperInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(upperInput))
            {
                if (!int.TryParse(upperInput, out upperBound))
                {
                    Console.WriteLine("Invalid input. Setting upper bound to maximum value.");
                    upperBound = int.MaxValue;
                }
            }

            var result = numbers.Where(n => n >= lowerBound && n <= upperBound).OrderBy(n => n).ToList();
            if (result.Count > 0)
            {
                Console.WriteLine($"Found {result.Count} number(s) in the range [{lowerBound}, {upperBound}]: {string.Join(", ", result)}");
            }
            else
            {
                Console.WriteLine($"No numbers found in the range [{lowerBound}, {upperBound}].");
            }
        }