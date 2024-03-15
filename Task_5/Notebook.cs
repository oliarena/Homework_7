namespace Task_5
{
    internal struct Notebook
    {
        readonly string model;
        readonly string manufacturer;
        readonly double price;

        public string Model
        {
            get { return model; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
        }

        public double Price
        {
            get { return price; }
        }

        public Notebook(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public Notebook(string model):this(model, "", 0)
        {
        }

        public Notebook(string model, string manufacturer) : this(model, manufacturer, 0)
        {
        }

        public Notebook(double price) : this("", "", price)
        {
        }

        public void PrintInfo()
        {
            Console.WriteLine(new string('-', 25));
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Manufacturer: {manufacturer}");
            Console.WriteLine($"Price: {price:C}");
            Console.WriteLine(new string('-', 25));
        }

    }        
}
