using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123", modelo: "Iphone 1", imei: "11111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "321", modelo: "Nokia 1", imei: "22222222", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");