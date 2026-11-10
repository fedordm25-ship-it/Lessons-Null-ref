var p = GetPerson();
Console.WriteLine(p?.Contacts?.Phone ?? "нет телефона");

static Person GetPerson()
{
    Person person = new Person() { Contacts = new Contacts() { Phone = "9577503795" } };
    return person;
}

class Person
{
    public Contacts Contacts { get; set; }
}

class Contacts
{
    public string? Phone { get; set; }
}


