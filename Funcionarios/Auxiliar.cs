using System;

namespace Aprendendo_c_
{
    public class Auxiliar : Funcionario
    {       
        public Auxiliar(double salario, string cpf): base(salario, cpf){

        }
        //override sobrepõe qualquer método igual da classe base
        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
        public override void AumentarSalario(){
            //Aumenta o salário em 10%
            Salario *= 1.1;
        }            
           
    }
}
