using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        //Dados
        int empregados, BicicletasVendidas;
        double salarioM, CustoBicicleta, ValorVenda, faturamento, comissao, SalarioF, Despesa, RendaLiquida;

        //Entrada De Dados
        Console.WriteLine("Digite os valores pedidos a seguir");
        Console.Write("Número de empregados:");
        empregados = int.Parse(Console.ReadLine());
        Console.Write("Valor do salário:");
        salarioM = double.Parse(Console.ReadLine());
        Console.Write("Custo da unidade:");
        CustoBicicleta = double.Parse(Console.ReadLine());
        Console.Write("Número de unidades vendidas:");
        BicicletasVendidas = int.Parse(Console.ReadLine());

        //Cálculos
        ValorVenda = CustoBicicleta * 1.5;
        comissao = BicicletasVendidas * CustoBicicleta * 0.15 / empregados;
        faturamento = ValorVenda * BicicletasVendidas;
        SalarioF = 2 * salarioM + comissao;
        Despesa = SalarioF * empregados;
        RendaLiquida = faturamento - Despesa;
        
        //Saída de dados
        Console.Write($"O salário final de cada funcionário é: {SalarioF}");
        Console.ReadLine();
        Console.Write($"A renda líquida da empresa é : {RendaLiquida}");
        Console.ReadLine();




 

      
    }


}
