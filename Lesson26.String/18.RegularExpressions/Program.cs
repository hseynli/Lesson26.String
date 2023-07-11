using System.Text.RegularExpressions;

// Altsətri probel ilə əvəz etmək.
Console.WriteLine(Regex.Replace("test123aaa4x5x6bbb789ccc",  // Giriş sətri.
                                @"\d+",                      // Şablon.
                                 " "));                      // Dəyişiklik üçün şablon.

Console.WriteLine(Regex.Replace("test123aaa4x5x6bbb789ccc",  // Giriş sətri.
                               @"\d",                        // Şablon.
                                " "));                       // Dəyişiklik üçün şablon.

/*
 Şablon dəyişənlər - şablonda aşağıdakı formada təyin olunur:
 (?<somevar>\d+)   - dəyişənin təyin edilməsi.
 ${somevar}        - yeni şanlonda şablon dəyişikliyin istifadə olunması.
 Nümunə:  Regex.Replace(@"test123firststr456secondstr", 
                        @"test(?<first>\d+)firststr(?<second>\d+)secondstr", 
                        @"test${second}firststr${first}secondstr")
 Nümunə bu sətri test456firststr123secondstr elə dəyişəcək ki, 123 və 456 yerlərini dəyişəcəkdir. 
 */

Console.WriteLine(Regex.Replace(@"test123firststr456secondstr",                         // Giriş sətri.
                                @"test(?<var1>\d+)firststr(?<var2>\d+)secondstr",       // Şablon.
                                @"test${var2}firststr${var1}secondstr"));               // Dəyişiklik üçün şablon.

Console.WriteLine(Regex.Replace("5 is less than 10",                                   // Giriş sətri.
                                @"\d",                                                 // Şablon.
                                m => (int.Parse(m.Value) + 1).ToString()));            // Uyğunluğu dəyişən funksiya.

// Delay.
Console.ReadKey();