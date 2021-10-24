using System;

namespace Aprendendo_c_
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {     
        public GerenteDeConta(double salario, string cpf): base(salario, cpf){

        }
        //override sobrepõe qualquer método igual da classe base
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
        public override void AumentarSalario(){
            //Aumenta o salário em 5%
            Salario *= 1.05;
        }            
           
    }
}
