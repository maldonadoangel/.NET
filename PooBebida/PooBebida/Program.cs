// See https://aka.ms/new-console-template for more information
using PooBebida.Models;

Console.WriteLine("Hello, World!");

Bebida bebida2 = new Bebida("Grapete", "Uva", 1000);
bebida2.beberse(500);
Console.WriteLine($"La bebida tiene un peso de: {bebida2.cantidad} ml actualmente, debido a que bebiste 500 ml");


//Herencia 
Cerveza cerveza = new Cerveza("Gallo", "Amargo", 200);
cerveza.beberse(100);
Console.WriteLine($"La cantidad que le queda a su cerveza es de: {cerveza.cantidad} ML");