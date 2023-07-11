using System.Text.RegularExpressions;

Regex regex;
string pattern;
string text;

// Lazım olan simvolları mötərizədə yazmaq olar [].
pattern = "^[qwerty]+$";
text = "qwec"; // Analiz olunan sətir.
regex = new Regex(pattern);
Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

// Sətir ancaq qeyd olunan simvollardan ibarət ola bilər - [qwerty]. Məsələn:  qqq, yyqyqyyyq, eeer ...
pattern = "^[qwerty]+$";
text = "qrwere";  // Analiz olunan sətir.
regex = new Regex(pattern);
Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

pattern = "^[abcdefghigklmnopqrstuvwxyz]+$";
text = "test"; // Analiz olunan sətir.
regex = new Regex(pattern);
Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

// İkinci üsul, a-z şablonu yuxarıdakını əvəz edir abcdefghigklmnopqrstuvwxyz
pattern = @"^[a-z]+$";
text = "test"; // Analiz olunan sətir.
regex = new Regex(pattern);
Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

// 0-9 bu aralığı əvəz edir - 01234567890.
pattern = "^[a-z0-9]+$";
text = "test007"; // Analiz olunan sətir.
regex = new Regex(pattern);
Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

// 0-9 bu aralığı əvəz edir - 01234567890.
pattern = "^[a-z0-9]+$";
text = "test 007"; // Analiz olunan sətir.
regex = new Regex(pattern);
Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

// Tarix şablonu.
pattern = @"^\d{2}-\d{2}-\d{4}$";
text = "02-05-1982"; // Analiz olunan sətir.
regex = new Regex(pattern);
Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

// * kvantifikatoru onu deyir ki, daxil olunan sətir 0 və daha artıq ola bilər...
pattern = @"^\d*$";
text = "ertty"; // Analiz olunan sətir.
regex = new Regex(pattern);
Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

// * kvantifikatoru onu deyir ki, daxil olunan sətir 0 və daha artıq ola bilər...
pattern = @"^\d*$";
text = ""; // Analiz olunan sətir.
regex = new Regex(pattern);
Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

// Sadə e-mail şablonu.
pattern = @"^[0-9a-z_-]+@[\S]+\.\S{2,4}$";
text = "hseynli@list.ru"; // Analiz olunan sətir.
regex = new Regex(pattern);
Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

// Delay.
Console.ReadKey();