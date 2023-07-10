using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var builder = new StringBuilder();

builder.Append("StringBuilder ").Append("çox ").Append("çox ");

string build1 = builder.ToString();

builder.Append("sürətlidir ...");

string build2 = builder.ToString();

Console.WriteLine(build1);
Console.WriteLine(build2);

// Delay.
Console.ReadKey();