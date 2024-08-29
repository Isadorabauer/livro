Livron11 = new Livro();

11.titulo = "HP - E a criança amaldiçoada!";
11.autor = "JK Rowling";
11.paginas = 530;

l1.ExibirInformacoes();
bool v1 = l1.VerificarTrezentos();
Console.WriteLine($"Esse livro tem mais de 300 páginas? " + v1);