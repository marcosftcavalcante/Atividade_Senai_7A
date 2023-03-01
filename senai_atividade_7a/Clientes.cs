// Atividade A7 Senai Back End - Marcos Felipe Tenorio Cavalcante 12/01/23

namespace senai_atividade_7a_2
{
    class Clientes
    {
        //atributos
        public string nome {get; set;}
        public string endereco {get; set;}
        public float valor {get; set;}
        public float valor_imposto {get; protected set;}
        public float total {get; protected set;}

        //métodos
        public virtual void Pagar_Imposto(float v){
            
            this.valor = v;
            this.valor_imposto = this.valor*10/100;
            this.total = this.valor + this.valor_imposto;
        }
        

    }
    
}