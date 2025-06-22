using EXEMPLOSFUNDAMENTOS.Models;

int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
  
    Console.WriteLine("Compra inválida");
}
else if (possivelVenda)
{

    Console.WriteLine("Venda Realizada");
}
else
{
    Console.WriteLine("Desculpe, mas não temos a quantidade desejada em estoque.");

}
;




//string a = "15";

//int b = 0;
//int.TryParse(a, out b);
//Console.WriteLine(b);
//Console.WriteLine("Conversão realizada com sucesso!");






// double a = 4 / (2+2);


// Console.WriteLine(a);

























// int inteiro = 5;
// string a = inteiro.ToString();



// Console.WriteLine(a);

// Pessoa pessoa1 = new Pessoa();           

// pessoa1.Nome = "Gabriel";
// pessoa1.Idade = 28; 
// pessoa1.Apresentar();

//Indicamos o caminho lógico onde se encontra nossa classe chamada Pessoa na linha 1 
// Indicamos na linha 3 que estamos "chamando" a classe Pessoa e nomeando-a como pessoa1 e instanciando ela com o comando = new Pessoa;
//Indiquei um parâmetro para o atributo Nome na linha 5 , chamando pessoa1(instancia que criamos).Nome(Atributo da classe);
//Indiquei um parâmetro para o atributo Idade na linha 6, chamando pessoa1(instancia que criamos).Idade(Atributo da classe);
// Foi feito a chamada para o método Apresentar da classe pessoa na linha 7.;
//Em suma quando quisermos usar uma classe e seus atributos e métodos digitamos o nome da classe como exemplo pessoa1 e usamos o ponto "."
//junto com o metodo ou atributo que queremos utilizar
//SEMPRE que usarmos comando devemos utilizar  " ; " ao final. 

