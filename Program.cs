using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("SmartPhone Nokia");
Smartphone nokia = new Nokia( numero: "6798455555", modelo: "Modelo1", imei: "asdasdad", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("TikTok");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone IPhone");
Smartphone iphone = new Iphone( numero: "67986688991", modelo: "ModeloX", imei: "fghjgjjfj", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");