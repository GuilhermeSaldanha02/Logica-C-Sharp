using SistemaLoginEnum.Enum;

NivelAcessoEnum acesso = NivelAcessoEnum.Admin;

switch (acesso)
{
    case NivelAcessoEnum.Usuario:
    Console.WriteLine("Bem-vindo! Você pode ver o catálogo.");
    break;

    case NivelAcessoEnum.Admin:
    Console.WriteLine("Bem-vindo, Chefe! Você tem acesso total.");
    break;

    case NivelAcessoEnum.Banido:
    Console.WriteLine("Acesso Negado. Contate o suporte.");
    break;
    
    default:
    Console.WriteLine("Sistema Não reconhece a entrada!!");
    break;
}