namespace Task_2
{
    internal static class TrainStation
    {
        public static void AddTrains(Train[] trains)
        {
            string? destination;
            int number;
            TimeOnly depart;

            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write($"Please, enter the {i+1} of {trains.Length} train destination ");
                destination = Console.ReadLine();
                while (string.IsNullOrEmpty(destination))
                {
                    Console.WriteLine("Entered value is incorrect. Please, try again...");
                    destination = Console.ReadLine();
                }

                Console.Write("Please, enter the train number ");
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Entered value is incorrect. Please, try again...");
                }

                Console.Write("Please, enter the depart time (HH:mm) ");
                while (!TimeOnly.TryParse(Console.ReadLine(), out depart))
                {
                    Console.WriteLine("Entered value is incorrect. Please, try again...");
                }

                trains[i] = new Train(destination, number, depart);
            }
        }

        public static void SortTrainsByNumber(Train[] trains) //Сортування можно було зробити на багато лешче через метод CompareTo
        {
            int n = trains.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (trains[j].Number > trains[j + 1].Number)
                    {
                        (trains[j + 1], trains[j]) = (trains[j], trains[j + 1]);
                    }
                }
            }
        }

        public static Train? SearchTrainByNumber(Train[] trains, int number)
        {
            foreach (Train train in trains)
            {
                if (train.Number.Equals(number))
                {
                    return train;
                }
            }

            return null;
        }

        public static void PrintTrains(Train[] trains)
        {
            Console.WriteLine(new string('-', 25));
            foreach (Train train in trains)
            {
                train.PrintInfo();
            }
            Console.WriteLine(new string('-', 25));
        }

        public static void RequestSearchByNumber(Train[] trains)
        {
            int number;
            Console.Write("Please, enter the train number you are looking for ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Entered value is incorrect. Please, try again...");
            }

            Train? train = SearchTrainByNumber(trains, number);
            if ( train != null)
            {
                train?.PrintInfo();
            }
            else
            {
                Console.WriteLine($"The train number {number} is not found.");
            }
        }
    }
}
