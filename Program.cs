using System;
namespace Atividade
{
  class Progam 
  {
    static void Main(string[] args)
    {
      float val_pag;
      Console.WriteLine("Informar Nome");
      string var_nome = Console.ReadLine();
      Console.WriteLine("Informar Endereço");
      string var_endereco = Console.ReadLine();
      Console.WriteLine("Pessoa Fisica (f) ou Pessoa Juridica (j)");
      string var_tipo = Console.ReadLine();
      if(var_tipo == "f")
      {
        // --- Pessoa Fisica ---
        Pessoa_Fisica pf = new Pessoa_Fisica();
        pf.nome = var_nome;
        pf.endereco = var_endereco;
        Console.WriteLine("Informar CPF");
        pf.cpf = Console.ReadLine();
        Console.WriteLine("Informar RG");
        pf.rg = Console.ReadLine();
        Console.WriteLine("Informar Valor de compra:");
        val_pag = float.Parse(Console.ReadLine());
        pf.Pagar_imposto(val_pag);
        Console.WriteLine("------- Pessoa Fisica -------");
        Console.WriteLine("Nome .........: " + pf.nome);
        Console.WriteLine("Endereço .....: " + pf.endereco);
        Console.WriteLine("CPF ..........: " + pf.cpf);
        Console.WriteLine("RG ...........: " + pf.rg);
        Console.WriteLine("Valor Compra .: " + pf.valor.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
        Console.WriteLine("Valor Imposto : " + pf.valor_imposto.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
        Console.WriteLine("Total a pagar : " + pf.total.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
      }
      if (var_tipo == "j")
      {
        // --- Pessoa Juridica ---
        Pessoa_Juridica pj = new Pessoa_Juridica();
        pj.nome = var_nome;
        pj.endereco = var_endereco;
        Console.WriteLine("Informar CNPJ");
        pj.cnpj = Console.ReadLine();
        Console.WriteLine("Informar IE");
        pj.ie = Console.ReadLine();
        Console.WriteLine("Informar Valor de compra:");
        val_pag = float.Parse(Console.ReadLine());
        pj.Pagar_imposto(val_pag);
        Console.WriteLine("------- Pessoa Juridica -------");
        Console.WriteLine("Nome .........: " + pj.nome);
        Console.WriteLine("Endereço .....: " + pj.endereco);
        Console.WriteLine("CNPJ .........:" + pj.cnpj);
        Console.WriteLine("IE ...........: " + pj.ie);
        Console.WriteLine("Valor Compra .: " + pj.valor.ToString("C"));
        Console.WriteLine("Valor Imposto : " + pj.valor_imposto.ToString("C"));
        Console.WriteLine("Total a pagar : " + pj.total.ToString("C"));
      }
    }
  }
}