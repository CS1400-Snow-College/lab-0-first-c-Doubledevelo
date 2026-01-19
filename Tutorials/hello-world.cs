// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string aFriend = "Bill";
Console.WriteLine(aFriend);

aFriend = "Maira";
Console.WriteLine(aFriend);

Console.WriteLine("Hello, " + aFriend);

Console.WriteLine($"Hello, {aFriend}");

string firstFriend = "Maria";
string secondFriend = "Sage";

Console.WriteLine($"Hello, {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

string greeting = "        Hello World!        ";
Console.WriteLine($"[{greeting}]");

string trimmedgreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedgreeting}]");

trimmedgreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedgreeting}]");

trimmedgreeting = greeting.Trim();
Console.WriteLine($"[{trimmedgreeting}]");

string sayHello = "Hello, World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));