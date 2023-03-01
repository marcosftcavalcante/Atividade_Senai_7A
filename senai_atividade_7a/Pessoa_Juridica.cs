namespace senai_atividade_7a_2
{
    class Pessoa_Juridica : Clientes
    {
        //Atributos
        public string cnpj {get; set;}
        public string ie {get; set;}

        //Metodo polimorfo

        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20/100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}