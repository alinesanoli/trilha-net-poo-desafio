using DesafioPOO.Models;

// Implementado!!
Console.WriteLine("Telefone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "5X Pro", imei: "454754788", memoria: 128);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("DIO");
nokia.InstalarAplicativo("Duolingo");

Console.WriteLine("\n");

Console.WriteLine("Telefone Iphone");
Smartphone iphone = new Iphone(numero: "45755", modelo: "xxxxxx", imei: "4s5df85sd5", memoria: 128);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
