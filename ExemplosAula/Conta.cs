using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Linguaguem Padrão é UML ( Diagrama de Classe ) 

//Atributos : -_numero:long

//Métodos


namespace ExemplosAula
{
    public class Conta
    {
        // O "_" É pra representar que é Atributo
       private long _numero;
       private string _nome;
        private decimal _saldo_incial;
    
        //Construtores
        public Conta(long numero, decimal saldo_incial, string Nome) //Assinatura diferente
        {
            _numero = numero;
            _saldo_incial = saldo_incial;
            _nome = Nome;
            
        }

        public long Numero 
        {
            get
            {
                return _numero;
                
            } 
            private set 
            {  
                _numero = value;
            } 
        }

        public decimal Saldo
        {
         
            get 
            { 
                return _saldo_incial;
            }

            set 
            { 
                
                _saldo_incial = value;
            
     
            }
        }

        public void Deposito(decimal value)
        {
            Saldo += value ;
        }

        public void Saque(decimal value)
        {
            Saldo -= value ;
        }


        //Escreve um código de teste para saque em conta
        //atualize o diagram de classe de modo que represente corretamente a classe Conta




        public string Nome
        {
            get { return _nome; }
        }
    }

}
