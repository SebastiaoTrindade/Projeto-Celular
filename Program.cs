using ProjetoCelular.Models;

// Realizando os testes

Smartphone nokia = new Nokia("112233445","N201",345634567,32);
Smartphone iphone = new Iphone("987654321","13",444444444,64);

nokia.Ligar();
nokia.InstalarAplicativo("cobrinha");
nokia.MostrarNumero();
nokia.Numero = "112233445";
nokia.MostrarNumero();

iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();

