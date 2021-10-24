using System;

namespace Aprendendo_c_
{
    public class SistemaInterno
    {       
            public bool Logar(IAutenticavel funcionario, string senha){
                bool usuarioAutenticado = funcionario.Autenticar(senha);

                if(usuarioAutenticado){
                    Console.WriteLine("Bem Vindo ao Sitema!");
                    return true;
                }else{
                    Console.WriteLine("Erro ao logar!");
                    return false;
                }
            }           
           
    }
}
