using System;

namespace senai_atividade_7a_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar seu nome ou nome da empresa");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar seu endereço ou endereço da empresa");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Digite f para pessoa física ou j para pessoa jurídica");
            string var_tipo = Console.ReadLine();


            //Estrutura de decisão sobre o tipo de pessoa

            if (var_tipo == "f")
            {
             
             //Pessoa física
             Pessoa_Fisica pf = new Pessoa_Fisica();
             pf.nome = var_nome;
             pf.endereco = var_endereco;
             Console.WriteLine("Informar seu CPF");
             pf.cpf = Console.ReadLine();
             Console.WriteLine("Informar seu RG");
             pf.rg = Console.ReadLine();
             Console.WriteLine("Informar Valor da Compra");
             val_pag = float.Parse(Console.ReadLine());
             pf.Pagar_Imposto(val_pag);
             Console.WriteLine("-------------------Pessoa Física-------------------");
             Console.WriteLine("Nome ..............: " + pf.nome);
             Console.WriteLine("Endereço ..........: " + pf.endereco);
             Console.WriteLine("CPF ...............: " + pf.cpf);
             Console.WriteLine("RG ................: " + pf.rg);
             Console.WriteLine("Valor de Compra ...: " + pf.valor.ToString("C"));
             Console.WriteLine("Imposto ...........: " + pf.valor_imposto.ToString("C"));
             Console.WriteLine("Total a Pagar .....: " + pf.total.ToString("C"));       

            }

            if (var_tipo == "j")
            {
                //Pessoa Jurídica
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informe o CNPJ da empresa");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informe a inscrição estadual da empresa");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar Valor da Compra");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("-------------------Pessoa Jurídica-------------------");
                Console.WriteLine("Nome ..............: " + pj.nome);
                Console.WriteLine("Endereço ..........: " + pj.endereco);
                Console.WriteLine("CNPJ ..............: " + pj.cnpj);
                Console.WriteLine("IE ................: " + pj.ie);
                Console.WriteLine("Valor de Compra ...: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto ...........: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar .....: " + pj.total.ToString("C"));
            }
        }
    }
}