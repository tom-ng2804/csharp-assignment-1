///////////////////////////////////////////////////////////////////////////////////////////////////
// Arrays and Strings
///////////////////////////////////////////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////////////////////////////////
// Test your Knowledge
///////////////////////////////////////////////////////////////////////////////////////////////////
/*
1. When to use String vs.StringBuilder in C#?
You use StringBuilder for when you want to build or manipulate a string. Anything beside that, you use String.

2. What is the base class for all arrays in C#?
System.Object, or IEnumerable if you consider an interface as a class.

3. How do you sort an array in C#?
Array.Sort

4. What property of an array object can be used to get the total number of elements in an array?
Length

5. Can you store multiple data types in System.Array?
Array of 'System.Object' data type.

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
CopyTo will copy the current value from the current array to another existing array instance.
Clone will create a new array instance, copy the current values to the new array, and return that new array.

*/

///////////////////////////////////////////////////////////////////////////////////////////////////
// Practice loops and operators
///////////////////////////////////////////////////////////////////////////////////////////////////
// 1
Console.WriteLine("1.");
{
    int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] array2 = new int[10];
    for (int i = 0; i < array1.Length; ++i)
    {
        array2[i] = array1[i];
        Console.WriteLine($"array1: {array1[i]} | array2: {array2[i]}");
    }
}
Console.WriteLine();

// 2
Console.WriteLine("2.");
{
    List<string> todo = new();
    void PrintTodoList()
    {
        Console.WriteLine("----- Current List -----");
        foreach (string item in todo)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------");
    }

    while (true)
    {
        Console.Write("Enter command (+ item, - item, or -- to clear)): ");
        string command = Console.ReadLine()!;
        if (command.StartsWith("--"))
        {
            todo.Clear();
            PrintTodoList();
            break;
        }
        if (command.StartsWith("+"))
        {
            todo.Add(command.Substring(2));
            PrintTodoList();
            continue;
        }
        if (command.StartsWith("-"))
        {
            todo.Remove(command.Substring(2));
            PrintTodoList();
            continue;
        }
    }
}
Console.WriteLine();

// 3
{
    // The following function was taken and modified from: https://labuladong.gitbook.io/algo-en/iv.-high-frequency-interview-problem/print_primenumbers
    bool IsPrime(int n)
    {
        for (int i = 2; i * i <= n; ++i)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> results = new();
        while (startNum <= endNum)
        {
            if (IsPrime(startNum))
            {
                results.Add(startNum);
            }
            ++startNum;
        }
        return results.ToArray();
    }
}

// 4
Console.WriteLine("4.");
{
    Console.Write("Input Array: ");
    int[] numbers = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();

    Console.Write("Input K: ");
    int k = int.Parse(Console.ReadLine()!);

    int n = numbers.Length;
    int[] sums = new int[n];

    for (int r = 1; r <= k; ++r)
    {
        for (int i = 0; i < n; ++i)
        {
            sums[(i + r) % n] += numbers[i];
        }

    }

    Console.WriteLine($"sum[] {String.Join(" ", sums)}");
}
Console.WriteLine();

