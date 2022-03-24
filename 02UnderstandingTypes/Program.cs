///////////////////////////////////////////////////////////////////////////////////////////////////
// Understanding Data Types
///////////////////////////////////////////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////////////////////////////////
// Test your Knowledge
///////////////////////////////////////////////////////////////////////////////////////////////////
/*
1.What type would you choose for the following "numbers"?
	- A person’s telephone number
		string
	- A person’s height
		float
	- A person’s age
		byte
	- A person’s gender (Male, Female, Prefer Not To Answer)
		string
	-A person’s salary
		decimal
	- A book’s ISBN
		string
	- A book’s price
		decimal
	- A book’s shipping weight
		float
	- A country’s population
		ulong
	- The number of stars in the universe
		BigInterger
	- The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business)
		ushort

2.What are the difference between value type and reference type variables? What is boxing and unboxing?
Value types are primitive data that directly hold the value, such as int, double, and such. The value is stored in the stack, can't by null, and won't be collected by the garbage collector. In addition, the user can create their own value type by implementing a struct or enum. On the other hand, reference types are data that hold the memory address to the value stored in the heap, such as string, StringBuiler, and any objects that created from the 'new' keyword. It is collected by the garbage collector, and the user can create their own reference type by implementing a class or interface.

Boxing is the process of converting a value type into an reference type object. And unboxing is the reverse.

3. What is meant by the terms managed resource and unmanaged resource in .NET
Managed resource are resources that the .NET framework knows about and will dispose of when the program close, while unmanaged resource are resources that the .NET framework doesn't know about so it can't dispose of when the program close.

4. Whats the purpose of Garbage Collector in .NET?
To release unused resources in memory.
*/

///////////////////////////////////////////////////////////////////////////////////////////////////
// Playing with Console App
///////////////////////////////////////////////////////////////////////////////////////////////////
{
	Console.WriteLine("Hacker Name Generator");

	Console.Write("Enter your favorite color: ");
	string color = Console.ReadLine()!;

	Console.Write("Enter your astrology sign: ");
	string sign = Console.ReadLine()!;

	Console.Write("Enter your street address number: ");
	int number = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine($"You hacker name is: {color}{sign}{number}");
}
Console.WriteLine();

///////////////////////////////////////////////////////////////////////////////////////////////////
// Practice number sizes and ranges
///////////////////////////////////////////////////////////////////////////////////////////////////
// 1
Console.WriteLine("1.");
{
	Console.WriteLine($"sbyte: {sizeof(sbyte)}");
	Console.WriteLine($"byte: {sizeof(byte)}");
	Console.WriteLine($"short: {sizeof(short)}");
	Console.WriteLine($"ushort: {sizeof(ushort)}");
	Console.WriteLine($"int: {sizeof(int)}");
	Console.WriteLine($"uint: {sizeof(uint)}");
	Console.WriteLine($"long: {sizeof(long)}");
	Console.WriteLine($"ulong: {sizeof(ulong)}");
	Console.WriteLine($"float: {sizeof(float)}");
	Console.WriteLine($"double: {sizeof(double)}");
	Console.WriteLine($"decimal: {sizeof(decimal)}");
}
Console.WriteLine();

// 2
Console.WriteLine("2.");
{
	Console.Write("Input: ");
	uint centuries = Convert.ToUInt32(Console.ReadLine());

	ulong years = centuries * 100;
	ulong days = years * 365;
	ulong hours = days * 24;
	ulong minutes = hours * 60;
	ulong seconds = minutes * 60;
	ulong milliseconds = seconds * 1000;
	ulong microseconds = milliseconds * 1000;
	ulong nanoseconds = microseconds * 1000;

	Console.WriteLine($"Output:" +
		$"{centuries} centuries" +
		$"= {years} years" +
		$"= {days} days" +
		$"= {hours} hours" +
		$"= {minutes} minutes" +
		$"= {seconds} seconds" +
		$"= {milliseconds} milliseconds" +
		$"= {microseconds} microseconds" +
		$"= {nanoseconds} nanoseconds"
	);
}
