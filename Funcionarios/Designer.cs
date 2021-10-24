using System;

namespace Aprendendo_c_
{
    public class Designer : Funcionario
    {       
        public Designer(double salario, string cpf): base(salario, cpf){

        }
        //override sobrepõe qualquer método igual da classe base
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
        public override void AumentarSalario(){
            //Aumenta o salário em 11%
            Salario *= 1.11;
        }            
           
    }
}
