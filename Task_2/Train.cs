namespace Task_2
{
    internal struct Train
    {
        string destination;
        int number;
        TimeOnly depart;

        public string Destination
        {
            get { return destination; }
        }

        public int Number
        { 
            get { return number; } 
        }

        public TimeOnly Depart
        {
            get { return depart; }
        }

        public Train(string destination, int number, TimeOnly depart)
        {   
            this.destination = destination;
            this.number = number;   
            this.depart = depart;   
        }

        public void PrintInfo()
        { 
            Console.WriteLine($"Num: {number}. Destination: {destination}. Depart Time: {depart:t}");     
        }
    }    
}
