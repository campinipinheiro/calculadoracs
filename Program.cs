#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main(string[] args)

    {
        bool inputValido2 = false;

        bool continuar = true;
        float resultado = 0;
        float primeiroNum = 0;
        float segundoNum = 0;


        while(continuar) {

            if(primeiroNum!=0) {

                Console.WriteLine("Digite o segundo número: ");

                if(float.TryParse(Console.ReadLine(), out segundoNum)) {

                    inputValido2 = true;

                } else {

                    Console.WriteLine("Entrada Inválida. Por favor, forneça uma entrada válida.");

                }

            }

            bool inputValido = false;
            
            bool continuarOperacao = false;

            while(inputValido == false &&  continuarOperacao == false) {

                Console.WriteLine("Digite o primeiro número: ");

                if(float.TryParse(Console.ReadLine(), out primeiroNum)) {

                    inputValido = true;

                } else {

                    Console.WriteLine("Entrada Inválida. Por favor, forneça uma entrada válida.");

                }


            }

            while(!inputValido2) {

                Console.WriteLine("Digite o segundo número: ");

                if(float.TryParse(Console.ReadLine(), out segundoNum)) {

                    inputValido2 = true;

                } else {

                    Console.WriteLine("Entrada Inválida. Por favor, forneça uma entrada válida.");

                }


            }
            
            Console.WriteLine("Digite o operador (+, -, *, /): ");
            string operador = Console.ReadLine();

            

        while(true) {
            switch(operador)

            {
                case "+":
                    resultado = primeiroNum+segundoNum;
                    break;
                case "-":
                    resultado = primeiroNum-segundoNum;
                    break;
                case "*":
                    resultado = primeiroNum*segundoNum;
                    break;
                case "/":
                    if(segundoNum==0 || primeiroNum==0) {
                        Console.WriteLine("Não é possível dividir por zero.");
                        return;
                    }
                    resultado = primeiroNum/segundoNum;
                    break;
                default:
                    Console.WriteLine("Operador Inválido! Insira um operador válido (+, -, *, /):");
                    operador = Console.ReadLine();
                    continue;


            }

            break;
        }



            Console.WriteLine("Seu resultado é " +resultado);

            Console.WriteLine("Escolha uma opção:\n 1 - Utilizar Resultado Anterior; \n 2 - Realizar Nova Operação \n 3 - Sair");

            byte escolha = byte.Parse(Console.ReadLine());

            switch(escolha) {

                // Não está capturando o resultado e inserindo como primeiroNum.
                
                case 1:
                primeiroNum = resultado;
                continuarOperacao = true;
                Console.WriteLine("Resultado anterior foi atribuído como primeiro número.");
                break;

                case 2:
                continuar = true;
                break;

                case 3:
                continuar = false;
                break;

                default:
                Console.WriteLine("Opção Inválida. Encerrando.");
                continuar = false;
                break;




            }
        }

    }
}