using Constructor;

Baby baby1 = new Baby//Default contructori kullanır.
{
    BirthDate = DateTime.Now,
    Name = "John",
    Surname = "Doe"
};
Console.WriteLine("First Baby:\nName: "+baby1.Name+"\nSurname: "+baby1.Surname+"\nBirth Date: "+baby1.BirthDate);

Baby baby2 = new Baby("Ebubekir", "Sıddık");//2. constuctori kullanır.
Console.WriteLine("First Baby:\nName: " + baby2.Name + "\nSurname: " + baby2.Surname + "\nBirth Date: " + baby2.BirthDate);
