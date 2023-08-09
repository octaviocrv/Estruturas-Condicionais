int velocidade1 , velocidade2; // DECLARANDO VARIAVEIS 




Console.WriteLine("O motorista estava dirigindo em qual velocidade  ?"); // PEDINDO A VELOCIDADE 1 QUE O MOTORISTA ESTAVA
velocidade1 = int.Parse(Console.ReadLine()); // GUARDANDO AS INFORMAÇÕES

Console.WriteLine("Qual a velocidade permitida na via ? "); // PEDINDO A VELOCIDADE 2  PERMITIDA NA VIA
velocidade2 = int.Parse(Console.ReadLine());  // GUARDANDO AS INFORMAÇÕES

if (velocidade1<velocidade2) { // SE VELOCIDADE1 FOR MENOR QUE VELOCIDADE 2

        Console.Write("O motorista respeitou a lei"); // MOSTRAR ISSO NA TELA

}

else if ( velocidade1-velocidade2<=10) { // SE FOR VELOCIDADE 1-VELOCIDADE2 E MENOR IGUAL QUE 10

    Console.WriteLine("A multa é de R$50,00"); // MOSTRAR ISSO NA TELA


}

else if (velocidade1 - velocidade2 > 10 && velocidade1 - velocidade2<=30) { // SE FOR VELOCIDADE1 - VELOCIDADE 2 for menor ou igual a 30 

    Console.WriteLine("Multa de R$100,00"); // MOSTRAR ISSO NA TELA
}


else { // SE NAO FOR NADA DISSO

        Console.WriteLine("Multa de R$200,00"); // MOSTRAR ISSO NA TELA


}
