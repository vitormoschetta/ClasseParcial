using System;
using ClasseParcial.Entidades;

namespace ClasseParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var usuario = new Usuario("Vitor", 17);
                usuario.MostraUsuario();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
