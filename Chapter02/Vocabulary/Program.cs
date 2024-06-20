using System.Reflection;
using System.Text;

// System.Data.DataSet ds;
// HttpClient client;

Assembly? myApp = Assembly.GetEntryAssembly();

if (myApp == null) return;

foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
	Assembly a = Assembly.Load(name);

	int methodCount = 0;

	foreach (TypeInfo t in a.DefinedTypes)
	{
		methodCount += t.GetMethods().Count();
	}

	Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
		arg0: a.DefinedTypes.Count(),
		arg1: methodCount,
		arg2: name.Name
	);
}

Console.WriteLine();

double heightInMeters = 1.88;

Console.WriteLine($"The value of {nameof(heightInMeters)} has the value {heightInMeters}.");

Console.WriteLine();

// Output an emoji in the command line

Console.OutputEncoding = Encoding.UTF8;

string grinningEmoji = char.ConvertFromUtf32(0x1F600);

Console.WriteLine(grinningEmoji);

Console.WriteLine();

// Prefix with @ to use a verbatim literal string

string filePath = @"C:\televisions\sony\bravia.txt";

Console.WriteLine(filePath);

Console.WriteLine();

// Raw string literals

string xml = """
							<person age="5">
								<first_name>Mark</first_name>
							</person>
						""";

Console.WriteLine(xml);

var person = new { FirstName = "Alice", Age = 56 };

string json = $$"""
							{
								"first_name": "{{person.FirstName}}",
								"age": {{person.Age}},
								"calculation": "{{{1 + 2}}}";
							}
							""";

Console.WriteLine(json);