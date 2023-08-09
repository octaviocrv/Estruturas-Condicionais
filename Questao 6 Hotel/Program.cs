
double x,diaria,ocupacao,normal,diferença; // declarando variaveis

Console.WriteLine("Qual o valor normal da diaria ?"); // coletando dados do valor normal da diaria
x = double.Parse(Console.ReadLine()); // guardando informações


diaria = 0.75 * x; // calculo de variaveis


Console.WriteLine("O valor da diaria promocional vai ser de: R$ {0:f2} " , diaria); // mostrando valor da diaria promocial


ocupacao = diaria * 60; // calculo


Console.WriteLine("O valor total arrecadado com 80% de ocupação e diaria promocional é de: R$ {0:f2}" , ocupacao); // Mostrando o valor total arrecadado com 80% de ocupação e diaria promocional



normal = x* 37.5; // calculo



Console.WriteLine("O valor total arrecadado com 50% de ocupação e diaria normal R$ {0:f2}" , normal); // Mostrando o valor total arrecadado com 50% de ocupação e diaria normal


diferença = ocupacao - normal;  // calculo




Console.WriteLine("O dinheiro que você vai receber vai ter o valor  de : R$ {0:f2}",diferença);// mostrando a o usuario o quanto ele vai receber




