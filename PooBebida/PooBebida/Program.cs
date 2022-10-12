// See https://aka.ms/new-console-template for more information
using PooBebida.Models;

Console.WriteLine("Hello, World!");

Bebida bebida2 = new Bebida("Grapete", "Uva", 1000);
bebida2.beberse(500);
Console.WriteLine($"La bebida tiene un peso de: {bebida2.cantidad} ml actualmente, debido a que bebiste 500 ml");

