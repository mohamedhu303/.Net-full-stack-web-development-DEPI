// Question 1: Write a C# program that prints the first 10 multiples of 5 using a do-while loop.
#region
//int x = 5;
//do
//{
//    Console.WriteLine(x);
//    x += 5;
//}
//while (x <= 50);
//Console.ReadKey();
#endregion


// Question 2: Write a C# program that calculates the factorial of a given number.
#region
//Console.Write("Enter the number: ");
//int num = int.Parse(Console.ReadLine());

//if (num == 0)
//{
//    Console.WriteLine("Not a factorial");
//}
//else
//{
//    int result = 1;
//    for (int i = 1; i <= num; i++)
//    {
//        result *= i;
//    }
//    Console.WriteLine($"The factorial is = {result}");
//}
//Console.ReadKey();
#endregion


//Question 3: Write a C# program that calculates and prints the sum of all even numbers between 1 and 100 using a for loop.
#region
//int sum = 0;
//for (int i = 1; i<=100; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine($"The sum is = {sum}");
//Console.ReadKey();
#endregion


// Question 4: Write a C# program that prints the multiplication table for all numbers from 1 to 12.
#region
//int num = 0;
//for (int i = 1; i<=12; i++)
//{
//    Console.WriteLine($"multiplication table of {i}");
//    for (int j = 1; j <= 12; j++)
//    {
//        int result = i * j;
//        Console.WriteLine($"multiple of {i} and {j} = {result}");
//    }
//    Console.WriteLine("==================================");
//}
//Console.ReadKey();
#endregion


// Question 5: Write a C# program that prints all prime numbers between 1 and 500.
#region
//bool isPrime = true;
//for (int i = 2; i <= 100; i++)
//{
//    for (int j = 2; j <= 100; j++)
//    {

//        if (i != j && i % j == 0)
//        {
//            isPrime = false;
//            break;
//        }

//    }
//    if (isPrime)
//    {
//        Console.WriteLine(i);
//    }
//    isPrime = true;
//}
//Console.ReadKey();
#endregion


// Question 6: Write a C# program that prints the following pattern using a loop:
//a
//ab
//abc
//abcd
//abcde
#region
//for (int i = 1; i <= 5; i++)
//{
//    for (char ch = 'a'; ch < 'a' + i; ch++)
//    {
//        Console.Write(ch);
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();
#endregion


// Question 7: Write a C# program that creates an array of 10 integers and finds the maximum and minimum elements in
// the array using a for loop.
#region
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//int max = arr[0];
//int min = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < min)
//    {
//        min = arr[i];
//    }
//    if (arr[i] > max)
//    {
//        max = arr[i];
//    }
//}
//Console.WriteLine($"minimum number is {min}");
//Console.WriteLine($"maximum number is {max}");

//Console.ReadKey();
#endregion


// Question 8: Write a C# program that reverses the elements of an array and prints the reversed array. Use a for loop.
#region
//int[] arr = { 1, 2, 3, 4, 5, 6 };
//int newArr = arr.Length - 1;

//for(int i = newArr; i>=0; i--)
//{
//    Console.WriteLine($"arr[{i}] = {arr[i]}");
//}
//Console.ReadKey();
#endregion


// Question 9: Write a C# program that prompts the user to enter 5 integers and stores them in an array. Then, the program
// should print the array elements in reverse order using a while loop.
#region
//int[] array = new int[5];
//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write($"Enter the input {i+1} = ");
//    array[i] = int.Parse(Console.ReadLine());
//}
//int num = array.Length - 1;
//while (num >= 0)
//{
//    Console.WriteLine($"array[{num}] = {array[num]}");
//    num--;
//}
#endregion


// Question 10: Write a C# program that prints all numbers from 1 to 100 but skips numbers that are multiples of 3 using a
// for loop.
#region
//for (int i = 1; i<= 100; i++)
//{
//    if(i%3 == 0)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}
#endregion


//Question 11: Write a C# program that checks if a given number is prime. If it is prime, print "Prime" otherwise,
//print "Not Prime".
#region
//Console.Write("Enter the number: ");
//int num = int.Parse(Console.ReadLine());

//if (num == 2 || num == 3)
//{
//    Console.WriteLine("Prime");
//}
//else if (num == 0 || num == 1 || num%2 == 0)
//{
//    Console.WriteLine("Not Prime");
//}
//else if (num % 3 != 0)
//{
//    Console.WriteLine("Prime");
//}
//Console.Read();
#endregion


// Question 12: Write a C# program that finds and prints the first 20 prime numbers.
#region
//int count = 0; 
//int num = 2;   
//while (count < 20)
//{
//    bool isPrime = true;
//    if (num > 1)
//    {
//        if (num == 2 || num == 3)
//        {
//            isPrime = true;
//        }
//        else if (num % 2 == 0 || num % 3 == 0)
//        {
//            isPrime = false;
//        }
//        else
//        {
//            for (int i = 5; i * i <= num; i += 6)
//            {
//                if (num % i == 0 || num % (i + 2) == 0)
//                {
//                    isPrime = false;
//                    break;
//                }
//            }
//        }
//    }
//    else
//    {
//        isPrime = false;
//    }

//    if (isPrime)
//    {
//        Console.WriteLine(num);
//        count++;
//    }

//    num++;
//}
#endregion


// Question 13: Write a C# program that prints the count of even/odd/positive/negative values in an given array.
#region
//int[] arr = { 1, 2, 3, -4, 5, 6, 7, -8, 9 };

//int even = 0; int odd = 0; int postive = 0; int negative = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if(arr[i]%2 == 0)
//    {
//        even++;
//        if (arr[i] > 0)
//        {
//            postive++;
//        }
//        else
//        {
//           negative++;
//        }
//    }
//    else
//    {
//        odd++;
//        if (arr[i] > 0)
//        {
//            postive++;
//        }
//        else
//        {
//            negative++;
//        }
//    }
//}
//Console.WriteLine($"postive number = {postive}");
//Console.WriteLine($"negative number = {negative}");
//Console.WriteLine($"odd number = {odd}");
//Console.WriteLine($"even number = {even}");
#endregion


// Question 14: Write a C# program that generates the Fibonacci sequence up to a specified number of terms entered by the user.
#region
//Console.Write("Enter number: ");
//int num = int.Parse(Console.ReadLine());

//if (num <= 0)
//{
//    Console.WriteLine("Position must be a positive integer.");
//}
//else
//{
//    int fub = 0;
//    for (int i = 1; i <= num; i++)
//    {
//        fub += i;
//    }
//    Console.WriteLine($"Fibonacci is {fub}");
//}
#endregion


// Question 15: Write a C# program that checks if an given array is palindrome or not.
#region
//Console.Write("Enter the number of elements: ");
//int n = int.Parse(Console.ReadLine());

//int[] array = new int[n];
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Enter element {i + 1}: ");
//    array[i] = int.Parse(Console.ReadLine());
//}

//bool isPalindrome = true;
//int start = 0;
//int end = n - 1;
//while (start < end)
//{
//    if (array[start] != array[end])
//    {
//        isPalindrome = false;
//        break;
//    }
//    start++;
//    end--;
//}
//if (isPalindrome)
//{
//    Console.WriteLine("The array is a palindrome.");
//}
//else
//{
//    Console.WriteLine("The array is not a palindrome.");
//}
#endregion