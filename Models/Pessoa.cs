using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOSFUNDAMENTOS.Models
{
    public class Pessoa 
    {
        public string Nome { get; set; } 
        public int Idade { get; set; } 

        public void Apresentar() 
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos"); 
        }

    }
}

//Na linha 6 temos o Nome do caminho lógico ao qual iremos nos referenciar para usar a classe 
//Na Linha 8 Criamos uma Classe Pública de nome Pessoa
//Na linha 10 Criamos um atributo público chamado Nome do tipo String com seus metodos get e set.
//Na Linha 11 Criamos um atributo público chamado Idade do tipo Int (Inteiro) com seus metodos get e set.
//Na linha 13 Criamos um método público chamado Apresentar.
//Na Linha 15 mostra a atividade que será executada quando o método for chamado.