namespace Task_3
{
    internal struct MyStruct
    {
        private string change;

        public string Change { get => change; set => change = value; }

        public MyStruct()
        {
            change = "initial";
        }
    }
}
