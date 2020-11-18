using System;

namespace Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem 
            // caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.


            // Console.WriteLine("Digite a nota entre Zero e Dez");
            // int nota = int.Parse(Console.ReadLine());

            // while(nota != 8)
            // {
            //     Console.WriteLine("Errou!");
            //     Console.WriteLine("Tente novamente");
            //     nota = int.Parse(Console.ReadLine());
            // }
            //     Console.WriteLine("Acertou!");


            // 2 - Faça um programa que leia um nome de usuário e a sua senha e não aceite
            // a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando 
            // a pedir as informações.

            // string senha = "";
            // string usuario = "";
            
            // Console.WriteLine("Digite o Usuário!");
            // usuario = Console.ReadLine();
            // Console.WriteLine("Digite a senha!");
            // senha= Console.ReadLine();

            
            // Console.WriteLine("confirmado");




            // 3 - Faça um programa que leia e valide as seguintes informações:

            // 1. Nome: diferente de vazio;
            // 2. Idade: entre 0 e 150;
            // 3. Salário: maior que zero;
            // 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));


            string nome;
            int idade;
            int salario;
            string ec;

            Console.WriteLine("Digite seu nome: ");
            nome = (Console.ReadLine());

            Console.WriteLine("Digite sua idade: ");
            idade= int.Parse(Console.ReadLine()); 

            Console.WriteLine("Digite seu Salário: ");
            salario = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite seu Estado Civíl: ");
            ec = (Console.ReadLine());

            Console.WriteLine("Confirmado");

        }
    }
}
