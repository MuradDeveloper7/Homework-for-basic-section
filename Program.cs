
//Soulution for thr first homework
System.Console.WriteLine("Enter day;(Dushanbe, Seshanbe, Chorshanbe, Panjshanbe, Juma, Shanbe, Yakshanbe):");
string days = Console.ReadLine();

string result = days switch
{
    "Dushanbe" => $"It is Monday",
    "Seshanbe" => $"It is Tuesday",
    "Chorshanbe" => $"It is Wednesday",
    "Panjshanbe" => $"It is Thursday",
    "Juma" => $"It is Friday",
    "Shanbe" => $"It is Saturday",
    "Yakshanbe" => $"It is Sunday ",
    _ => $"Sorry! Try again later to enter correct day!"
};

System.Console.WriteLine(result);



//Solution for the second homework
System.Console.WriteLine("Enter your number:");
int number = Convert.ToInt32(Console.ReadLine());
string str = "WELLCOME";

if (number >= 8)
{
    System.Console.WriteLine(str);
}
else
{
    System.Console.WriteLine("wellCOmE");
}


//Solution for the third home work
System.Console.WriteLine("Typr x  number");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Typr   number");
int y = Convert.ToInt32(Console.ReadLine());


if (x > y)
{
    System.Console.WriteLine("x is greater than y!");
}
else if (x < y)
{
    System.Console.WriteLine("x is less than y");
}
else if (x == y)
{
    System.Console.WriteLine("x nad y are equal");
}
else
{
    System.Console.WriteLine("x and y are not copmarable!");
}