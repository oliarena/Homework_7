namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine("MyClass.change = " + myClass.Change);
            Console.WriteLine("MyStruct.change = " + myStruct.Change);

            myStruct.Change = "changed";
            Console.WriteLine("MyStruct.change = " + myStruct.Change);

            StructTakerOut(myStruct, out myStruct);
            Console.WriteLine("MyStruct.change = " + myStruct.Change);

            StructTakerRef(ref myStruct);
            Console.WriteLine("MyStruct.change = " + myStruct.Change);

            Console.ReadKey();  
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "changed";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.Change = "changed";
        }

        static void StructTakerOut(MyStruct myStruct, out MyStruct outStruct)
        {
            outStruct = myStruct;
            outStruct.Change = "out changed";
        }

        static void StructTakerRef(ref MyStruct myStruct)
        {
            myStruct.Change = "ref changed";
        }

    }
}