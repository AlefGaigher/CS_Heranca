using System;

namespace Aprendendo_c_
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(double salario, string cpf): base(salario, cpf){

        }       
        //override sobrepõe qualquer método igual da classe base
        public override double GetBonificacao()
        {
            return Salario * 0.10;
        }
        public override void AumentarSalario(){
            //Aumenta o salário em 15%
            Salario *= 1.15;
        }
    }
}
