namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            TrainStation.AddTrains(trains);
            TrainStation.PrintTrains(trains);
            TrainStation.SortTrainsByNumber(trains);
            Console.WriteLine("Sorted trains: ");
            TrainStation.PrintTrains(trains);

            while (true)
            {
                TrainStation.RequestSearchByNumber(trains);
            }
        }
    }
}