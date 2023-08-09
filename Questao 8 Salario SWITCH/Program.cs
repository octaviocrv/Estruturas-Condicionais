char classe;
double salario,novosalario;

Console.WriteLine("Entre com o valor do seu salario"); // Pedindo para ele entrar com o salario atual 
salario = double.Parse(Console.ReadLine());// guardando as informações da variavel salario

Console.WriteLine("Escolha entre as opçoes: A(8%), B(11%) e C ( Aumneto fixo) "); // Mostrando as opçoes para o usuario escolher
classe = char.Parse(Console.ReadLine().ToLower()); // guardando as informações da variavel classe e usando ToLower para nao ter diferença entre A e a


switch (classe) // começando o switch comparativo entre as opçoes
{

        case 'a' : // caso digitar a
                novosalario = salario * 1.08; // fazer isso
                Console.WriteLine("Seu salario vai ser de: {0:f2} " , novosalario); // saida de dados do salario
                
        break; // quebra de fase do programa 


        case 'b' : // caso digitar b
                novosalario = salario * 1.11; // fazer isso
                Console.WriteLine("Seu salario vai ser de: {0:f2} " , novosalario); // saida de dados novosalario

        break; 

        case 'c' : // caso digitar b
                
               if ( salario <= 1000) { // se salario for menor ou igual a 1000 

                novosalario = salario + 350; // fazer isso
                Console.WriteLine("Seu Salário será: {0:f2}", novosalario); //saida de dados do salario

               }

               else if (salario > 1000) { // se nao salario menor que 1.000

                novosalario = salario + 200; // fazer isso
                Console.WriteLine("Seu salario vai ser de: {0:f2} " , novosalario); // mostrando isso na tela do usuario

               }

               break; // quebra de fase do programa 

               default: //caso não for nenhum dos caso fazer isso
                Console.WriteLine("Letra Inválida, tente A para(8%), B para (11%) e C para (Aumento Fixo)"); //saida de dados caso a letra indicada não for nenhuma das pedidas 
                break; //// quebra de fase do programa 
               

        








}              


                    



