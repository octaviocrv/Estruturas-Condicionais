

double x,y,res; // Declarando variaveis


Console.WriteLine("Digite o valor inteiro de x"); // Pedindo o valor de X
x = double.Parse(Console.ReadLine());// Guardando informações digitadas pelo usuario


Console.WriteLine("Digite o valor inteiro de y");// Pedindo o valor de Y
y = double.Parse(Console.ReadLine()); // Guardando informações digitadas pelo usuario


res = x + y; // faça essa conta

if(res>=10) { // se RES for maior ou igual a 10
    
    res = res+5; // adicione 5 em res
    Console.WriteLine("Seu resultado é:" + res); // mostrar resultado para usuario

}

else { // se não faça essa

    res = res + 7; // adicionar 7 em res
    Console.WriteLine("o seu Número é: {0}", res);
}


