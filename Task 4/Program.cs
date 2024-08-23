//1 - Create data type Student with properties (Id, Name, Age, Phone, Address,Grade)
using System.Diagnostics;

struct Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Phone { get; set; }
    public string Address { get; set; }
    public int Grade { get; set; }

    public void printDetails()
    {
        Console.WriteLine($"Student ID is {Id}");
        Console.WriteLine($"Student Name is {Name}");
        Console.WriteLine($"Student Age is {Age}");
        Console.WriteLine($"Student Phone is {Phone}");
        Console.WriteLine($"Student Address is {Address}");
        Console.WriteLine($"Student Grade is {Grade}");
        Console.WriteLine("========================================");
    }
}

class Students_info
{
    static void Main()
    {
        // 2 - Create array of type Student with size 10
        Student[] students = new Student[2];

        // 3 - Ask the user to enter the data of 10 students
        Console.WriteLine("Enter Your Details:");

        for (int i = 0; i < students.Length; i++)
        {
            Console.Write($"Enter id's Student {i + 1}: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write($"Enter name's Student {i + 1}: ");
            String name = (Console.ReadLine());

            Console.Write($"Enter age's Student {i + 1}: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write($"Enter phone's Student {i + 1}: ");
            int phone = int.Parse(Console.ReadLine());

            Console.Write($"Enter address's Student {i + 1}: ");
            string address = Console.ReadLine();

            Console.Write($"Enter grade's Student {i + 1}: ");
            int grade = int.Parse(Console.ReadLine());

            Console.WriteLine("========================================");

            students[i] = new Student
            {
                Id = id,
                Name = name,
                Age = age,
                Phone = phone,
                Address = address,
                Grade = grade

            };
        }

        Console.Clear(); // Remove after end Addition

        // Print the result 
        foreach (Student printDetails in students)
        {
            printDetails.printDetails();
        }

            // 4-Offer 5 queries for the user
            while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("============");
            Console.WriteLine("1. Get the minimum grade of all grades");
            Console.WriteLine("2. Get the maximum grade of all grades");
            Console.WriteLine("3. Get the average of all grades");
            Console.WriteLine("4. Get the count of grades greater than a value (Enter value)");
            Console.WriteLine("5. Get the count of students with a specific age (Enter age)");
            Console.WriteLine("Type 'quit' to exit the program");

            string choice = Console.ReadLine().ToLower();

            if(choice == "quit")
            {
                break;
            }

            switch (choice)
            {
                // 1.Get the minimum grade of all grades
                case "1":
                    int min = students[0].Grade;
                    foreach (Student studentGrade in students)
                    {
                        if (studentGrade.Grade > min)
                        {
                            min = studentGrade.Grade;
                        }
                    }
                    Console.WriteLine($"The Minimum Grade of all students is = {min}");
                    break;

                // 2. Get the maximum grade of all grades
                case "2":
                    int max = students[0].Grade;
                    foreach (Student studentGrade in students)
                    {
                        if (studentGrade.Grade < max)
                        {
                            max = studentGrade.Grade;
                        }
                    }
                    Console.WriteLine($"The Maximum Grade of all students is = {max}");
                    break;

                // 3.Get the average of all grades
                case "3":
                    int totalSum = 0;
                    for (int i = 0; i < students.Length; i++)
                    {

                        totalSum += students[i].Grade;
                    }

                    float avg = totalSum / students.Length;
                    Console.WriteLine($"The Average of all Grades = {avg}");
                    break;

                // 4. Get the count of grades greater than a value (Entered by user)
                case "4":
                    
                    Console.Write("Enter the value: ");
                    int value = int.Parse(Console.ReadLine());
                    int countGreaterGrade = 0;
                    foreach (Student countGrade in students)
                    {
                        if (countGrade.Grade > value)
                        {
                            countGreaterGrade++;
                        }
                    }
                    Console.WriteLine($"count Grade Greater than{value} = {countGreaterGrade}");
                    break;

                // 5. Get the count of students with a specific age (Entered by user)
                case "5":
                    Console.WriteLine("Write the Age: ");
                    int speAge = int.Parse(Console.ReadLine());
                    int countAge = 0;
                    foreach (Student countSpeAge in students)
                    {
                        if (countSpeAge.Age == speAge)
                        {
                            countAge++;
                        }

                    }
                    Console.WriteLine($"The count of specific age =  {countAge}");
                    break;
            }
        }
    }
}
