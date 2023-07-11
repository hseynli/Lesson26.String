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

// Aşağıdakı şablon rəqəmi təyin etmək üçün istifadə olunur.
const string pattern = @"\d";

// Regex klasının instansını yaradırır və onun konstruktoruna təyin etdiyimiz şablonu ötürürük.
Regex regex = new Regex(pattern);

while (true)
{
    // Şablonun yoxlanılacağı sətir.
    string @string = Console.ReadKey().KeyChar.ToString();

    if (@string == " ")
        break;

    // Sətrin şablonu uyğunluğunu müyyən etmək. 

    // IsMatch - qəbul elədiyi arqumentin şablonu uyğunluğunu yoxlamaq üçün istifadə olunur. 
    // IsMatch - metodun qaytardığı tip - bool. True - əgər sətr şablona uyğun gəlibsə, false - əks halda.   
    bool success = regex.IsMatch(@string);

    Console.WriteLine(success ? " şablona uyğundur \"{0}\"" : " şablona uyğun deyil \"{0}\"", pattern);
}