namespace C_ClassesAndObjects
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Car myCar = new Car();
            //myCar.SetName("What a car");
            //Console.WriteLine(myCar.GetName());
            /*
            myCar.Name = "What a car";
            Console.WriteLine(myCar.Name);
            myCar.Details();

            Car audi = new Car("Audi A4", 250, "blue");
            audi.Drive();
            Console.WriteLine(audi.GetHp());
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
            */

            Members member1 = new Members();
            member1.Introducing(true);
            Console.ReadLine();
        }
    }
}
