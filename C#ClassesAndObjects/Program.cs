using System.Collections;

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
            //Arrays();
            //Arrays2D();
            //NestedLoopOnArray();
            //JaggedArray();
            //JaggedArrayChallenge();

            /*
            int[] grades = new int[] { 10, 12, 14, 16, 18, 20 };
            double average = GetAverage(grades);
            Console.WriteLine($"The average is {average}");
            */

            /*
            int[] happiness = new int[] { 1, 2, 3, 4, 5 };
            SunIsShining(happiness);
            foreach (int item in happiness)
            {
                Console.WriteLine(item);
            }
            */

            //ParamsMethod("Hello", "World", "!");
            //ParamsMethod2("Hello", 50, 3.14f, '@', 4, 5, 6, 7, 8, 9, 10);

            //Console.WriteLine(MinV2(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            //ArrayLists();

            /*
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.ID, stud1);
            studentsTable.Add(stud2.ID, stud2);
            studentsTable.Add(stud3.ID, stud3);
            studentsTable.Add(stud4.ID, stud4);

            Student storedStudent1 = (Student)studentsTable[stud1.ID];

            foreach (DictionaryEntry student in studentsTable)
            {
                Student temp = (Student)student.Value;
                Console.WriteLine($"ID: {temp.ID}, Name: {temp.NAME}, Grade: {temp.GRADE}");
            }

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine($"Student ID: {value.ID}");
                Console.WriteLine($"Student Name: {value.NAME}");
                Console.WriteLine($"Student Grade: {value.GRADE}");
            }

            Console.WriteLine($"ID: {storedStudent1.ID}, Name: {storedStudent1.NAME}, Grade: {storedStudent1.GRADE}");
            */

            /*
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable studentsTable = new Hashtable();

            foreach (Student student in students)
            {
                if (!studentsTable.ContainsKey(student.ID))
                {
                    studentsTable.Add(student.ID, student);
                }
            }

            foreach (Student student in studentsTable.Values) 
            {
                Console.WriteLine($"Details from Hashtable ID: {student.ID}, Name: {student.NAME}, Grade: {student.GRADE}");
            }
            */
            
            /*
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artorias", 55, 35),
                new Employee("Intern", "Ernest", 22, 8),
            };

            Dictionary<string, Employee> employeesDictionary = new Dictionary<string, Employee>();
            foreach (Employee employee in employees) { employeesDictionary.Add(employee.Role, employee); }

            string key = "CEO";
            if (employeesDictionary.ContainsKey(key))
            {
                Employee empl = employeesDictionary[key];
                Console.WriteLine($"Employee {empl.Name} is a {empl.Role} and earns {empl.Salary} per year");
            }
            else
            {
                Console.WriteLine($"Employee with key {key} does not exist");
            }

            // Alternative Way
            if (employeesDictionary.TryGetValue(key, out Employee empl2))
            {
                Console.WriteLine($"Employee {empl2.Name} is a {empl2.Role} and earns {empl2.Salary} per year");
            }
            else
            {
                Console.WriteLine($"Employee with key {key} does not exist");
            }

            //Using for loop
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Employee {employees[i].Name} is a {employees[i].Role} and earns {employees[i].Salary} per year");
            }

            string keyToUpdate = "CEO";
            if (employeesDictionary.ContainsKey(keyToUpdate))
            {
                Employee empl = employeesDictionary[keyToUpdate];
                empl.Name = "Gwyn Lord of Cinder";
                employeesDictionary[keyToUpdate] = empl;
            }
            else
            {
                Console.WriteLine($"Employee with key {keyToUpdate} does not exist");
            }

            Console.WriteLine(employeesDictionary["CEO"].Name);
            */
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
                {1,2,3}, // row 0
                {4,5,6}, // row 1
                {7,8,9} // row 2
            };
            Console.WriteLine($"Central value is {array2D[1, 1]}");

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"020", "021"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"120", "121"}
                },
                {
                    {"200", "201"},
                    {"210", "211"},
                    {"220", "221"}
                },
                {
                    {"300", "301"},
                    {"310", "311"},
                    {"320", "321"}
                }
            };
            Console.WriteLine($"Central value is {array3D[1, 1, 1]}");

            string[,] array2DString = new string[,]
            {
                {"one", "two"},
                {"three", "four"},
                {"five", "six"},
            };

            int dimensions = array2DString.Rank;

            array2DString[1, 1] = "chicken";
            Console.WriteLine($"Central value is {array2DString[1, 1]}");
            Console.WriteLine($"Dimensions of array2DString is {dimensions}");
        }
        public static void NestedLoopOnArray()
        {
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            foreach (int item in matrix)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");

            Console.WriteLine("This is our 2D array printed using nested for loop");

            Console.WriteLine("Print only odd numbers:");
            for (int i = 0; i < matrix.GetLength(0); i++) // rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // columns
                {
                    //matrix[i, j] = 0;
                    //Console.Write($"{matrix[i, j]} ");
                    //Print only odd numbers

                    if (matrix[i, j] % 2 == 1)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                }
            }

            Console.WriteLine("Print only diagonal numbers:");
            for (int i = 0; i < matrix.GetLength(0); i++) // rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // columns
                {
                    if (i == j)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }

            //Doing the above with one loop
            Console.WriteLine("Print only diagonal numbers:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, i]);
            }

            // Capturing the other diagonal
            Console.WriteLine("Print the other diagonal numbers:");
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i, j]);
            }
        }
        public static void JaggedArray()
        {
            // Declare the array of two elements:
            int[][] jaggedArray = new int[3][];

            // Initialize the elements:
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[6];
            jaggedArray[2] = new int[3] { 1, 2, 3 };

            // Initialize the elements:
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 1, 2, 3, 4, 5, 6 };

            //Alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3, 4, 5, 6 },
                new int[] { 1, 2, 3 }
            };

            Console.WriteLine($"The value in the middle of the first entry is {jaggedArray[0][1]}");
            foreach (int[] item in jaggedArray2)
            {
                foreach (int item2 in item)
                {
                    Console.WriteLine($"The value is {item2}");
                }
            }
        }
        public static void JaggedArrayChallenge()
        {
            string[][] jaggedArrayFriends = new string[3][]
            {
                new string[] { "Kyle", "Martha" },
                new string[] { "John", "Carol" },
                new string[] { "Chris", "Amanda" }
            };

            Console.WriteLine($"Hi {jaggedArrayFriends[1][1]}. My name is {jaggedArrayFriends[0][0]}");
            Console.WriteLine($"Hi {jaggedArrayFriends[0][1]}. My name is {jaggedArrayFriends[1][0]}");
            Console.WriteLine($"Hi {jaggedArrayFriends[2][1]}. My name is {jaggedArrayFriends[2][0]}");
        }
        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }

        static void SunIsShining(int[] happinessArray)
        {
            int addFactor = 2;
            int size = happinessArray.Length;

            for (int i = 0; i < size; i++)
            {
                happinessArray[i] += addFactor;
            }
        }
        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i]);
            }
        }
        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine("");
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }

        static void ArrayLists()
        {
            //Declaring an ArrayList with undefined amount of objects
            ArrayList myArrayList = new ArrayList();
            //Declaring an ArrayList with defined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(3.14);
            myArrayList.Add(true);
            myArrayList.Add(false);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            myArrayList.Remove(25);
            myArrayList.RemoveAt(0);
            Console.WriteLine($"The capacity of myArrayList is {myArrayList.Count}");

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                } else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine($"The sum of the numbers in myArrayList is {sum}");
        }

        static void Dictionaries()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" }
            };
        }

        class Employee
        {
            public string Role { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public float Rate { get; set; }

            public float Salary
            {
                get
                {
                    return Rate * 8 * 5 * 4 * 12;
                }
            }

            public Employee(string role, string name, int age, float rate)
            {
                Role = role;
                Name = name;
                Age = age;
                Rate = rate;
            }

            public void Details()
            {
                Console.WriteLine($"Role: {Role}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Rate: {Rate}");
            }
        }
    }
}
