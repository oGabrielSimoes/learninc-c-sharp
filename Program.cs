using EXEMPLOSFUNDAMENTOS.Models; //Indicando o caminho lógico onde se encontra nossa classe chamada Pessoa.

Pessoa pessoa1 = new Pessoa(); // Indica que estamos "chamando" a classe Pessoa e nomeando-a como pessoa1 e...
// instanciando ela com o comando = new Pessoa

pessoa1.Nome = "Gabriel"; //Indiquei um parâmetro para o atributo Nome, chamando pessoa1(instancia que criamos).Nome(Atributo da classe) 
pessoa1.Idade = 28; //Indiquei um parâmetro para o atributo Idade, chamando pessoa1(instancia que criamos).Idade(Atributo da classe)
pessoa1.Apresentar(); // Foi feito a chamada para o método Apresentar da classe pessoa.