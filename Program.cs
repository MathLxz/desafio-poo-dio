using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone

Iphone iphone1 = new("11111111111", "S16", "2222222222222222", 128);
Nokia nokia1 = new("33333333333", "NB2", "4444444444444444", 256);

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Github");

Console.WriteLine("\n");

nokia1.Ligar();
iphone1.ReceberLigacao();
nokia1.InstalarAplicativo("Gmail");
