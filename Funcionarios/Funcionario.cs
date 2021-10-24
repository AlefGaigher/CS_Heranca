using System;

namespace Aprendendo_c_
{
    //abstract permite informar que a classe é abstrata, ou seja, é apenas herdada os argumentos
    public abstract class Funcionario
    {   
        public static int TotalDeFuncionario { get; private set; }              
        public string Nome {get; set;}
        //private não permite alterar o campo diretamente
        public string CPF { get; private set; }
        //protected permite alterações somente entre classes filho e base
        public double Salario { get; protected set; }
        
        public Funcionario(double salario, string cpf){
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionario++;
        } 

        //Virtual permite que seja sobrescrito por outro método da classe filho
        // public virtual double GetBonificacao(){            
        //     return Salario * 0.10;
        // }

        //Abstract Torna obrigatório em outras classes.
        public abstract double GetBonificacao();
        public abstract void AumentarSalario();
        
    }
}
