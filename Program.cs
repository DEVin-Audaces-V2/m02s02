internal class Program
{
    private static void Main(string[] args)
    {
        // EXEMPLO 01
        
        // // Variáveis
        // String? nome; // tipo de dado texto
        // int idade;
        // // int numero1, numero2; // Declaração de duas variáveis do tipo inteiro
        // // bool variavelBoolean = true;

        // // Mensagens instrucionais ao usuário
        // Console.WriteLine("Olá mundo! Digite o seu nome: ");

        // // Entradas: inserção de dados
        // nome = Console.ReadLine(); // Aguardando o usuário digitar

        // Console.WriteLine("Olá " + nome + ", digite a sua idade: ");
        // idade = int.Parse(Console.ReadLine());

        // // Processamentos: calculos, regras de negócios...

        // // Saídas: mostrar resultados em tela

        // Console.WriteLine("Olá " + nome + ", a sua idade é " + (idade + 1));

        // // Console.WriteLine("Olá " + nome + "! Seja bem-vindo ao C#!");

        // // nome = "Marcos";

        // // Console.WriteLine("Olá " + nome + "! Seja bem-vindo ao C#!");


        // EXEMPLO 02, operadores 

        // int numero1 = 10; 
        // int numero2 = 15;

        // int soma = numero1 + numero2;
        // int subtracao = numero1 - numero2;
        // int multiplicacao = numero1 * numero2;
        // double divisao = numero1 / numero2;
        // int restoDaDivisao = numero1 % numero2;

        // Console.WriteLine(soma);
        // Console.WriteLine(subtracao);
        // Console.WriteLine(multiplicacao);
        // Console.WriteLine(divisao);
        // Console.WriteLine(restoDaDivisao);

        // EXEMPLO 03

        // Entradas

        // Console.WriteLine("Digite o primeiro número: ");
        // int numero1 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite o primeiro número: ");
        // int numero2 = int.Parse(Console.ReadLine());

        // // Processamentos/Operações
        // int soma = numero1 + numero2 + 10;

        // Saídas
        //Console.WriteLine("A soma dos números é: " + soma);
        
        // EXEMPLO 04

        // Console.WriteLine((2 + 2) * 2);

        // // EXEMPLO 05

        // Console.WriteLine("Digite o primeiro numero: ");
        // int numero1 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Digite o segundo numero: ");
        // int numero2 = int.Parse(Console.ReadLine());

        // // Estrutura condicional, if-else
        // if (numero1 > numero2)
        // {
        //     Console.WriteLine("O primeiro número é maior!");
        // } else if(numero1 == numero2)
        // {

        // }
        // else
        // {
        //     Console.WriteLine("O segundo número é maior.");
        // }

        // // Console.WriteLine(1 == 1);
        // // Console.WriteLine(2 >= 5);

        // // // EXEMPLO 06

        // Console.Write("Digite um número para verificar se ele é ímpar ou par: ");
        // int numero = int.Parse(Console.ReadLine());

        // if (numero % 2 == 0)
        // {
        //     Console.WriteLine("O número é par!");
        // }
        // else
        // {
        //     Console.WriteLine("O número é impar!");
        // }

        // Console.WriteLine(!((2 < 5) && (2 > 4)));

        // // 2 é menor que 5? Sim
        // // 2 é maior que 4? Não
        // // Sim && Não == Não
        // // Inverta o resultado final

        // Aula 03

        // Exemplo Laco de repetição FOR
        // for (int i = 1; i <= 20; i++)
        // {
        //     Console.Write(i + ", ");
        // }
        
        // Console.WriteLine("Fora do laço de repetição.");

        // Exemplo laço de repetição While

        // Sintaxe While
        // while (true)
        // {
        //     // Bloco que código
        //     Console.WriteLine("teste");
        // }

        // int valor = 10;

        // while (valor >= 0)
        // {
        //     Console.WriteLine(valor--);
        // }

        // Exercício 01

        // int numero1, numero2, soma;

        // Console.Write("Digite o primeiro número: ");
        // numero1 = int.Parse(Console.ReadLine());

        // Console.Write("Digite o segundo número: ");
        // numero2 = int.Parse(Console.ReadLine());

        // soma = numero1 + numero2;

        // Console.WriteLine($"A soma dos números é: {soma}");

        // Exercício 02

        // int numero;

        // Console.WriteLine("Digite um número inteiro: ");
        // numero = int.Parse(Console.ReadLine());

        // if (numero % 2 == 0)
        // {
        //     Console.WriteLine("O número é par.");
        // } else
        // {
        //     Console.WriteLine("O número é impar.");
        // }

        // Exercício 03

        // string nome;
        // int idade;

        // Console.Write("Digite o nome do paciente: ");
        // nome = Console.ReadLine();

        // Console.Write("Digite a idade do paciente: ");
        // idade = int.Parse(Console.ReadLine());

        // Console.WriteLine($"O nome do paciente é {nome}");

        // if (idade < 18)
        // {
        //     Console.WriteLine("O paciente é menor de idade");
        // } else if (idade >= 60)
        // {
        //     Console.WriteLine("O paciente é idoso.");
        // } else 
        // {
        //     Console.WriteLine("O paciente é maior de idade.");
        // }

        // // Exercicio 04

        // string marca, modelo;
        // double km;

        // Console.Write("Digite a marca do carro: ");
        // marca = Console.ReadLine();

        // Console.Write("Digite a modelo do carro: ");
        // modelo = Console.ReadLine();

        // Console.Write("Digite a quilometragem rodada do carro: ");
        // km = double.Parse(Console.ReadLine());

        // Console.WriteLine($"\n- Marca do carro: {marca}\n- Modelo do carro: {modelo}\n- Quilometragem rodada: {km}");

        // if (km > 10000)
        // {
        //     Console.WriteLine("É necessário fazer uma revisão no carro.");
        // }

        // // EXEMPLO 07 - CALCULADORA

        // // Variáveis
        // double numero1, numero2;
        // char operacao;

        // Console.WriteLine("Olá! Seja bem-vinda(o) a Calculadora!\n");

        // do
        // {
        //     Console.WriteLine("Agora, escolha uma operação: \n");

        //     Console.WriteLine("+ : SOMAR");
        //     Console.WriteLine("- : SUBTRAIR");
        //     Console.WriteLine("* : MULTIPLICAR");
        //     Console.WriteLine("/ : DIVIDIR");
        //     Console.WriteLine("? : SAIR");

        //     // Entradas
        //     Console.Write("\nDigite a operação escolhida: ");
        //     operacao = char.Parse(Console.ReadLine());

        //     if (operacao != '?')
        //     {
        //         Console.Write("Digite o primeiro número: ");
        //         numero1 = int.Parse(Console.ReadLine());
                
        //         Console.Write("Digite o segundo número: ");
        //         numero2 = int.Parse(Console.ReadLine());

        //         switch (operacao)
        //         {
        //             case '+':
        //                 Console.WriteLine(numero1 + numero2);
        //                 break;
        //             case '-':
        //                 Console.WriteLine(numero1 - numero2);
        //                 break;
        //             case '*':
        //                 Console.WriteLine(numero1 * numero2);
        //                 break;
        //             case '/':
        //                 Console.WriteLine(numero1 / numero2);
        //                 break;
        //             case '?':
        //                 Console.WriteLine("Saindo do sistema...");
        //                 break;
        //             default:
        //                 Console.WriteLine("Opção inválida.");
        //                 break;
        //         }

        //     }
        // } while (operacao != '?');
        
        
        // Console.WriteLine("\nObrigado por usar a Calculadora!");
        

        // Processamentos/Operações

        // MENU COM IF-ELSE
        // if (operacao == '+')
        // {
        //     Console.WriteLine("soma");
        // } else if(operacao == '-')
        // {
        //     Console.WriteLine("subtracao");
        // } else if (operacao == '*')
        // {
        //     Console.WriteLine("multiplicacao");
        // } else if (operacao == '/') 
        // {
        //     Console.WriteLine("divisao");
        // } else if (operacao == '?') 
        // {
        //     Console.WriteLine("sair");
        // } else 
        // {
        //     Console.WriteLine("Opção inválida! Digite uma opção disponível no menu.");
        // }

        // MENU COM SWITCH CASE (OUTRA ESTRUTURA CONDICIONAL)
        // Saídas/Operação
        

        // Exemplos inicial List, aula 04, semana 02
        // List<string> nomes = new List<string> { "Peterson", "Camila"};

        // nomes.Add("Jaime");
        // nomes.Add("Marcos");

        // Console.WriteLine(nomes[0]);

        // nomes.Insert(0, "Roberta");

        // Console.WriteLine("--------------");

        // Console.WriteLine(nomes[0]);
        // Console.WriteLine(nomes[1]);
        // Console.WriteLine(nomes[2]);
        // Console.WriteLine(nomes[3]);
        // Console.WriteLine("Utilizando o ElementAt: ");
        
        // string nomePosicao1 = nomes.ElementAt(1);
        
        // Console.WriteLine("Imprimindo a posição " + nomePosicao1);
        // Console.WriteLine("Imprimindo a posição " + nomes.ElementAt(0));

        // nomes.RemoveAt(0);

        // Console.WriteLine("Imprimindo a posição " + nomes.ElementAt(0));

        // Console.WriteLine("Count: " + nomes.Count());
        // nomes.Add("Pedro");
        // Console.WriteLine("\n\nUtilizando o método Contains...");
        // Console.WriteLine("O nome Peterson, existe na lista: " + nomes.Contains("Pedro") + "\n\n");        
        
        // Console.WriteLine("Limpando a lista...");
        // nomes.Clear();

        // Console.WriteLine("Count: " + nomes.Count());

        // Console.WriteLine("Imprimindo a primeira posição da lista, após limpar...");
        // Console.WriteLine(nomes[0]);

        // Exemplo Array, aula 02, semana 02

        // string[] nomes = {"Maria", "João", "Paulo", "Marcos", "Marcelo", "Romeu"};

        // Console.WriteLine(nomes.Length);

        // nomes[5] = "Julieta";

        // Console.WriteLine(nomes.Length);
        // Console.WriteLine($"O nome da posição 5 é: {nomes[5]}");
        
        // nomes[0] = "Romeu";
        
        // Console.WriteLine($"O nome João existe no array? {nomes.FirstOrDefault()}");

        // string[] sobrenomes = new string[3];

        
        // Exercicio 05
    //    int[] numeros = new int[4];

    //    for (int i = 0; i < 4; i++)
    //    {
    //     Console.Write($"Digite o {i+1}º numero: ");
    //     numeros[i] = int.Parse(Console.ReadLine());
    //    }
       
    //     Array.Sort(numeros);
        
    //     Console.WriteLine("Numeros em ordem crescente: ");
    //     for (int i = 0; i < 4; i++)
    //     {
    //         Console.WriteLine(numeros[i]);
    //     }

    // Exercicio 06

    // string frase = "A linguagem de programação C# é muito poderosa";

    // string[] palavras = frase.Split(' ');

    // Console.WriteLine(palavras[7]);

    // Exe 07 

    // int numero;

    // do
    // {
    //     Console.Write("Digite um número inteiro positivo: ");
    //     numero = int.Parse(Console.ReadLine());

    //     if (numero <= 0 )
    //     {
    //         Console.WriteLine("o número deve ser positivo e diferente de zero. Tente novamente.");
    //     }

    // } while (numero <= 0);


    // for (int i = 0; i < numero; i += 2)
    // {
    //     Console.WriteLine($"{i}");
    // }


    // // Exe 08 

    // int[] numeros = new int[5];

    // for (int i = 0; i < 5; i++)
    // {
    //     Console.Write($"Digite o {i + 1}º número: ");
    //     numeros[i] = int.Parse(Console.ReadLine());
    // }

    // int maior = numeros[0];

    // for (int i = 0; i < numeros.Length; i++)
    // {
    //     if (numeros[i] > maior)
    //     {
    //         maior = numeros[i];
    //     }
    // }

    // Console.WriteLine($"O maior número digitado foi {maior}.");

    // Exe 09 

    Console.Write("Quantos números deseja calcular a média: ");
    int quantidade = int.Parse(Console.ReadLine());

    int[] numeros = new int[quantidade];

    for (int i = 0; i < quantidade; i++)
    {
        Console.Write($"Digite o {i + 1}º número: ");
        numeros[i] = int.Parse(Console.ReadLine());
    }

    int soma = 0;

    foreach (int numero in numeros)
    {
        soma += numero;
    }

    double media = (double)soma / quantidade;

    Console.WriteLine($"A média dos números é: {media}");

    }
}