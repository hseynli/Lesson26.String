using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Cari reqion haqqında məlumatın əldə edilməsi.
RegionInfo regionInfo = RegionInfo.CurrentRegion;
Console.WriteLine("EnglishName region:\t{0}.", regionInfo.EnglishName);
Console.WriteLine("NativeName region:\t{0}.", regionInfo.NativeName);

Console.WriteLine(new string('-', 35));

Console.WriteLine("CurrencySymbol region:\t{0}", regionInfo.CurrencySymbol);
Console.WriteLine("CurrencyEnglishName:\t{0}", regionInfo.CurrencyEnglishName);
Console.WriteLine("CurrencyNativeName:\t{0}", regionInfo.CurrencyNativeName);

Console.WriteLine(new string('-', 35));

// Cari tarix formatının əldə edilmədi: günlərin adları.
string[] days = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;

Console.WriteLine("Həftənin günləri:");
foreach (string day in days)
{
    Console.WriteLine(day);
}

Console.WriteLine(new string('-', 35));

// Alman dilində cari tarixin əldə edilməsi: günlərin adları.
days = CultureInfo.GetCultureInfo("de-DE").DateTimeFormat.DayNames;

Console.WriteLine("Həftənin günləri alman dilində:");
foreach (string day in days)
{
    Console.WriteLine(day);
}

// Delay.
Console.ReadKey();