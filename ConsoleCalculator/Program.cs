// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Console.ReadLine();
// Declare variables and then initialize to zero.
//int num1 = 0; int num2 = 0;
float num3 = 0.0f; float num4 = 0.0f;

// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number.
Console.WriteLine("Type a number, and then press Enter");
num3 = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number.
Console.WriteLine("Type another number, and then press Enter");
num4 = Convert.ToInt32(Console.ReadLine());

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your option? ");

// Use a switch statement to do the math.
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num3} + {num4} = " + (num3 + num4));
        break;
    case "s":
        Console.WriteLine($"Your result: {num3} - {num4} = " + (num3 - num4));
        break;
    case "m":
        Console.WriteLine($"Your result: {num3} * {num4} = " + (num3 * num4));
        break;
    case "d":
        Console.WriteLine($"Your result: {num3} / {num4} = " + (num3 / num4));
        break;
}
// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();
