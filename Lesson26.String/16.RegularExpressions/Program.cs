using System.Text.RegularExpressions;
using System.Text;

// Requlyar ifadələr.

/*
 
  System.Text.RegularExpressions - bütün Regex-lərlər işləmək üçün mövcüd olan namespace-dir.  
 
  METASİMVOLLAR - axtarış şablonunu yaratmaq üçün mövcüd olan simvollardır.
       
  \d    rəqəmi təyin edir. 
  \D 	rəqəm olmayan ixtiyari simvolu təyin edir. 
  \w 	rəqəm, hərf və ya altdan xətt simvolunu təyin edir. 
  \W    rəqəm, hərf və ya altdan xətt simvolu olmayan bütün digər simvolları təyin edir. 
  \s 	boşluq da daxil olmaqla istənilən simvolu müəyyən edir. 
  \S  	tabulyasiya, yeni sətir və ya \r olmayan digər bütün simvollar.
   .    yeni sətir simvolundan başqa digər bütün simvolları təyin edir. 
  \.    . simvolunu təyin edir.
 
 */

Console.OutputEncoding = Encoding.UTF8;

string pattern = @"\d";

var regex = new Regex(pattern);

// Yoxlama üçün olan sətr tipli massiv.
var array = new[] { "test", "123", "test123test", "123test", "test123" };

foreach (string element in array)
{
    Console.WriteLine(
        regex.IsMatch(element)
            ? "\"{0}\" sətri şablona uyğundur \"{1}\""
            : "\"{0}\" sətri şablona uyğun deyil \"{1}\"", element, pattern);

    Console.WriteLine(new string('-', 50));
}

Console.WriteLine("\n\n");

while (true)
{
    Console.WriteLine("Müqayisə üçün sətr daxil edin: ");

    // Müqayisə ediləcək sətr.
    string input = Console.ReadLine();

    if (input == "exit")
        break;

    Console.WriteLine(
        input != null && regex.IsMatch(input)
            ? "\"{0}\" sətri şablona uyğundur \"{1}\""
            : "\"{0}\" sətri şablona uyğun deyil \"{1}\"", input, pattern);

    Console.WriteLine(new string('-', 50));
}