using System;

namespace Aprendendo_c_
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }        
        
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
