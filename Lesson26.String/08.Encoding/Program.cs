using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Kodirovkanın dəyişdirilməsi üçün sətir.
string leUnicodeStr = "apple!";

// Kodirovka parametrləri.

// Unicode - UTF-16 formatı üçün ardıcıl baytlar əsasında kodirovka alır.
Encoding leUnicode = Encoding.Unicode;

// BigEndianUnicode - UTF-16 formatı üçün əks ardıcıl baytlar əsasında kodirovka alır.
Encoding beUnicode = Encoding.BigEndianUnicode;

// UTF8 - UTF-8 formatı üçün kodirovka alır.
Encoding utf8 = Encoding.UTF8;

// Sətirləri baytdan ibarət massivə çevirmək.
byte[] leUnicodeBytes = leUnicode.GetBytes(leUnicodeStr);                       // Unicode.
byte[] beUnicodeBytes = Encoding.Convert(leUnicode, beUnicode, leUnicodeBytes); // Endian Unicode.
byte[] utf8Bytes = Encoding.Convert(leUnicode, utf8, leUnicodeBytes);           // UTF8.

// Massivin tərkiblərini ekrana çıxarırıq.
Console.WriteLine("Yaradılan sətir: {0}\n", leUnicodeStr);


Console.WriteLine("Unicode, birinci kiçiyi:");
var builder = new StringBuilder();
foreach (byte b in leUnicodeBytes)
{
    builder.Append(b).Append(":");
}
Console.WriteLine("{0}\n", builder);


Console.WriteLine("Unicode, birinci böyüyü:");
builder = new StringBuilder();
foreach (byte b in beUnicodeBytes)
{
    builder.Append(b).Append(":");
}
Console.WriteLine("{0}\n", builder);


Console.WriteLine("UTF baytları:");
builder = new StringBuilder();
foreach (byte b in utf8Bytes)
{
    builder.Append(b).Append(":");
}
Console.WriteLine(builder.ToString());

// Delay.
Console.ReadKey();