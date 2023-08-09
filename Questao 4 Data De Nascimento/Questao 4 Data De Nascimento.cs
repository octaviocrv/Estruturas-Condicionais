double x, y; // Declarando variaveis
char res;// Declarando variaveis

Console.WriteLine("Digite o seu ano de nascimento"); // Pedindo a data de nascimento
x = double.Parse(Console.ReadLine()); // Guardando dados digitados pelo usuario
Console.WriteLine("Você já fez aniversário esse ano: ('S'/'N') "); // Perguntando se ele ja fez aniversario esse ano (Sim ou Nao)
res = char.Parse(Console.ReadLine().ToUpper()); // Guardando dados digitados pelo usuario


y = 2022 - x; // Operação Matematica

if (y >= 18 && res=='S') // se y for maior ou igual a 18 e a resposta for sim ....
{
    Console.WriteLine("A idade dele é : {0} e ele está apto a tirar Carteira de Habilitação", y); // Faça isso
}
else // Se não ...
{
    y = y - 1; // Faça isso
    Console.WriteLine("A idade dele é : {0} e ele NÃO está apto a tirar Carteira de Habilitação", y); // Mostrar na tela do
}

