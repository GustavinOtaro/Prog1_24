﻿using Aula04_01.Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer c1 = new Customer();
c1.CustomerId = 1;
c1.Name = "Jaguara";
c1.EmailAddress = "jaguara@pixotge.net";


// Construtor por Instanciação 
Customer c2 = new Customer(2);
c1.Name = "Boca-Mole";
c1.EmailAddress = "bocamole@pixotge.net";


// Contrutor por atribuição 
Customer c3 = new Customer
{
    CustomerId = 3,
    Name = "Nerso",
    EmailAddress = "nerso@pixote.net"
};