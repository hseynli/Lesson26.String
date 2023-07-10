using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Ekrana çıxarmaq istəyimiz məbləğ.
double money = 122343.45;

// Üç culture yaradırıq.
var american = new CultureInfo("en-US");
var germany = new CultureInfo("de-DE");
var russian = new CultureInfo("ru-RU");

// Lazım olan culture-a əsasında sətri format edirik və dəyəri dəyişəndə saxlayırıq.
string localMoney = money.ToString("C", american);
string result = String.Format("USA money: {0}", localMoney);

localMoney = money.ToString("C", germany);
result += String.Format("\nGermany money: {0}", localMoney);

localMoney = money.ToString("C", russian);
result += String.Format("\nRussian money: {0}", localMoney);

// Dəyəri ekranda əks elətdirik.
Console.WriteLine(result);