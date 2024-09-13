//Odd or even

using System.ComponentModel.Design;

int a = 11;

int result = a % 2;

// % is a modulus operator; 0 - means number is even and 1 means number is odd

Console.WriteLine(result);

//if (result == 0)
//{
//    Console.WriteLine($"{a} is an even number");
//}
//else
//{
//    Console.WriteLine($"{a} is an odd number");
//}

switch (result)
{
    case 0:
        Console.WriteLine($"{a} is an even number");
        break;
    case 1:
        Console.WriteLine($"{a} is an odd number");
        break;
    default:
        Console.WriteLine("Invalid value");
        break;
}