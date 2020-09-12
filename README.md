# ClasseParcial / Partial Class


Significa usar a mesma classe, em um mesmo namespace, em arquivos separados. 

Em nosso código de exemplo, temos na pasta 'Validacoes' as seguintes partial Class:

```
namespace ClasseParcial.Validacoes
{
    public partial class Valida
    {
        public static void MinimoInteiro(int propriedade, int minimo, string mensagem)
        {
            if (propriedade < minimo)
                throw new InvalidOperationException(mensagem);
        }
    }
    
    
    
    public partial class Valida
    {
        public static void MinimoCaracteres(string propriedade, int minimo, string mensagem)
        {
            if (propriedade.Length < minimo)
                throw new InvalidOperationException(mensagem);
        }
    }
    
}

```

Veja que elas possuem o mesmo nome. Isso é possível graças a palavra chave 'partial'. 

Ocorre que a aplicação irá 'enxergar' as duas classes parciais como uma única classe chamada 'Valida'.

O real objetivo? Simplesmente para organização do código, quando classes forem muito grandes, e exigirem uma certa separação para melhor organização e entendimento.

