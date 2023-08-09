double nota; // declarando a variavel nota

Console.WriteLine(" Qual a nota que voce tirou ? "); // pedindo a nota a o usuario
nota = double.Parse(Console.ReadLine());// Guardando informações

if (nota >= 8 && nota <= 10) // /se nota for menor ou igual a 10 e maior e igual a 8
{
    Console.WriteLine("Sua nota foi classificada como ótima"); // Mostrar isso na tela do usuario

}
else if (nota >=7 && nota <8) // então se nota for menor que 8 e maior ou igual a 7
{
    Console.WriteLine("Sua nota foi  classificada como bom"); // Mostrar isso na tela do usuario
}
else if (nota >= 5 && nota < 7) // //então se nota for menor que 7 e maior ou igual a 5
{
    Console.WriteLine("Sua nota foi classificada como regular"); // Mostrar isso na tela do usuario
}
else if (nota<5) // //então se a nota for menor que 5
{
    Console.WriteLine("Sua nota foi classificada como insatisfatória:"); // Mostrar isso na tela do usuario
}
else // qualquer coisa fora disso deve ser:
{
    Console.WriteLine("Nota Inválida"); // Mostrar isso na tela do usuario
}











