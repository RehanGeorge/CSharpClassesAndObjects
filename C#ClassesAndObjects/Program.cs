namespace C_ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("Audi A4", 250, "blue");
            audi.Drive();
            audi.Details();

            Car bmw = new Car("BMW M5", 350);
            bmw.Drive();
            bmw.Details();

            Console.WriteLine("Press stop to stop the car");
            string userInput = Console.ReadLine();
            if (userInput == "stop")
            {
                audi.Stop();
            }
            else
            {
                audi.Drive();
            }
        }
    }
}
