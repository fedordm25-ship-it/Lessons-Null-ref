
static void Rename(Hero h) { h.Name = "Артур"; }
static void Replace(Hero h) { h = new Hero { Name = "Мерлин" }; }
static void ReplaceRef(ref Hero h) { h = new Hero { Name = "Моргана" }; }

var hero = new Hero { Name = "Бob" };
Rename(hero); Console.WriteLine(hero.Name);
Replace(hero); Console.WriteLine(hero.Name);
ReplaceRef(ref hero); Console.WriteLine(hero.Name);
class Hero { public required string Name; }
