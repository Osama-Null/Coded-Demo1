using System;
using System.Formats.Asn1;

Console.WriteLine("\nCHALLENGE 1\n");

// DataType Var-Name;
string fName = "Osama", lName = "Ash";
int n1 = 9, n2 = 14, n3 = n1 + n2;
Console.WriteLine(fName + " " + lName + ", Your number is: " + n3);
Console.WriteLine("______________________");

/*____________________________________________________________________________________________*/
Console.WriteLine("\nCHALLENGE 2\n");

string n4 = "23", n5 = "9", n6 = "7";
string total = (Convert.ToInt16(n4) + Convert.ToInt16(n5) + Convert.ToInt16(n6)).ToString();
Console.WriteLine("\n" + total);
Console.WriteLine("______________________");

/*____________________________________________________________________________________________*/
Console.WriteLine("\nCHALLENGE 3\n");

Console.Write("\nFull name: "); string fuName = Console.ReadLine();
Console.Write("City: "); string city = Console.ReadLine();
Console.WriteLine("\nYour full name is " + fuName + " and you your city is " + city);
Console.WriteLine("______________________");

/*____________________________________________________________________________________________*/
Console.WriteLine("\nCHALLENGE 4\n");

Console.Write("\nFirst number: "); int num1 = (Convert.ToInt16(Console.ReadLine()));
Console.Write("Second number: "); int num2 = (Convert.ToInt16(Console.ReadLine()));
int sum = num1 + num2;
Console.WriteLine("\nThe total: " + sum);
Console.WriteLine("______________________");

/*____________________________________________________________________________________________*/
Console.WriteLine("\nCHALLENGE 5\n");

Console.Write("\nEnter your avg: "); double avg = Convert.ToDouble(Console.ReadLine());
if (avg >= 50 && avg <= 100)
{
    Console.WriteLine("Passed");
}

else if (avg < 50 && avg <= 0)
{
    Console.WriteLine("Failed");
}

else Console.WriteLine("Out of range or Invalid input");
Console.WriteLine("______________________");
