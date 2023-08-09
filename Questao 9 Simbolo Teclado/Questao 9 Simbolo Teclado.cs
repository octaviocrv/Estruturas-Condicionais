char simbolo;


Console.WriteLine("Entre com um desses simbolos: <,>,=,+,");
simbolo = char.Parse(Console.ReadLine());

switch (simbolo) 
{
    case '<' : // caso entre com <
         
         Console.WriteLine("SINAL DE MENOR"); // mostrar isso

    break; // pula de fase

            case '>' : // caso entre com +
         
         Console.WriteLine("SINAL DE MAIOR"); // mostrar isso

    break; // pula de fase

        case '=' : // caso entre com =
         
         Console.WriteLine("SINAL DE IGUAL"); // mostrar isso

    break; // pula de fase

        case '+' : // caso entre com !
         
         Console.WriteLine("SINAL DE SOMA"); // mostrar isso

    break; // pula de fase

      default: //caso não for nenhum dos simbolos fazer isso
                
                Console.WriteLine("Simbolo Invalido por favor siga as instuções"); //saida de dados default
                
                break; //pular de fase


}    