using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Cari culture haqqında məlumatın alınmasıПолучение информации о текущей культуре.
CultureInfo currentCulture = CultureInfo.CurrentCulture;
Console.WriteLine("Cari lokal: {0}.", currentCulture);

Console.ReadKey();

// Sistemdə olan bütün culture haqqında məlumatın əldə edilməsi.
CultureInfo[] cultureInfo = CultureInfo.GetCultures(CultureTypes.AllCultures);
Console.WriteLine("Sistemdə {0} sayda culture var.", cultureInfo.Length);

foreach (CultureInfo ci in cultureInfo)
{
    Console.WriteLine(ci.EnglishName + " | " + ci.ToString());
}

// İstifadəçi tərəfindən yaradılmış bütün culture-ların alınması.
cultureInfo = CultureInfo.GetCultures(CultureTypes.UserCustomCulture);

if (cultureInfo.Length < 1)
{
    Console.WriteLine("İstifadə özü tərəfindən heç bir culture yaradılmamışdır.");
}
else
{
    Console.WriteLine("İsfidadəçi tərəfindən yaradılmış lokallar:");

    foreach (CultureInfo ci in cultureInfo)
    {
        Console.WriteLine(ci.EnglishName + " | " + ci.ToString());
    }
}

// Delay.
Console.ReadKey();