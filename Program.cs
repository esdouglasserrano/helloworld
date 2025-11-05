// Hello World
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("[Simple Hello World]");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Hello, World!");
Console.WriteLine();


// Strings
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("[Working With Strings]");
Console.ForegroundColor = ConsoleColor.White;
string firstFriend = "Erick";
string secondFriend = "Antoine";
string friends = $"My friends are {firstFriend} and {secondFriend}.";
Console.WriteLine(friends);
Console.WriteLine();


// Numbers
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("[Working With Numbers]");
Console.ForegroundColor = ConsoleColor.White;
decimal a = 14.44M;
decimal b = 15.55M;
decimal c = a + b;
Console.WriteLine($"The answer is {c}!");
Console.WriteLine();


// If Statements
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("[If Statements]");
Console.ForegroundColor = ConsoleColor.White;
int firstNumber = 5;
int secondNumber = 5;
if ((firstNumber + secondNumber) > 10)
{
  Console.WriteLine("The answer is greater than 10.");
}
if ((firstNumber + secondNumber) < 10)
{
  Console.WriteLine("The answer is less than 10.");
}
else
{
  Console.WriteLine("The answer is 10.");
}
Console.WriteLine();


// Do While Loop
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("[Do While Loop]");
Console.ForegroundColor = ConsoleColor.White;
int counter = 0;

do
{
  Console.WriteLine(counter);
  counter++;
}
while (counter < 5);
Console.WriteLine();


// For Loop
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("[For Loop]");
Console.ForegroundColor = ConsoleColor.White;
for (int i = 0; i < 5; i++)
{
  if (i == 3)
  {
    Console.WriteLine($"{i}!");
  }
  Console.WriteLine("Not three...");
}
Console.WriteLine();


// Lists
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("[Lists]");
Console.ForegroundColor = ConsoleColor.White;
var names = new List<string> { "Douglas", "Erick", "Antoine" };
names.Add("Kcits");
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

var numbers = new List<int> { 0, 14, 144 };
numbers.Add(21);
foreach (var number in numbers[0..4])
{
  Console.WriteLine($"One of my favorite numbers is {number}.");
}
Console.WriteLine();


// Arrays
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("[Arrays]");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(names[0]);
Console.WriteLine(names[1]);
Console.WriteLine(names[2]);
Console.WriteLine(names[^1]);

var cats = new String[] { "Chiqui", "Sultana", "Minino" };
cats = [.. cats, "Lily"];

int catNumber = 1;
foreach (var cat in cats)
{
  Console.WriteLine($"Cat #{catNumber} is called {cat}.");
  catNumber++;
}
Console.WriteLine();


// Sorting & Searching Lists
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("[Sorting & Searching Lists]");
Console.ForegroundColor = ConsoleColor.White;
names.Sort();
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
Console.WriteLine($"The name \"Antoine\" is now located at index {names.IndexOf("Antoine")} inside the \"names\" list.");
Console.WriteLine();


// Language Integrated Query (LINQ)
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("[Language Integrated Query (LINQ)]");
Console.ForegroundColor = ConsoleColor.White;
List<int> thoughts = [0, 1, 15, 14, 16, 37, 38, 55, 66, 9, 12];

for (int i = 0; i < thoughts.Count; i++)
{
  if (thoughts[i] > 49)
  {
    Console.WriteLine($"Found a floating thought over 49... it was {thoughts[i]}.");
  }
}

IEnumerable<int> thoughtQuery =
  from thought in thoughts
  where thought < 49 // Note this is now less than
  select thought;

Console.WriteLine("Here are some floating thoughts under 49...");
foreach (int i in thoughtQuery)
{
  Console.Write(i + " ");
}
Console.WriteLine("\n");


// LINQ Query Expression Basics
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("[LINQ Query Expression Basics]");
Console.ForegroundColor = ConsoleColor.White;

List<int> scores = [12, 49, 38, 22, 4, 18, 53];
IEnumerable<string> scoreQuery =
  from score in scores
  where score > 14
  orderby score descending
  select $"The score is {score}...";

foreach (string s in scoreQuery)
{
  Console.WriteLine(s);
}
Console.WriteLine("");