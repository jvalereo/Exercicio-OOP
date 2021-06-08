using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula7
{
   public  class Pessoa
    {

        //declarando os atributos, campos,variaveis da class program

        public string nome;
        public string sobrenome;
        public int idade;
        public double peso;
        public string cpf;
        public string endereco;
        public string cidade;
        public string estado;
        public string pais;

        //declarando o construtor da class do objeto pesssoa

        public Pessoa(string nome, string sobrenome, int idade, double peso, 
         string cpf, string endereco, string cidade, string estado, string pais)
        {

            this.nome = nome;
            this.sobrenome = sobrenome;
            this.idade = idade;
            this.peso = peso;
            this.cpf = cpf;
            this.endereco = endereco;
            this.cidade = cidade;
            this.estado = estado;
            this.pais = pais;

        }

        public Pessoa()
        {
            // TODO: Complete member initialization
        }

        //declarando os métodos da classe do pessoa
        //Get: lê o conteúdo do atributo e retorna a informação
        //Set: armazena a informação passada por parâmetro no atributo 

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getSobrenome()
        {
            return sobrenome;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public  int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;

        }

        public double getPeso()
        {
            return peso;
        }

        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        public string getCpf()
        {
            return cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getEndereco()
        {
            return endereco;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public string getCidade()
        {
            return cidade;
        }

        public void setCidade(string cidade)
        {
            this.cidade = cidade;

        }

        public string getEstado()
        {
            return estado;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

        public string getPais()
        {
            return pais;
        }

        public void setPais(string pais)
        {
            this.pais = pais;
        }

       //fim da classe pessoa
    }
}
