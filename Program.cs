using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia1 = new Nokia(numero: "79 1234-5678", modelo: "Modelo 1", imei: "111111111", memoria: 128);
nokia1.Ligar();
nokia1.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone1 = new Iphone(numero: "11 8765-4321", modelo: "Modelo 2", imei: "222222222", memoria: 256);
iphone1.Ligar();
iphone1.InstalarAplicativo("Telegram");