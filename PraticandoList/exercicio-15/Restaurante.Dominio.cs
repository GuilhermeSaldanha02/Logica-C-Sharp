namespace Restaurante.Dominio;

public enum StatusPedido
{
    Pendente = 1,
    EmPreparacao = 2,
    Pronto = 3,
    Entregue = 4,
    Cancelado = 5
}
public enum CategoriaPrato
{
    Entrada = 1,
    PratoPrincipal = 2,
    Sobremesa = 3,
    Bebida = 4
}