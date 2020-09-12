using System;

namespace ClasseParcial.Validacoes
{
    public partial class Valida
    {
        public static void MinimoCaracteres(string propriedade, int minimo, string mensagem)
        {
            if (propriedade.Length < minimo)
                throw new InvalidOperationException(mensagem);
        }
    }
}