// 5
Console.WriteLine("5.");
{
    Console.Write("Input Array: ");
    int[] numbers = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();

    int maxCount = 0;
    int count = 1;
    int currentSequence = 0;
    for (int i = numbers.Length - 2; i >= 0; --i)
    {
        int prevNumber = numbers[i + 1];
        int currentNumber = numbers[i];
        if (currentNumber == prevNumber)
        {
            ++count;
            if (count >= maxCount)
            {
                currentSequence = prevNumber;
                maxCount = count;
            }
        }
        else
        {
            count = 1;
        }
    }

    for (int i = 0; i < maxCount; ++i)
    {
        Console.Write($"{currentSequence} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// 6
Console.WriteLine("6.");
{
    Console.Write("Input Array: ");
    List<int> numbers = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToList();

    Dictionary<int, int> frequencies = new();
    foreach (int number in numbers)
    {
        if (frequencies.ContainsKey(number))
        {
            ++frequencies[number];
        }
        else
        {
            frequencies.Add(number, 1);
        }
    }

    int maxFrequency = frequencies.Values.ToList().Max();
    var results = frequencies.Where(frequency => frequency.Value == maxFrequency);

    if (results.Count() == 1)
    {
        Console.WriteLine($"The number {results.First().Key} is the most frequent (occurs {results.First().Value} times)");
    }
    else
    {
        List<int> keys = results.Select(r => r.Key).ToList();
        keys.Sort();
        int leftMost = numbers.Find(keys.Contains);
        Console.WriteLine($"The numbers {String.Join(", ", keys)} have the same maximal frequence (each occurs {frequencies[numbers.Find(keys.Contains)]} times). The leftmost of them is {leftMost}.");
    }
}
Console.WriteLine();

///////////////////////////////////////////////////////////////////////////////////////////////////
// Practice Strings
///////////////////////////////////////////////////////////////////////////////////////////////////
// 1
Console.WriteLine("1.");
{
    Console.Write("Input String: ");
    string input = Console.ReadLine()!;

    Console.Write("Output Method 1: ");
    foreach (char c in input.ToArray().Reverse())
    {
        Console.Write(c);
    }
    Console.WriteLine();

    Console.Write("Output Method 2: ");
    for (int i = input.Length - 1; i >= 0; --i)
    {
        Console.Write(input[i]);
    }
    Console.WriteLine();
}
Console.WriteLine();

// 2
Console.WriteLine("2.");
HashSet<char> delimiters = new() { ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ', '.' };
{
    Console.Write("Input String: ");
    string input = Console.ReadLine()!;

    char[] chars = input.ToCharArray();
    string[] words = input.Split(delimiters.ToArray()).Where(w => w.Any()).Reverse().ToArray();
    int currentWord = 0;
    for (int i = 0; i < chars.Length; ++i)
    {
        char currentChar = chars[i];
        if (delimiters.Contains(currentChar))
        {
            if (i != 0 && !delimiters.Contains(chars[i - 1]))
            {
                Console.Write(words[currentWord]);
                ++currentWord;
            }
            Console.Write(currentChar);
        }
    }
}
Console.WriteLine();

// 3
Console.WriteLine("3.");
{
    Console.Write("Input String: ");
    string input = Console.ReadLine()!;
    
    List<string> results = new();
    string[] words = input.Split(delimiters.ToArray()).Where(w => w.Any()).ToArray();

    bool IsPalindrome(string str)
    {
        char[] chars1 = str.ToArray();
        char[] chars2 = str.ToArray().Reverse().ToArray();
        for (int i = 0; i < chars1.Length; ++i)
        {
            if (chars1[i] != chars2[i]) return false;
        }
        return true;
    }

    foreach (string word in words)
    {
        if (IsPalindrome(word))
        {
            results.Add(word);
        }
    }

    Console.WriteLine(String.Join(",", results));
}
Console.WriteLine();

// 4
Console.WriteLine("4.");
{
    Console.Write("Input String: ");
    string url = Console.ReadLine()!;

    int protocolEndIndex = url.IndexOf("://");
    string protocol = protocolEndIndex != -1 ? url.Substring(0, protocolEndIndex) : String.Empty;

    string serverAndResource = protocolEndIndex != -1 ? url.Substring(protocol.Length + 3) : url;
    int severEndIndex = serverAndResource.IndexOf("/");

    string server = severEndIndex != -1 ? serverAndResource.Substring(0, severEndIndex) : serverAndResource;
    string resource = severEndIndex != -1 ? serverAndResource.Substring(severEndIndex + 1) : String.Empty;

    Console.WriteLine($"[protocol] = \"{protocol}\"");
    Console.WriteLine($"[server] = \"{server}\"");
    Console.WriteLine($"[resource] = \"{resource}\"");
}
Console.WriteLine();
