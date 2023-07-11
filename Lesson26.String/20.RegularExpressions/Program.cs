using System.Text.RegularExpressions;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// | - (VƏ YA) şablonunu ifadə edir. 
string pattern = "test|str|aaaa";

var array = new string[4];
array[0] = "some text with test in it";
array[1] = "some text with str in it";
array[2] = "some text with aaaa in it";
array[3] = "some text with nothing in it";

var regex = new Regex(pattern);

foreach (string element in array)
{
    if (regex.IsMatch(element))
        Console.WriteLine("Sətir \"{0}\" bu şablona uyğun gəlir \"{1}\"", element, pattern);
    else
        Console.WriteLine("Sətir \"{0}\" bu şablona uyğun gəlmir \"{1}\"", element, pattern);
}

// Delay.
Console.ReadKey();