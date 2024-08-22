
/*
//Question 1: Write a C# program that prints your name, age, and favorite hobby on separate lines.
#region
Console.WriteLine($"Your name is {name}");
Console.WriteLine($"Your age is {age}");
Console.WriteLine($"Your hobby is {hobby}");
#endregion


//Question 2: Write a C# program that declares variables of different data types (int, double, string, bool) and assigns them values. Then, print these values to the console.
#region
// Variables
string name = "Mohamed";
int age = 20;
string hobby = "Football";
double gpa = 4.2;
bool isSuccessed = true;

// Print Lines
Console.WriteLine($"Your name is {name}");
Console.WriteLine($"Your age is {age}");
Console.WriteLine($"Your hobby is {hobby}");
Console.WriteLine($"Your hobby is {gpa}");
Console.WriteLine($"Your hobby is {isSuccessed}");
#endregion


//Question 3: Write a C# program that converts a temperature value from Celsius to Fahrenheit. The Celsius temperature should be stored in a variable.
#region
Console.Write("temperature value as Celsius = ");
int Celsius = int.Parse(Console.ReadLine());
double Fahrenheit = (Celsius * 1.8) + 32;
Console.WriteLine($"Fahrenheit of {Celsius} = {Fahrenheit}");
#endregion


//Question 4: Write a C# program that takes two numbers as input and performs the following operations: addition, subtraction, multiplication, and division. Print the results of each operation.
#region
Console.Write("Enter number One: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter number Two: ");
int num2 = int.Parse(Console.ReadLine());

int result = num1 + num2;
Console.WriteLine($"Addition = {result}");

result = num1 - num2;
Console.WriteLine($"Addition = {result}");

result = num1 * num2;
Console.WriteLine($"Addition = {result}");

result = num1 / num2;
Console.WriteLine($"Addition = {result}");
#endregion


//Question 5: Write a C# program that calculates the area of a rectangle. The program should prompt the user to enter the length and width of the rectangle, and then calculate and display the area.
#region
Console.Write("Enter Length of Rectangle: ");
double length = int.Parse(Console.ReadLine());

Console.Write("Enter Width of Rectangle: ");
double width = int.Parse(Console.ReadLine());

double area = length * width;
Console.WriteLine($"Area of rectangle {area}");
#endregion


//Question 6: Write a C# program that takes an integer as input and checks if it is even or odd. Print a message indicating whether the number is even or odd.
#region
Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"{num} is Even");
}
else
{
    Console.WriteLine($"{num} is Ood");
}
#endregion


//Question 7: Write a C# program that prompts the user to enter their age. If the age is 18 or older, print "You are eligible to vote." If the age is less than 18, print "You are not eligible to vote."
#region
Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You are eligible to vote.");
}
else
{
    Console.WriteLine("If the age is less than 18");
}
#endregion


//Question 8: Write a C# program that simulates a simple grading system. The program should prompt the user to enter a score (0-100), and then print the corresponding grade based on the following criteria:
//90-100: A
//80-89: B
//70-79: C
//60-69: D
//Below 60: F
#region
Console.Write("Enter your score: ");
int score = int.Parse(Console.ReadLine());

if (score <= 100 && score >= 90)
{
    Console.WriteLine($"your score {score} => A");
}
else if (score <= 89 && score >= 80)
{
    Console.WriteLine($"your score {score} => B");
}
else if (score <= 79 && score >= 70)
{
    Console.WriteLine($"your score {score} => C");
}
else if (score <= 69 && score >= 60)
{
    Console.WriteLine($"your score {score} => D");
}
else if (score <= 60 && score! > 0)
{
    Console.WriteLine($"your score {score} => F");
}
else
{
    Console.WriteLine($"your score {score} => is Wrong!!");
}
#endregion
*/