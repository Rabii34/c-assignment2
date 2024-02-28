// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// ASSIGNMENT 2
//1) Write a C# program that takes two numbers as input from the user and performs the following
//arithmetic operations: 
Console.WriteLine("QUERY 1");
Console.WriteLine("Enter 1st number to perform Arithmetic operation");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd number to perform Arithmetic operation");
int n2 = Convert.ToInt32(Console.ReadLine());
////Addition
int add = n1 + n2;
Console.WriteLine($"The {n1} add by {n2} is : {add}");
////Subtraction
int sub = n1 - n2;
Console.WriteLine($"The {n1} subtract by {n2} is : {sub}");
////Multiplication
int mul = n1 * n2;
Console.WriteLine($"The {n1} multiply by {n2} is : {mul}");
////Division
int div = n1 / n2;
Console.WriteLine($"The {n1} divide by {n2} is : {div}");
////Modulus (Remainder)
int mod = n1 % n2;
Console.WriteLine($"The {n1} modulus by {n2} is : {mod}");

//2) Write a C# program to compare two numbers entered by the user and print whether the first
//number is greater than, less than, or equal to the second number.
Console.WriteLine("QUERY 2");
Console.WriteLine("Enter 1st number to perform comparision");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd number to perform comparision");
int num2 = Convert.ToInt32(Console.ReadLine());
//The first number is equal to the second number
if (num1 == num2)
{
    Console.WriteLine($"The {num1} is equal to {num2} ");
}
//The first number is greater than to the second number
else if (num1 > num2)
{
    Console.WriteLine($"The {num1} is greater than {num2} ");
}
//The first number is less than to the second number
else
{
    Console.WriteLine($"The {num1} is less than {num2} ");
}

//3) Write a C# program to print the multiplication table of a number entered by the user using
//a loop (for, while, or do-while).
Console.WriteLine("QUERY 3");
Console.WriteLine("Enter 1st number for multiplication");
int num = Convert.ToInt32(Console.ReadLine());
// multiplication table using for loop
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}

//4) Write a C# program to print a pattern of asterisks (*) in the following format
//using nested loops:
Console.WriteLine("QUERY 4");
int ast = 0;
for (int i = 0; i < 5; i++)
{

    for (int j = 0; j <= ast; j++)
    {
        Console.Write("*");
    }
    ast++;
    Console.Write("\n");
}

//5) Write a C# program to find the sum of all even numbers between 1 and 100 using loop
//control statements (break and continue).
Console.WriteLine("QUERY 5");
int even = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 2 != 0)
    {
        continue;
    }
    even += i;
}
Console.WriteLine($"The sum of all even numbers between 1 to 100 is: {even}");

//6) Write a C# program to reverse a string entered by the user without using any built-in
//reverse functions or methods.
Console.WriteLine("QUERY 6");
Console.WriteLine("Enter any string and get reversed answer");
var str = Console.ReadLine();
string input = "";
for (var i = str.Length - 1; i >= 0; --i)
{
    input += str[i];

}
Console.WriteLine(input);

//7) Write a C# program to print all the prime numbers between 1 and 100 using a loop and conditional statements.
Console.WriteLine("QUERY 7");
Console.WriteLine("Prime numbers between 1 and 100");
for (int i = 1; i <= 100; i++)
{
    int prime = 0;
    if (i > 1)
    {
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                prime = 1;
                break;
            }
        }
        if (prime == 0)
        {
            Console.Write(i + "\n");
        }
    }
 
}
