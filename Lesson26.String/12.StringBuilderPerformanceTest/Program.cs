using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string simpleString = "";

DateTime time = DateTime.Now;

// Adi sətirlər üzrə sürətin yoxlanılması.
for (int i = 0; i < 100000; i++)
{
    simpleString += "a";
}

TimeSpan timeSS = DateTime.Now - time;

Console.WriteLine("Adi sətir {0} vaxta quruldu.", timeSS);

var builder = new StringBuilder();

time = DateTime.Now;

// StringBuilder-dən istifadə edərək sürətin yoxlanılması.
for (int i = 0; i < 100000; i++)
{
    builder.Append("a");
}

TimeSpan timeSB = DateTime.Now - time;

Console.WriteLine("StringBuilder köməkliyi ilə {0} vaxta quruldu.", timeSB);

Console.WriteLine("Adi sətrin uzunluğu: {0}", simpleString.Length);

simpleString = builder.ToString();

Console.WriteLine("StringBuilder sətrin uzunluğu: {0}", simpleString.Length);

// Delay.
Console.ReadKey();