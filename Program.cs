using System.Data;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

string firstFriend = "Erick";
string secondFriend = "Antoine";
string friends = $"My friends are {firstFriend} and {secondFriend}.";

Console.WriteLine(friends);

decimal a = 14.44M;
decimal b = 15.55M;
decimal c = a + b;

Console.WriteLine($"The answer is {c}!");

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

int counter = 0;

do
{
  Console.WriteLine(counter);
  counter++;
}
while (counter < 5);

for (int i = 0; i < 5; i++)
{
  if (i == 3)
  {
    Console.WriteLine($"{i}!");
  }
  Console.WriteLine("Not three...");
}

var names = new List<string> { "Douglas", "Erick", "Antoine" };
names.Add("Kcits");
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

var numbers = new List<int> { 0, 14, 144 };
numbers.Add(21);
foreach (var number in numbers)
{
  Console.WriteLine($"One of my favorite numbers is {number}.");
}

// Testing github stuff