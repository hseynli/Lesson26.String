using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// UTF7 kodirovkasında faylın yaradılması.
string file = "file.txt";
StreamWriter writer = new StreamWriter(file, false, Encoding.UTF7);
writer.WriteLine("Salam, dünya!");
writer.Close();

// Faylın tərkibini birbaşa kodirovka göstərərək oxumaq.
StreamReader reader = new StreamReader(file, Encoding.UTF7);
Console.WriteLine(reader.ReadToEnd());
reader.Close();

// Kodirovka göstərmədən faylın tərkibini oxumaq.
reader = new StreamReader(file);
Console.WriteLine(reader.ReadToEnd());
reader.Close();

// Delay.
Console.ReadKey();