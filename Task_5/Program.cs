using System.Reflection.Emit;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook("MacbookPro", "Apple", 2200);
            Notebook notebook2 = new Notebook("Probook", "HP", 1200);
            Notebook notebook3 = new Notebook("Ideapad", "Lenovo", 800);

            notebook1.PrintInfo();
            notebook2.PrintInfo();
            notebook3.PrintInfo();

            Console.ReadKey();
        }
    }
}