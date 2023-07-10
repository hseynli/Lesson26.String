string @string = @"
                               Jack and Jill
                               Went up the hill...
                              ";

Console.WriteLine(@string);

// Aşağıdakı iki string tipli dəyişən yaddaşın eyni ünvanında yerləşəcəkdir (string interning).
string string1 = "c:\\windows\\system32";
string string2 = @"c:\windows\system32";

Console.WriteLine("string1 = " + string1);
Console.WriteLine("string2 = " + string2);
Console.WriteLine("Object.ReferenceEqual(string1, string2): {0}",
    Object.ReferenceEquals(string1, string2));


// Yaddaşın köhnə ünvanına reference olacaq (interning) yeni dəyişən yaratmağa cəhd etmək

Console.WriteLine("\nEnter some string:");
string stringNew = String.Intern(Console.ReadLine());
//string stringNew = Console.ReadLine();
// Müqayisə.
Console.WriteLine("Object.ReferenceEqual(string1, stringNew): {0}",
    ReferenceEquals(string1, stringNew));

// Delay.
Console.ReadKey();