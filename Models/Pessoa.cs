using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOSFUNDAMENTOS.Models //Nome do caminho lógico ao qual iremos nos referenciar para usar a classe
{
    public class Pessoa //Cria uma Classe Pública de nome Pessoa
    {
        public string Nome  { get; set; } //Indica um atributo públido chamado Nome do tipo String com seus metodos get e set.
        public int Idade { get; set; } //Indica um atributo públido chamado Idade do tipo String com seus metodos get e set.

        public void Apresentar() //Indica a criação de método chamado Apresentar.
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos"); //atividade que será executada quando o método for chamado.
           
        }

    }
}