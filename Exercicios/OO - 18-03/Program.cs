using OO.Models;

Customer c1 = new Customer();

c1.FirstName = "Gustavo";
c1.LastName = "Calliari";
c1.CustomerId = 1;
c1.Birthdate = new DateTime();
c1.EmailAddress = "gustavinhogameplay@gmail.com";

Address address1 = new Address();
address1.Street = "Santa Rech Demartini";
address1.District = "Amarante";
address1.City = "Videira";
address1.Number = 559;
address1.FederalState = "SC";
address1.Country = "Brasil";
address1.ZipCode = "89566-462";
address1.AddressType = AddressType.Commercial;

Console.WriteLine($"Nome: {c1.FirstName} {c1.LastName}" );
Console.WriteLine($"Email: {c1.EmailAddress} ");

c1.Addresses.Add(address1);

foreach(var ad in c1.Addresses)
{
    Console.WriteLine("--------------------------------");
    Console.WriteLine($"Rua: {ad.Street}");
    Console.WriteLine($"Bairro: {ad.District}");
    Console.WriteLine($"Numero: {ad.Number}");
    Console.WriteLine($"Cidade: {ad.City}");
    Console.WriteLine($"Estado: {ad.FederalState}");
    Console.WriteLine($"Pais: {ad.Country}");
    Console.WriteLine("--------------------------------");

}
