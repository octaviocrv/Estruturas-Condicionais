double a,b,x; // Declarando variaveis

Console.WriteLine("Escreva o coeficiente de A "); // Pedindo a o usuario informar valor de A
a = double.Parse(Console.ReadLine()); // Guardando as informações digitadas


Console.WriteLine("Escreva o coeficiente de B"); // Pedindo a o usuario informar valor de b
b = double.Parse(Console.ReadLine()); // Guardando as informações digitadas

x = -b/a; // Conta pra saber a raiz


Console.WriteLine("O valor da raiz da equação é:" + x);  // mostrar para o usuario



