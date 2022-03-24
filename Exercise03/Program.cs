///////////////////////////////////////////////////////////////////////////////////////////////////
// Controlling Flow and Converting Types
///////////////////////////////////////////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////////////////////////////////
// Test your Knowledge
///////////////////////////////////////////////////////////////////////////////////////////////////
/*
1.What happens when you divide an int variable by 0?
System.DivideByZeroException is thrown.

2. What happens when you divide a double variable by 0?
You get infinity.

3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
That value will just retain its max value.

4. What is the difference between x = y++; and x = ++y;?
The postfix increment will returns the value then increment, so y will set to x then y increase by 1.
While prefix increment will increment then return the value, so y will increase by 1 then x is set to y.

5. What is the difference between break, continue, and return when used inside a loop statement?
break will exit out the current scope. continue will go to the next iteration, in other words, back to the top of the loop again, and return will exit out the function entirely.

6. What are the three parts of a for statement and which of them are required?
initialization, condition, and iterator.

7. What is the difference between the = and == operators?
= is an assignment operator.
== is an equality operator.

8. Does the following statement compile? for ( ; true; ) ;
yes

9. What does the underscore _ represent in a switch expression?
default

10. What interface must an object implement to be enumerated over by using the foreach statement?
IEnumerable

*/

///////////////////////////////////////////////////////////////////////////////////////////////////
// Practice loops and operators
///////////////////////////////////////////////////////////////////////////////////////////////////
// 1
Console.WriteLine("1.");
{
    for (int i = 0; i < 100; ++i)
    {
        bool isFizz = i % 3 == 0;
        bool isBuzz = i % 5 == 0;
        if (isFizz && isBuzz)
        {
            Console.WriteLine("fizzbuzz");
            continue;
        }
        if (isFizz)
        {
            Console.WriteLine("fizz");
            continue;
        }
        if (isBuzz)
        {
            Console.WriteLine("buzz");
            continue;
        }
    }
}
Console.WriteLine();

// 2
Console.WriteLine("2.");
{
    int rows = 5;
    int cols = 9;
    int padding = cols / 2;
    for (int i = 0; i < rows; ++i)
    {
        for (int j = 0; j < padding; ++j)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < cols - (padding * 2); ++j)
        {
            Console.Write("*");
        }
        for (int j = 0; j < padding; ++j)
        {
            Console.Write(" ");
        }
        --padding;
        Console.WriteLine();
    }
}
Console.WriteLine();

// 3
Console.WriteLine("3.");
{
    int correctNumber = new Random().Next(3) + 1;
    Console.WriteLine("Guess The Number");
    while (true)
    {
        Console.Write("Your guess: ");
        int guessedNumber = int.Parse(Console.ReadLine()!);
        if (guessedNumber < 1 || guessedNumber > 3)
        {
            Console.WriteLine("Out of bound");
            continue;
        }
        if (guessedNumber < correctNumber)
        {
            Console.WriteLine("Low");
            continue;
        }
        if (guessedNumber > correctNumber)
        {
            Console.WriteLine("High");
            continue;
        }
        Console.WriteLine("Correct");
        break;
    }
}
Console.WriteLine();

// 4
Console.WriteLine("4.");
{
    Console.Write("Enter your bithdate (YYYY-MM-DD): ");
    DateOnly inputDate = DateOnly.Parse(Console.ReadLine()!);
    int ageInDays = DateOnly.FromDateTime(DateTime.Now).DayNumber - inputDate.DayNumber;
    Console.WriteLine($"You are {ageInDays} days old.");
    Console.WriteLine($"Your next 10,000 days anniversay is on {inputDate.AddDays(10000).ToString("yyyy-MM-dd")}.");
}
Console.WriteLine();

// 5
Console.WriteLine("5.");
{
    int currentHour = DateTime.Now.Hour;
    void Greet()
    {
        if (currentHour < 12)
        {
            Console.WriteLine("Good Morning");
            return;
        }
        if (currentHour < 18)
        {
            Console.WriteLine("Good Afternoon");
            return;
        }
        if (currentHour < 21)
        {
            Console.WriteLine("Good Evening");
            return;
        }
        if (currentHour < 24)
        {
            Console.WriteLine("Good Night");
            return;
        }

    }
    Greet();
}
Console.WriteLine();

// 6
Console.WriteLine("6.");
{
    for (int i = 1; i <= 4; ++i)
    {
        for (int j = 0; j < 24; j += i)
        {
            Console.Write($"{j},");
        }
        Console.WriteLine(24);
    }
}
