// unnsigned integer means positive whole number or 0

uint naturalNumber = 23;

// integer means negative or positive whole number or 0

int integerNumber = -23;

// float means a single-precision floating point
//  F suffix makes it a float literal

float realNumber = 2.3F;

// double means a double-precision floating point
// double is the default type a number value with a decimal point

double anotherRealNumber = 2.3;

Console.WriteLine($"{naturalNumber} is a natural number");
Console.WriteLine($"{integerNumber} is a integer number");
Console.WriteLine($"{realNumber} is a real number");
Console.WriteLine($"{anotherRealNumber} is a another real number");

Console.WriteLine();

// Storing real numbers

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range of {int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range of {double.MinValue:N0} to {double.MaxValue:N0}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range of {decimal.MinValue:N0} to {decimal.MaxValue:N0}");