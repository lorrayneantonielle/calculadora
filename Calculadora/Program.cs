using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {

        enum Menu { Soma=1, Subtracao, Divisao, Multiplicação, Potencia, Raiz, Sair}

        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair) // enquanto não escolher sair, execute o prorama
            {
                Console.WriteLine("Seja bem vindo à Calculadora de Console!\nSelecione uma das opções abaixo:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                /*string opcaoTXT = Console.ReadLine();
                int opcaoINT = int.Parse(opcaoTXT);
                Menu opcao = (Menu)opcaoINT;*/

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicação:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;                    
                }
                
                Console.Clear();

            }
            
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao Menu.");
            Console.ReadLine();

        }
        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao Menu.");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao Menu.");
            Console.ReadLine();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao Menu.");
            Console.ReadLine();
        }
        
        static void Potencia()
        {
            Console.WriteLine("Potência de um número");
            Console.WriteLine("Digite o a base:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            int b = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(a, b);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao Menu.");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raíz de um número");
            Console.WriteLine("Digite o número:");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao Menu.");
            Console.ReadLine();
        }

    }
}
