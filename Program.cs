using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "111111", modelo: "modelo nokia", imei: "imei nokia", memoria: 64);
Smartphone iphone = new Iphone(numero: "222222", modelo: "modelo iphone", imei: "imei iphone", memoria: 32);

Console.WriteLine("------------------------------");
iphone.InstalarAplicativo("Instagram");
iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine("------------------------------");
nokia.InstalarAplicativo("Snake");
nokia.Ligar();
nokia.ReceberLigacao();