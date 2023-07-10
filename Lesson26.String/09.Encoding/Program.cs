using System.Text;

var swUtf7 = new StreamWriter("text.txt", true, Encoding.UTF7);
swUtf7.WriteLine("Hello, world!");
swUtf7.Close();

// UTF8
var swUtf8 = new StreamWriter("text.txt", true, Encoding.UTF8);
swUtf8.WriteLine("Hello, world!");
swUtf8.Close();

// Unicode
var swUtf16 = new StreamWriter("text.txt", true, Encoding.Unicode);
swUtf16.WriteLine("Hello, world!");
swUtf16.Close();

// UTF32
var swUtf32 = new StreamWriter("text.txt", true, Encoding.UTF32);
swUtf32.WriteLine("Hello, world!");
swUtf32.Close();

//File.WriteAllText("text.txt", "Hello World!", Encoding.BigEndianUnicode);

Console.WriteLine(File.ReadAllText("text.txt"));
// Delay.
Console.ReadKey();