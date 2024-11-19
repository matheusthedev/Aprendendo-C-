using pilaresPOO.Classes.Pilares;
Console.Clear();

ContaCorrente ctReis = new ContaCorrente();
ctReis.titular = "Matheus Reis";
ctReis.Depositar(1000f);

Console.WriteLine($"Titulas da conta: {ctReis.titular}");
Console.WriteLine($"Saldo inicial na conta: {ctReis.GetSaldo()}");

float valorSacado = ctReis.Sacar(200f);

Console.WriteLine($"Seu saque foi de: {valorSacado}");
Console.WriteLine($"Novo Saldo: {ctReis.GetSaldo()}");