using System.Text;
using System.Diagnostics;

Console.OutputEncoding = Encoding.UTF8;

string simpleString = "";

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

// Adi sətirlər üzrə sürətin yoxlanılması.
for (int i = 0; i < 100000; i++)
{
    simpleString += "a";
}

stopwatch.Stop();

Console.WriteLine("Adi sətir {0} vaxta quruldu.", stopwatch.Elapsed.TotalSeconds);

var builder = new StringBuilder();

stopwatch.Restart();

// StringBuilder-dən istifadə edərək sürətin yoxlanılması.
for (int i = 0; i < 100000; i++)
{
    builder.Append("a");
}


Console.WriteLine("StringBuilder köməkliyi ilə {0} vaxta quruldu.", stopwatch.Elapsed.TotalSeconds);

Console.WriteLine("Adi sətrin uzunluğu: {0}", simpleString.Length);

simpleString = builder.ToString();

Console.WriteLine("StringBuilder sətrin uzunluğu: {0}", simpleString.Length);

// Delay.
Console.ReadKey();