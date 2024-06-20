using System.Xml;

object height = 1.88;
object name = "Miguel";

Console.WriteLine($"{name} is {height} meters tall");

// int length1 = name.Length;
int length2 = ((string)name).Length;

Console.WriteLine($"{name} has {length2} characters.");
Console.WriteLine();

// XML

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

// Target-typed new
// Specify the type first and then use new without repeating the type

Console.WriteLine("===== Target-typed new =====");

Person miguel = new();
miguel.BirthDate = new(1995, 10, 23);

Console.WriteLine(miguel.BirthDate.ToString());

Console.WriteLine();

List<Person> people = new()
{
	new()  { FirstName = "Leonisa"},
	new()  { FirstName = "Erel"},
	new()  { FirstName = "Lorene"}
};

Console.WriteLine(people.Count);

Console.WriteLine();

// Default values

Console.WriteLine("===== Default values =====");

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

Console.WriteLine();

int number = 13;

Console.WriteLine($"number has been set to: {number}");

number = default;

Console.WriteLine($"number has been reset to its default: {number}");

Console.WriteLine();