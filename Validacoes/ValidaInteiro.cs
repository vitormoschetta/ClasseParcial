using System;

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
}