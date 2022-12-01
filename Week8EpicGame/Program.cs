string folderPath = @"C:\Users\stena\OneDrive\Documents\data\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";
string weaponFile = "weapons.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));
string[] weapon = File.ReadAllLines(Path.Combine(folderPath, weaponFile));

//string[] heroes = { "Daemon Targaryen", "Arya Stark", "Volodymyr Zelenskiy", "Nick Cave" };
//string[] villains = { "Vladimir Putler", "Aemond Targaryen", "Evil Morty", "Five Finger Death Punch", "Mart Helme" };
//string[] weapon = { "HIMARS", "Caraxes", "great sword of steel and power", "pure love", "portal gun" };


string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day.");



string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world.");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string RandomStringFromArray = someArray[randomIndex];
    return RandomStringFromArray;
}
