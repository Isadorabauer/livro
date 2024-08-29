class Livro
{ 
GCNotificationStatus init


public string autor;

public int paginas;

void ExibirInformacoes()
{
    Console.WriteLine($"Titulo: {titulo}, autor: {autor}, páginas: {paginas}")
}

 
public bool VerificarTrezentos()
{
    if (paginas > 300)
    {
        return true;
    }
    else 
    {
        return false;
    } 

}
 }