
double x, y; // declarando variaveis


Console.WriteLine("De o valor de X"); // Pedindo o valor de X
x = double.Parse(Console.ReadLine()); // Guardando as informações digitadas pelo usuario



if(x<=1) { // se x for menor ou igual a 1f
    
    y = 1; // faça isso
    Console.WriteLine("O valor de Y:" + y ); // mostra isso
}


else if (x>1&&x<=2) {  // então se x for maior que 1 e menor e igual a 2
    
    y=2; // faça isso
    Console.WriteLine("O valor de Y:" + y ); // mostra isso
}

else if(x>2&&x<=3) { // então se x for maior que 2 e menor ou igual a 3
    
    y= Math.Pow(x,2); // faça isso
    Console.WriteLine("O valor de Y:" + y ); // mostra isso
}


else if (x>3) { // se x for maior que 3
    
    y=Math.Pow(x,3);
    Console.WriteLine("O valor de Y:" + y ); // mostra isso
}

else // Quando nao for nada disso fazer isso
        
{
    Console.WriteLine("Inválido"); // mostrar ''invalido'' na tela do usuario
}








