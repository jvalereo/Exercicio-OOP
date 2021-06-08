using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula 7, Programação Orientação ao Objeto
            //Inserindo dados, tipo string , int, double
            //Jonas Valereo - Técnico em Informática

            //declarando o objeto result1 da class pessoa

            Pessoa result1 = new Pessoa();

            //declarando o objeto result1

            result1.nome = "Rafael";
            result1.sobrenome = "junior ferreira";
            result1.idade = 40;
            result1.peso = 41.45;
            result1.cpf = "241.547.687-54";
            result1.endereco = "Rua aurora, N.º41, Vila madalena -  São Paulo - Sp";
            result1.cidade = "São Paulo";
            result1.estado = "São Paulo";
            result1.pais = "Brasil";

            //declarando o objeto result2 da class pessoa

            Pessoa result2 = new Pessoa();

            //declarando o objeto result2

            result2.nome = "Juan";
            result2.sobrenome = "ferreira";
            result2.idade = 25;
            result2.peso = 60.21;
            result2.cpf = "000.547.528-54";
            result2.endereco = "Rua montevidel, N.º11, Buenos Ares - Argentina - AG";
            result2.cidade = "Boca junior";
            result2.estado = "Buenos Ares";
            result2.pais = "Argentina";


            Pessoa result3 = new Pessoa();

            //declarando o objeto result3

            result3.nome = "Pablo";
            result3.sobrenome = "monthoia";
            result3.idade = 35;
            result3.peso = 70.00;
            result3.cpf = "123.654.874-57";
            result3.endereco = "Rua camerom, N.º98, punta da peste - Colombia - CA";
            result3.cidade = "Santiago";
            result3.estado = "Colombia";
            result3.pais = "Colombia";


            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("Resultado da pesquisa:");
            Console.WriteLine();
            Console.WriteLine("Nome = " + result1.nome);
            Console.WriteLine("Sobrenome = " + result1.sobrenome);
            Console.WriteLine("Idade = " + result1.idade + " anos");
            Console.WriteLine("Peso = " + result1.peso.ToString("F2", CultureInfo.InvariantCulture) + " Kg");
            Console.WriteLine("Cpf = " + result1.cpf);
            Console.WriteLine("Endereço = " + result1.endereco);
            Console.WriteLine("Cidade = " + result1.cidade);
            Console.WriteLine("Estado = " + result1.estado);
            Console.WriteLine("Pais = " + result1.pais);

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Nome = " + result2.nome);
            Console.WriteLine("Sobrenome = " + result2.sobrenome);
            Console.WriteLine("Idade = " + result2.idade + " anos");
            Console.WriteLine("Peso = " + result2.peso.ToString("F2", CultureInfo.InvariantCulture) + " Kg");
            Console.WriteLine("Cpf = " + result2.cpf);
            Console.WriteLine("Endereço = " + result2.endereco);
            Console.WriteLine("Cidade = " + result2.cidade);
            Console.WriteLine("Estado = " + result2.estado);
            Console.WriteLine("Pais = " + result2.pais);

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Nome = " + result3.nome);
            Console.WriteLine("Sobrenome = " + result3.sobrenome);

            Console.WriteLine("Idade = " + result3.idade + " anos");
            Console.WriteLine("Peso = " + result3.peso.ToString("F2", CultureInfo.InvariantCulture) + " Kg");
            Console.WriteLine("Cpf = " + result3.cpf);
            Console.WriteLine("Endereço = " + result3.endereco);
            Console.WriteLine("Cidade = " + result3.cidade);
            Console.WriteLine("Estado = " + result3.estado);
            Console.WriteLine("Pais = " + result3.pais);


            //saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();


            //fim do programa
        }
    }
}
