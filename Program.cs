using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
    Console.WriteLine("Smartphone Nokia: ");
    Smartphone nokia = new Nokia("555-234-857", "mini7", "123", 64);
    nokia.Ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("Instagram");

    Console.WriteLine("\n");

    Console.WriteLine("Smartphone iPhone: ");
    Smartphone iPhone = new Iphone("555-356-974", "13", "456", 120);
    iPhone.Ligar();
    iPhone.ReceberLigacao();
    iPhone.InstalarAplicativo("VSCO");