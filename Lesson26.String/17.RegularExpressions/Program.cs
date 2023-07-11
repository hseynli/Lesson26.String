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
 
  KVANTİFİKATORLAR - qeyd edilən simvolun harada və neçə dəfə rast gələ bilinəcəyini təyin etmək üçün istifadə olunur.
 
  ^ - sətrin əvvəlindən. 
  $ - sətrin sonundan. 
  + - altşablonun bir və daha artıq rast gəlinməsi.  

 */

Console.OutputEncoding = Encoding.UTF8;

string pattern;

// ŞABLONLAR:

// altsətrin birdən daha çox rast gəlinməsi (\d+).
//pattern = @"\d+";     // "123", "test123", "123test", "te123st", "4556yyy789"

// lazım olan altsətr sətrin əvvəlində olmalıdır (\d+).
//pattern = @"^\d+";  // "123", "123test", "4556yyy789"

// lazım olan altsətr sətrin sonunda olmalıdır (\d+).
//pattern = @"\d+$";  // "123", "test123", "4556yyy789"

// bütün sətr əvvəldən (^) sona kimi ($) ^ və $ (bu halda \d) simvolları arasında olan patternə uyğun gəlməlidir.
//pattern = @"^\d+$"; // "123"

// sətrin əvvəlində və sonunda rəqəmlər, arasında isə rəqəm olmayan simvollar.
pattern = @"^\d*\D+\d+$"; // "4556yyy789"


var regex = new Regex(pattern);

// Yoxla üçün sətr tipində massiv.
var array = new[] { "test", "123", "test123", "123test", "te123st", "4556yyy789" };

foreach (String element in array)
{
    Console.WriteLine(
        regex.IsMatch(element)
            ? "\"{0}\" sətri şablona uyğundur \"{1}\""
            : "\"{0}\" sətri şablona uyğun deyil \"{1}\"", element, pattern);

    Console.WriteLine(new string('-', 50));
}

// Delay.
Console.ReadKey();