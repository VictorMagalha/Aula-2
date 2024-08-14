double numero1;
double numero2;

Console.WriteLine("Digite o primeiro numero para as equaçoes: ");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo numero para as equaçoes: ");
numero2 = Convert.ToDouble(Console.ReadLine());

double soma = numero1 + numero2;
double subtracao = numero1 - numero2;
double divisao = numero1 / numero2;
double multiplicacao = numero1 * numero2;

Console.WriteLine("O valor da soma dos numeros é, " + soma);
Console.WriteLine($"O valor da subtracao dos numeros é: {subtracao}");
Console.WriteLine(string.Format("O valor da multiplicacao dos numeros é: {0}", multiplicacao));
Console.WriteLine(string.Format("O valor da divisao dos numeros é: {0}", divisao));