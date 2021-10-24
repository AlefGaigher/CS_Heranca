using System;

namespace Aprendendo_c_
{
    class Program
    {
        static void Main(string[] args)
        {   
            //CalcularBonificacao();
        }

        public static void CalcularBonificacao(){
        
        }

        public static void UsarSistema(){
            Diretor alef = new Diretor(5000, "12334454");
            SistemaInterno sistemaInterno = new SistemaInterno();
            sistemaInterno.Logar(alef, "123");
        }
    }
}
