namespace Task_3
{
    internal class MyClass
    {
        private string? change;

        public string? Change { get => change; set => change = value; }

        public MyClass()
        {
            change = "initial";
        }
    }
}
