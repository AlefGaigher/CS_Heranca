using System;

namespace Aprendendo_c_
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }        
        
        protected FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
