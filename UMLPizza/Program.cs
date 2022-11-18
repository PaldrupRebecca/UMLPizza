// See https://aka.ms/new-console-template for more information
using System.Xml.Schema;
using UMLPizza;

Customer c1 = new Customer("Børge Hansen", "bh@gmail.com", "Børgevej 23");
Customer c2 = new Customer("Hans Frederiksen","hans.fr@hotmail.com","Rosengade 7");
Customer c3 = new Customer("Lene Mogensen", "lene@mogensen.dk", "Poppelvænget 29");

//Console.WriteLine(c1.ToString());
//Console.WriteLine(c2.ToString());
//Console.WriteLine(c3.ToString());

Pizza p1 = new Pizza(3, "Capricciosa", 80, "tomato, cheese, ham & mushrooms");
Pizza p2 = new Pizza(11, "Naples", 79, "tomato, cheese, anchovies & olives");
Pizza p3 = new Pizza(9, "Gorgonzola", 85, "tomato, gorgonzola, onion & mushroom");

//Console.WriteLine(p1.ToString());
//Console.WriteLine(p2.ToString());
//Console.WriteLine(p3.ToString());

Order o1 = new Order(p1, c1);
Order o2 = new Order(p2, c2);
Order o3 = new Order(p3, c3);


Console.WriteLine(o1.ToString());

Console.WriteLine(o2.ToString());

Console.WriteLine(o3.ToString());

int DeliveryPrice = 40;

double TotalPrice = p1.Price + p2.Price + p3.Price + DeliveryPrice;

Console.WriteLine($"Total price, {TotalPrice} kr");