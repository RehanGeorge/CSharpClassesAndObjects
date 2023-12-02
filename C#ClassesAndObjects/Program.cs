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

            /*
            Members member1 = new Members();
            member1.Introducing(true);
            Console.ReadLine();
            */
            Arrays2D();
        }
        public static void Arrays()
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 8;
            grades[4] = 4;

            Console.WriteLine($"Grade at index 0: {grades[0]}");

            Console.WriteLine("Insert the new value for Grade at index 0: ");
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine($"Grades at index 0 is: {grades[0]}");

            // another way to initialize an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 4 };

            // third way to initialize an array
            int[] gradesOfMathStudentsB = new int[] { 20, 13, 12, 8, 4 };

            Console.WriteLine($"Length of gradesOfMathStudentsA: {gradesOfMathStudentsA.Length}");

            string[] students = new string[5];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = i.ToString();
                Console.WriteLine($"Student at index {i} is {students[i]}");
            }

            Console.WriteLine(students);

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            string[] friends = { "John", "Tom", "Bob", "Kyle", "Mike" };

            foreach (string friend in friends)
            {
                Console.WriteLine($"Hi {friend}");
            }
        }
        public static void Arrays2D()
        {
            // declare a 2D array
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
        }
    }
}
