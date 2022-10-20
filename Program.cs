using EXEMPLOEXPLORANDO.Models;
using System.Globalization;
using Newtonsoft.Json;

int numero = 15;
bool par = false;

par = numero.EhPar();

string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "ímpar");
Console.WriteLine(mensagem);



//invocando uma função generica

// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("Teste");

// Console.WriteLine(arrayString[0]);



//Declarando variavel do tipo dinamica

// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");



//Declarando tipos anonimos em coleções

// string consteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(consteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach(var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }



// Declarando um objeto do tipo anonimo

// var tipoAnonimo = new { Nome = "Breno", Sobrenome = "Lucena", Altura = 1.80 };

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);



//passando nulleable dentro de uma deserialização de JSON

// string consteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(consteudoArquivo);

// foreach(Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}{(venda.Desconto.HasValue ? $", Desconto de: {venda.Desconto}" : "")}");
// }




//Atribuindo o nulleable

// bool? desejaReceberEmail = null;

// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O user optou por receber o e-mail");
// }
// else
// {
//     Console.WriteLine("O user não respondeu ou optou por não receber e-mail");
// }


// DESERIALIZAÇÃO

// string consteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(consteudoArquivo);

// foreach(Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
// }



// NUGET - SERIALIZAÇÃO

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);



// int numero = 10;
// bool ehPar = false;

// //Par ou Impar com IF TERNÁRIO

// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

//Par ou Impar com condicional IF/ELSE

// if(numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }






// Pessoa p1 = new Pessoa("Breno", "Lucena"); //Constructor

// (string nome, string sobrenome) = p1; //Deconstructor - sintaxe muito parecida com a da tupla

// Console.WriteLine(nome + " " + sobrenome);


//Tuplas como MÉTODO

// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, LinhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if(sucesso)
// {
//     //Console.WriteLine("Quantidade linhas do arquivo:" + QuantidadeDeLinhas);
//     foreach(string linha in LinhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// } 
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }


//Tuplas

// (int Id, string Nome, string Sobrenome, decimal Altura) exemploTupla = (1, "Breno", "Lucena", 1.78M);

// ValueTuple<int, string, string, decimal> outroExemploTupla = (2, "Patricia", "Marinucci", 1.60M);

// var maisOutroExemploTupla = Tuple.Create(3, "Rosana", "Medeiros", 1.60M);

// Console.WriteLine($"Id: {exemploTupla.Id}");
// Console.WriteLine($"Nome: {exemploTupla.Nome}");
// Console.WriteLine($"Sobrenome: {exemploTupla.Sobrenome}");
// Console.WriteLine($"Altura: {exemploTupla.Altura}");

// Console.WriteLine("------------------------------------------");

// Console.WriteLine($"Id: {outroExemploTupla.Item1}");
// Console.WriteLine($"Nome: {outroExemploTupla.Item2}");
// Console.WriteLine($"Sobrenome: {outroExemploTupla.Item3}");
// Console.WriteLine($"Altura: {outroExemploTupla.Item4}");

// Console.WriteLine("------------------------------------------");

// Console.WriteLine($"Id: {maisOutroExemploTupla.Item1}");
// Console.WriteLine($"Nome: {maisOutroExemploTupla.Item2}");
// Console.WriteLine($"Sobrenome: {maisOutroExemploTupla.Item3}");
// Console.WriteLine($"Altura: {maisOutroExemploTupla.Item4}");



// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("PE", "Pernambuco");
// estados.Add("PB", "Paraíba");
// estados.Add("BA", "Bahia");

// Console.WriteLine(estados["PE"]);

// foreach(KeyValuePair<string, string> item in estados)
// //KeyValuePair<key type, value type> pode ser substituido pela palavra "var" - foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("-----------------------------------------------------------");

// estados.Remove("BA");
// estados["PB"] = "Paraiba - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave {chave}");
// }





//Coleção PILHAS

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento {pilha.Pop()} do topo da pilha.");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }



// Coleção FILAS

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o lemento: {fila.Dequeue()}");

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }



// new ExemploExcecao().Metodo1();


// try
// {
//     string[] linhas = File.ReadAllLines("d/Arquivos/arquivo_Leitura.txt");

//     //Se o caminho para o acesso ao arquivo estiver errado ocorre um erro de exception.

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho na pasta não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }



// string dataString = "2022-14-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if(sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// } else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }


// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd/M/yyyy HH:mm"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// DateTime data2 = DateTime.Parse("02/09/2022 18:00");
// Console.WriteLine(data2);


// CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

// decimal valorMonetario = 82.40M;
// //Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
// Console.WriteLine(valorMonetario.ToString("C8"));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));


// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);


// // Variavel p1 do tipo Pessoa
// Pessoa p1 = new Pessoa(nome: "Breno", sobrenome: "Lucena");
// // p1.Nome = "Breno";
// // p1.Sobrenome = "Lucena";
// // p1.Idade = 40;
// // p1.Apresentar();

// Pessoa p2 = new Pessoa(nome: "Patricia", sobrenome: "Marinucci de Lucena");
// // p2.Nome = "Patricia";
// // p2.Sobrenome = "Marinucci de Lucena";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


