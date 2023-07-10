Console.OutputEncoding = System.Text.Encoding.UTF8;

// Fərqli tiplərdə bir neçə dəyişən yaradırıq.
Int32 myInt = 32;
Double myDouble = 32.32;

MyClass1 my1 = new MyClass1();
MyClass2 my2 = new MyClass2();

// ToString() metodunun işləməsinin nümunələri.
Console.WriteLine("Primitiv tiplər:");
string s1 = String.Format("myInt = {0:x} - dəyərin özü ekranda əks olunacaqdır.", myInt);
Console.WriteLine(s1);
Console.WriteLine("myDouble = {0} - dəyərin özü ekranda əks olunacaqdır.", myDouble);

Console.WriteLine("\nİstifadəçi tipləri:");
Console.WriteLine("my1 = {0} - Full clasification name ekranda əks olunacaqdır.", my1.ToString());
Console.WriteLine("my2 = {0} - override olunmuş metod işə düşəcəkdir.", my2);


// Delay.
Console.ReadKey();


class MyClass1
{
}

class MyClass2
{
    public override string ToString()
    {
        return "We changed the ToString()";
    }
}